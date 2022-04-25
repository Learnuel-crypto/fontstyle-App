using PrintingPress;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public static class ImageLoader
    {
        public static string imagePath { get; private set; }
        public static string fileDeletePath;
        public static string LogoName { get;private  set; }
        public static string BarCodePath { get; private set; }
        /// <summary>
        /// Load picture images
        /// </summary>
        /// <returns></returns>
        public static string Load()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "@C://Pictures";
            fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png";
            fileDialog.FilterIndex = 1;
            fileDialog.Title = "Select Image";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return imagePath = fileDialog.FileName;
            }
            else
            {
                return imagePath;
            }

        }
        /// <summary>
        /// Load any file
        /// </summary>
        /// <returns></returns>
        public static string LoadFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|PNG|*.png|PDF|*.pdf";
            fileDialog.FilterIndex = 1;
            fileDialog.Title = "Select File";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return imagePath = fileDialog.FileName;
            }
            else
            {
                return imagePath;
            }

        }
        /// <summary>
        /// Get staff images
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MemoryStream GetStaff(string staffid)
        {
            try
            {
                MemoryStream ms = null;
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                using (SqlConnection mycon = myConHelper.GetConnection())
                {

                    SqlCommand myComand = mycon.CreateCommand();
                    myComand.Connection = mycon;
                    myComand.Parameters.Clear();
                    myComand.Parameters.AddWithValue("@staffid", staffid);
                    myComand.CommandType = CommandType.StoredProcedure;
                    myComand.CommandText = "sp_staff_passport";
                    SqlDataAdapter da = new SqlDataAdapter(myComand);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow Rec in dt.Rows)
                        {
                            if (Rec[0] != null)
                            {
                                byte[] pic = (byte[])Rec[0];
                                ms = new MemoryStream(pic);
                            }
                        }

                    }
                }

                return ms;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Save Receipt logo image
        /// </summary>
        /// <param name="filepath"></param>
        public static void SaveReceipt(string filepath)
        {
            try
            {
                using (FileStream stream = File.OpenRead(filepath))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    string extn = new FileInfo(filepath).Extension;
                    string name = new FileInfo(filepath).Name ;
                    ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                    SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@data", SqlDbType.VarBinary).Value = buffer;
                    myCommand.Parameters.AddWithValue("@extension", SqlDbType.Char).Value = extn;
                    myCommand.Parameters.AddWithValue("@filename", SqlDbType.VarChar).Value = name; 
                    myCommand.CommandText = "UPDATE ReceiptName SET Document=@data,Extension=@extension,Filename=@filename";
                     
                    mySqlHelper.Open();
                    myCommand.ExecuteNonQuery();
                    mySqlHelper.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Get receipt Logo and barcode details
        /// </summary>
        public static void GetReceiptDetails()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand(); 
                myComand.CommandText = "SELECT * FROM ReceiptName"; 
                SqlDataAdapter da = new SqlDataAdapter(myComand);
                mySqlHelper.Open();
                var reader = myComand.ExecuteReader();
                if (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["Filename"].ToString()))
                    {
                        var name = reader["Filename"].ToString();
                        var document = (byte[]) reader["Document"];
                        var extn = reader["Extension"].ToString();
                        name = name + extn;
                        File.WriteAllBytes(name, document);
                        LogoName = name;
                        
                    }
                     
                }
                mySqlHelper.Close();
                BarCodePath = BarCodeGen.QRcode("Fontstyle int. solutions #");

            }
            catch (Exception e)
            {
                if (e.Message.ToLower().StartsWith("could not find procedure"))
                {

                }
               else if (e.Message.Contains("used by another process"))
                {
                    throw new Exception("Receipt is already opened, please close and try again");
                }
                else
                {
                    throw new Exception(e.Message);
                }


            }
        } 
    }
}
