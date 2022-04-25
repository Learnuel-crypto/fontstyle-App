using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Notifications;

namespace PrintingPress.API.Configuration
{
    public partial class ReceiptSetupFrm : Form
    {
        private Receipt receipt = new Receipt();
        public ReceiptSetupFrm(int userRole)
        {
            InitializeComponent();
            if (userRole != 7 && userRole != 6 && userRole !=5)
                throw new Exception("Access denied:you do not have required privilege");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContact.Text.Contains(","))
                {
                    string[] Slipter = txtContact.Text.Split(new string[] { "," }, StringSplitOptions.None);
                    var left = "";
                    foreach (String str in Slipter)
                    {
                        Validation.Contact(str.Trim(),11,15);
                        left += string.Format(" {0}", str.Trim());
                    }
                }
                receipt.Contact = txtContact.Text;
                receipt.Address = txtAddress.Text;

                if (AuthenticiationFrm.ShowAuth() == DialogResult.Yes)
                { 
                    receipt.Update();
                    ConfirmationNotifyFrm.Show("Receipt", "Updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
