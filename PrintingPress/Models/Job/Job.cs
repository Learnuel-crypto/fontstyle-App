using PrintingPress.Models.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models;
using WindowsFormsApplication1.Modification.Models.Helper;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;

namespace PrintingPress.Models.Job
{
    public class Job : IJob
    {
        private SqlDataAdapter da;
        private DataTable _table;
        private int jobID;

        public int JobID
        {
            get { return jobID; }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid job id");
                jobID = value;
            }
        }
        private string category;
        /// <summary>
        /// Job category
        /// </summary>
        public string Category
        {
            get { return category; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Provide job category");
                category = value;
            }
        }

        private string desc;
        /// <summary>
        /// Job description
        /// </summary>
        public string Desc
        {
            get { return desc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter job description");
                desc = value;
            }
        }
        private int qty;

        public int Qty
        {
            get { return qty; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid quantity");
                Validation.Contact(value.ToString());
                qty = value;
            }
        }
        private Decimal cost;

        public Decimal Cost
        {
            get { return cost; }
            set
            {
                if (value <= 0m)
                    throw new Exception("Invalid cost value");
                cost = value;
            }
        }
        private string heading;

        public string Heading
        {
            get { return heading; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Select job Heading");
                heading = value;
            }
        }

        private string code;
        /// <summary>
        /// Heading code
        /// </summary>
        public string Code
        {
            get { return code; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Select heading code");
                code = value;
            }
        }

        public DataTable Search(string searchText)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", searchText.Trim(
                    )); 
                myComand.CommandText = "sp_get_jobs";
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
                CreateProcedure proc;
                if (ex.Message.ToLower().StartsWith("could not find stored procedure 'sp_get_jobs'."))
                {
                     proc = Factory.CreateProc();
                    proc.Create(Procedures.create_view_job_items());
                    proc.Create(Procedures.create_sp_get_jobs());
                    proc.Create(Procedures.create_sp_get_jobs_date());
                   proc.Create(Procedures.create_sp_get_jobs_between_date());
                   proc.Create(Procedures.create_sp_get_item_invoice_total());
                   proc.Create(Procedures.create_sp_get_items_debt_paid_total());
                    
                    Search(searchText.Trim());
                    return _table; 
                }
                else
                {
                    throw new ExceptionHandling("There was error in the process, try again", ex);
                }


            }
        }

        public DataTable Search(DateTime datefrom)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom",  datefrom.Date);
                myComand.CommandText = "sp_get_jobs_date";
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
        public DataTable Search(DateTime datefrom,DateTime dateto)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom.Date);
                myComand.Parameters.AddWithValue("@dateto", dateto.Date);
                myComand.CommandText = "sp_get_jobs_between_date";
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
        internal static Decimal InvoiceTotal(string invoiceid)
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_item_invoice_total", myconn);
                    cmd.Parameters.AddWithValue("@invoiceid", invoiceid);
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
                    throw new Exception(ex.Message);
                 
            }
        }
        internal static Decimal TotalDebtPaid(string description)
        {
            var amount = 0.00m;
            try
            {

                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_items_debt_paid_total", myconn);
                    cmd.Parameters.AddWithValue("@desc", description);
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
                throw new Exception(ex.Message);

            }
        }
    }
}
