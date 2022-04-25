namespace PrintingPress
{
    partial class LoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.panBody = new System.Windows.Forms.Panel();
            this.panInforLoader = new System.Windows.Forms.Panel();
            this.lblConnectInfor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panLoader = new System.Windows.Forms.Panel();
            this.linkImport = new System.Windows.Forms.LinkLabel();
            this.linkConnectServer = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.panHeader.SuspendLayout();
            this.panBody.SuspendLayout();
            this.panInforLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Controls.Add(this.lblMinimize);
            this.panHeader.Controls.Add(this.lblclose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(602, 16);
            this.panHeader.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::PrintingPress.Properties.Resources.Minus_Math__20px;
            this.label1.Location = new System.Drawing.Point(563, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(555, -2);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(17, 19);
            this.lblMinimize.TabIndex = 1;
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblclose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(584, -2);
            this.lblclose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(18, 19);
            this.lblclose.TabIndex = 0;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // panBody
            // 
            this.panBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBody.Controls.Add(this.panInforLoader);
            this.panBody.Controls.Add(this.panHeader);
            this.panBody.Controls.Add(this.lblCompanyName);
            this.panBody.Controls.Add(this.panel2);
            this.panBody.Controls.Add(this.pictureBox1);
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(0, 0);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(604, 417);
            this.panBody.TabIndex = 25;
            // 
            // panInforLoader
            // 
            this.panInforLoader.Controls.Add(this.lblConnectInfor);
            this.panInforLoader.Controls.Add(this.pictureBox2);
            this.panInforLoader.Location = new System.Drawing.Point(0, 373);
            this.panInforLoader.Name = "panInforLoader";
            this.panInforLoader.Size = new System.Drawing.Size(361, 41);
            this.panInforLoader.TabIndex = 25;
            this.panInforLoader.Visible = false;
            // 
            // lblConnectInfor
            // 
            this.lblConnectInfor.AutoSize = true;
            this.lblConnectInfor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblConnectInfor.Location = new System.Drawing.Point(65, 9);
            this.lblConnectInfor.Name = "lblConnectInfor";
            this.lblConnectInfor.Size = new System.Drawing.Size(89, 21);
            this.lblConnectInfor.TabIndex = 1;
            this.lblConnectInfor.Text = "Connecting";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(11, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 38);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.lblCompanyName.Location = new System.Drawing.Point(10, 227);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(330, 64);
            this.lblCompanyName.TabIndex = 24;
            this.lblCompanyName.Text = "FONTSTYLE INTEGRATED\r\n SOLUTIONS";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.panLoader);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnCreateUser);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.linkForgotPass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(360, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 399);
            this.panel2.TabIndex = 23;
            // 
            // panLoader
            // 
            this.panLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.panLoader.Controls.Add(this.linkImport);
            this.panLoader.Controls.Add(this.linkConnectServer);
            this.panLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLoader.Location = new System.Drawing.Point(0, 366);
            this.panLoader.Name = "panLoader";
            this.panLoader.Size = new System.Drawing.Size(242, 33);
            this.panLoader.TabIndex = 7;
            // 
            // linkImport
            // 
            this.linkImport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.linkImport.AutoSize = true;
            this.linkImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkImport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkImport.LinkColor = System.Drawing.Color.Transparent;
            this.linkImport.Location = new System.Drawing.Point(179, 6);
            this.linkImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkImport.Name = "linkImport";
            this.linkImport.Size = new System.Drawing.Size(57, 21);
            this.linkImport.TabIndex = 8;
            this.linkImport.TabStop = true;
            this.linkImport.Text = "Import";
            this.linkImport.Visible = false;
            this.linkImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImport_LinkClicked);
            // 
            // linkConnectServer
            // 
            this.linkConnectServer.AutoSize = true;
            this.linkConnectServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkConnectServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkConnectServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkConnectServer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkConnectServer.LinkColor = System.Drawing.Color.White;
            this.linkConnectServer.Location = new System.Drawing.Point(7, 6);
            this.linkConnectServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkConnectServer.Name = "linkConnectServer";
            this.linkConnectServer.Size = new System.Drawing.Size(114, 21);
            this.linkConnectServer.TabIndex = 3;
            this.linkConnectServer.TabStop = true;
            this.linkConnectServer.Text = "Connect server";
            this.linkConnectServer.Visible = false;
            this.linkConnectServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnectServer_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(24, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(204, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(72, 230);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.AllowDrop = true;
            this.btnCreateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Location = new System.Drawing.Point(28, 230);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(116, 32);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Visible = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowDrop = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(162, 230);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(66, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(22, 134);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 29);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkForgotPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkForgotPass.LinkColor = System.Drawing.Color.Yellow;
            this.linkForgotPass.Location = new System.Drawing.Point(25, 270);
            this.linkForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(134, 21);
            this.linkForgotPass.TabIndex = 2;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "Forgot Password?";
            this.linkForgotPass.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Let get started....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 19.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(88, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintingPress.Properties.Resources.fontstyle_logo;
            this.pictureBox1.Location = new System.Drawing.Point(96, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Interval = 5000;
            this.ConnectionTimer.Tick += new System.EventHandler(this.ConnectionTimer_Tick);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.panBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fontstyle login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFrm_FormClosed);
            this.Load += new System.EventHandler(this.ChatFrm_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            this.panInforLoader.ResumeLayout(false);
            this.panInforLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panLoader.ResumeLayout(false);
            this.panLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Panel panBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.LinkLabel linkConnectServer;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.LinkLabel linkImport;
        private System.Windows.Forms.Panel panLoader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panInforLoader;
        private System.Windows.Forms.Label lblConnectInfor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer ConnectionTimer;
    }
}

