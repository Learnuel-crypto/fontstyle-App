using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress.API.Notifications
{
    public partial class ConfirmInforFrm : Form
    {
        static ConfirmInforFrm OperationConfirmed; static DialogResult result = DialogResult.OK;
        public ConfirmInforFrm()
        {
            InitializeComponent();
            btnYes.Focus();
        }
        public static DialogResult Show(string title, string message)
        {
            OperationConfirmed = new ConfirmInforFrm();
            OperationConfirmed.lblTitle.Text = title;
            OperationConfirmed.lblMessage.Text = message;
            OperationConfirmed.btnYes.Focus();
            OperationConfirmed.ShowDialog();
            return result;
        }
     
        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; this.Close();
        }
    }
}
