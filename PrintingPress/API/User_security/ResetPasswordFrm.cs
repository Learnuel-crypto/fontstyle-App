using System;
using System.Windows.Forms;
using EncryptPassword35;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.User_security
{
    public partial class ResetPasswordFrm : Form
    {
        private IUsers user = Factory.CreateNewUser();
        public ResetPasswordFrm(string username)
        {
            InitializeComponent();
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            lblUsername.Text = username;
            txtNewPassword.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys KeyData)
        {
            if (KeyData == (Keys.Escape))
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, KeyData);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    txtNewPassword.Focus();
                    throw new Exception("Enter new password");
                }

                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Confirm new password");
                }

                if (SecurePassword.Encrypt(txtNewPassword.Text.Trim()) !=
                    SecurePassword.Encrypt(txtConfirmPass.Text.Trim()))
                    throw new Exception("Password mismatched");
                user.Username = lblUsername.Text;
                user.NewPassword = txtNewPassword.Text;
                user.ForgottonPassword(user);
                MessageBox.Show("Password reset was successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
