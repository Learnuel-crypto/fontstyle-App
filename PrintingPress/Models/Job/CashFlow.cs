using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models;
using WindowsFormsApplication1.Modification.Models.Helper;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using ChucksMedicare.Model;
using PrintingPress.Models.Helper;

namespace PrintingPress.Models.Job
{
    public class CashFlow : ICashFlow
   {
       private SqlDataAdapter da;
       private DataTable _table;
        private string cashId;

        public string CashID
        {
            get { return cashId; }
            set { cashId = value; }
        }
        private string desc;
        /// <summary>
        /// the descripion of the event
        /// </summary>
        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }

        public void Delete(string cashcode)
        {
            try
            {
                var invoiceid = "";
                if (this.Description.Contains("#"))
                {
                    invoiceid = this.Description.Substring(this.Description.LastIndexOf("#")+1);
                }
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cashid", this.CashID);
                myComand.Parameters.AddWithValue("@invoiceid", invoiceid);
                myComand.CommandText = "sp_delete_cashflow";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);  
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close(); 
               UserActivity.RecordActivity(string.Format("Delete cashflow with Code: {0}",cashcode));
            }
            catch (Exception ex)
            {
                CreateProcedure proc = Factory.CreateProc();
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                   
                    proc.Create(Procedures.sp_delete_cashflow());
                    proc.Create(Procedures.alter_sp_delete_cashflow());
                    Delete(cashcode);

                }else if (ex.Message == "Procedure or function sp_invoice has too many arguments specified.")
                {
                    proc.Create(Procedures.alter_sp_delete_cashflow());
                    Delete(cashcode);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
              
            }
        }

        public DataTable Display(DateTime date)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@date", date);
                myComand.CommandText = "sp_view_expense_by_date";
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
                myComand.CommandText = "sp_view_expense_by_between_date";
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
        }
        public DataTable Search(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_cashflow";
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
                    proc.Create(Procedures.sp_get_cashflow());
                    Search(search);
                    return _table;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public DataTable SearchByHeading(string heading)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@heading", heading);
                myComand.CommandText = "sp_view_cashflow_by_heading";
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
                    proc.Create(Procedures.sp_view_cashflow_by_heading());
                    SearchByHeading(heading);
                    return _table;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal  static Decimal MonthlyIncome()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_monthly_income", myconn); 
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
                    proc.Create(Procedures.sp_get_monthly_income());
                    MonthlyIncome();
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
                    SqlCommand cmd = new SqlCommand("sp_get_current_income", myconn); 
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
                    proc.Create(Procedures.sp_get_current_income());
                    CurrentMonthIncome();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        internal static Decimal MonthlyExpense()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_monthly_expense", myconn); 
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
                    proc.Create(Procedures.sp_get_monthly_expense());
                    MonthlyExpense();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal static Decimal CashInHand()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_income_athand", myconn);
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
                    proc.Create(Procedures.sp_get_current_income_athand());
                    CashInHand();
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
                    SqlCommand cmd = new SqlCommand("sp_get_current_income_inbank_bydate", myconn);
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
                if (ex.Message== "Could not find stored procedure 'sp_get_current_income_inbank_bydate'.")
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_current_income_inbank_bydate());
                    proc.Create(Procedures.alter_sp_get_current_income_inbank());
                    TodayCashInBank(value);
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        internal static Decimal CashInBank()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_income_inbank", myconn);
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
                    proc.Create(Procedures.sp_get_current_income_inbank());
                    CashInBank();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal static Decimal CurrentMonthExpense()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_current_month_expense", myconn);
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
                    proc.Create(Procedures.sp_get_current_month_expense());
                    CurrentMonthExpense();
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
                    SqlCommand cmd = new SqlCommand("sp_get_today_income_inhand", myconn);
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
                    proc.Create(Procedures.sp_get_today_income_inhand());
                    TodayCashInHand();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal static Decimal TodayCashInHand(DateTime date)
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_income_inhand_bydate", myconn);
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
                CreateProcedure proc; 
                if (ex.Message == "Could not find stored procedure 'sp_get_today_income_inhand_bydate'.")
                {
                    proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_today_income_inhand_bydate());
                    TodayCashInHand(date);
                    return amount;
                } 
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        internal static Decimal TodayCashInBank()
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_income_inbank", myconn);
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
                    proc.Create(Procedures.sp_get_today_income_inbank());
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
        /// Get today expense
        /// </summary>
        /// <returns></returns>
        internal static Decimal TodayExpense()
        {
            var amount = 0.00m;
            try
            { 
                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_today_cashflow_expense", myconn);
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
                    proc.Create(Procedures.sp_get_today_cashflow_expense());
                    TodayExpense();
                    return amount;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get debt payment details
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public DataTable GetDebtReceiptDetails(ICashFlow details)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cashflowid", details.CashID);
                myComand.CommandText = "sp_get_debt_payment_details";
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
                    proc.Create(Procedures.sp_get_debt_payment_details());
                    GetDebtReceiptDetails(details);
                    return _table;

                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Get code status and statement
        /// </summary>
        /// <param name="code">cashflow code</param>
        /// <returns></returns>
        public DataTable GetCodeStatus(string code)
        {

            try
            {
                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                { 
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_code_status", myconn);
                    cmd.Parameters.AddWithValue("@code", code.Trim());
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    _table = new DataTable();
                    _table.Load(sdr);
                    return _table;
                }
            }

            catch (Exception ex)
            {
                if (ex.Message== "Could not find stored procedure 'sp_get_code_status'.")
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_get_code_status());
                    GetCodeStatus(code);
                    return _table;
                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }

            }
        }
    }
}
