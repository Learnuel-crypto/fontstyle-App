using PrintingPress.Models;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Income_expense
{
    public partial class CodeHeading : Form
    {
        private IExpenses cashFlow = Factory.CreateExpenses();
        public CodeHeading()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridview(dgvDetails);
            dgvDetails.DataSource = cashFlow.GetExpenseCodeAndHeading("");

            cmbStatus.DataSource = cashFlow.GetExpenseSetInfor("");
            cmbStatus.DisplayMember = "Statement";
            cmbStatus.ValueMember = "SetID";
            DisplaySelect();
        }
        void DisplaySelect()
        {


            cmbCode.DataSource = cashFlow.GetExpenseCode();
            cmbCode.DisplayMember = "Code";
        }
        void Clear()
        {
            // cmbDesc.ResetText();
            cmbCode.ResetText();
            txtHeading.Clear();
            dgvDetails.DataSource = cashFlow.GetExpenseCodeAndHeading("");
            DisplaySelect();
        }
        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = cashFlow.GetExpenseCodeAndHeading(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cashFlow.Code = cmbCode.Text.Trim();
                cashFlow.SetupDescription = cmbStatus.Text.Trim().ToUpper();
                cashFlow.ExpenseHeading = txtHeading.Text.Trim();
                cashFlow.RegisterExpensHeading();
                Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CodeHeading_Load(object sender, EventArgs e)
        {
            dgvDetails.Columns[0].Visible = false;
        }

        private void dgvDetails_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                cashFlow.SetID = dgvDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbCode.Text = dgvDetails.SelectedRows[0].Cells[1].Value.ToString();
                cmbStatus.Text = dgvDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtHeading.Text = dgvDetails.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashFlow.SetID))
                    throw new Exception("Select a record to perform operation");
                if (MessageBox.Show("This will Delete other related records\nContinue ?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cashFlow.DeleteExpensHeading();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashFlow.SetID))
                    throw new Exception("Select a record to perform operation");
                cashFlow.Code = cmbCode.Text.Trim();
                cashFlow.SetupDescription = cmbStatus.Text.Trim().ToUpper();
                cashFlow.ExpenseHeading = txtHeading.Text.Trim().ToUpper();
                cashFlow.UpdateExpensHeading();
                Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvDetails.RowCount > 0)
                {
                    var printDialog = new PrintDialog();
                    printDialog.ShowDialog();
                    if (MyPrinter.Print)
                    {
                        MyPrinter.PrintRecordsPortrate(dgvDetails, MyPrinter.PrintTitle);
                    }
                }
                else
                {
                    MessageBox.Show("No record to print", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
