using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model;
using PrintingPress.API.Income_expense;
using PrintingPress.API.Messenger;
using PrintingPress.API.Notifications;
using PrintingPress.Models.Helper;
using PrintingPress.Models.Job;
using PrintingPress.Models.Staff_mgt;
using PrintingPress.API.Customer_mgt;
using PrintingPress.API.Configuration;
using PrintingPress.API.Reports.Invoice_receipt;
using PrintingPress.API.User_security;
using System.IO.IsolatedStorage;
using System.Net;
using EncryptString;

namespace PrintingPress.API.Startups
{
    public partial class DashboardFrm : Form
    {

        private IInvoice invoice = Factory.CreateInvoice();
        private ICashFlow cashFlow = Factory.createCashFlow();
        public DashboardFrm()
        {
            InitializeComponent();
           DataGridStyle.StyleDatagridMaterial(dgvInvoice); 
           DataGridStyle.StyleDatagridMaterial(dgvCash); 

        }

        private void CashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Users.RoleID !=7 && Users.RoleID !=6 && Users.RoleID !=5)
                    throw new Exception("Access denied: You don't have required privilege");
                var setupAccount = new AccountFrm();
                setupAccount.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DashboardFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserActivity.RecordActivity("Shutdown application");
            Application.Exit();
        }

        private void issueInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var genInvoice = new InvoiceGenFrm();
                genInvoice.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CashCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Users.RoleID < 7)
                    throw new Exception("You don't have required privilege");
                var user = new CreateUserFrm();
                user.Show(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable loadData()
        {
             
          return invoice.Display(DateTime.Now); 
            
        }
         
        private DataTable LoadCashflow()
        {
           return cashFlow.Display(DateTime.Now); 
        }
        private async void DashboardFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Task<DataTable> task1 = new Task<DataTable>(loadData);
                task1.Start();

               
                Task<DataTable> task = new Task<DataTable>(LoadCashflow);
                task.Start();

                dgvInvoice.DataSource = await task1;
                dgvCash.DataSource= await task;

                dgvCash.Columns[0].Visible = false; 

                RefreshTimer.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            try { 
            if (dgvInvoice.RowCount > 0)
            {
                var id=invoice.InvoicID = dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                var item = new ItemsFrm(id); 
                item.Show(this); 
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
} 
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserActivity.RecordActivity("Logged out");
            this.Hide();
            var login = new LoginFrm();
            login.Show();
        }

        

        private void incomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var cashFlow = new CashFlowFrm(true);
                cashFlow.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void expenseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var cashFlow = new CashFlowFrm();
                cashFlow.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtInvoiceFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = invoice.Display(dtInvoiceFrom.Value);
        }

        private void dtInvoiceTo_ValueChanged(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = invoice.Display(dtInvoiceFrom.Value, dtInvoiceTo.Value);
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private async void linkInvoiceRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task<DataTable> task1 = new Task<DataTable>(loadData);
            task1.Start();
            dgvInvoice.DataSource = await task1;
        }

        private void dtCasflowFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvCash.DataSource = cashFlow.Display(dtCasflowFrom.Value);
        }

        private void dtCasflowTo_ValueChanged(object sender, EventArgs e)
        {
            dgvCash.DataSource = cashFlow.Display(dtCasflowFrom.Value,dtCasflowTo.Value);
        }

        private void linkCashRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDebtReceipt.Visible = false;
            dgvCash.DataSource = cashFlow.Display(DateTime.Now);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void chechFile()
        {
            //check Activation
            using (IsolatedStorageFile isolatedStorageFile =
                IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (IsolatedStorageFileStream isolatedStorageFileStream =
                        new IsolatedStorageFileStream("chat_server.txt", System.IO.FileMode.Open, isolatedStorageFile))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                        {
                            var activation = sr.ReadLine();
                          
                            if (string.IsNullOrEmpty(activation))
                            {
                                var messageServer = new MessengerServerConfig();
                                messageServer.Show(this);
                                chatToolStripMenuItem.PerformClick();
                            }
                            else
                            {
                                StringEncryptor stringEncryptor = new StringEncryptor();
                                FileInfo fileInfo= new FileInfo("server_log.txt");
                              var filecontent= File.ReadAllText(fileInfo.FullName);
                              if (string.IsNullOrEmpty(filecontent))
                              {
                                  var messageServer = new MessengerServerConfig();
                                  messageServer.Show(this);
                                  chatToolStripMenuItem.PerformClick();
                                }
                              else
                              {
                                  var host = activation.Substring(0, activation.IndexOf('/'));
                                  host = string.Format("http://{0}/chat/admin_log.php", host);
                                  System.Diagnostics.Process.Start(host);
                              }
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    if (ex.Message == "Could not find file 'chat_server.txt'.")
                    {
                        var charServer = new MessengerServerConfig();
                        charServer.Show(this);
                    }
                    else
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

            private async void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(invoice.InvoicID))
                    throw new Exception("Select invoice to delete");
                if (MessageBox.Show("Do you want to delete selected invoice ?", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        invoice.Delete();
                        invoice.InvoicID = null;
                        Refresher.Refresh=true;
                        Refresher.Type = "cashflow";
                        Task<DataTable> task = new Task<DataTable>(loadData);
                        task.Start();
                        dgvInvoice.DataSource = await task;
                    ConfirmationNotifyFrm.Show("Completed", "Deleted successfully");
                       

                }
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
                invoice.Qty =Int32.Parse( dgvInvoice.SelectedRows[0].Cells["Totalqty"].Value.ToString());
                invoice.Total = Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Total"].Value.ToString());
                invoice.Paid = Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Cash"].Value.ToString());
                invoice.Balance = Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["Balance"].Value.ToString());
                invoice.OtherPaymentAmount = Convert.ToDecimal( dgvInvoice.SelectedRows[0].Cells["to_bank"].Value.ToString());
                invoice.Method = dgvInvoice.SelectedRows[0].Cells["Method"].Value.ToString();
                invoice.Date =Convert.ToDateTime( dgvInvoice.SelectedRows[0].Cells["Date"].Value);

            }
        }

        private void dgvCash_Click(object sender, EventArgs e)
        {
            if (dgvCash.RowCount > 0)
            {
                cashFlow.CashID = dgvCash.SelectedRows[0].Cells[0].Value.ToString();
               cashFlow.Description = dgvCash.SelectedRows[0].Cells["Description"].Value.ToString();
               if (cashFlow.Description.Contains("#"))
               {
                   invoice.Paid = Convert.ToDecimal(dgvCash.SelectedRows[0].Cells["Amount"].Value.ToString());
                   invoice.Date = Convert.ToDateTime(dgvCash.SelectedRows[0].Cells["Date"].Value.ToString());
                   invoice.Method = dgvCash.SelectedRows[0].Cells["Method"].Value.ToString();
               }

               linkDebtReceipt.Visible = cashFlow.Description.Contains("#") ? true : false;
                
            }
        }

        private async void linkDelCashflow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashFlow.CashID))
                    throw new Exception("Select cashflow to delete");
                if (MessageBox.Show("Do you want to delete selected cashflow ?", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cashFlow.Delete(dgvCash.SelectedRows[0].Cells["Code"].Value.ToString());
                    cashFlow.CashID = null;
                    Task<DataTable> task =new Task<DataTable>( LoadCashflow);
                    task.Start(); 
                    dgvCash.DataSource = await task;
                    ConfirmationNotifyFrm.Show("Completed","Deleted successfully");
 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            try
            {
                var cashDetails = new ViewCashFlowFrm();
                cashDetails.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            try
            {
                var invoiceDetails = new ViewInvoiceFrm();
                invoiceDetails.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Refresher.Refresh)
                {
                    if (Refresher.Type == "cashflow")
                    {
                        linkDebtReceipt.Visible = false;
                        dgvCash.DataSource = cashFlow.Display(DateTime.Now);
                    }

                    if (Refresher.Type == "invoice")
                    {
                        Task<DataTable> task1 = new Task<DataTable>(loadData);
                        task1.Start();
                        dgvInvoice.DataSource = await task1;
                    }

                    if (Refresher.Type == "both")
                    {
                        linkDebtReceipt.Visible = false;
                        dgvCash.DataSource =  cashFlow.Display(DateTime.Now);
                        
                        Task<DataTable> task1 = new Task<DataTable>(loadData);
                        task1.Start();
                        dgvInvoice.DataSource = await task1;
                         
                    }

                     
                    Refresher.Type = null;
                    Refresher.Refresh = false;
                }

                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(invoice.InvoicID))
                { 
                    var item = new ItemsFrm(invoice.InvoicID);
                    item.Show();
                }
                else
                {
                    throw new Exception("Select a record to view");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var customer_section = new Customer_dashboardFrm();
                customer_section.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var setReceipt = new ReceiptSetupFrm(Users.RoleID);
                setReceipt.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(invoice.InvoicID))
                    throw new Exception("Select a record to print receipt");
                var receiptFrm = new CRInvoiceFrm();
                receiptFrm.ReprintReceipt(invoice);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 
                var activity = new UserActivityFrm();
                activity.Show(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkDebtReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashFlow.CashID))
                    throw new Exception("Select a record to print receipt");
                invoice.InvoicID = cashFlow.Description.Substring(cashFlow.Description.IndexOf("#") + 1);
                var reprintDebtReceipt = new CRInvoiceFrm();
                reprintDebtReceipt.DebtReceipt(invoice,cashFlow);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void securityQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                var database = new DatabaseFrm(false);
                database.Show(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var database = new DatabaseFrm(true,true);
                database.Show(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void debtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                var customerReport = new Customer_activityFrm();
                customerReport.Show(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                chechFile();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            { 
            var messageServer = new MessengerServerConfig();
            messageServer.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void invoiceItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                var invoiceItems = new InvoiceItemsFrm();
                invoiceItems.Show(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
