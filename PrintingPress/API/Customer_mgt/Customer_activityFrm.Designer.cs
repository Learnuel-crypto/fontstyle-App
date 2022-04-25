namespace PrintingPress.API.Customer_mgt
{
    partial class Customer_activityFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_activityFrm));
            this.panHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkPrintInvoice = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkPrint = new System.Windows.Forms.LinkLabel();
            this.panWait = new System.Windows.Forms.Panel();
            this.lblInfor = new System.Windows.Forms.Label();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.linkCashRefresh = new System.Windows.Forms.LinkLabel();
            this.panHead.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.panHead.Controls.Add(this.label1);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(625, 30);
            this.panHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Report";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panWait);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dgvInvoice);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 482);
            this.panel1.TabIndex = 0;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbCustomer.Location = new System.Drawing.Point(40, 7);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(241, 25);
            this.cmbCustomer.TabIndex = 196;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(331, 7);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(92, 25);
            this.dtFrom.TabIndex = 192;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(287, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 194;
            this.label4.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(455, 6);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(89, 25);
            this.dtTo.TabIndex = 193;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(427, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 195;
            this.label3.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintingPress.Properties.Resources.icons8_search_24px;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(4, 42);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.Size = new System.Drawing.Size(617, 430);
            this.dgvInvoice.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.linkPrintInvoice);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 35);
            this.panel2.TabIndex = 1;
            // 
            // linkPrintInvoice
            // 
            this.linkPrintInvoice.AutoSize = true;
            this.linkPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPrintInvoice.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintInvoice.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.linkPrintInvoice.Location = new System.Drawing.Point(1, 4);
            this.linkPrintInvoice.Name = "linkPrintInvoice";
            this.linkPrintInvoice.Size = new System.Drawing.Size(63, 21);
            this.linkPrintInvoice.TabIndex = 187;
            this.linkPrintInvoice.TabStop = true;
            this.linkPrintInvoice.Text = "     Print";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.linkCashRefresh);
            this.panel3.Controls.Add(this.linkPrint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 35);
            this.panel3.TabIndex = 1;
            // 
            // linkPrint
            // 
            this.linkPrint.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkPrint.AutoSize = true;
            this.linkPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPrint.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrint.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrint.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.linkPrint.Location = new System.Drawing.Point(7, 5);
            this.linkPrint.Name = "linkPrint";
            this.linkPrint.Size = new System.Drawing.Size(63, 21);
            this.linkPrint.TabIndex = 187;
            this.linkPrint.TabStop = true;
            this.linkPrint.Text = "     Print";
            this.linkPrint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrint_LinkClicked);
            // 
            // panWait
            // 
            this.panWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panWait.Controls.Add(this.lblInfor);
            this.panWait.Controls.Add(this.picWait);
            this.panWait.Location = new System.Drawing.Point(0, 0);
            this.panWait.Name = "panWait";
            this.panWait.Size = new System.Drawing.Size(625, 482);
            this.panWait.TabIndex = 201;
            this.panWait.Visible = false;
            // 
            // lblInfor
            // 
            this.lblInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.lblInfor.Location = new System.Drawing.Point(2, 414);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(622, 26);
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
            this.picWait.Location = new System.Drawing.Point(47, 42);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(535, 369);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWait.TabIndex = 0;
            this.picWait.TabStop = false;
            // 
            // linkCashRefresh
            // 
            this.linkCashRefresh.AutoSize = true;
            this.linkCashRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCashRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkCashRefresh.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkCashRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCashRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCashRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkCashRefresh.Location = new System.Drawing.Point(76, 5);
            this.linkCashRefresh.Name = "linkCashRefresh";
            this.linkCashRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkCashRefresh.TabIndex = 196;
            this.linkCashRefresh.TabStop = true;
            this.linkCashRefresh.Text = "     Refresh";
            this.linkCashRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCashRefresh_LinkClicked);
            // 
            // Customer_activityFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_activityFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkPrintInvoice;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkPrint;
        private System.Windows.Forms.Panel panWait;
        private System.Windows.Forms.Label lblInfor;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.LinkLabel linkCashRefresh;
    }
}