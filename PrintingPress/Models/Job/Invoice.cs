using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Modification.Models;
using WindowsFormsApplication1.Modification.Models.Helper;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using ChucksMedicare.Model;
using PrintingPress.Models.Helper;
using PrintingPress.Models.Staff_mgt;
using System.Windows.Forms;

namespace PrintingPress.Models.Job
{
    public class Invoice : IInvoice
    {
        private SqlDataAdapter da;
        private DataTable _table;

        private string invoicid;

        public string InvoicID
        {
            get { return invoicid; }
            set
            {
                
                invoicid = value;
            }
        }
        private int qty;
        /// <summary>
        /// total number of items in the invoice
        /// </summary>
        public int Qty
        {
            get { return qty; }
            set
            {
                if(value<0)
                    throw new Exception("Invalid quantity");
                Validation.Contact(value.ToString());
                qty = value;
            }
        }
        private Decimal total;

        public Decimal Total
        {
            get { return total; }
            set
            {
                if(value<0m)
                    throw new Exception("total amount value is invalid");
                Validation.Amount(value.ToString());
                total = value;
            }
        }

        private Decimal paid;

        public Decimal Paid
        {
            get { return paid; }
            set
            {
                if (value < 0m)
                    throw new Exception("Paid amount value is invalid");
                Validation.Amount(value.ToString());
                paid = value;
            }
        }

        private Decimal balance;
        /// <summary>
        /// Balance left
        /// </summary>
        public Decimal Balance
        {
            get { return balance; }
            set
          {
              if (value < 0m)
                  throw new Exception("Balance amount value is invalid");
                balance = value;
            }
        }
 

        private string otherPayment;

        public string OtherPayment
        {
            get { return otherPayment; }
            set { otherPayment = value; }
        }

        private Decimal otherPaymentAmount;

        public Decimal OtherPaymentAmount
        {
            get { return otherPaymentAmount; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception(string.Format("enter {0} amount", this.OtherPayment));
                if (value < 0m)
                    throw new Exception(this.OtherPayment + " amount is invalid");
                Validation.Amount(value.ToString());
                otherPaymentAmount = value;
            }
        }

        public string ToDateTime(DateTime date)
        {
            return date.ToString("MM/dd/yyyy ") + string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }
        private DateTime date;
        /// <summary>
        /// Invoice date
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string method;

        public string Method
        {
            get { return method; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Select Transaction method");
                if (!MethodExist(value.ToLower().Trim()))
                    throw new Exception("Invalid Transaction method");
                method = value;
            }
        }
        private string heading;

        public string Heading
        {
            get { return heading; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Select heading");
                heading = value;
            }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Select heading Code");
                code = value;
            }
        }

        private bool MethodExist(string method)
        {
            var check = false;
             List<string> methods=new List<string>();
             methods.Add("cash");
             methods.Add("transfer");
             methods.Add("bank");
             methods.Add("pos");
             methods.Add("cash & transfer");
             methods.Add("cash & bank");
             methods.Add("cash & pos");

             if (methods.Contains(method))
                 check = true;
             return check;
        }
        /// <summary>
        /// Make cash sale
        /// </summary>
        /// <param name="cart"></param>

