using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
using EncryptString;

namespace PrintingPress.API.Configuration
{
    public partial class MessengerServerConfig : Form
    {
        public MessengerServerConfig()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtServer.Text))
                    throw new Exception("enter server name");
                if (string.IsNullOrEmpty(txtPort.Text))
                    throw new Exception("enter port number");
                if (string.IsNullOrEmpty(txtUsername.Text))
                    throw new Exception("enter username on server");
                if (string.IsNullOrEmpty(txtServer.Text))
                    throw new Exception("enter server user password");
                var link = string.Format("{0}:{1}/{2}{3}",txtServer.Text.ToLower().Trim(),txtPort.Text.Trim(),txtUsername.Text.Trim(),txtPassword.Text.Trim());
                if (!string.IsNullOrEmpty(link))
                {
                    using (IsolatedStorageFile isolatedStorageFile =
                        IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null,
                            null))
                    {
                        using (IsolatedStorageFileStream isolatedStorageFileStream =
                            new IsolatedStorageFileStream("chat_server.txt", System.IO.FileMode.OpenOrCreate,
                                isolatedStorageFile))
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(isolatedStorageFileStream))
                            {
                                StringEncryptor stringEncryptor=new StringEncryptor();
                               sw.WriteLine(link);
                                File.AppendAllText(string.Format("{0}/{1}",Application.StartupPath,"server_log.txt"),stringEncryptor.Encrypt(link));
                                MessageBox.Show("Server configured", "Completed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            { 
                    throw new Exception(ex.Message);
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
