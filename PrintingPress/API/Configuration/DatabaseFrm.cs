using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using PrintingPress.API.Notifications;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress.API.Configuration
{
    public partial class DatabaseFrm : Form
    {
        private bool Import;
        private bool Loggedin;
        
        /// <summary>
        /// Import or restore database after app installation
        /// </summary>
        /// <param name="import"></param>
        /// <param name="loggedin"></param>
        public DatabaseFrm(bool import, bool loggedin = true)
        {
            if (loggedin)
            {
                if (Users.RoleID != 7 && Users.RoleID != 6 && Users.RoleID != 5)
                    throw new Exception("Access denied: You don't have required privilege");
            } 
            InitializeComponent();
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
            linkRestore.Enabled = false;
            if (import)
            {
                linkBackup.Enabled = false;
                linkBackup.Enabled = false;
                linkRestore.Enabled = true;
            }
            panWait.Dock = DockStyle.Fill;
            Import = import;
            Loggedin = loggedin;
        }
        private void linkBackup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                lblBackupPath.Text = dig.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        
        private async void btnBackup_Click(object sender, EventArgs e)
        {
             
            try
            {
                if (ConfirmInforFrm.Show("Database","Backup ?") == DialogResult.Yes)
                {
                    if (AuthenticiationFrm.ShowAuth() == DialogResult.Yes)
                    {
                        lblInfor.Text = "Please wait... backing up database ";
                        panWait.Visible = true;
                        var db = new MyDB();
                        await Task.Run(() => db.Backup(lblBackupPath.Text, true));
                        panWait.Visible = false;
                        ConfirmationNotifyFrm.Show("Database", "Backup Completed Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database backup error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panWait.Visible = false;
            }
        }

        private void linkRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "SQL SERVER database backup files|*.bak";
            dig.Title = "Database restore";

            if (dig.ShowDialog() == DialogResult.OK)
            {
                lblRestorePath.Text = dig.FileName;
                btnRestore.Enabled = true;
            }
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblRestorePath.Text))
                    throw new Exception("please select backup file");
                if (ConfirmInforFrm.Show("Database", "Restore ?") == DialogResult.Yes)
                {
                    if (Loggedin)
                    {
                        if (AuthenticiationFrm.ShowAuth() == DialogResult.Yes)
                        {
                            lblInfor.Text = "Please wait... restoring database ";
                            panWait.Visible = true;
                            var db = Factory.CreateDb();
                            if (Import)
                            {
                                db.CreatBDForImport();
                            }
                          
                            btnRestore.Enabled = false;
                            await Task.Run(() => db.Restore(lblRestorePath.Text, Loggedin));
                            panWait.Visible = false;
                            ConfirmationNotifyFrm.Show("Database", "Restore Completed Successfully");
                          
                            btnRestore.Enabled = true;
                            var login = new LoginFrm(true);
                            this.Close();
                            login.ShowDialog();

                        }
                    }
                    else
                    {
                        lblInfor.Text = "Please wait... restoring database ";
                        panWait.Visible = true;
                        var db = Factory.CreateDb();
                        if (Import)
                        {
                            db.CreatBDForImport();
                        }

                        btnRestore.Enabled = false;
                        await Task.Run(() => db.Restore(lblRestorePath.Text, Loggedin));
                        panWait.Visible = false;
                        ConfirmationNotifyFrm.Show("Database", "Restore Completed Successfully");
                        btnRestore.Enabled = true;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Database already exist")
                {
                    if (MessageBox.Show(ex.Message + "\nReplace existing database ?", "Comfirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var db = Factory.CreateDb();
                        await Task.Run(() => db.Restore(lblRestorePath.Text, true));
                        ConfirmationNotifyFrm.Show("Database", "Restore Completed Successfully");
                        panWait.Visible = false;
                        btnRestore.Enabled = true;
                        if (Loggedin)
                        {
                            var login = new LoginFrm(true);
                            this.Close();
                            login.ShowDialog(); 
                        }

                    }
                    else
                    {
                        ConfirmationNotifyFrm.Show("Database", "Restore cancelled");
                    }
                   
                }
                else
                {
                    panWait.Visible = false;
                    MessageBox.Show(ex.Message, "Database import error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
