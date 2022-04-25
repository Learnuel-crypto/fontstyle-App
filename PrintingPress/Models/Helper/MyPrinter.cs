using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using DGVPrinterHelper;
using PrintingPress;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using WindowsFormsApplication1.Modification.Models;

namespace WindowsFormsApplication1
{
    class MyPrinter
        {
            public MyPrinter()
            {

            }
      
        public static bool Print = true;
        
       
        /// <summary>
        /// Print page title
        /// </summary>
        public static string PrintTitle { get; set; }
        /// <summary>
        /// School name
        /// </summary>
        public static string Contact { get; private set; }
        /// <summary>
        /// School address
        /// </summary>
        public static string Address { get; private set; }
#region
            /// <summary>
            /// Printer Class
            /// </summary>
            
            public static void PrintRecordsPortrate(DataGridView recordsDataGridView, string title)
            {
                try
                {
                    schoolInfor sch = new schoolInfor();
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = sch.SchoolName.ToUpper();
                    printer.SubTitle = title.ToUpper();
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PageNumberAlignment = StringAlignment.Near;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Motto: " + sch.Motto.ToLower(); 
                    printer.FooterSpacing = 15;
                    printer.PrintDialogSettings.AllowPrintToFile = true;
                    printer.ShowTotalPageNumber = true;
                    printer.PrintDataGridView(recordsDataGridView);
                }
                catch (Exception)
                {
                    
                }
            }
            public static void PrintRecords(DataGridView recordsDataGridView, string title)
            {
                try
                {
                    schoolInfor sch = new schoolInfor(); 
                    DGVPrinter printer = new DGVPrinter();
                    recordsDataGridView.AutoSize = true;
                    printer.Title = sch.SchoolName.ToUpper();
                    printer.SubTitle = title.ToUpper();
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true; 
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer ="Motto: " +sch.Motto.ToLower();
                    printer.FooterSpacing = 15; 
                    printer.PrintDialogSettings.AllowPrintToFile = true;
                    printer.ShowTotalPageNumber = true;
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    printer.PrintDataGridView(recordsDataGridView);
                }
                catch (Exception)
                {

                }
            }
            public static void GetReceiptHeading()
            {
                try
                { 
                    using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_receipt_heading", myconn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        myconn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(sdr);

                        if (table.Rows.Count > 0)
                        {
                            DataRow row = table.Rows[0];
                            if (!string.IsNullOrEmpty(row[1].ToString()))
                            {
                                Contact = (row["Contact"].ToString());
                                Address = row["Address"].ToString();
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    CreateProcedure proc = Factory.CreateProc();
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                    { 
                        proc.Create(Procedures.sp_get_receipt_heading());
                        GetReceiptHeading();
                    }else if (ex.Message == "Invalid object name 'Receipt'.")
                    {
                        //call invoice method to create the table
                        proc.Create(Procedures.create_receipt_table());
                        GetReceiptHeading();
                    }
                    else
                    {
                        throw new Exception(ex.Message);
                    }
            }
            }
    }
}
#endregion
