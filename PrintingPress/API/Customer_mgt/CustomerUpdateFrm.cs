using System;
using System.Windows.Forms;
using PrintingPress.Models.Job;
using PrintingPress.API.Messenger;

namespace PrintingPress.API.Customer_mgt
{
    public partial class CustomerUpdateFrm : Form
    {
        private ICustomer newCustomer = Factory.CreateCustomer();
        public bool updated = false;
        public CustomerUpdateFrm(ICustomer customer)
        {
            InitializeComponent();
            txtName.Text = customer.Name;
            txtContact.Text = customer.Contact;
            newCustomer.CusID = customer.CusID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                newCustomer.Name = txtName.Text.Trim();
                newCustomer.Contact = txtContact.Text.Trim();
                newCustomer.CustomerNumberExist();
                newCustomer.Update();
                var notify = new OperationNotifyFrm("Customer update", "Updated successfully");
                updated = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            updated = false;
            this.Close();
        }
    }
}
