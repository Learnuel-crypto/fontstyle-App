using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Notifications;
using PrintingPress.Models.Job;
using PrintingPress.Models.Helper;
using PrintingPress.API.Reports.Invoice_receipt;
using PrintingPress.API.Configuration;
using PrintingPress.API.General_reports;

namespace PrintingPress.API.Income_expense
{
    public partial class ViewInvoiceFrm : Form
    {
        private IInvoice invoice = Factory.CreateInvoice();
        private int searched = 0;
       
        public ViewInvoiceFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvDetails);
            panWait.Dock = DockStyle.Fill;
            CRInvoiceFrm.loadingInvoiceReceipt = false;
            GeneralReportFrm.invoicePrint = false;
            
        }

        private async void ViewInvoiceFrm_Load(object sender, EventArgs e)
        {
            try
            {
                lblMonthIncome.Text = string.Format("{0:N}", Invoice.LastMonthlyIncome());
                lblMonthExpense.Text = string.Format("{0:N}", Invoice.LastMonthlyDebt());
                lblCurIncome.Text = string.Format("{0:N}", Invoice.CurrentMonthIncome());
                lblCurExpense.Text = string.Format("{0:N}", Invoice.CurrentMonthDebt());
                lblCashAthand.Text = string.Format("{0:N}", Invoice.CashInHand());
                lblCashInBank.Text = string.Format("{0:N}", Invoice.CashInBank());
                lblTodayDebt.Text = string.Format("{0:N}", Invoice.TodayDebt());
                lblTodayCash.Text = string.Format("{0:N}", Invoice.TodayCashInHand());
                lblTodayBank.Text = string.Format("{0:N}", Invoice.TodayCashInBank());
                dgvDetails.Focus();
                Task<DataTable> task1 = new Task<DataTable>(LoadData);
                task1.Start();
                dgvDetails.DataSource = await task1;
                totalsTimer.Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataTable LoadData()
        {
            return invoice.Display(""); 
        }

        private async void linkDelCashflow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    Task<DataTable> task = new Task<DataTable>(LoadData);
                    task.Start();
                    dgvDetails.DataSource = await task;
                    ConfirmationNotifyFrm.Show("Completed", "Deleted successfully");
                    Refresher.Type = "invoice";
                    Refresher.Refresh = true;
                    lblMonthIncome.Text = string.Format("{0:N}", Invoice.LastMonthlyIncome());
                    lblMonthExpense.Text = string.Format("{0:N}", Invoice.LastMonthlyDebt());
                    lblCurIncome.Text = string.Format("{0:N}", Invoice.CurrentMonthIncome());
                    lblCurExpense.Text = string.Format("{0:N}", Invoice.CurrentMonthDebt());
                    lblCashAthand.Text = string.Format("{0:N}", Invoice.CashInHand());
                    lblCashInBank.Text = string.Format("{0:N}", Invoice.CashInBank());
                    lblTodayDebt.Text = string.Format("{0:N}", Invoice.TodayDebt());
                    lblTodayCash.Text = string.Format("{0:N}", Invoice.TodayCashInHand());
                    lblTodayBank.Text = string.Format("{0:N}", Invoice.TodayCashInBank());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void linkCashRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task<DataTable> task1 = new Task<DataTable>(LoadData);
            task1.Start();
            dgvDetails.DataSource = await task1;
            dateCash.Value=DateTime.Now;
            totalsTimer.Start();
        }

        private void dtCasflowFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = invoice.Display(dtCasflowFrom.Value);
            invoice.InvoicID = null;
        }

        private void dtCasflowTo_ValueChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = invoice.Display(dtCasflowFrom.Value, dtCasflowTo.Value);
            invoice.InvoicID = null;
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount > 0)
                {
                    var id = invoice.InvoicID = dgvDetails.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                    var item = new ItemsFrm(id);
                    item.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDetails_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                invoice.InvoicID = dgvDetails.SelectedRows[0].Cells["InvoiceID"].Value.ToString(); 
                invoice.Qty = Int32.Parse(dgvDetails.SelectedRows[0].Cells["Totalqty"].Value.ToString());
                invoice.Total = Convert.ToDecimal(dgvDetails.SelectedRows[0].Cells["Total"].Value.ToString());
                invoice.Paid = Convert.ToDecimal(dgvDetails.SelectedRows[0].Cells["Cash"].Value.ToString());
                invoice.Balance = Convert.ToDecimal(dgvDetails.SelectedRows[0].Cells["Balance"].Value.ToString());
                invoice.OtherPaymentAmount = Convert.ToDecimal(dgvDetails.SelectedRows[0].Cells["To_bank"].Value.ToString());
                invoice.Method = dgvDetails.SelectedRows[0].Cells["Method"].Value.ToString();
                invoice.Date = Convert.ToDateTime(dgvDetails.SelectedRows[0].Cells["Date"].Value);
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length >= 3)
            {
                dgvDetails.DataSource = invoice.Display(txtSearch.Text);
                searched = 1;

            }

            if (searched != 0 && string.IsNullOrEmpty(txtSearch.Text))
            {
                Task<DataTable> task1 = new Task<DataTable>(LoadData);
                task1.Start();
                dgvDetails.DataSource = await task1;
                searched = 0;
            }
            invoice.InvoicID = null;
        }

        private void totalsTimer_Tick(object sender, EventArgs e)
        {
            lblMonthIncome.Text = string.Format("{0:N}", Invoice.LastMonthlyIncome());
            lblMonthExpense.Text = string.Format("{0:N}", Invoice.LastMonthlyDebt());
            lblCurIncome.Text = string.Format("{0:N}", Invoice.CurrentMonthIncome());
            lblCurExpense.Text = string.Format("{0:N}", Invoice.CurrentMonthDebt());
            lblCashAthand.Text = string.Format("{0:N}", Invoice.CashInHand());
            lblCashInBank.Text = string.Format("{0:N}", Invoice.CashInBank());
            lblTodayDebt.Text= string.Format("{0:N}", Invoice.TodayDebt());
            lblTodayCash.Text= string.Format("{0:N}", Invoice.TodayCashInHand());
            lblTodayBank.Text= string.Format("{0:N}", Invoice.TodayCashInBank());
        }

        private void picMoneyBag_Click(object sender, EventArgs e)
        {

        }

        private void linkReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(invoice.InvoicID))
                    throw new Exception("Select a record to print receipt");
                CRInvoiceFrm.loadingInvoiceReceipt = true;
                lblInfor.Text = "Please wait... preparing receipt";
                WaitTimer.Start();
                var receiptFrm = new CRInvoiceFrm();
                receiptFrm.ReprintReceipt(invoice);

            }
            catch (Exception ex)
            {
                CRInvoiceFrm.loadingInvoiceReceipt = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        { 
            if (CRInvoiceFrm.loadingInvoiceReceipt)
            {
                panWait.Visible = true;
            }
            else if (GeneralReportFrm.invoicePrint)
            {
                panWait.Visible = true;
            }
            else
            {
                panWait.Visible = false;
            }
        }
  
        private void linkPrintRecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    lblInfor.Text = "Please wait... preparing print page";
                    GeneralReportFrm.invoicePrint = true;
                    WaitTimer.Start();
                    var printInvoice = new GeneralReportFrm();
                    printInvoice.PrintInvoice(dgvDetails);
                     
                }

            }
            catch (Exception ex)
            {
                GeneralReportFrm.invoicePrint = false;
                WaitTimer.Stop();
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(invoice.InvoicID))
                    throw new Exception("Select a record to view items");
                   
                    var item = new ItemsFrm(invoice.InvoicID);
                    item.Show();
                 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateCash_ValueChanged(object sender, EventArgs e)
        {
            try { 
            totalsTimer.Stop();
            lblTodayCash.Text = string.Format("{0:N}", Invoice.TodayCashInHand(dateCash.Value));
            lblTodayBank.Text = string.Format("{0:N}", Invoice.TodayCashInBank(dateCash.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
