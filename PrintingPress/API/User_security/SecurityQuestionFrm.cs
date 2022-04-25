using System;
using System.Windows.Forms;
using EncryptString;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.User_security
{
    public partial class SecurityQuestionFrm : Form
    {
        StringEncryptor strCrypt = new StringEncryptor();
        private IUsers user = Factory.CreateNewUser();
        private IUsers oldUser = Factory.CreateNewUser();
        private bool Recovery;
        private string search;

        public SecurityQuestionFrm()
        {
            InitializeComponent();
            Recovery = false;
            lblCaption.Text = "Set Recovery Questions";
        }

        public SecurityQuestionFrm(string search)
        { //get recovery questions
            user.Username = search;
            oldUser = user.getUserQuestions(user);
            if (string.IsNullOrEmpty(oldUser.FirstQuestion))
                throw new Exception("No security question found for this user");
            InitializeComponent();
            Recovery = true;
            lblCaption.Text = "Answer Recovery Questions";

            cmbQuestion1.Items.Clear();
            cmbQuestion2.Items.Clear();
            cmbQuestion1.Text = oldUser.FirstQuestion;
            cmbQuestion2.Text = oldUser.SecondQuestion;
            txtAnswer1.Focus();
            this.search = search;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Recovery)
                {
                    user.UserID = Users.LoginUserID;
                    user.FirstQuestion = cmbQuestion1.Text;
                    user.FirstAnswer = strCrypt.Encrypt(txtAnswer1.Text.Trim().ToLower());
                    user.SecondQuestion = cmbQuestion2.Text;
                    user.SecondAnswer = strCrypt.Encrypt(txtAnswer2.Text.Trim().ToLower());
                    user.SetRecoveryQuestion(user);
                    MessageBox.Show("Recovery questions set succesfully", "Completed", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else if (Recovery)
                {
                    user.FirstAnswer = txtAnswer1.Text.Trim().ToLower();
                    user.SecondAnswer = txtAnswer2.Text.Trim().ToLower();
                    //after submitting answer if correct
                    if (strCrypt.Encrypt(user.FirstAnswer) == oldUser.FirstAnswer && strCrypt.Encrypt(user.SecondAnswer) == oldUser.SecondAnswer)
                    {
                        //open reset password form
                        var reset = new ResetPasswordFrm(user.Username);
                        this.Hide();
                        reset.Show();
                    }
                    else
                    {
                        throw new Exception("Either first or second answer is incorrect\ntry again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
