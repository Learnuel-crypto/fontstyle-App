using ChucksMedicare.Model.Staff_mgt;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Startups
{

    public partial class CreateUserFrm : Form
    {
        private IStaffs createUser = Factory.CreateStaff();
        public CreateUserFrm()
        {
            InitializeComponent();
            checkActive.Checked = true;
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

                if (combRole.Text.ToLower() == "choose role")
                    throw new Exception("Select user role");
                createUser.Name = txtName.Text.Trim();
                createUser.Contact = txtContact.Text.Trim();
                createUser.Username = txtUsername.Text.Trim();
                createUser.Password = txtPassword.Text.Trim();
                createUser.Role = combRole.Text;
                createUser.IsActive = checkActive.Checked ? 1 : 0;
               

                if (!checkActive.Checked)
                {
                    if (MessageBox.Show("Staff account is not active, continue ?","Staff account", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        createUser.AddWithAccount(true);
                        MessageBox.Show("Account created successfully", "Completed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                    }
                }
                else
                {
                    createUser.AddWithAccount(true);
                    MessageBox.Show("Account created successfully", "Completed", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

       private void Clear()
        {
            txtName.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            combRole.ResetText(); 
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
