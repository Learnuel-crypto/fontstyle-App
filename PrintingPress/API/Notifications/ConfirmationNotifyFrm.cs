using System;
using System.Windows.Forms;

namespace PrintingPress.API.Notifications
{
    /// <summary>
    /// Just confirm the operation has been completed successfully
    /// </summary>
    public partial class ConfirmationNotifyFrm : Form
    {
        static ConfirmationNotifyFrm Paymentcompleted; static DialogResult result = DialogResult.OK;
        public ConfirmationNotifyFrm()
        {
            InitializeComponent();
            btnYes.Focus();
            CloseTimer.Start();
        }
        public static DialogResult Show(string title, string message)
        {
            Paymentcompleted = new ConfirmationNotifyFrm();
            Paymentcompleted.lblTitle.Text = title;
            Paymentcompleted.lblMessage.Text = message; 
            Paymentcompleted.btnYes.Focus();
            Paymentcompleted.ShowDialog(); 
            return result;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
