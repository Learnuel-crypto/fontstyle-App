using System;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace PrintingPress.API.Configuration
{
    public partial class PrintTitleFrm : Form
    {
        static PrintTitleFrm PrintTitle; static DialogResult result = DialogResult.OK;
        public PrintTitleFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show print title box
        /// </summary>
        /// <returns></returns>
        public static DialogResult ShowTitleBox( )
        {
            PrintTitle = new PrintTitleFrm();  
            PrintTitle.btnProceed.Focus();
            PrintTitle.ShowDialog();
            return result;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Enter page heading", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyPrinter.PrintTitle = txtTitle.Text.Trim();
                MyPrinter.Print = true;
                result = DialogResult.Yes;
                this.Close();
            }
           
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            MyPrinter.Print = false;
            this.Close();
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnProceed.PerformClick();
        }
    }
}
