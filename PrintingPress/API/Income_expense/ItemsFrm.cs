using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress.Models.Job;

namespace PrintingPress.API.Income_expense
{
    public partial class ItemsFrm : Form
    {
        private IInvoice Invoice = Factory.CreateInvoice();
        public ItemsFrm(string invoice)
        {
            InitializeComponent();
            txtName.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtName.BackColor=Color.White;
            txtContact.BackColor=Color.White;

            DataGridStyle.StyleDatagridMaterial(dgvDetails); 
            dgvDetails.DataSource = Invoice.DisplayInvoiceItem(invoice);
            var DataRow = Invoice.DisplayInvoiceCustomer(invoice).Rows[0];
            txtName.Text = DataRow["Name"].ToString();
            txtContact.Text = DataRow["Contact"].ToString();
            lblInvoiceId.Text = invoice;

            lblTotal.Text = Total().ToString();
        }

        Decimal Total()
        {
            var total = 0.00m;
            if (dgvDetails.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvDetails.Rows )
                {
                    total += Convert.ToDecimal( row.Cells["Cost"].Value.ToString());
                }
            }

            return total;
        }

        private void ItemsFrm_Load(object sender, EventArgs e)
        {
             
        }
    }
}
