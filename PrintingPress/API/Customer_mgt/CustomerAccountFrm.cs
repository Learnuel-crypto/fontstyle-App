using System.Windows.Forms;
using PrintingPress.Models.Job;
using PrintingPress.Models;
using System;
using System.Threading.Tasks;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Messenger;
using PrintingPress.API.Notifications;
using PrintingPress.API.Reports.Invoice_receipt;
using PrintingPress.Models.Helper;

namespace PrintingPress.API.Customer_mgt
{
    public partial class CustomerAccountFrm : Form
    {
        private ICustomer customer = Factory.CreateCustomer();
        private IInvoice DebtInvoice = Factory.CreateInvoice();
        private IExpenses expense = Factory.CreateExpenses();
        private IArithmetic calculation = Factory.CreateArithmetic();
        private Decimal paidAmount = 0m;
        internal static bool proceed;
        private Decimal balance = 0m; 
        public CustomerAccountFrm(ICustomer customer,Decimal total)
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvInvoice);
            lblInvoiceID.Text = "";
            lblDate.Text = "nil";

            lblCustomerName.Text = string.Format("{0} Account", customer.Name);
            this.customer = customer;
            cmbHeading.DataSource = expense.GetIncomeHeading();
            cmbHeading.DisplayMember = "Heading";
            dgvInvoice.DataSource = DebtInvoice.DisplayCustomerDebt(customer.CusID);
            dgvInvoice.Columns[0].Visible = false;
            dgvInvoice.Columns["Qty"].Visible = false; 
            lblTotalDebt.Text = total.ToString();
            
        }
       

        public CustomerAccountFrm(ICustomer customer , IInvoice invoice, Decimal total)
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvInvoice);
            lblInvoiceID.Text = invoice.InvoicID;
            lblTotalDebt.Text = "0.00";
            lblCustomerName.Text = string.Format("{0} Account", customer.Name);
            this.customer = customer;
            balance = invoice.Balance;
            lblTotal.Text = invoice.Total.ToString();
            lblBalance.Text = invoice.Balance.ToString();
            lblPaid.Text = (invoice.Paid+invoice.OtherPaymentAmount).ToString();
            var dDate= invoice.Date.ToString();
            lblDate.Text = invoice.Date.ToString("dd/MM/yyyy");
            DebtInvoice.Date = Convert.ToDateTime(invoice.Date);

            cmbHeading.DataSource = expense.GetIncomeHeading();
            cmbHeading.DisplayMember = "Heading";
            DebtInvoice.InvoicID = invoice.InvoicID;
            dgvInvoice.DataSource = DebtInvoice.DisplayCustomerDebt(customer.CusID);
            dgvInvoice.Columns[0].Visible = false;
            dgvInvoice.Columns["Qty"].Visible = false;
            lblTotalDebt.Text = total.ToString();
            DebtInvoice = invoice; 
        }

        private void cmbHeading_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lblCode.Text = expense.GetCodeByHeading(cmbHeading.Text.Trim());
        }

        private void CustomerAccountFrm_Load(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblTotalDebt.Text) <= 0m)
                btnPay.Enabled = false;
        }

        private void dgvInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.RowCount > 0)
            {
             lblInvoiceID.Text=   DebtInvoice.InvoicID = dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                lblTotal.Text = dgvInvoice.SelectedRows[0].Cells["Total"].Value.ToString();
                lblPaid.Text=(Convert.ToDecimal(dgvInvoice.SelectedRows[0].Cells["Cash"].Value) + Convert.ToDecimal(dgvInvoice.SelectedRows[0].Cells["To_bank"].Value)).ToString();
                lblBalance.Text= dgvInvoice.SelectedRows[0].Cells["Bal"].Value.ToString();
                  lblDate.Text = dgvInvoice.SelectedRows[0].Cells["Date"].Value.ToString();
                  DebtInvoice.Date = Convert.ToDateTime(dgvInvoice.SelectedRows[0].Cells["Date"].Value.ToString());
                DebtInvoice.Total = Convert.ToDecimal(lblTotal.Text);
                  DebtInvoice.Paid = Convert.ToDecimal(lblPaid.Text);
                  DebtInvoice.Balance = Convert.ToDecimal(lblBalance.Text);
                  balance = DebtInvoice.Balance;

            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnPay.PerformClick();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        void clear()
        {
            totalTimer.Stop();
            DebtInvoice.InvoicID = null;
            lblTotal.Text = "0.00";
            lblPaid.Text = "0.00";
            lblBalance.Text = "0.00";
            lblDate.Text = "nill";
            lblInvoiceID.Text = "";
            txtAmount.Clear();
            paidAmount = 0m;
            expense.SetID = null;
            expense.NetDebt = 0;
            dgvInvoice.DataSource = DebtInvoice.DisplayCustomerDebt(customer.CusID);
        }
        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                proceed = false;
                waitTimer.Start();
                if (string.IsNullOrEmpty(DebtInvoice.InvoicID))
                    throw new Exception("Select invoice to pay debt");
                if (string.IsNullOrEmpty(lblCode.Text))
                    throw new Exception("Select Heading");
                expense.Code = lblCode.Text;
                expense.ExpenseHeading = cmbHeading.Text;
                if (string.IsNullOrEmpty(cmbTransc.Text))
                    throw new Exception("Select transaction type");
                if (string.IsNullOrEmpty(txtAmount.Text))
                    throw new Exception("Enter Amount");
                expense.Description = string.Format("Received debt payment for invoice #{0}", DebtInvoice.InvoicID);
                expense.SetID = DebtInvoice.InvoicID;
                expense.Amount = txtAmount.Text;
                expense.TransactionType = cmbTransc.Text.Trim();
                expense.Date = dtPayDate.Value;
               var totaldebt= expense.NetDebt =Convert.ToDecimal(lblTotalDebt.Text);
                DebtInvoice.Method = cmbTransc.Text.Trim();
             
                DebtInvoice.Paid =Convert.ToDecimal(txtAmount.Text);
                if (ConfirmInforFrm.Show("Confirm Amount", expense.Amount.ToString()) == DialogResult.Yes)
                {
                    totalTimer.Stop();
                     expense.PayDebt();  
                    Refresher.Refresh = true;
                    Refresher.Type = "both";
                    proceed = true;
                    clear(); 
                    var total = await Task.Run(() => calculation.TotalGridColumn(dgvInvoice, "Bal"));
                    lblTotalDebt.Text = total.ToString();
                    if (SuccessFrm.Show("Balance payment", "Completed Successfully", "Print Receipt ?") ==
                        DialogResult.Yes)
                    {
                        CRInvoiceFrm.loadingDebtReceipt = true;
                       var  receipt =new CRInvoiceFrm();
                        receipt.DebtReceipt(DebtInvoice,customer, totaldebt.ToString(), dtPayDate.Value);
                    }
                   
                }
                  
            }
            catch (Exception ex)
            {
                CRInvoiceFrm.loadingDebtReceipt = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void txtAmount_TextChanged(object sender, EventArgs e)
        { 
            if(!string.IsNullOrEmpty(txtAmount.Text))
                 totalTimer.Start();
        }

        private void totalTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAmount.Text))
                {
                    Validation.Amount(txtAmount.Text.Trim());
                    paidAmount = Convert.ToDecimal(txtAmount.Text.Trim());
                    if (paidAmount > DebtInvoice.Balance)
                        throw new Exception("Amount to pay exceeds balance");
                    lblBalance.Text = (balance - paidAmount).ToString();
                    balance = DebtInvoice.Balance;
                }
                else
                {
                    lblBalance.Text = DebtInvoice.Balance.ToString();
                }
            }
            catch (Exception ex)
            {
                totalTimer.Stop();
                txtAmount.Clear();
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
            }
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            picWait.Visible = CRInvoiceFrm.loadingDebtReceipt ? true : false;
        }
    }
}