        public void Save(List<IJob> jobList, ICustomer customer)
        { 
        using (SqlConnection myconnection = Factory.CreateSqlConHelper().GetConnection())
        {
            myconnection.Open();

            SqlCommand InvoiceComand = myconnection.CreateCommand();
            SqlCommand JobItemsComand = myconnection.CreateCommand();  
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = myconnection.BeginTransaction(
                IsolationLevel.ReadCommitted, "SampleTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction. 
            InvoiceComand.Connection = myconnection;
            InvoiceComand.Transaction = transaction;

            JobItemsComand.Connection = myconnection;
            JobItemsComand.Transaction = transaction;

            
            try
            { 
                //insert into sales table
                InvoiceComand.Parameters.AddWithValue("@invoiceid", this.InvoicID);
                InvoiceComand.Parameters.AddWithValue("@totalamount", this.Total);
                InvoiceComand.Parameters.AddWithValue("@date", ToDateTime(this.Date));
                InvoiceComand.Parameters.AddWithValue("@totalqty", this.Qty);
                InvoiceComand.Parameters.AddWithValue("@method", this.Method);
                InvoiceComand.Parameters.AddWithValue("@amount", this.Paid);
                InvoiceComand.Parameters.AddWithValue("@balance", this.Balance);
                InvoiceComand.Parameters.AddWithValue("@userid", Users.LoginUserID);
                InvoiceComand.Parameters.AddWithValue("@cusid",
                    string.IsNullOrEmpty(customer.CusID)|| customer.CusID=="0" ? " " : customer.CusID);
                InvoiceComand.Parameters.AddWithValue("@name", customer.Name);
                InvoiceComand.Parameters.AddWithValue("@contact", customer.Contact);
                InvoiceComand.Parameters.AddWithValue("@amtinbank", this.otherPaymentAmount);
                InvoiceComand.CommandText = "sp_invoice";
                InvoiceComand.CommandType = CommandType.StoredProcedure;
                InvoiceComand.ExecuteNonQuery();
                InvoiceComand.Transaction.Commit();
                foreach (IJob job in jobList)
                {
                    //insert each product contained in the sales into the items table
                    JobItemsComand.Parameters.Clear();
                    JobItemsComand.Parameters.AddWithValue("@invoiceid", this.InvoicID);
                    JobItemsComand.Parameters.AddWithValue("@pieces", job.Qty);
                    JobItemsComand.Parameters.AddWithValue("@desc", job.Desc);
                    JobItemsComand.Parameters.AddWithValue("@cost", job.Cost);
                    JobItemsComand.Parameters.AddWithValue("@code", job.Code);
                    JobItemsComand.Parameters.AddWithValue("@heading", job.Heading);
                    JobItemsComand.Parameters.AddWithValue("@category", job.Category);
                    JobItemsComand.CommandText = "sp_invoice_items";
                    JobItemsComand.CommandType = CommandType.StoredProcedure;
                    JobItemsComand.ExecuteNonQuery();
                }

                UserActivity.RecordActivity(String.Format("issued invoice {0}", InvoicID));
               
                    //transaction.Commit();
                

            }
            catch (Exception ex)
            { 
                    transaction.Rollback();
                    if (ex.Message == "Procedure or function sp_invoice has too many arguments specified.")
                    {
                        var proc = Factory.CreateProc();
                        proc.Create(Procedures.alter_invoice_table());
                        proc.Create(Procedures.alter_sp_invoice()); 

                        //alter the following queries 
                        proc.Create(Procedures.alter_sp_only_invoice());
                        proc.Create(Procedures.alter_sp_view_invoice_details());  
                        proc.Create(Procedures.alter_sp_view_invoice_by_date());
                        proc.Create(Procedures.alter_sp_view_invoice_between_date());
                        proc.Create(Procedures.alter_sp_get_last_monthly_invoice_income());
                        proc.Create(Procedures.alter_sp_get_last_monthly_invoice_debt());
                        proc.Create(Procedures.alter_sp_get_current_month_invoice());
                        proc.Create(Procedures.alter_sp_get_current_month_invoice_debt());
                        proc.Create(Procedures.alter_sp_get_current_invoice_income_inhand());
                        proc.Create(Procedures.alter_sp_get_current_invoice_income_inbank());
                        proc.Create(Procedures.alter_sp_get_today_invoice_income_inbank());
                        proc.Create(Procedures.alter_sp_get_today_invoice_income_inhand());
                        proc.Create(Procedures.alter_sp_get_today_invoice_income_balance());

                        Save(jobList, customer);
                    }
                    else
                         
                    {
                        customer.CusID = "";
                        throw new Exception("An error occurred, transaction failed\nTry again");
                    } 
            }
        }
        }
        public DataTable Display(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_invoice_details";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_view_invoice_details());
                    Display(search);
                    return _table;

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }

               
            }
        }

       
        public DataTable DisplayByCustomer(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_invoice_details_by_customer";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_view_invoice_details_by_customer());
                    DisplayByCustomer(search);
                    return _table;

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }


            }
        }
        /// <summary>
        /// Get customer debt
        /// </summary>
        /// <param name="search">customer id</param>
        /// <returns></returns>
        public DataTable DisplayCustomerDebt(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_invoice_customer_debt";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_view_invoice_customer_debt());
                    DisplayByCustomer(search);
                    return _table;

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }


            }
        }

        public DataTable DisplayInvoiceByCode(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_expense_code_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        public DataTable DisplayInvoiceByCategory(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_expense_code_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable Display(DateTime date)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@date", date);
                myComand.CommandText = "sp_view_invoice_by_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable Display(DateTime datefrom, DateTime dateto)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom);
                myComand.Parameters.AddWithValue("@dateto", dateto);
                myComand.CommandText = "sp_view_invoice_between_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        public DataTable DisplayInvoiceItem(string invoiceid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", invoiceid);
                myComand.CommandText = "sp_view_invoice_items";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }/// <summary>
        /// Get invoice customer
        /// </summary>
        /// <param name="invoiceid"></param>
        /// <returns></returns>
        public DataTable DisplayInvoiceCustomer(string invoiceid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@invoiceid", invoiceid);
                myComand.CommandText = "sp_customer_invoice";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_customer_invoice());
                    DisplayInvoiceCustomer(invoiceid);
                     
                }
                else
                {
                    throw new Exception(ex.Message);
                }
                return _table;
            }
        }
        public void Delete()
        {

            using (SqlConnection myconnection = Factory.CreateSqlConHelper().GetConnection())
            {
                myconnection.Open();

                SqlCommand InvoiceComand = myconnection.CreateCommand();
                SqlCommand cashflowComand = myconnection.CreateCommand();
                SqlCommand cashflowDeleteComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                InvoiceComand.Connection = myconnection;
                InvoiceComand.Transaction = transaction;

                cashflowComand.Connection = myconnection;
                cashflowComand.Transaction = transaction;

                cashflowDeleteComand.Connection = myconnection;
                cashflowDeleteComand.Transaction = transaction;
                try
                {
                    cashflowComand.Parameters.AddWithValue("@invoiceid", this.InvoicID);
                    cashflowComand.CommandText = "sp_get_invoice_cashflow";
                    cashflowComand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sdr = new SqlDataAdapter(cashflowComand);
                    _table = new DataTable();
                    sdr.Fill(_table);
                    cashflowComand.ExecuteNonQuery();


                    // use transaction here 
                    InvoiceComand.Parameters.AddWithValue("@invoiceid", this.InvoicID);
                    InvoiceComand.CommandText = "sp_delete_invoice";
                    InvoiceComand.CommandType = CommandType.StoredProcedure; 
                    InvoiceComand.ExecuteNonQuery();

                    if (_table.Rows.Count > 0)
                    {
                        foreach (DataRow item in _table.Rows)
                        {
                            //delete the cashflow records
                            cashflowDeleteComand.Parameters.Clear();
                            cashflowDeleteComand.Parameters.AddWithValue("@cashflowid", item["ID"].ToString());
                            cashflowDeleteComand.CommandText = "sp_delete_invoice_cashflow";
                            cashflowDeleteComand.CommandType = CommandType.StoredProcedure;
                            cashflowDeleteComand.ExecuteNonQuery();

                        }
                    }

                    UserActivity.RecordActivity(String.Format("Deleted Invoice {0}", InvoicID));
                   transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    CreateProcedure proc = Factory.CreateProc();
                    if (ex.Message == "Could not find stored procedure 'sp_get_invoice_cashflow'.")
                    { 
                        proc.Create(Procedures.sp_get_invoice_cashflow());
                        Delete();
                    }
                    else if(ex.Message == "Could not find stored procedure 'sp_delete_invoice_cashflow'.")
                    {
                        proc.Create(Procedures.sp_delete_invoice_cashflow());
                        Delete();
                    }
                    else if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                    { 
                        proc.Create(Procedures.sp_delete_invoice());
                        Delete();

                    }
                    else
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// Delete invoice by auto ID
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@id", id);
                myComand.CommandText = "sp_delete_customer_invoice";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(String.Format("Deleted Invoice {0}", InvoicID));
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_delete_customer_invoice());
                    Delete(id);

                }
                else
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        public DataTable GetHeadingInfor(string invoiceid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@invoiceid", invoiceid);
                myComand.CommandText = "sp_get_invoice_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure 'sp_get_invoice_heading'."))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_invoice_heading());
                    GetHeadingInfor(invoiceid);
                    return _table;
                }
                else
                {
                    throw new Exception(ex.Message);
                }
               
            }
        }
        #region Get total from invoice

        /// <summary>
        /// Get Past Month's invoice total income
        /// </summary>
        /// <returns></returns>
        internal static Decimal LastMonthlyIncome()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_last_monthly_invoice_income", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_last_monthly_invoice_income());
                    LastMonthlyIncome();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get Past month's invoice debt
        /// </summary>
        /// <returns></returns>
        internal static Decimal LastMonthlyDebt()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_last_monthly_invoice_debt", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_last_monthly_invoice_debt());
                    LastMonthlyDebt();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        internal static Decimal CurrentMonthIncome()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_month_invoice", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_current_month_invoice());
                    CurrentMonthIncome();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get current month invoice debt
        /// </summary>
        /// <returns></returns>
        internal static Decimal CurrentMonthDebt()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_month_invoice_debt", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_current_month_invoice_debt());
                    CurrentMonthDebt();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get invoice cash in hand
        /// </summary>
        /// <returns></returns>
        internal static Decimal CashInHand()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_invoice_income_inhand", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_current_invoice_income_inhand());
                    CashInHand();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get invoice cash in bank
        /// </summary>
        /// <returns></returns>
        internal static Decimal CashInBank()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_invoice_income_inbank", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_current_invoice_income_inbank());
                    CashInBank();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal static object TodayCashInBank(DateTime value)
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_invoice_income_inbank_bydate", myconn);
                    cmd.Parameters.AddWithValue("@date", value.Date);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message=="Could not find stored procedure 'sp_get_today_invoice_income_inbank_bydate'.")
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_today_invoice_income_inbank_bydate());
                    TodayCashInBank(value);
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Get today cash at hand
        /// </summary>
        /// <returns></returns>
        internal static Decimal TodayCashInBank()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_invoice_income_inbank", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_today_invoice_income_inbank());
                    TodayCashInBank();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get today cash in bank
        /// </summary>
        /// <returns></returns>
        internal static Decimal TodayCashInHand()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_invoice_income_inhand", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_today_invoice_income_inhand());
                    TodayCashInHand();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get today cash by date
        /// </summary>
        /// <param name="date">Date </param>
        /// <returns></returns>
        internal static Decimal TodayCashInHand(DateTime date)
        {
            var amount = 0.00m;
            try
            { 
                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_invoice_income_inhand_bydate", myconn);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                CreateProcedure proc = Factory.CreateProc();
                if (ex.Message == "Could not find stored procedure 'sp_get_today_invoice_income_inhand_bydate'.")
                {
                   proc.Create(Procedures.sp_get_today_invoice_income_inhand_bydate());
                   proc.Create(Procedures.alter_sp_get_today_invoice_income_inhand());
                    TodayCashInHand(date);
                    return amount;
                } 
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Today balance payments left
        /// </summary>
        /// <returns></returns>
        internal static Decimal TodayDebt()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_invoice_income_balance", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["Total"].ToString()))
                            {
                                amount = Convert.ToDecimal(dr["Total"]);
                            }

                        }

                    }
                }

                return amount;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_today_invoice_income_balance());
                    TodayCashInHand();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        #endregion

        #region generate invoice number
        /// <summary>
        /// Return new invoice id from the last id
        /// </summary>
        /// <returns></returns>
        internal static string GetLastInvoiceID()
        {
            var id = "";
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_last_invoice_id", myconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["InvoiceID"].ToString()))
                            {
                                id = GenerateInvoiceID(dr["InvoiceID"].ToString());
                            }

                        }

                    }
                    else
                    {
                        id = GenerateInvoiceID("00001");
                    }
                }
                if(InvoiceIDExist(id))
                     GetLastInvoiceID();
                return id;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_last_invoice_id());
                    GetLastInvoiceID();
                    return id;

                }
                else
                {
                    MessageBox.Show("An error occurred during invoice ID generation", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return id;
                }
            }
        }
    
        private static string GenerateInvoiceID(string lastID)
        {
            if (lastID == "0001")
                return "00001";
            var lastid = lastID;
            string trailZero=null;
            string leadingDigit=null;
            if (lastid.StartsWith("0"))
            {
                while (lastid.StartsWith("0"))
                {
                    trailZero += lastID.Substring(0, lastid.IndexOf("0") + 1);
                    leadingDigit = lastid.Substring(trailZero.Length);
                    lastid = leadingDigit;
                }
            }
            else
            {
                leadingDigit = lastID;
            }

            if (leadingDigit.Length <= 2)
            {
                trailZero = "000";
            }
            else if (leadingDigit.Length <= 3)
            {
                trailZero = "00";
            }
            else if (leadingDigit.Length <= 5)
            {
                trailZero = "0";
            }
             
            leadingDigit = (Convert.ToInt32(leadingDigit) + 1).ToString();
            return string.Concat(trailZero, leadingDigit);
            
        }

        internal static bool InvoiceIDExist(string invoiceid)
        {
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_invoice_id_exist", myconn);
                    cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if (!string.IsNullOrEmpty(dr["InvoiceID"].ToString()))
                            {
                                return true;
                            }

                        }

                    }

                    return false;
                } 
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_invoice_id_exist());
                    InvoiceIDExist(invoiceid);
                    return false;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public DataTable DisplayByCustomer(string cusID, DateTime value)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cusid", cusID);
                myComand.Parameters.AddWithValue("@date", value.Date);
                myComand.CommandText = "sp_view_invoice_details_by_customer_bydate";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_view_invoice_details_by_customer_bydate());
                    proc.Create(Procedures.sp_view_invoice_details_by_customer_between_date());
                    DisplayByCustomer(cusID,value.Date);
                    return _table;

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }


            }
        }
        public DataTable DisplayByCustomer(string cusID, DateTime value,DateTime dateto)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cusid", cusID);
                myComand.Parameters.AddWithValue("@date", value.Date);
                myComand.Parameters.AddWithValue("@dateto", dateto.Date);
                myComand.CommandText = "sp_view_invoice_details_by_customer_between_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }
            
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_view_invoice_details_by_customer_bydate());
                    proc.Create(Procedures.sp_view_invoice_details_by_customer_between_date());
                    DisplayByCustomer(cusID, value.Date,dateto.Date);
                    return _table;

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }


            }
        }
        #endregion
    }
}
