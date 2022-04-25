using PrintingPress;
using PrintingPress.Models.Helper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public  class UserSettings
  {
      private SqlDataAdapter da;
        DataTable _table;
        private string title;
        /// <summary>
        /// Setting title
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Setting title cannot be empty");
                title = value;
            }
        }

        private string titleValue;
        /// <summary>
        /// Setting title value
        /// </summary>
        public string TitleValue
        {
            get { return titleValue; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Value for title is empty");
                titleValue = value;
            }
        }
        /// <summary>
        /// Save setting
        /// </summary>
        public void Save()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@title", this.Title);
                    cmd.Parameters.AddWithValue("@value", this.TitleValue); 
                    cmd.CommandText = "sp_setting";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                     
                }
            }
            catch (Exception Ex)
            {
                 
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Update setting
        /// </summary>
        public void Update()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@title", this.Title);
                    cmd.Parameters.AddWithValue("@value", this.TitleValue);
                    cmd.CommandText = "sp_update_appsetting";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
        }
        public string GetUserSettings(string searchText)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", searchText);
                myComand.CommandText = "sp_get_appsetting";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                if (_table.Rows.Count > 0)
                {
                    foreach (DataRow item in _table.Rows)
                    {
                        if (!string.IsNullOrEmpty(item["Value"].ToString()))
                        {
                            TitleValue = item["Value"].ToString();
                        }
                    }
                }

                return TitleValue;
            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
    }
}
