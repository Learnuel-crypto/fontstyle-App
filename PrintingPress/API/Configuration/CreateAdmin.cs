using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model.Staff_mgt;
using Exception = System.Exception;

namespace PrintingPress.API.Configuration
{
    public partial class CreateAdmin : Form
    {
        private IStaffs createUser = Factory.CreateStaff();
        public CreateAdmin()
        {
            InitializeComponent();
            txtConfirmPass.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var login = new LoginFrm();
            this.Close();
            login.Show();
        }

 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    txtName.Focus();
                    throw new Exception("Enter Name");
                }

                Validation.Name(txtName.Text.Trim());

                if (string.IsNullOrEmpty(txtContact.Text))
                {
                    txtContact.Focus();
                    throw new Exception("Enter Contact");
                }

                Validation.Contact(txtContact.Text.Trim(), 11, 15);
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus();
                    throw new Exception("Enter username");
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    throw new Exception("Enter password");
                }

                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Confirm password");
                }

                if (txtPassword.Text.Trim() != txtConfirmPass.Text.Trim())
                {
                    txtConfirmPass.Focus();
                    throw new Exception("Password mismatch");
            }

                 createUser.Name = txtName.Text.Trim();
                createUser.Contact = txtContact.Text.Trim();
                createUser.Username = txtUsername.Text.Trim();
                createUser.Password = txtPassword.Text.Trim();
                createUser.Role = "Administrator";
                createUser.IsActive = 1;
               createUser.AddWithAccount(true);
               MessageBox.Show("Registration successful", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if registration was successful 
                var login = new LoginFrm();
                this.Close();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnCreate.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnCreate.PerformClick();
        }
    }
}
