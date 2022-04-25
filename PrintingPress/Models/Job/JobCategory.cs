using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.Models.Helper;

namespace PrintingPress.Models.Job
{
    public class JobCategory:Expenses, IJobCategory
   {

        private string jobid;

        public string JobId
        {
            get { return jobid; }
            set { jobid = value; }
        }

        /// <summary>
        /// add category
        /// </summary>
        public void Add()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", this.Code);
                myComand.Parameters.AddWithValue("@heading", this.ExpenseHeading);
                myComand.Parameters.AddWithValue("@category", this.Description);
                myComand.CommandText = "sp_insert_job_category";
                myComand.CommandType = CommandType.StoredProcedure; 
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                 

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        public void UpdateJob()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", this.Code);
                myComand.Parameters.AddWithValue("@heading", this.ExpenseHeading);
                myComand.Parameters.AddWithValue("@category", this.Description);
                myComand.Parameters.AddWithValue("@jobid", this.JobId);
                myComand.CommandText = "sp_update_job_category";
                myComand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close(); 

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public void DeleteJob()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand(); 
                myComand.Parameters.AddWithValue("@jobid", this.JobId);
                myComand.CommandText = "sp_delete_job_category";
                myComand.CommandType = CommandType.StoredProcedure;
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
        /// Search Job category
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public DataTable SearchJobCategory(string searchText)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", searchText);
                myComand.CommandText = "sp_view_jobcategory";
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
        public DataTable GetJobCategory(string code,string heading)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", code);
                myComand.Parameters.AddWithValue("@heading", heading);
                myComand.CommandText = "sp_get_job_category";
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
    }
}
