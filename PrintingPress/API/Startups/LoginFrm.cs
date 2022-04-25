using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model;
using PrintingPress.API.Configuration;
using PrintingPress.API.Income_expense;
using PrintingPress.API.Messenger;
using PrintingPress.API.Startups;
using PrintingPress.Models.Staff_mgt;

namespace PrintingPress
{
    public partial class LoginFrm : Form
    {
         
      private ISqlHelper mySqlHelper=null; 
      private IUsers user = Factory.CreateNewUser();
      private string Error = null;
        private int errorCount=0;
        private bool ReAuthenticate;
        public  LoginFrm(bool dbOperation=false)
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            ReAuthenticate = dbOperation;
        }

     private  string   CheckConnection()
     { 
            try
            {
               
                mySqlHelper= Factory.CreateSqlConHelper(true); 
                Error = "No error";
                return Error;

            }
            catch (Exception ex)
            {
                
              return  Error =ex.Message;
              
            }

        }
        private string CheckUser()
        {
            var error = "No error";
            try
            {
                if (mySqlHelper.IsConnection)
                    Users.CheckUserExistOnFirstRun();
                btnCreateUser.Visible = false;
                btnClose.Visible = true;
                btnLogin.Enabled = true;
                return error;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                if (ex.Message == "No user created")
                {
                    btnClose.Visible = false;
                    btnCreateUser.Visible = true;
                    btnLogin.Enabled = false;
                      
                }
                else if (ex.Message == "There is no row at position 0.")
                {
                    btnClose.Visible = false;
                    btnCreateUser.Visible = true;
                    btnLogin.Enabled = false;
                     
                }
                else if (ex.Message.ToLower().StartsWith("cannot open database"))
                { 
                    linkConnectServer.Visible = true;
                    linkImport.Visible = true; 
                    btnLogin.Enabled = false;
                     
                    lblConnectInfor.ForeColor = Color.IndianRed;
                    panInforLoader.Visible = true;

                    btnClose.Visible = true;
                    btnCreateUser.Visible = false;
                    btnLogin.Enabled = false;


                }
                else if(string.IsNullOrEmpty(ex.Message))
                {
                    linkConnectServer.Visible = false;
                    linkImport.Visible = false;
                    btnClose.Visible = true;
                    btnCreateUser.Visible = false;
                    btnLogin.Enabled = false;


                }
                else
                {
                    linkConnectServer.Visible = true;
                    linkImport.Visible = true;
                   // MessageBox.Show(ex.Message, "Server error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return error;
            }
        }

        //private void CreateDataBase()
        //{
        //    try
        //    {
        //        // MyDB db = new MyDB(Application.StartupPath + "\\script.sql");
        //        var db = Factory.CreateDb(); 
        //        ConnectionTimer.Stop(); 
        //        var path = Application.StartupPath + "\\default.bak";
        //        db.CreatBDForImport();
        //        db.Restore(path, false);
        //        ConnectionTimer.Start();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private async void ChatFrm_Load(object sender, EventArgs e)
        {
            try
            {
                lblConnectInfor.Text = "Connecting..";
                lblConnectInfor.ForeColor = Color.IndianRed;
                panInforLoader.Visible = true; 
                Task<string> task = new Task<string>(CheckConnection);
                task.Start();
              var error=  await task;
               
                if (error == "No error")
                {
                    lblConnectInfor.Text = "Connected";
                    lblConnectInfor.ForeColor = Color.Green;
                    panInforLoader.Visible = false;
                   var userError= CheckUser(); 
                   if (userError.ToLower().StartsWith("cannot open database"))
                   {
                        //use async method to create database
                        lblConnectInfor.Text = "Database not found";
                        panInforLoader.Visible = true;
                        ConnectionTimer.Enabled = false; 
                      //  CreateDataBase();
                        
                       
                    }
                }
                else
                {
                    lblConnectInfor.Text = "Disconnected";
                    lblConnectInfor.ForeColor = Color.Red;
                    panInforLoader.Visible = true;
                    Error = null;
                }

                ConnectionTimer.Enabled = true;
                ConnectionTimer.Start();
            }
            catch (Exception ex)
            {
                lblConnectInfor.Text = "Disconnected";
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus();
                    throw new Exception("Enter Username");
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    throw new Exception("Enter Password");
                }

                if (!user.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
                {
                    errorCount++;
                    MessageBox.Show("Incorrect username or password", "login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (user.IsLogin && user.isActive)
                    {
                        if (Users.RoleID == 7 || Users.RoleID == 6 || Users.RoleID == 5)
                        {
                            UserActivity.RecordActivity("Logged in");
                            if (!ReAuthenticate)
                            {
                                var dashboard = new DashboardFrm();
                                this.Hide();
                                dashboard.Show();
                            }
                            else { this.Close(); }
                        }
                        else
                        {
                            UserActivity.RecordActivity("Logged in");
                            if (!ReAuthenticate)
                            {
                                var chat = new ChatBoxFrm();
                                this.Hide();
                                chat.Show();
                            }
                            else { this.Close();}
                        }
                       
                        
                    }else if (user.IsLogin && !user.isActive)
                    {
                        MessageBox.Show("Account is has been deactivateds", "login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    

                }
                if (errorCount >= 3)
                {
                    linkForgotPass.Visible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var createAdmin = new CreateAdmin();
            this.Hide();
            createAdmin.Show();
        }

        void Reconnect()
        {
            try
            {
                mySqlHelper = Factory.CreateSqlConHelper(true);
                lblConnectInfor.Text = "Connected";
                lblConnectInfor.ForeColor = Color.Green;
                panInforLoader.Visible = false;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                lblConnectInfor.Text = "Connecting...";
                lblConnectInfor.ForeColor = Color.IndianRed;
                panInforLoader.Visible = true;
            }
             
        }
        private async void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblConnectInfor.Text = "Connecting..";
                //lblConnectInfor.ForeColor = Color.IndianRed;
                //panInforLoader.Visible = true;
                Task<string> task = new Task<string>(CheckConnection);
                task.Start();
                var error = await task;

                if (error == "No error")
                {
                    lblConnectInfor.Text = "Connected";
                    lblConnectInfor.ForeColor = Color.Green;
                    panInforLoader.Visible = false;
                    var userError = CheckUser();
                    if (userError.ToLower().StartsWith("cannot open database"))
                    {
                        //use async method to create database
                        lblConnectInfor.Text = "Database not found";
                        btnCreateUser.Visible = false;
                        btnClose.Visible = true;
                        panInforLoader.Visible = true;
                    }
                     
                }
                else
                {
                    lblConnectInfor.Text = "Disconnected";
                    lblConnectInfor.ForeColor = Color.Red;
                    panInforLoader.Visible = true;
                    Error = null;
                }
                 
            }
            catch (Exception)
            {
                lblConnectInfor.Text = "Disconnected";
               /// MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void LoginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
             
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkConnectServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ConnectionTimer.Start();
                var config = new ServerConfigFrm();
                config.ShowDialog();
                ConnectionTimer.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ConnectionTimer.Stop();
                var config = new DatabaseFrm(true,false);
                config.ShowDialog(this);
                ConnectionTimer.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
