using System;
using System.Windows.Forms;

namespace PrintingPress.API.Messenger
{
    public partial class OperationNotifyFrm : Form
    {
        public OperationNotifyFrm(string operation, string notification)
        {
            InitializeComponent();
            lblTitle.Text = operation;
            lblMessage.Text = notification;
            CloseTimer.Start();
            this.ShowDialog();
        }
 

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
