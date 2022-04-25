using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Configuration
{
    public partial class ServerConfigFrm : Form
    {
        string connectionString;
        private const string defaultConnString = @"Data Source=(local)\SQLEXPRESS;AttachDbFilename=|DataDirectory|\pinoxsystemdata.mdf;Integrated Security=True;User Instance=True";
        IAppSettings settings = Factory.CreateAppSettings();
        public ServerConfigFrm()
        {
            InitializeComponent();
            txtDatabase.UseSystemPasswordChar = true;
            txtUser.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;
            

        }

        private void ServerConfigFrm_Load(object sender, EventArgs e)
        {
            comServer.Items.Add(".");
            comServer.Items.Add("(local)");
            comServer.Items.Add(@".\SQLEXPRESS");
            comServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            comServer.SelectedIndex = 3;
            btnSave.Enabled = false;
        }

        private   void btnTest_Click(object sender, EventArgs e)
        {
            connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};{4};",
               comServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text, "Integrated Security = True");
            try
            {
                ISqlHelper helper = Factory.CreateSqlConHelper(connectionString);
               
                if (helper.IsConnection)
                    MessageBox.Show("Test connected successful", "messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISqlHelper helper = Factory.CreateSqlConHelper(connectionString);

                if (helper.IsConnection)
                {
                    settings.SaveConnectionString("cn", connectionString);
                    MessageBox.Show("Configuration saved successfully\nRestart application", "messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
