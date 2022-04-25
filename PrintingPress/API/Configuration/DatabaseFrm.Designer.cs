namespace PrintingPress.API.Configuration
{
    partial class DatabaseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.linkBackup = new System.Windows.Forms.LinkLabel();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.linkRestore = new System.Windows.Forms.LinkLabel();
            this.lblRestorePath = new System.Windows.Forms.Label();
            this.panWait = new System.Windows.Forms.Panel();
            this.lblInfor = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database operation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.linkBackup);
            this.groupBox1.Controls.Add(this.lblBackupPath);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select destination folder";
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBackup.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(285, 77);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(88, 28);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // linkBackup
            // 
            this.linkBackup.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkBackup.AutoSize = true;
            this.linkBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBackup.Image = global::PrintingPress.Properties.Resources.More_24px_3;
            this.linkBackup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBackup.Location = new System.Drawing.Point(379, 51);
            this.linkBackup.Name = "linkBackup";
            this.linkBackup.Size = new System.Drawing.Size(25, 20);
            this.linkBackup.TabIndex = 1;
            this.linkBackup.TabStop = true;
            this.linkBackup.Text = "    ";
            this.linkBackup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackup_LinkClicked);
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBackupPath.Location = new System.Drawing.Point(9, 40);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(364, 31);
            this.lblBackupPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.linkRestore);
            this.groupBox2.Controls.Add(this.lblRestorePath);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select file";
            // 
            // btnRestore
            // 
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRestore.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(281, 83);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 28);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // linkRestore
            // 
            this.linkRestore.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkRestore.AutoSize = true;
            this.linkRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRestore.Image = global::PrintingPress.Properties.Resources.More_24px_3;
            this.linkRestore.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRestore.Location = new System.Drawing.Point(379, 52);
            this.linkRestore.Name = "linkRestore";
            this.linkRestore.Size = new System.Drawing.Size(25, 20);
            this.linkRestore.TabIndex = 1;
            this.linkRestore.TabStop = true;
            this.linkRestore.Text = "    ";
            this.linkRestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRestore_LinkClicked);
            // 
            // lblRestorePath
            // 
            this.lblRestorePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRestorePath.Location = new System.Drawing.Point(9, 41);
            this.lblRestorePath.Name = "lblRestorePath";
            this.lblRestorePath.Size = new System.Drawing.Size(364, 31);
            this.lblRestorePath.TabIndex = 0;
            // 
            // panWait
            // 
            this.panWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panWait.Controls.Add(this.lblInfor);
            this.panWait.Controls.Add(this.picWait);
            this.panWait.Location = new System.Drawing.Point(6, 38);
            this.panWait.Name = "panWait";
            this.panWait.Size = new System.Drawing.Size(412, 251);
            this.panWait.TabIndex = 201;
            this.panWait.Visible = false;
            // 
            // lblInfor
            // 
            this.lblInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.lblInfor.Location = new System.Drawing.Point(3, 192);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(406, 26);
            this.lblInfor.TabIndex = 8;
            this.lblInfor.Text = "Please wait... backing up";
            this.lblInfor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picWait
            // 
            this.picWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picWait.Image = global::PrintingPress.Properties.Resources.Spinner2_1s_200px;
            this.picWait.Location = new System.Drawing.Point(97, 60);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(219, 135);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWait.TabIndex = 0;
            this.picWait.TabStop = false;
            // 
            // DatabaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 289);
            this.Controls.Add(this.panWait);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkBackup;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.LinkLabel linkRestore;
        private System.Windows.Forms.Label lblRestorePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panWait;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.PictureBox picWait;
    }
}