using PrintingPress.Models;
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Income_expense
{
    public partial class BasicSetupFrm : Form
    {
        private IExpenses cashflow = Factory.CreateExpenses();

        public BasicSetupFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvDetails);
        }

        private void BasicSetupFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDetails.DataSource = cashflow.GetExpenseSetInfor("");
                dgvDetails.Columns[2].Visible = false;
                dgvDetails.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cashflow.SetupDescription = txtCategory.Text.Trim();
                cashflow.Status = cmbStatus.Text.Trim();
                cashflow.RegisterSetup();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Clear()
        {
            txtCategory.Clear();
            cmbStatus.ResetText();
            cashflow.SetID = null;
            dgvDetails.DataSource = cashflow.GetExpenseSetInfor("");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashflow.SetID))
                    throw new Exception("Select a record to perform operation");
                cashflow.SetupDescription = txtCategory.Text.Trim();
                cashflow.Status = cmbStatus.Text.Trim();
                cashflow.UpdateRegisterSetup();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cashflow.SetID))
                    throw new Exception("Select a record to perform operation");
                if (MessageBox.Show("This will Delete other related records\nContinue ?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    cashflow.DeleteRegisterSetup();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDetails_Click(object sender, EventArgs e)
        {
            if(dgvDetails.RowCount > 0)
            {
                cashflow.SetID = dgvDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtCategory.Text = dgvDetails.SelectedRows[0].Cells[1].Value.ToString();
                var x = dgvDetails.SelectedRows[0].Cells[2].Value.ToString();
                cmbStatus.Text = x == "+" ? "Income" : "Expense";

            }
        }
    }
}

