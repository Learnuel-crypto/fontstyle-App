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
using PrintingPress.Models.Job;
using PrintingPress.API.General_reports;

namespace PrintingPress.API.Customer_mgt
{
    public partial class Customer_activityFrm : Form
    {
        private ICustomer customer = Factory.CreateCustomer();
        public Customer_activityFrm()
        {
            InitializeComponent();
            DataGridStyle.StyleDatagridMaterial(dgvInvoice);
            cmbCustomer.DataSource = customer.GetCustomersNames("");
            cmbCustomer.DisplayMember = "Name";
            panWait.Dock = DockStyle.Fill;
            dgvInvoice.DataSource = customer.GetCustomerReport("");
            dgvInvoice.Columns[0].Visible = false;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgvInvoice.DataSource = customer.GetCustomerReport(cmbCustomer.Text);
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = customer.GetCustomerReportByDate(dtFrom.Value);
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dgvInvoice.DataSource = customer.GetCustomerReportByDate(dtFrom.Value,dtTo.Value);
        }

        private void linkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvInvoice.RowCount <= 0)
                    throw new Exception("No record to print");
                if (PrintTitleFrm.ShowTitleBox() == DialogResult.Yes)
                {
                    panWait.Visible = true;
                    var report = new GeneralReportFrm();
                    report.PrintCustomerReport(dgvInvoice);
                    panWait.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void linkCashRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvInvoice.DataSource = await  Task.Run(()=>customer.GetCustomerReport(""));
        }
    }
}
