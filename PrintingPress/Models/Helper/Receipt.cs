using PrintingPress;
using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using PrintingPress.Models.Staff_mgt;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public class Receipt
    {
        public string Fullname { get; set; } 
        public string FeeName { get; set; }
        public string Cashier { get; set; }
        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter address");
                address = value;
            }
        }

        public string Amount { get; set; }
        public string Date { get; set; } 
        private string contact;

        public string Contact
        {
            get { return contact; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Entr receipt contact(s)");
                if (!value.Contains(","))
                {
                    Validation.Contact(value);
                }
                else
                {
                    string[] Slipter = value.Split(new string[] {","}, StringSplitOptions.None);
                    var left = "";
                    foreach (String str in Slipter)
                    {
                        Validation.Contact(str.Trim());
                        left += string.Format(" {0}", str.Trim());
                    }

                    value = left;
                }

                contact = value;
            }
        }

        /// <summary>
        /// Update receipt details
        /// </summary>
        internal void Update()
        {
            try
            {
                using (SqlConnection myconn = Factory.CreateSqlConHelper().GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_update_receipt", myconn);
                    cmd.Parameters.AddWithValue("@contact", this.Contact);
                    cmd.Parameters.AddWithValue("@address", this.Address);
                    cmd.Parameters.AddWithValue("@userid", Users.LoginUserID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                CreateProcedure proc = Factory.CreateProc();
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    proc.Create(Procedures.create_receipt_table());
                    proc.Create(Procedures.sp_update_receipt());
                    Update();
                }
                else if (ex.Message == "Invalid object name 'Receipt'.")
                { 
                    proc.Create(Procedures.create_receipt_table());
                    Update();
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
          
    }

}
