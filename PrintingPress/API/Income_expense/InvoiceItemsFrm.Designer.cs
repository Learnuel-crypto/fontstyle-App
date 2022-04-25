namespace PrintingPress.API.Income_expense
{
    partial class InvoiceItemsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceItemsFrm));
            this.dtCasflowTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCasflowFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.linkCashRefresh = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panWait = new System.Windows.Forms.Panel();
            this.lblInfor = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCasflowTo
            // 
            this.dtCasflowTo.CustomFormat = "yyy-mm-dd";
            this.dtCasflowTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCasflowTo.Location = new System.Drawing.Point(200, 6);
            this.dtCasflowTo.Name = "dtCasflowTo";
            this.dtCasflowTo.Size = new System.Drawing.Size(111, 25);
            this.dtCasflowTo.TabIndex = 3;
            this.dtCasflowTo.ValueChanged += new System.EventHandler(this.dtCasflowTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 190;
            this.label3.Text = "To";
            // 
            // dtCasflowFrom
            // 
            this.dtCasflowFrom.CustomFormat = "yyy-mm-dd";
            this.dtCasflowFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCasflowFrom.Location = new System.Drawing.Point(55, 6);
            this.dtCasflowFrom.Name = "dtCasflowFrom";
            this.dtCasflowFrom.Size = new System.Drawing.Size(111, 25);
            this.dtCasflowFrom.TabIndex = 2;
            this.dtCasflowFrom.ValueChanged += new System.EventHandler(this.dtCasflowFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 189;
            this.label4.Text = "From";
            // 
            // linkCashRefresh
            // 
            this.linkCashRefresh.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkCashRefresh.AutoSize = true;
            this.linkCashRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCashRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkCashRefresh.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkCashRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCashRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCashRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkCashRefresh.Location = new System.Drawing.Point(315, 8);
            this.linkCashRefresh.Name = "linkCashRefresh";
            this.linkCashRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkCashRefresh.TabIndex = 4;
            this.linkCashRefresh.TabStop = true;
            this.linkCashRefresh.Text = "     Refresh";
            this.linkCashRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCashRefresh_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblPageHeading);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 39);
            this.panel1.TabIndex = 191;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(344, 6);
            this.txtSearch.MaximumSize = new System.Drawing.Size(738, 27);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(336, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblPageHeading
            // 
            this.lblPageHeading.AutoSize = true;
            this.lblPageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblPageHeading.Location = new System.Drawing.Point(3, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(193, 32);
            this.lblPageHeading.TabIndex = 12;
            this.lblPageHeading.Text = "Invoice items";
            this.lblPageHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.panWait);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.dtCasflowTo);
            this.panel2.Controls.Add(this.linkCashRefresh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtCasflowFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 496);
            this.panel2.TabIndex = 192;
            // 
            // panWait
            // 
            this.panWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panWait.Controls.Add(this.lblInfor);
            this.panWait.Controls.Add(this.picWait);
            this.panWait.Location = new System.Drawing.Point(108, 103);
            this.panWait.Name = "panWait";
            this.panWait.Size = new System.Drawing.Size(466, 291);
            this.panWait.TabIndex = 201;
            this.panWait.Visible = false;
            // 
            // lblInfor
            // 
            this.lblInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.lblInfor.Location = new System.Drawing.Point(0, 239);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(463, 26);
            this.lblInfor.TabIndex = 9;
            this.lblInfor.Text = "Please wait... preparing print page";
            this.lblInfor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picWait
            // 
            this.picWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picWait.Image = global::PrintingPress.Properties.Resources.Spinner2_1s_200px;
            this.picWait.Location = new System.Drawing.Point(97, 82);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(273, 127);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWait.TabIndex = 0;
            this.picWait.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkLabel1.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkLabel1.Location = new System.Drawing.Point(404, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "     Print";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(3, 37);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(677, 459);
            this.dgvDetails.TabIndex = 0;
            // 
            // waitTimer
            // 
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // InvoiceItemsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceItemsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCasflowTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtCasflowFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkCashRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageHeading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panWait;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.Timer waitTimer;
    }
}