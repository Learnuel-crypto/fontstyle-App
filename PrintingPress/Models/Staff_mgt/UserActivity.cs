 
using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress;
using PrintingPress.Models.Staff_mgt;

namespace ChucksMedicare.Model
{
    public  class UserActivity : IUserActivity
    {
        /// <summary>
        /// Methods are not connect to the table
        /// </summary>
        /// <param name="description"></param>
        public string Description { get; set; }
        private DataTable _table;
        public UserActivity(string description)
        {
            RecordActivity(description);
        }

        public UserActivity()
        {
        }
       /// <summary>
       /// Record use acctivity
       /// </summary>
       /// <param name="description"></param>
        public static void RecordActivity(string description)
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();
                
                    SqlCommand myComand = connection.GetConnection().CreateCommand(); 
                    myComand.Parameters.Clear();
                    myComand.Parameters.AddWithValue("@userid", Users.LoginUserID);
                    myComand.Parameters.AddWithValue("@description", description);
                    myComand.Parameters.AddWithValue("@date",ToDateTime());
                    myComand.CommandText = "sp_activity";
                    myComand.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    myComand.ExecuteNonQuery();
                    connection.Close(); 
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }
       /// <summary>
       /// Record user activity
       /// </summary>
        public   void RecordActivity()
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();

                SqlCommand myComand = connection.GetConnection().CreateCommand();
                myComand.Parameters.Clear();
                myComand.Parameters.AddWithValue("@userid", Users.LoginUserID);
                myComand.Parameters.AddWithValue("@description", this.Description);
                myComand.Parameters.AddWithValue("@date", ToDateTime());
                myComand.CommandText = "sp_activity";
                myComand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                myComand.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       /// <summary>
       /// Search activity by date
       /// </summary>
       /// <param name="date"></param>
       /// <returns></returns>
        public DataTable SearchByDate(DateTime date)
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();
                 
                SqlCommand cmd = new SqlCommand("sp_search_user_log_date", connection.GetConnection());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@userid", Users.LoginUserID);
                cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    _table = new DataTable();
                    da.Fill(_table);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return _table;
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
       /// <summary>
       /// Seach user acctivity
       /// </summary>
       /// <param name="search"></param>
       /// <returns></returns>
        public DataTable DisplayUserLog(string search)
        {
            try
            {
                ISqlHelper connection = Factory.CreateSqlConHelper();
                SqlCommand cmd = new SqlCommand("sp_search_user_log", connection.GetConnection());
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@userid", Users.LoginUserID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    _table = new DataTable();
                    da.Fill(_table);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return _table;
                 
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Date and Time format
        /// </summary>
        /// <returns></returns>
        public static string ToDateTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy ") + string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }
        /// <summary>
        /// Search user activity between dates
        /// </summary>
        /// <param name="datefrom"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public DataTable SearchBetweenDates(DateTime datefrom, DateTime to)
        {
            try
            { 
                  ISqlHelper connection = Factory.CreateSqlConHelper();
                SqlCommand cmd = new SqlCommand("sp_search_user_log_between_date", connection.GetConnection());
                    cmd.Parameters.AddWithValue("@fromdate", datefrom);
                    cmd.Parameters.AddWithValue("@todate", to);
                    cmd.Parameters.AddWithValue("@userid", Users.LoginUserID);
                cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    _table = new DataTable();
                    da.Fill(_table);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return _table;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
