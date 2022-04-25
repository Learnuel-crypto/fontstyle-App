using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.API.Configuration;
using PrintingPress.API.General_reports;
using PrintingPress.Models.Job;

namespace PrintingPress.API.Income_expense
{
    public partial class InvoiceItemsFrm : Form
    {
        private IJob jobs = Factory.CreateJob();
        public InvoiceItemsFrm()
        {
            InitializeComponent();
            panWait.Dock = DockStyle.Fill;
            DataGridStyle.StyleDatagridMaterial(dgvDetails);
            loadData("");
           
        }

       async void loadData(string text)
        {
            dgvDetails.DataSource = await  Task.Run(()=>jobs.Search(text));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData(txtSearch.Text);
        }

        private void linkCashRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadData("");
        }

        private async void dtCasflowFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDetails.DataSource = await Task.Run(() => jobs.Search(dtCasflowFrom.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dtCasflowTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDetails.DataSource = await Task.Run(() => jobs.Search(dtCasflowFrom.Value,dtCasflowTo.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private   void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                if (dgvDetails.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    waitTimer.Start();
                   panWait.Visible = true;
                    var receiptform = new GeneralReportFrm(); 
                  receiptform.PrintItemsReport(dgvDetails);
                 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            if (!GeneralReportFrm.ItemsProcessing)
            {
                panWait.Visible = false;
                waitTimer.Stop();
            }
             
        }
    }
}
