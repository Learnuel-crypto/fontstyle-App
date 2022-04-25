using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Messenger;
using PrintingPress.Models.Job;
using PrintingPress.Models.Helper;
using PrintingPress.API.Reports.Invoice_receipt;

namespace PrintingPress.API.Income_expense
{
    public partial class InvoiceGenFrm : Form
    {
        private IJobCategory jobCategory = Factory.CreateJobCategory();
        private ICustomer customer = Factory.CreateCustomer();
        private ICustomer Invoiccustomer;
        private CRInvoiceFrm receipt;
        List<IJob> jobsCart = new List<IJob>();
        private IJob job; 
        public static IInvoice invoice = Factory.CreateInvoice();
        private int index = 0; 
        public InvoiceGenFrm()
        {
            InitializeComponent(); 
            cmbCategory.BackColor = Color.White;
            cmbHeading.BackColor = Color.White;
            DataGridStyle.StyleDatagridMaterial(dgvDetails);
            cmbHeading.DataSource = jobCategory.GetExpenseCodeAndHeading("");
            cmbHeading.DisplayMember = "Heading";
            CRInvoiceFrm.loadingInvoiceReceipt = false;
            picWait.Visible = false;
           cmbCode.DataSource = customer.GetCustomersNames("");
            cmbCode.DisplayMember = "Name";
            picWait.Dock = DockStyle.Fill;
        }
 
        private   void btnPrepare_Click(object sender, EventArgs e)
        {
            try
            {
                waitTimer.Start();
                if (dgvDetails.RowCount <= 0)
                    throw new Exception("Add jobs to prepare");
                //validate customer
             Invoiccustomer = Factory.CreateCustomer();
           Invoiccustomer.Name = cmbCode.Text.Trim();
        Invoiccustomer.Contact = txtContact.Text;
                //check customer number
                if (Invoiccustomer.CustomerNumberExist())
                    throw new Exception("Customer number already exist");
                var completeInvoice = new InvoiceCompleteFrm(invoice);
                     completeInvoice.ShowDialog();
                     if (completeInvoice.proceed)
                     {
                         //call insert method
                         invoice.Save(jobsCart, Invoiccustomer);
                         Refresher.Type = "invoice";
                         Refresher.Refresh = true;
                    int x = 0;
                    while (dgvDetails.RowCount > 0)
                    {
                        dgvDetails.Rows.RemoveAt(x);
                    }
                    cmbCode.ResetText();
                    txtContact.Clear();
                    txtAmount.Clear();

                    if (SuccessFrm.Show("Invoice", "Transaction successful", "Print receipt ?") ==
                             DialogResult.Yes)
                    {
                         receipt = new CRInvoiceFrm();
                        receipt.PrintReceipt(Invoiccustomer, jobsCart, invoice);
                            
                    }
                    Clear();
                }
                     else
                     {
                         picWait.Visible = false;
                }
                     
            }
            catch (Exception ex)
            {
                invoice.Paid = 0m; 
                invoice.Balance = 0m;
                CRInvoiceFrm.loadingInvoiceReceipt = false;
                if (ex.Message == "This SqlTransaction has completed; it is no longer usable.")
                {
                    MessageBox.Show("An error occurred, transaction failed\n Please try again", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                 
            }
        }

        private void LoadReceipt()
        {
            
        }
     private   void Clear()
        {
            picWait.Visible = false;
            jobsCart.Clear(); 
            index = 0;
            invoice.Paid = 0m;
            invoice.Total = 0m;
            invoice.Balance = 0m;
            invoice.InvoicID = null; 
            txtDesc.Focus();
            cmbCode.DataSource = customer.DisplayCustomers("");
            
        }
        
        private void cmbHeading_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.ResetText();
            lblHeadCode.Text = jobCategory.GetCodeByHeading(cmbHeading.Text.Trim().ToUpper());
            cmbCategory.DataSource = jobCategory.GetJobCategory(lblHeadCode.Text, cmbHeading.Text);
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "CodeID"; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                job = Factory.CreateJob();
                //get the job details
                job.Heading = cmbHeading.Text;
                job.Code = lblHeadCode.Text;
                job.Category = cmbCategory.Text;
                job.Desc = txtDesc.Text.Trim();
                var jobType = job.Heading.Trim().Substring(0, job.Heading.IndexOf(" "));
                if(!job.Desc.ToLower().Contains(jobType.ToLower()))
                    job.Desc += string.Format(" {0}", jobType.ToLower());
                job.Qty = Int32.Parse(txtQty.Text.Trim());
                if(!txtAmount.Text.Contains("."))
                    txtAmount.Text= txtAmount.Text +".00";
                job.Cost = Convert.ToDecimal(txtAmount.Text.Trim());

                //add to jobscart
                jobsCart.Add(job);

                //display in datagrid view 
                dgvDetails.Rows.Add( job.Category, job.Desc, job.Qty,job.Cost ,job.Heading,index);
               
                //prepare invoice
                invoice.Qty += 1;
                invoice.Total += job.Cost; 
                txtQty.Clear();
                txtAmount.Clear();
                txtDesc.Focus();
                txtDesc.Clear();
                index++;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        { 
                
                if (!string.IsNullOrEmpty(cmbCode.Text))
                {
                    txtContact.Clear();
                  if(!string.IsNullOrEmpty( customer.CustomerExist(cmbCode.Text.Trim())))
                    {
                        txtContact.Text = customer.Contact;
                        customer.CusID = cmbCode.SelectedIndex.ToString();
                    }
                     
                } 
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnAdd.PerformClick();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount > 0)
                {
                    var cost = Convert.ToDecimal(dgvDetails.SelectedRows[0].Cells["Amount"].Value.ToString());
                   var selectedIndex = dgvDetails.SelectedRows[0].Index;
                    dgvDetails.Rows.RemoveAt(selectedIndex); 
                    //remove from job list
                    jobsCart.RemoveAt(selectedIndex); 
                    //remove amount from invoice total
                    invoice.Total -= cost;
                    //reduct qty by one
                    invoice.Qty -= 1; 
                    index--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        } 
        private void InvoiceGenFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            picWait.Visible = CRInvoiceFrm.loadingInvoiceReceipt ? true : false;
        }
    }
}
