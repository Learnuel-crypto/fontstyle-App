using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Notifications;
using PrintingPress.Models.Helper;
using PrintingPress.Models.Job;
using PrintingPress.API.Reports.Invoice_receipt;
using PrintingPress.API.Configuration;
using PrintingPress.API.General_reports;
using PrintingPress.Models;

namespace PrintingPress.API.Income_expense
{
    public partial class ViewCashFlowFrm : Form
    {
        private ICashFlow cashFlow = Factory.createCashFlow();
        private IInvoice invoice = Factory.CreateInvoice();
        private IJobCategory heading = Factory.CreateCategory();
        private IExpenses expense = Factory.CreateExpenses();
        List<string> Headlist = new List<string>();
        private int searched = 0;
        private int selectedindex;
        internal static string InvoiceDateFrom;
        internal static string InvoiceDateTo;
        GeneralReportFrm printCashflow;
        public ViewCashFlowFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvDetails); 
           cmbHeading.DataSource = heading.GetExpenseCodeAndHeading("");
           cmbHeading.DisplayMember = "Heading";
           panWait.Dock = DockStyle.Fill;
           CRInvoiceFrm.loadingReprintDebtReceipt = false;
           InvoiceDateTo = null;
           InvoiceDateFrom = null;
            WaitTimer.Start();
        }

        private void dtCasflowTo_ValueChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = cashFlow.Display(dtCasflowFrom.Value,dtCasflowTo.Value);
            cashFlow.CashID = null;
            InvoiceDateTo = dtCasflowTo.Value.ToString();
        }

        DataTable LoadData()
        {
            return cashFlow.Search("");
        }

        private async void ViewCashFlowFrm_Load(object sender, EventArgs e)
        {
            try
            {
                lblMonthIncome.Text = string.Format("{0:N}", CashFlow.MonthlyIncome());
                lblMonthExpense.Text = string.Format("{0:N}", CashFlow.MonthlyExpense());
                lblCurIncome.Text = string.Format("{0:N}",CashFlow.CurrentMonthIncome());
                lblCurExpense.Text = string.Format("{0:N}", CashFlow.CurrentMonthExpense());
                lblCashAthand.Text = string.Format("{0:N}", CashFlow.CashInHand());
                lblCashInBank.Text = string.Format("{0:N}", CashFlow.CashInBank());
                lblTodayExpense.Text= string.Format("{0:N}", CashFlow.TodayExpense());
                lblTodayCash.Text= string.Format("{0:N}", CashFlow.TodayCashInHand());
                lblTodayBank.Text= string.Format("{0:N}", CashFlow.TodayCashInBank());

                dgvDetails.Focus();
                Task<DataTable> task1 = new Task<DataTable>(LoadData);
                task1.Start(); 
                dgvDetails.DataSource = await task1;
                dgvDetails.Columns[0].Visible = false;
                totalsTimer.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void totalsTimer_Tick(object sender, EventArgs e)
        {
            lblMonthIncome.Text = string.Format("{0:N}", CashFlow.MonthlyIncome());
            lblMonthExpense.Text = string.Format("{0:N}", CashFlow.MonthlyExpense());
            lblCurIncome.Text = string.Format("{0:N}", CashFlow.CurrentMonthIncome());
            lblCurExpense.Text = string.Format("{0:N}", CashFlow.CurrentMonthExpense());
            lblCashAthand.Text = string.Format("{0:N}", CashFlow.CashInHand());
            lblCashInBank.Text = string.Format("{0:N}", CashFlow.CashInBank());
            lblTodayExpense.Text = string.Format("{0:N}", CashFlow.TodayExpense());
            lblTodayCash.Text = string.Format("{0:N}", CashFlow.TodayCashInHand());
            lblTodayBank.Text = string.Format("{0:N}", CashFlow.TodayCashInBank());
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length >= 3)
            {
                dgvDetails.DataSource = cashFlow.Search(txtSearch.Text);
                searched = 1;
               
            }

            if (searched != 0 && string.IsNullOrEmpty(txtSearch.Text))
            {
                Task<DataTable> task1 = new Task<DataTable>(LoadData);
                task1.Start();
                dgvDetails.DataSource = await task1;
                searched = 0;
            }
            cashFlow.CashID = null;
        }

        private async void linkCashRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                panReport.Visible = false;
                Task<DataTable> task1 = new Task<DataTable>(LoadData);
                task1.Start();
                dgvDetails.DataSource = await task1;
                cashFlow.CashID = null;
                InvoiceDateFrom = null;
                InvoiceDateTo = null;
                dateCash.Value=DateTime.Now;
                totalsTimer.Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtCasflowFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = cashFlow.Display(dtCasflowFrom.Value);
            cashFlow.CashID = null;
            InvoiceDateFrom = dtCasflowFrom.Value.ToString();
        }

        private void dgvDetails_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                cashFlow.CashID = dgvDetails.SelectedRows[0].Cells[0].Value.ToString();
                invoice.Method = dgvDetails.SelectedRows[0].Cells["Method"].Value.ToString();
                invoice.Date = Convert.ToDateTime( dgvDetails.SelectedRows[0].Cells["Date"].Value);
                invoice.Paid =Convert.ToDecimal( dgvDetails.SelectedRows[0].Cells["Amount"].Value.ToString());
               selectedindex = dgvDetails.SelectedRows[0].Index;
               cashFlow.Description = dgvDetails.SelectedRows[0].Cells["Description"].Value.ToString();
               linkDebtReceipt.Visible = cashFlow.Description.Contains("#") ? true : false;

            }
        }

       
        private void linkDelCashflow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashFlow.CashID))
                    throw new Exception("Select a record to delete");
                panReport.Visible = false;
                if (MessageBox.Show("Do you want to delete this ?", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cashFlow.Delete(dgvDetails.SelectedRows[0].Cells["Code"].Value.ToString());
                    dgvDetails.Rows.RemoveAt(selectedindex);
                    cashFlow.CashID = null;
                    lblMonthIncome.Text = string.Format("{0:N}", CashFlow.MonthlyIncome());
                    lblMonthExpense.Text = string.Format("{0:N}", CashFlow.MonthlyExpense());
                    lblCurIncome.Text = string.Format("{0:N}", CashFlow.CurrentMonthIncome());
                    lblCurExpense.Text = string.Format("{0:N}", CashFlow.CurrentMonthExpense());
                    lblCashAthand.Text = string.Format("{0:N}", CashFlow.CashInHand());
                    lblCashInBank.Text = string.Format("{0:N}", CashFlow.CashInBank());
                    lblTodayExpense.Text = string.Format("{0:N}", CashFlow.TodayExpense());
                    lblTodayCash.Text = string.Format("{0:N}", CashFlow.TodayCashInHand());
                    lblTodayBank.Text = string.Format("{0:N}", CashFlow.TodayCashInBank());
                    ConfirmationNotifyFrm.Show("Cashflow", "Deleted Successfully");
                    Refresher.Type = "cashflow";
                    Refresher.Refresh = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbHeading_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbHeading.Text))
                {
                    dgvDetails.DataSource = cashFlow.SearchByHeading(cmbHeading.Text.Trim());
                    dgvDetails.Columns["Status"].Visible = false;
                }

                linkDebtReceipt.Visible = false;
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
                    lblInfor.Text = "Please wait... preparing receipt";
                panReport.Visible = false;
                CRInvoiceFrm.loadingReprintDebtReceipt = true;
                invoice.InvoicID = cashFlow.Description.Substring(cashFlow.Description.IndexOf("#") + 1);
                   
                    var reprintDebtReceipt = new CRInvoiceFrm();
                    reprintDebtReceipt.DebtReceipt(invoice, cashFlow);
                

            }
            catch (Exception ex)
            {
                CRInvoiceFrm.loadingReprintDebtReceipt = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            panWait.Visible = CRInvoiceFrm.loadingReprintDebtReceipt ? true : false || GeneralReportFrm.CasflowPrint ? true : false;
             
        }

        void LoadPrint()
        { 
              printCashflow = new GeneralReportFrm();
            printCashflow.PrintCashFlow(dgvDetails);
            printCashflow.Show();

        }
        private  void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    lblInfor.Text = "Please wait... preparing print page";
                    panReport.Visible = false;
                    GeneralReportFrm.CasflowPrint = true;
                    var printCashflow = new GeneralReportFrm();
                    printCashflow.PrintCashFlow(dgvDetails);



                }

            }
            catch (Exception ex)
            {
                GeneralReportFrm.CasflowPrint = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panReport.Visible = false;
            listFields.Items.Clear();
            checkSum.Checked = false;
            Headlist.Clear();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount <= 0)
                    throw new Exception("No record to perform operation");

                cmbCategory.DataSource = expense.GetExpenseSetInfor("");
                    cmbCategory.DisplayMember = "Statement";
                    panReport.Visible = true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCategory.Text))
            {
                if (!listFields.Items.Contains(cmbCategory.Text))
                {
                    listFields.Items.Add(cmbCategory.Text.Trim());
                    Headlist.Add(cmbCategory.Text.Trim());
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = listFields.SelectedIndex;
            listFields.Items.RemoveAt(index);
            Headlist.RemoveAt(index);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (listFields.Items.Count <= 0)
                    throw new Exception("Add category");
                var sumtotal = checkSum.Checked ? true : false;
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    lblInfor.Text = "Please wait... preparing report";
                    panReport.Visible = false;
                    GeneralReportFrm.CasflowPrint = true;
                    var generalReport = new GeneralReportFrm();
                    generalReport.PrintAccountStatement(dgvDetails, Headlist,sumtotal);
                    
                }
                              
                    
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
            lblTodayCash.Text = string.Format("{0:N}", CashFlow.TodayCashInHand(dateCash.Value));
            lblTodayBank.Text = string.Format("{0:N}", CashFlow.TodayCashInBank(dateCash.Value));
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
