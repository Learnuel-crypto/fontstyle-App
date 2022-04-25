using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using PrintingPress;

namespace WindowsFormsApplication1
{
    class schoolInfor
    { 

            public   string SchoolName;
            public   string Address;
            public   string Motto;
            public   PictureBox Logo; 
        /// <summary>
        /// constructor to call all methods
        /// </summary>
            public schoolInfor()
            {
                getSchoolName();
                getAddress();
                getMotto();
                 
            }
            #region
        /// <summary>
        /// get the school details for receipt and printing other documents
        /// </summary>
        /// <returns></returns>
            private   string getAddress()
            {
                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
                con.Open();
                SqlCommand cmdS = new SqlCommand("select * from ReceiptName ", con);
                SqlDataAdapter recsch = new SqlDataAdapter(cmdS);
                DataTable dtSch = new DataTable();
                DataSet ds = new DataSet();
                recsch.Fill(dtSch);
                foreach (DataRow drs in dtSch.Rows)
                { 
                    Address = drs[2].ToString();
                }
                con.Close();
                return Address;
            }
            public  string getMotto()
            {
                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
                con.Open();
                SqlCommand cmdMotto = new SqlCommand("select Motto from ReceiptName ", con);
                SqlDataAdapter moto = new SqlDataAdapter(cmdMotto);
                DataTable dtMoto = new DataTable();
                moto.Fill(dtMoto);
                foreach (DataRow drs in dtMoto.Rows)
                {
                      Motto = drs["Motto"].ToString(); 
                }
                con.Close();
                if (string.IsNullOrEmpty(Motto))
                {
                    return Motto = "cashDesk";
                }
                else
                {
                    return  Motto;
                }
            }
            private   string getLogo()
            {
                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
                con.Open();
                SqlCommand cmdS = new SqlCommand("select * from ReceiptName ", con);
                SqlDataAdapter recsch = new SqlDataAdapter(cmdS);
                DataTable dtSch = new DataTable();
                DataSet ds = new DataSet();
                recsch.Fill(dtSch);
                recsch.Fill(ds);
                int x = dtSch.Rows.Count; 
                if (x <= 0)
                {
                       
                }
                else
                {
                    byte[] pic = (byte[])ds.Tables[0].Rows[0]["Logo"];
                    MemoryStream ms = new MemoryStream(pic);
                    Logo.Image = Image.FromStream(ms);
                    con.Close();
                }
                return "" ;
            }
          private   string   getSchoolName()
            {
                SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
                con.Open();
                SqlCommand cmdS = new SqlCommand("select * from ReceiptName ", con);
                SqlDataAdapter recsch = new SqlDataAdapter(cmdS);
                DataTable dtSch = new DataTable();
                DataSet ds = new DataSet();
                recsch.Fill(dtSch);
                recsch.Fill(ds);
                int x = dtSch.Rows.Count;

                if (x <= 0)
                {
                    SchoolName = "No School Name Set";
                    
                }
                else
                {
                    //GET THE SCHOOL NAME
                    foreach (DataRow drs in dtSch.Rows)
                    {
                        SchoolName = drs[1].ToString(); 
                    }
                     
                }
                con.Close();
                return SchoolName;
                
            }
        
    }
}
#endregion