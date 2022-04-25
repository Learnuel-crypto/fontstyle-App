using PrintingPress.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Income_expense
{
    public partial class AccountFrm : Form
    {
        private IExpenses expense = Factory.CreateExpenses();
        List<string> Headlist = new List<string>();
        public AccountFrm()
        {
            try
            {
                InitializeComponent();
                DataGridStyle.StyleDatagridview(dgvExpenseHeadingList);

                cmbHeadingList.DataSource = expense.GetExpenseCodeAndHeading("");
                cmbHeadingList.DisplayMember = "Heading";

                cmbCodeList.DataSource = expense.GetExpenseCode();
                cmbCodeList.DisplayMember = "Code";
                dgvExpenseHeadingList.DataSource = expense.ViewAllExpensure("");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AccountFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvExpenseHeadingList.Columns[4].Visible = false;
                dgvExpenseHeadingList.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var setupExpense = new BasicSetupFrm();
                setupExpense.ShowDialog();
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
                var headingSetup = new CodeHeading();
                headingSetup.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //cmbHeadingList.DataSource = expense.GetExpenseCodeAndHeading("");
            //cmbHeadingList.DisplayMember = "Heading";

            //cmbCodeList.DataSource = expense.GetExpenseCode();
            //cmbCodeList.DisplayMember = "Code";

            //dgvExpenseHeadingList.DataSource = expense.ViewAllExpensure("");
        }

        private void linkReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvExpenseHeadingList.RowCount > 0)
                {
                    cmbCategory.DataSource = expense.GetExpenseSetInfor("");
                    cmbCategory.DisplayMember = "Statement";
                    panReport.Visible = true;
                }
                else
                {
                    throw new Exception("No record to perform operation");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvExpenseHeadingList.DataSource = expense.ViewAllExpensure(txtSearch.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbHeadingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!checkCandH.Checked)
                {
                    dgvExpenseHeadingList.DataSource = expense.ViewAllExpensure(cmbHeadingList.Text);
                }
                else
                {
                    dgvExpenseHeadingList.DataSource = expense.SearchExpenditureCodeandHeand(cmbCodeList.Text, cmbHeadingList.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbCodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!checkCandH.Checked)
                {
                    dgvExpenseHeadingList.DataSource = expense.ViewAllExpensure(cmbCodeList.Text);
                }
                else
                {
                    dgvExpenseHeadingList.DataSource = expense.SearchExpenditureCodeandHeand(cmbCodeList.Text, cmbHeadingList.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvExpenseHeadingList.DataSource = expense.SearchExpenditureByDate(dtpFrom.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvExpenseHeadingList.DataSource = expense.SearchExpenditureByDate(dtpFrom.Value, dtpTo.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panReport.Visible = false;
            listFields.Items.Clear();
            Headlist.Clear();
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

        private void lblPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvExpenseHeadingList.RowCount > 0)
                {
                    var printDialog = new PrintDialog();
                    printDialog.ShowDialog();
                    if (MyPrinter.Print)
                    {
                        MyPrinter.PrintRecordsPortrate(dgvExpenseHeadingList, MyPrinter.PrintTitle);
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
                if (dgvExpenseHeadingList.RowCount > 0)
                {
                    if (listFields.Items.Count > 0)
                    {
                        var printDialog = new PrintDialog();
                        printDialog.ShowDialog();
                        if (MyPrinter.Print)
                        {
                            //MyPrinter.PrintRecordsPortrate(dgvExpenseHeadingList, MyPrinter.GetPrintTile());
                            //generate report here
                            var report = new CashFlowFrm();
                          //  report.PrepareExpenditureData(dgvExpenseHeadingList, Headlist);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Add Heading to prepar report", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvExpenseHeadingList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvExpenseHeadingList.RowCount > 0)
                {

                    expense.Code = dgvExpenseHeadingList.SelectedRows[0].Cells["Category"].Value.ToString();
                    expense.ExpenseHeading = dgvExpenseHeadingList.SelectedRows[0].Cells["Description"].Value.ToString();
                    if (checkDate.Checked)
                    {
                        //var viewExpense = new ViewExpense(expense.Code, expense.ExpenseHeading, dtpFrom.Value);
                        //viewExpense.Show();
                    }
                    else
                    {
                        //var viewExpense = new ViewExpense(expense.Code, expense.ExpenseHeading);
                        //viewExpense.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void expenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var setupExpense = new CashFlowFrm();
                setupExpense.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var setupExpense = new CashFlowFrm(true);
                setupExpense.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void jobFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var jobSetup =new JobSetupFrm();
            jobSetup.Show();
        }

        private void issueInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genInvoice=new InvoiceGenFrm();
            genInvoice.Show();
        }
    }
    }
