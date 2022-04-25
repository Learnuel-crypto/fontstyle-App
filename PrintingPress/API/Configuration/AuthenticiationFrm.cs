using System;
using System.Windows.Forms;
using EncryptPassword35;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.Configuration
{
    public partial class AuthenticiationFrm : Form
    {
        static AuthenticiationFrm OperationConfirmed; static DialogResult result = DialogResult.OK;
        public AuthenticiationFrm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Confirm password");
                if (SecurePassword.Encrypt(txtPassword.Text.Trim()) == Users.LoggedInPassword)
                {
                    result = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    throw new Exception("Incorrect Password");
                }
            }
            catch (Exception ex)
            {
                txtPassword.Focus();
                MessageBox.Show(ex.Message, "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static DialogResult ShowAuth()
        {
            OperationConfirmed = new AuthenticiationFrm();
            OperationConfirmed.txtPassword.Focus();
            OperationConfirmed.txtPassword.UseSystemPasswordChar = true;
            OperationConfirmed.ShowDialog();
            return result;
        }
        private void btnCancell_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnProceed.PerformClick();
        }
    }
}
