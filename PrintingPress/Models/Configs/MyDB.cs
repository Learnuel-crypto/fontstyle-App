using ChucksMedicare.Model;
using EncryptString;
using PrintingPress;
using PrintingPress.Models.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace WindowsFormsApplication1
{
   public class MyDB
    {
        protected internal MyDB(string script)
        {
            SliptScriptAndRun(script);
        }
        protected internal MyDB()
        {
        }
        private const string newDatabaseConnString = "yqV+V9oz+FWy0NBj20nKMOGU840L4tKDlrrbXMSvjW/qoN4fKDr24V4Crft81lSJXiFfuHJMaEHHTL7uazDcZhgdjoaqocVpQIrqPb7wP+s=";
        private const string databaseName = "uYOJAgit8/g1SzWQySTLAw==";

        private const string createdDatabaseConnString =
            "yqV+V9oz+FWy0NBj20nKMOGU840L4tKDlrrbXMSvjW8d1TkY66le4feRqEPcmz+5ivhOnqUgx2d63Ip5JHC2QMWr0bI1RtI/4/OxjaRRGNhBrr6NCJ0w54ftKNWLxRt0";
        StringEncryptor stringEncryptor = new StringEncryptor();
        private string Script;
        SqlConnection Con;
        SqlCommand cmd;
        SqlCommand cmd2;//to create tables in the database
                        /// <summary>
                        /// Create database from script
                        /// </summary>
                        /// <param name="script"> script</param>
        private void SliptScriptAndRun(string script)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper(true);
                Script = File.ReadAllText(script);
                string[] Slipter = Script.Split(new string[] { "GO" }, StringSplitOptions.None);
                using (Con = new SqlConnection(stringEncryptor.Decrypt(newDatabaseConnString)))
                {
                    Con.Open();
                    using (cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = string.Format("CREATE DATABASE {0}", stringEncryptor.Decrypt(databaseName));
                        cmd.ExecuteNonQuery();
                    }
                }
                using (Con = new SqlConnection(stringEncryptor.Decrypt(createdDatabaseConnString)))
                {
                    Con.Open();
                    foreach (String str in Slipter)
                    {
                        using (cmd2 = Con.CreateCommand())
                        {
                            cmd2.CommandText = str;
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                File.Delete(script);
                Con.Close();
                
            }
            catch (Exception ex)
            {
                Con.Close();
                if (ex.Message.ToLower().StartsWith("database " + stringEncryptor.Decrypt(databaseName) + "already exists:"))
                {
                    if (MessageBox.Show("Database  already exist \nDelete existing database ?", "Database Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DeleteExistingDatabase(databaseName);
                        SliptScriptAndRun(script);
                        File.Delete(script);
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message+"\nDatabase could not be created", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        /// <summary>
        /// Delete existing database 
        /// </summary>
        /// <param name="dbname"></param>
        private void DeleteExistingDatabase(string dbname)
        {
            try
            {

                using (Con = new SqlConnection(stringEncryptor.Decrypt(createdDatabaseConnString)))//master to delete the created database
                {
                    var sb = new StringBuilder();
                    sb.Append(string.Format("DROP DATABASE {0}", stringEncryptor.Decrypt(dbname)));
                    cmd = new SqlCommand(sb.ToString(), Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Existing Database Deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        ///
        /// created database before import existing data
        /// </summary>
        protected internal  void CreatBDForImport()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper(true);
                using (Con = new SqlConnection(stringEncryptor.Decrypt(newDatabaseConnString)))
                {
                    Con.Open();
                    using (cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = string.Format("CREATE DATABASE {0}", stringEncryptor.Decrypt(databaseName));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Database 'Fontsystem_db' already exists."))
                {
                    throw new Exception("Database already exist");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
               
            }
        }
        protected internal void Backup(string path, bool loggedIn = false)
        { 

            SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
            string database = con.Database.ToString();
            try
            {
                if (string.IsNullOrEmpty(path))
                    throw new Exception("please enter backup file location");
                 
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + path + "\\" +  "Fonstyle Database " +
                             "_" + DateTime.Now.ToString("dd-MM-yyyy")+ ".bak'";
                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    UserActivity.RecordActivity("Backedup Database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Restore Database
        /// </summary>
        /// <param name="path"></param>
        protected internal void Restore(string path, bool loggedIn = false)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                    throw new Exception("please select backup file");
              
                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
                string database = con.Database.ToString();
                con.Open();

                //There are lots of things you did not take into consideration here
                //you would have used a transaction query to do this with a procedure

                string sqlstmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlstmt2, con);
                bu2.ExecuteNonQuery();

                string sqlstmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlstmt3, con);
                bu3.ExecuteNonQuery();

                string sqlstmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlstmt4, con);
                bu4.ExecuteNonQuery();
                con.Close();
                 if(loggedIn)
                     UserActivity.RecordActivity("Restored Database");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        /// <summary>
        /// Get the last date backup was done
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDbLastUpdate()
        {

            try
            {
                DateTime date=DateTime.Today.Date;
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_backup_date", myconn);
                    cmd.Parameters.AddWithValue("@title", "Database Backup");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            if(!string.IsNullOrEmpty(dr[0].ToString()))
                            date = Convert.ToDateTime(dr[0].ToString());
                        }

                    }
                }

                return date;
            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
                //throw new Exception(ex.Message);
            }
        }
    }
}