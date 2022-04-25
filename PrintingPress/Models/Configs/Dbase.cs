using EncryptString;
using PrintingPress;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace WindowsFormsApplication1.Modification.Models.Configs
{
    class Dbase
    {
        protected internal Dbase(string script)
        {
            SliptScriptAndRun(script);
        }
        protected internal Dbase()
        {
        }
        private const string newDatabaseConnString = "/0Eka+/lqF01LFpirH6c+BrQ98a7TGYZpslOR8LSiBN05JITCuy5A2nNvy3b7VFjG9BRQzzT47ddCfyTarSpLYvdvioItM+91I1CuqQofd0=";
        private const string databaseName = "FfViBuXQ1fO2v59njsnEAQtCCPf/WxDx01Urgyk+I/A=";

        private const string createdDatabaseConnString =
            "yqV+V9oz+FWy0NBj20nKMOGU840L4tKDlrrbXMSvjW8MZF4lAYFREqYRahKX+q9MxaidASd1RuDyOv84t+Dnh1+X3Mnuuh9xpxQVm3tyOZmvHM3isANSiSpvtcBzmfVN";
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
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
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

                MessageBox.Show("Database Created Successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("database " + stringEncryptor.Decrypt(databaseName) + "already exists:"))
                {
                    if (MessageBox.Show("Database  already exist \nDelete existing database ?", "Database Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        DeleteExistingDatabase(databaseName);
                        SliptScriptAndRun(script);
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        protected internal void Backup(string path, bool loggedIn = false)
        {
            ISqlHelper connection = Factory.CreateSqlConHelper();
            SqlConnection con = connection.GetConnection();
            string database = con.Database.ToString();
            try
            {
                if (string.IsNullOrEmpty(path))
                    throw new Exception("please enter backup file location");

                //this code is not the right way to this;
                //you would have used a procedure so the program is protected
                //from SQL INJECTION
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + path + "\\" + stringEncryptor.Decrypt("pkpmM826cyYFViMo8B7E1w==") + " Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    Con.Close();
                    //if (loggedIn)
                       // UserActivity.RecordActivity("Backedup database");
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
                    throw new Exception("please ennter backup file location");
                ISqlHelper connection = Factory.CreateSqlConHelper();
                SqlConnection con = connection.GetConnection();
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
               // if (loggedIn)
                   // UserActivity.RecordActivity("Restored database");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
