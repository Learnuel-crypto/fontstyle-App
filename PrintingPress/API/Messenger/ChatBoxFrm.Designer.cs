namespace PrintingPress.API.Messenger
{
    partial class ChatBoxFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBoxFrm));
            this.flpChats = new System.Windows.Forms.FlowLayoutPanel();
            this.panHead = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnResetLogin = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panFooter = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.copyTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ChatUpdater = new System.Windows.Forms.Timer(this.components);
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.panHead.SuspendLayout();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpChats
            // 
            this.flpChats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpChats.AutoScroll = true;
            this.flpChats.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChats.Location = new System.Drawing.Point(3, 46);
            this.flpChats.Name = "flpChats";
            this.flpChats.Size = new System.Drawing.Size(458, 433);
            this.flpChats.TabIndex = 0;
            this.flpChats.WrapContents = false;
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panHead.Controls.Add(this.btnLogout);
            this.panHead.Controls.Add(this.btnResetLogin);
            this.panHead.Controls.Add(this.btnSecurity);
            this.panHead.Controls.Add(this.btnAll);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(462, 40);
            this.panHead.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::PrintingPress.Properties.Resources.icons8_sign_out_24px_1;
            this.btnLogout.Location = new System.Drawing.Point(424, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(32, 30);
            this.btnLogout.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnLogout, "Logout");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnResetLogin
            // 
            this.btnResetLogin.AutoSize = true;
            this.btnResetLogin.FlatAppearance.BorderSize = 0;
            this.btnResetLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetLogin.ForeColor = System.Drawing.Color.White;
            this.btnResetLogin.Image = global::PrintingPress.Properties.Resources.icons8_password_24px;
            this.btnResetLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetLogin.Location = new System.Drawing.Point(107, 5);
            this.btnResetLogin.Name = "btnResetLogin";
            this.btnResetLogin.Size = new System.Drawing.Size(114, 30);
            this.btnResetLogin.TabIndex = 14;
            this.btnResetLogin.Text = "     Reset details";
            this.toolTip1.SetToolTip(this.btnResetLogin, "Reset login");
            this.btnResetLogin.UseVisualStyleBackColor = true;
            // 
            // btnSecurity
            // 
            this.btnSecurity.AutoSize = true;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSecurity.Image = global::PrintingPress.Properties.Resources.icons8_sign_in_form_password_24px;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(8, 5);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(90, 30);
            this.btnSecurity.TabIndex = 13;
            this.btnSecurity.Text = "      Security";
            this.toolTip1.SetToolTip(this.btnSecurity, "Set security questions");
            this.btnSecurity.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.AutoSize = true;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::PrintingPress.Properties.Resources.FacebookMessenger_3;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(230, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(72, 27);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "     Chats";
            this.toolTip1.SetToolTip(this.btnAll, "See all chats");
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // panFooter
            // 
            this.panFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panFooter.Controls.Add(this.btnSend);
            this.panFooter.Controls.Add(this.txtMessage);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(0, 485);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(462, 79);
            this.panFooter.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSend.ForeColor = System.Drawing.Color.Transparent;
            this.btnSend.Image = global::PrintingPress.Properties.Resources.icons8_sent_24px;
            this.btnSend.Location = new System.Drawing.Point(401, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(39, 36);
            this.btnSend.TabIndex = 6;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSend, "send");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMessage.Location = new System.Drawing.Point(4, 10);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(391, 58);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // copyTimer
            // 
            this.copyTimer.Tick += new System.EventHandler(this.copyTimer_Tick);
            // 
            // ChatUpdater
            // 
            this.ChatUpdater.Tick += new System.EventHandler(this.ChatUpdater_Tick);
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 30000;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // ChatBoxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 564);
            this.Controls.Add(this.panFooter);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.flpChats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatBoxFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatBoxFrm_FormClosed);
            this.Load += new System.EventHandler(this.ChatBoxFrm_Load);
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.panFooter.ResumeLayout(false);
            this.panFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpChats;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Timer copyTimer;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnResetLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer ChatUpdater;
        private System.Windows.Forms.Timer waitTimer;
    }
}