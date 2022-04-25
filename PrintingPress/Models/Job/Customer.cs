using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.Models.Helper;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using WindowsFormsApplication1.Modification.Models;
using ChucksMedicare.Model;

namespace PrintingPress.Models.Job
{
    public class Customer : ICustomer
    {
       public SqlDataAdapter da;
       public DataTable _table;
        private string cusid;

        public string CusID
        {
            get { return cusid; }
            set { cusid = value; }
        }

        private string name;
        /// <summary>
        /// Customer fullname
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Customer name is empty");
                Validation.Name(value);
                name = value;
            }
        }

        private string contact;
        /// <summary>
        /// Customer contact
        /// </summary>
        public string Contact
        {
            get { return contact; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter customer contact");
                Validation.Contact(value, 11, 15);
                contact = value;
            }
        }
        /// <summary>
        /// Get customer's contact
        /// </summary>
        /// <returns></returns>
        public string GetContact()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    string x = "";
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_customer_contact", myconn);
                    cmd.Parameters.AddWithValue("@id", this.CusID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            x = dr["Contact"].ToString();
                            
                        }

                    }

                    return x;
                }

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
           
        }
        /// <summary>
        /// Check if customer exist
        /// </summary>
        /// <returns></returns>
        public string CustomerExist(string name)
        {
            try
            {
                this.CusID = null;
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                { 
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_customer_exist", myconn);
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            this.CusID =  dr["CusID"].ToString();
                            this.Contact = dr["Contact"].ToString();

                        }

                    }

                    return this.CusID;
                }

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }

        }
        /// <summary>
        /// check if number exist
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public bool CustomerNumberExist()
        {
            var numbExistOnces = false;
            try
            {
               
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_customer_number_exist", myconn);
                    cmd.Parameters.AddWithValue("@contact", this.Contact.Trim());
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
                                var total = Int32.Parse(dr["Total"].ToString());
                                if(total>1)
                                    numbExistOnces = true;
                            }
                               
                        }

                    }

                    return numbExistOnces;
                }

            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_customer_number_exist());
                    this.CustomerNumberExist();

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }

                return numbExistOnces;
            }

        }
        public DataTable DisplayCustomers(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_customer";
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
        /// <summary>
        /// Get customers from the customer table
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable GetCustomers(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_customer";
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
        /// <summary>
        /// Display names of cutomers
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable GetCustomersNames(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_customer_names";
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
        public DataTable GetCustomerReport(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_customer_invoice_sum";
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
                if (ex.Message.ToLower()== "could not find stored procedure 'sp_customer_invoice_sum'.")
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_customer_invoice_sum());
                    proc.Create(Procedures.sp_customer_invoice_sum_bydate());
                    proc.Create(Procedures.sp_customer_invoice_sum_between_date());
                    this.GetCustomerReport(search);

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }

                return _table;
            }
        }

        public DataTable GetCustomerReportByDate(DateTime datefrom)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom.Date);
                myComand.CommandText = "sp_customer_invoice_sum_bydate";
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
        public DataTable GetCustomerReportByDate(DateTime datefrom,DateTime dateto)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom.Date);
                myComand.Parameters.AddWithValue("@dateto", dateto.Date);
                myComand.CommandText = "sp_customer_invoice_sum_between_date";
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
        /// <summary>
        /// Register Customer
        /// </summary>
        public void Add()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", "cvc");
                myComand.CommandText = "sp_get_heading_by_code";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                 
            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Delete customer
        /// </summary>
        public void Delete()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@cusid", this.CusID);
                myComand.CommandText = "sp_delete_customer";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Deleted customer {0} details", this.CusID));
            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_delete_customer());
                    Delete();

                }
                else
                {
                    //"There was error in the process, try again"
                    throw new ExceptionHandling(ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// update customer details
        /// </summary>
        public void Update()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@name", this.Name);
                myComand.Parameters.AddWithValue("@cusid", this.CusID);
                myComand.Parameters.AddWithValue("@contact", this.Contact);
                myComand.CommandText = "sp_update_customer";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity(string.Format("Updated customer {0} details",this.CusID));
            }

            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.sp_update_customer());
                    Update();

                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }
            }
        }
    }
}
