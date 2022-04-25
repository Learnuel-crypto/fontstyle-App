using PrintingPress.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using PrintingPress.API.Notifications;
using PrintingPress.Models.Helper;

namespace PrintingPress.API.Income_expense
{
    public partial class CashFlowFrm : Form
    {
        private IExpenses expense = Factory.CreateExpenses(); 
        private bool FlowType;
        public CashFlowFrm(bool flowType=false)
        {
            InitializeComponent();
            FlowType = flowType;
            

            cmbCode.DataSource = expense.GetExpenseCode();
            cmbCode.DisplayMember = "Code";

            cmbCode.BackColor = Color.White;
            cmbHeading.BackColor = Color.White;
            lblHeading.Text= FlowType== true ?  "Income" : "Expense";
            linkSetExpense.Text = FlowType == true ? "Set income" : "Set expense";
            if (flowType)
            {
                cmbHeading.DataSource = expense.GetIncomeHeading();
                cmbHeading.DisplayMember = "Heading";
            }
            else
            {
                cmbHeading.DataSource = expense.GetExpenseHeading();
                cmbHeading.DisplayMember = "Heading";
            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                expense.Code = cmbCode.Text;
                expense.ExpenseHeading = cmbHeading.Text;
                expense.Description = txtexpensename.Text;
                expense.Amount = txtcost.Text;
                expense.TransactionType = cmbTransc.Text.Trim();
                expense.Date = dateTimeDate.Value;
                 expense.Insert();
                 ConfirmationNotifyFrm.Show("Cashflow", "Operation Successful"); 
                txtcost.Clear();
                txtexpensename.Clear();
                Refresher.Type = "cashflow";
                Refresher.Refresh = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n Operation Failed", "Cashflow", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtcost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnSubmit.PerformClick();
        }

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void cmbHeading_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCode.Text = expense.GetCodeByHeading(cmbHeading.Text.Trim());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
