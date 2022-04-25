using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System;
using PrintingPress.Models.Helper;
using PrintingPress;

namespace Activation
{
    class AppActivation
    {
        SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
        private static bool Activated { get; set; }
        private static string Key=null;
         
        private static void UpdateActivation(string key)
        {
            try
                {

                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();

                con.Open();
                SqlCommand cmddelete = new SqlCommand("DELETE ActivationTable" , con);
                cmddelete.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.Parameters.Clear();
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add(new SqlParameter("@key" , SqlDbType.VarChar));
                cmd2.Parameters["@key"].Value = key;
                cmd2.CommandText = "INSERT INTO ActivationTable values(@key) ";
                cmd2.ExecuteNonQuery();
                con.Close();
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Unkown error occurred" , ex);
                }
             
        }
        public static string isActivated()
        {
             
            using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
            { 
                string query = "SELECT ActivationKey FROM ActivationTable";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;
                if (x > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Key = dr["ActivationKey"].ToString(); 
                    }
                    
                }
                return Key;
            }
             
        }

        public static void activate(string key)
        {
            try
                {
                if (string.IsNullOrEmpty(isActivated()))
                    {
                    UpdateActivation(key);
                    using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly , null , null))
                        {
                        using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("apps.txt" , System.IO.FileMode.CreateNew , isolatedStorageFile))
                            {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(isolatedStorageFileStream))
                                {
                                sw.WriteLine(key);
                                MessageBox.Show("Software Activation Successful" , "Activation" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                                }
                            }
                        }
                    Activated = true;
                    }
                else
                    {
                    Activated = false;
                    }
                }catch (Exception ex)
                {
                throw new ExceptionHandling("Activation error" , ex);
                }
        }
        

        public static bool CheckLimit()
        {

            using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
            {  
                string query = "SELECT * FROM Cash";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;

                string query2 = "SELECT * FROM Sales";
                SqlDataAdapter da2 = new SqlDataAdapter(query2 , con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                int y = dt2.Rows.Count;
               
                if (x >= 120)
                {
                    return true;
                }
                else
                {
                    if (y >= 120)
                        {
                        return true;
                        }
                    else
                        {
                        return false;
                        }
                } 
            }

        }
    }
}
