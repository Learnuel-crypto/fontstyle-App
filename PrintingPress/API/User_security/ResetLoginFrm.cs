using System;
using System.Windows.Forms;
using EncryptPassword35;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.User_security
{
    public partial class ResetLoginFrm : Form
    {
        private IUsers user = Factory.CreateNewUser();
        public ResetLoginFrm()
        {
            InitializeComponent();
            txtCurrentPass.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtLoggedInPassword.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;

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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCurrentPass.Text))
                {
                    txtCurrentPass.Focus();
                    throw new Exception("Enter current password");
                }
                if (string.IsNullOrEmpty(txtNewPass.Text))
                {
                    txtNewPass.Focus();
                    throw new Exception("Enter new password");
                }
                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Confirm new password");
                }

                if (SecurePassword.Encrypt(txtCurrentPass.Text.Trim()) != Users.LoggedInPassword)
                    throw new Exception("Current password is incorrect");
                if (SecurePassword.Encrypt(txtNewPass.Text.Trim()) !=
                    SecurePassword.Encrypt(txtConfirmPass.Text.Trim()))
                    throw new Exception("Password mismatched");
                user.NewPassword = txtConfirmPass.Text.Trim();
                user.ResetPassword(user, Users.LoginUserID);

                txtConfirmPass.Clear();
                txtCurrentPass.Clear();
                txtNewPass.Clear();
                MessageBox.Show("Password reset was succesful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetUsername_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewUsername.Text))
                {
                    txtNewUsername.Focus();
                    throw new Exception("Enter new username");
                }
                if (string.IsNullOrEmpty(txtLoggedInPassword.Text))
                {
                    txtLoggedInPassword.Focus();
                    throw new Exception("Enter current password");
                }

                if (SecurePassword.Encrypt(txtLoggedInPassword.Text.Trim()) != Users.LoggedInPassword)
                    throw new Exception("Current password is incorrect");
                user.Newusername = txtNewUsername.Text;
                user.ResetUsername(user, Users.LoginUserID);
                MessageBox.Show("Username reset was succesful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNewUsername.Clear();
                txtLoggedInPassword.Clear();
                LogTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLoggedInPassword_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyValue == (char)Keys.Enter)
                btnResetUsername.PerformClick();
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnResetPassword.PerformClick();
        }

        private void LogTimer_Tick(object sender, EventArgs e)
        {
            if (Users.IsLoggedIn == false)
            {
                var logoutFrm = new LoginFrm();
                LogTimer.Stop();
                this.Close();
                logoutFrm.Show();
                LogTimer.Start();
            }
        }
    }
}
