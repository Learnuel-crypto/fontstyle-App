using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.Models.Job;

namespace PrintingPress.API.Income_expense
{
    public partial class JobSetupFrm : Form
    {
        private IJobCategory jobCategory = Factory.CreateJobCategory();
        public JobSetupFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvDetails);
            cmbHeading.DataSource = jobCategory.GetExpenseCodeAndHeading("");
            cmbHeading.DisplayMember = "Heading";

            cmbCode.DataSource = jobCategory.GetExpenseCode();
            cmbCode.DisplayMember = "Code";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void JobSetupFrm_Load(object sender, EventArgs e)
        {
            try { 
            dgvDetails.DataSource = jobCategory.SearchJobCategory("");
            dgvDetails.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        

        private void cmbHeading_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCode.Text = jobCategory.GetCodeByHeading(cmbHeading.Text.Trim().ToUpper());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDetails.DataSource = jobCategory.SearchJobCategory(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbCode.Text))
                    throw new Exception("Select Code");
                if (string.IsNullOrEmpty(cmbHeading.Text))
                    throw new Exception("Select category heading");
                if (string.IsNullOrEmpty(txtCategory.Text))
                    throw new Exception("Please enter category");
                jobCategory.Code = cmbCode.Text;
                jobCategory.ExpenseHeading = cmbHeading.Text;
                jobCategory.Description = txtCategory.Text;
                jobCategory.Add();
                dgvDetails.DataSource = jobCategory.SearchJobCategory("");
                txtCategory.Clear();
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
                if (string.IsNullOrEmpty(jobCategory.JobId))
                    throw new Exception("Select an item to perform operation");
                if (string.IsNullOrEmpty(cmbCode.Text))
                    throw new Exception("Select Code");
                if (string.IsNullOrEmpty(cmbHeading.Text))
                    throw new Exception("Select category heading");
                if (string.IsNullOrEmpty(txtCategory.Text))
                    throw new Exception("Please enter category");
                jobCategory.Code = cmbCode.Text;
                jobCategory.ExpenseHeading = cmbHeading.Text;
                jobCategory.Description = txtCategory.Text;
                jobCategory.UpdateJob();
                jobCategory.JobId = null;
                dgvDetails.DataSource = jobCategory.SearchJobCategory("");
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
                jobCategory.JobId = dgvDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtCategory.Text = dgvDetails.SelectedRows[0].Cells["Category"].Value.ToString();
                cmbHeading.Text = dgvDetails.SelectedRows[0].Cells["Heading"].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(jobCategory.JobId))
                    throw new Exception("Select an item to perform operation");
                 
                jobCategory.DeleteJob();
                jobCategory.JobId = null;
                dgvDetails.DataSource = jobCategory.SearchJobCategory("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue ==(char)Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
