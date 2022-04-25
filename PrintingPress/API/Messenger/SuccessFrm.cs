using System;
using System.Windows.Forms;

namespace PrintingPress.API.Messenger
{
    public partial class SuccessFrm : Form
    {
        static SuccessFrm Paymentcompleted; static DialogResult result = DialogResult.OK;
        public SuccessFrm()
        {
            InitializeComponent();
            btnYes.Focus();
        }
        public static DialogResult Show(string title, string message, string question)
        {
            Paymentcompleted = new SuccessFrm();
            Paymentcompleted.lblTitle.Text = title;
            Paymentcompleted.lblMessage.Text = message;
            Paymentcompleted.lblQuestion.Text = question;
            Paymentcompleted.btnYes.Focus();
            Paymentcompleted.ShowDialog();
            return result;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }
    }
}
