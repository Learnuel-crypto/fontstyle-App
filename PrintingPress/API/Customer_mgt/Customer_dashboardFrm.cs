using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.Models.Job;
using System;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using PrintingPress.API.Configuration;
using PrintingPress.API.Messenger;
using PrintingPress.API.General_reports;
using PrintingPress.API.Income_expense;

namespace PrintingPress.API.Customer_mgt
{
    public partial class Customer_dashboardFrm : Form
    {
        private ICustomer customer = Factory.CreateCustomer();
        private IInvoice invoice = Factory.CreateInvoice();
        private string ID { get; set; }
        public Customer_dashboardFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridviewFixed(dgvCustomer);
            DataGridStyle.StyleDatagridviewFixed(dgvInvoice);
            dgvCustomer.DataSource = customer.GetCustomersNames ("");
            lblCusName.Text = "";
            RefreshTimer.Start();

        }

        private void Customer_dashboardFrm_Load(object sender, System.EventArgs e)
        {
            dgvCustomer.Columns[0].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length>2)
            {
                dgvCustomer.DataSource = customer.GetCustomersNames(txtSearch.Text.Trim());
            }
            else if(string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvCustomer.DataSource =  customer.GetCustomersNames("");
            }
        }
     internal   Decimal Total()
        {
            var total = 0.00m;
            if (dgvInvoice.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Bal"].Value.ToString());
                }
            }

            return total;
        }
        private async void dgvCustomer_Click(object sender, System.EventArgs e)
        {
            if (dgvCustomer.RowCount > 0)
            {
                customer.CusID = dgvCustomer.SelectedRows[0].Cells["CusID"].Value.ToString();
                 customer.Name = dgvCustomer.SelectedRows[0].Cells["Name"].Value.ToString();
                customer.Contact = dgvCustomer.SelectedRows[0].Cells["Contact"].Value.ToString();
                dgvInvoice.DataSource = await Task.Run(()=> invoice.DisplayByCustomer(customer.CusID));
               dgvInvoice.Columns[0].Visible = false;
                lblCusName.Text = string.Format("{0}", customer.Name);
            }

            linkPayDebt.Visible = false;
            invoice.InvoicID = null;
        }

        private void dgvCustomer_DoubleClick(object sender, System.EventArgs e)
        {
            if (dgvCustomer.RowCount > 0)
            {
                //call update form
                var updateCustomer =new CustomerUpdateFrm(customer);
                updateCustomer.ShowDialog(this);
                if (updateCustomer.updated)
                {
                    dgvCustomer.DataSource = customer.GetCustomersNames("");
                    customer.CusID = null;
                    updateCustomer.updated = false;
                }
            }
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.CusID))
                    throw new Exception("Select a record to update");
                var updateCustomer = new CustomerUpdateFrm(customer);
                updateCustomer.ShowDialog(this);
                if (updateCustomer.updated)
                {
                    dgvCustomer.DataSource = customer.GetCustomersNames("");
                    customer.CusID = null;
                    updateCustomer.updated = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void linkAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.CusID))
                    throw new Exception("Select a customer to view account");

                var customerAcct = new CustomerAccountFrm(customer, Total()); 
                customerAcct.Show(this); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.RowCount > 0)
            {
                invoice.InvoicID = dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                invoice.Total =Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Total"].Value);
                invoice.Paid =Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Cash"].Value);
                invoice.OtherPaymentAmount =Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["To_bank"].Value);
                invoice.Balance =Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Bal"].Value);
                invoice.Date = Convert.ToDateTime( dgvInvoice.SelectedRows[0].Cells["Date"].Value.ToString());
                linkPayDebt.Visible = invoice.Balance > 0m ? true:false;
                ID = dgvInvoice.SelectedRows[0].Cells["ID"].Value.ToString();
            }
        }

        private void linkPayDebt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.CusID))
                    throw new Exception("Select a customer to pay debt");

                var customerAcct = new CustomerAccountFrm(customer,invoice, Total());
              
                customerAcct.Show(this); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkDeleteCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(customer.CusID))
                    throw new Exception("Select a record to delete");
                if (MessageBox.Show("Do you want to delete ?", "Confrim", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    customer.Delete();
                    var operation = new OperationNotifyFrm("Customer delete", "Customer Deleted successfully");
                    customer.CusID = null;
                    dgvCustomer.DataSource = customer.GetCustomersNames("");
                    dgvInvoice.DataSource = null;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkDelInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(invoice.InvoicID))
                    throw new Exception("Select invoice to delete");
                if (MessageBox.Show("Do you want to delete invoice ?", "Confrim", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    invoice.Delete();
                    var operation = new OperationNotifyFrm("Invoice delete", "Invoice Deleted successfully");
                    dgvInvoice.DataSource = invoice.DisplayByCustomer(customer.CusID);
                    invoice.InvoicID= ID = null;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (CustomerAccountFrm.proceed)
            {
                dgvInvoice.DataSource = await Task.Run(()=> invoice.DisplayByCustomer(customer.CusID));
                CustomerAccountFrm.proceed = false;
            }
        }

        private void linkPrintCusitner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
            {
                MyPrinter.Print = true;
                MyPrinter.PrintRecordsPortrate(dgvCustomer,MyPrinter.PrintTitle);
            }
        }

        private async void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                linkPayDebt.Visible = false;
            if (string.IsNullOrEmpty(customer.CusID))
                throw new Exception("Select a customer");
            dgvInvoice.DataSource = await Task.Run(() => invoice.DisplayByCustomer(customer.CusID,dtFrom.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dtTo_ValueChanged(object sender, EventArgs e)
        {
            try {
                linkPayDebt.Visible = false;
                if (string.IsNullOrEmpty(customer.CusID))
                throw new Exception("Select a customer");
            dgvInvoice.DataSource = await Task.Run(() => invoice.DisplayByCustomer(customer.CusID, dtFrom.Value,dtTo.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkPrintInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvInvoice.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    //print data
                    var generalPrint = new GeneralReportFrm();
                    generalPrint.PrintInvoice(dgvInvoice,true);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoice.RowCount > 0)
                {
                    var id = invoice.InvoicID = dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                    var item = new ItemsFrm(id);
                    item.Show(this);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
