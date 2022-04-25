using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model;
using PrintingPress.API.Configuration;
using PrintingPress.API.General_reports;

namespace PrintingPress.API.User_security
{
    public partial class UserActivityFrm : Form
    {
        private IUserActivity userActivity = Factory.UserActivity();
        public   UserActivityFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvActivity);
           
        }

       private async Task loadDataAsync()
        {
            dgvActivity.DataSource=await Task.Run(() =>  userActivity.DisplayUserLog(""));
            
        }

        private async void UserActivityFrm_Load(object sender, EventArgs e)
        {

            
            dgvActivity.DataSource = await Task.Run(() => userActivity.DisplayUserLog(""));
            
        }

        private   void linkReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvActivity.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                { 
                      var printRecord = new GeneralReportFrm();
                      printRecord.PrintReceipt(dgvActivity);
                  
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvActivity.DataSource = await Task.Run(() => userActivity.SearchByDate(dtFrom.Value));
        }

        private async void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dgvActivity.DataSource = await Task.Run(() => userActivity.SearchBetweenDates(dtFrom.Value,dtTo.Value));
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
                dgvActivity.DataSource = await Task.Run(() => userActivity.DisplayUserLog(""));
            if(txtSearch.TextLength>2)
                dgvActivity.DataSource = await Task.Run(() => userActivity.DisplayUserLog(txtSearch.Text.Trim()));
        }
    }
}
