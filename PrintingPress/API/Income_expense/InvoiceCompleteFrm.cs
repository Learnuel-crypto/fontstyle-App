using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintingPress.Models.Job;
using Exception = System.Exception;

namespace PrintingPress.API.Income_expense
{
    public partial class InvoiceCompleteFrm : Form
    {
        private Decimal paidAmount;
        private Decimal bankAmount;
        private Decimal bal; 
        private Decimal Total;
        public bool proceed;
        private string otherPay;
        public InvoiceCompleteFrm(IInvoice invoice)
        {
            InitializeComponent();
            Total=bal= invoice.Total;
            lblToal.Text = invoice.Total.ToString();
            lblBalance.Text = invoice.Total.ToString();
            txtInvoiceID.Focus(); 
            
        }
         
        private void btnCancell_Click(object sender, EventArgs e)
        {
            proceed = false;
            this.Close();
          
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            totalTimer.Start(); 
        }

        private void totalTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                 
                if (!string.IsNullOrEmpty(txtAmount.Text))
                {
                    if (!string.IsNullOrEmpty(txtInBank.Text))
                        bal = Convert.ToDecimal(lblBalance.Text);
                    paidAmount = Convert.ToDecimal(txtAmount.Text.Trim());
                    if (paidAmount > Total)
                    {
                        txtAmount.Focus();
                        txtAmount.Clear();
                        paidAmount = 0m;
                        throw new Exception("Cash amount exceeds balance");
                    }

                    if (bankAmount + paidAmount > Total)
                    {
                        txtAmount.Focus();
                        txtAmount.Clear();
                        paidAmount = 0m;
                        throw new Exception("Payment exceeds total amount");
                    }
                     
                }
                else
                {
                    paidAmount = 0m; 
                }

                if (!string.IsNullOrEmpty(txtInBank.Text))
                {
                    if (!string.IsNullOrEmpty(txtAmount.Text))
                        bal = Convert.ToDecimal(lblBalance.Text);
                    bankAmount = Convert.ToDecimal(txtInBank.Text.Trim());
                    if (bankAmount > Total)
                    {
                        txtInBank.Focus();
                        txtInBank.Clear();
                        bankAmount = 0m;
                        throw new Exception(string.Format("{0} amount exceeds balance",
                            InvoiceGenFrm.invoice.OtherPayment));
                    }

                    if (bankAmount + paidAmount > Total)
                    {
                        txtInBank.Focus();
                        txtInBank.Clear();
                        bankAmount = 0m;
                        throw new Exception("Payment exceeds total amount");
                    }
                     
                }
                else
                {
                    bankAmount = 0m; 
                }
                

