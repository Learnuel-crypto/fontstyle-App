using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.User_security
{
    public partial class ForgotPasswordFrm : Form
    {
        private IUsers user = Factory.CreateNewUser();
        public ForgotPasswordFrm()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    throw new Exception("Enter last username or password");
                var search = user.RecoverAccount(txtSearch.Text.Trim());
                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Account was NOT Found", "Search completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    var resetPass = new SecurityQuestionFrm(search);
                    resetPass.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
            }
        }
    }
}