                setBalance(paidAmount, bankAmount);
            }
            catch (Exception ex)
            {
                
                totalTimer.Stop();
                setBalance(paidAmount, bankAmount);
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void setBalance(Decimal paid, Decimal transfer)
        {
            lblBalance.Text = (Total - (paid + transfer)).ToString();
            bal = Total - (paid + transfer);
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            { 
               
               totalTimer.Stop();
                if (string.IsNullOrEmpty(txtInvoiceID.Text))
                {
                    txtInvoiceID.Focus();
                    throw new Exception("Enter Invoice number");
                }

                InvoiceGenFrm.invoice.InvoicID = txtInvoiceID.Text.Trim(' ');
                if (!checkAuto.Checked && Invoice.InvoiceIDExist(txtInvoiceID.Text.Trim()))
                {
                    txtInvoiceID.Focus();
                    throw new Exception("Invoice number already exist");
                }else
                
                { 
                    if(Invoice.InvoiceIDExist(txtInvoiceID.Text.Trim()))
                   txtInvoiceID.Text=  InvoiceGenFrm.invoice.InvoicID = Invoice.GetLastInvoiceID();
                }
                   // InvoiceGenFrm.invoice.InvoicID = txtInvoiceID.Text;
                    if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    txtAmount.Focus();
                    throw new Exception("Enter paid amount");
                }

                if (string.IsNullOrEmpty(cmbMehtod.Text))
                    throw new Exception("Select Transaction method");
                InvoiceGenFrm.invoice.Method = cmbMehtod.Text;
                if (otherPay.Contains("&"))
                {
                    InvoiceGenFrm.invoice.OtherPayment = otherPay.Substring(otherPay.IndexOf("&")+1).Trim();
                }
                else
                {
                    InvoiceGenFrm.invoice.OtherPayment = null;
                }

                if (!string.IsNullOrEmpty(InvoiceGenFrm.invoice.OtherPayment))
                {
                    if (string.IsNullOrEmpty(txtInBank.Text))
                    {
                        txtInBank.Focus();
                        throw new Exception(string.Format("Enter {0} amount", InvoiceGenFrm.invoice.OtherPayment));
                    }

                    InvoiceGenFrm.invoice.OtherPaymentAmount = Convert.ToDecimal(txtInBank.Text);
                    
                }
                else
                {
                    InvoiceGenFrm.invoice.OtherPaymentAmount = 0.00m;
                }

                //this code is to make payment as bank payment if it is not cash
                if (otherPay == "Transfer" || otherPay == "Bank" || otherPay == "POS")
                {
                    InvoiceGenFrm.invoice.Paid = 0.00m; Convert.ToDecimal(txtAmount.Text);
                    InvoiceGenFrm.invoice.OtherPaymentAmount = Convert.ToDecimal(txtAmount.Text);
                    InvoiceGenFrm.invoice.OtherPayment = otherPay;
                }
                else
                {
                    InvoiceGenFrm.invoice.Paid = Convert.ToDecimal(txtAmount.Text.Trim());
                }
               
                InvoiceGenFrm.invoice.Date = dtInvoice.Value; 
                InvoiceGenFrm.invoice.Balance = Convert.ToDecimal(lblBalance.Text.Trim()); 
               
                proceed = true;
                paidAmount = 0m;
                txtAmount.Clear();
                this.Close();

            }
            catch (Exception ex)
            {
               
                paidAmount = 0m;
                bankAmount = 0m;
                InvoiceGenFrm.invoice.OtherPaymentAmount = 0.00m; 
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalTimer.Start();
            }
        }

        private async void InvoiceCompleteFrm_Load(object sender, EventArgs e)
        {
            checkAuto.Checked = true;
            txtInvoiceID.Text = await Task.Run(()=> Invoice.GetLastInvoiceID());
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void cmbMehtod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var method =otherPay= cmbMehtod.Text;
            InvoiceGenFrm.invoice.OtherPaymentAmount = 0m;
            if (method == "Cash" || method == "Transfer" || method == "Bank" || method == "POS")
            {
                this.Width = 240;
                this.Height = 273;
                BalancceLabel.Location=new Point(14,194);
                lblBalance.Location=new Point(86,194);
                BankAmountlabel.Visible = false;
                txtInBank.Visible = false;
                bankAmount = 0.00m;
                lblCash.Text = method == "Transfer" ? "Tran Amt.:" : method + " Amt.:";
            }
            else if(method.StartsWith("Cash &"))
            {
                this.Width = 240;
                this.Height = 308;
                BankAmountlabel.Location=new Point(2,198);
                txtInBank.Location=new Point(86,195);
                BalancceLabel.Location = new Point(14, 231);
                lblBalance.Location = new Point(87, 231);
                BankAmountlabel.Visible = true;
                txtInBank.Visible = true;
                lblCash.Text = "Cash Amt.:";
               var otherLable = method.Substring(method.LastIndexOf("&") + 1).Trim();
                BankAmountlabel.Text = string.Format("{0} Amt.", otherLable=="Transfer"?"Tran.":otherLable );
                InvoiceGenFrm.invoice.OtherPayment = otherLable;
            }
           
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnProceed.PerformClick();
        }

        private void checkAuto_Click(object sender, EventArgs e)
        {
            try
            {
                totalTimer.Start();
                if (checkAuto.Checked)
                {
                    txtInvoiceID.Text = Invoice.GetLastInvoiceID();
                }
                else
                {
                    txtInvoiceID.Clear();
                    txtInvoiceID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void txtInvoiceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkAuto.Checked)
                checkAuto.Checked = false;
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtInBank_TextChanged(object sender, EventArgs e)
        {
            totalTimer.Start(); 

        }
  
        private void txtInBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtInBank_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnProceed.PerformClick();
        }

        private void InvoiceCompleteFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        
    }
}
