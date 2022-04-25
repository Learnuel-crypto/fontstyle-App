namespace PrintingPress.API.Customer_mgt
{
    partial class Customer_dashboardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_dashboardFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panLeftHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkDeleteCustomer = new System.Windows.Forms.LinkLabel();
            this.linkPrintCusitner = new System.Windows.Forms.LinkLabel();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panRigtbody = new System.Windows.Forms.Panel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.panSearch = new System.Windows.Forms.Panel();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.linkDelInvoice = new System.Windows.Forms.LinkLabel();
            this.linkPrintInvoice = new System.Windows.Forms.LinkLabel();
            this.linkPayDebt = new System.Windows.Forms.LinkLabel();
            this.linkAccount = new System.Windows.Forms.LinkLabel();
            this.panHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panLeftHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panRigtbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panSearch.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panLeftHead, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panRigtbody, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panLeftHead
            // 
            this.panLeftHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLeftHead.Controls.Add(this.pictureBox1);
            this.panLeftHead.Controls.Add(this.panel2);
            this.panLeftHead.Controls.Add(this.txtSearch);
            this.panLeftHead.Controls.Add(this.dgvCustomer);
            this.panLeftHead.Location = new System.Drawing.Point(3, 3);
            this.panLeftHead.Name = "panLeftHead";
            this.panLeftHead.Size = new System.Drawing.Size(398, 472);
            this.panLeftHead.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintingPress.Properties.Resources.icons8_search_24px;
            this.pictureBox1.Location = new System.Drawing.Point(357, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkDeleteCustomer);
            this.panel2.Controls.Add(this.linkPrintCusitner);
            this.panel2.Controls.Add(this.linkUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 36);
            this.panel2.TabIndex = 183;
            // 
            // linkDeleteCustomer
            // 
            this.linkDeleteCustomer.AutoSize = true;
            this.linkDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDeleteCustomer.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.linkDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDeleteCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDeleteCustomer.LinkColor = System.Drawing.Color.Blue;
            this.linkDeleteCustomer.Location = new System.Drawing.Point(226, 8);
            this.linkDeleteCustomer.Name = "linkDeleteCustomer";
            this.linkDeleteCustomer.Size = new System.Drawing.Size(74, 21);
            this.linkDeleteCustomer.TabIndex = 185;
            this.linkDeleteCustomer.TabStop = true;
            this.linkDeleteCustomer.Text = "     Delete";
            this.toolTip1.SetToolTip(this.linkDeleteCustomer, "Delete invoice");
            this.linkDeleteCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeleteCustomer_LinkClicked);
            // 
            // linkPrintCusitner
            // 
            this.linkPrintCusitner.AutoSize = true;
            this.linkPrintCusitner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintCusitner.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPrintCusitner.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkPrintCusitner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintCusitner.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintCusitner.Location = new System.Drawing.Point(138, 8);
            this.linkPrintCusitner.Name = "linkPrintCusitner";
            this.linkPrintCusitner.Size = new System.Drawing.Size(63, 21);
            this.linkPrintCusitner.TabIndex = 184;
            this.linkPrintCusitner.TabStop = true;
            this.linkPrintCusitner.Text = "     Print";
            this.toolTip1.SetToolTip(this.linkPrintCusitner, "Print customer name");
            this.linkPrintCusitner.Visible = false;
            this.linkPrintCusitner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintCusitner_LinkClicked);
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkUpdate.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkUpdate.Location = new System.Drawing.Point(306, 8);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(80, 21);
            this.linkUpdate.TabIndex = 182;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "     Update";
            this.toolTip1.SetToolTip(this.linkUpdate, "Update customer infor");
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdate_LinkClicked);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(9, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 29);
            this.txtSearch.TabIndex = 81;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 84);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(392, 385);
            this.dgvCustomer.TabIndex = 80;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // panRigtbody
            // 
            this.panRigtbody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRigtbody.AutoScroll = true;
            this.panRigtbody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panRigtbody.Controls.Add(this.dtTo);
            this.panRigtbody.Controls.Add(this.label3);
            this.panRigtbody.Controls.Add(this.lblCusName);
            this.panRigtbody.Controls.Add(this.dgvInvoice);
            this.panRigtbody.Controls.Add(this.panSearch);
            this.panRigtbody.Location = new System.Drawing.Point(407, 3);
            this.panRigtbody.Name = "panRigtbody";
            this.panRigtbody.Size = new System.Drawing.Size(507, 472);
            this.panRigtbody.TabIndex = 1;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(409, 41);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(89, 25);
            this.dtTo.TabIndex = 189;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(381, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 191;
            this.label3.Text = "To";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCusName.Location = new System.Drawing.Point(8, 41);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(123, 25);
            this.lblCusName.TabIndex = 83;
            this.lblCusName.Text = "invoice record";
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
            this.dgvInvoice.Location = new System.Drawing.Point(2, 69);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.Size = new System.Drawing.Size(504, 400);
            this.dgvInvoice.TabIndex = 81;
            this.dgvInvoice.Click += new System.EventHandler(this.dgvInvoice_Click);
            this.dgvInvoice.DoubleClick += new System.EventHandler(this.dgvInvoice_DoubleClick);
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.panSearch.Controls.Add(this.dtFrom);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.linkDelInvoice);
            this.panSearch.Controls.Add(this.linkPrintInvoice);
            this.panSearch.Controls.Add(this.linkPayDebt);
            this.panSearch.Controls.Add(this.linkAccount);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(507, 38);
            this.panSearch.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(406, 8);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(92, 25);
            this.dtFrom.TabIndex = 188;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(362, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 190;
            this.label4.Text = "From";
            // 
            // linkDelInvoice
            // 
            this.linkDelInvoice.AutoSize = true;
            this.linkDelInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDelInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDelInvoice.Image = global::PrintingPress.Properties.Resources.Cancel_20px;
            this.linkDelInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDelInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDelInvoice.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.linkDelInvoice.Location = new System.Drawing.Point(174, 11);
            this.linkDelInvoice.Name = "linkDelInvoice";
            this.linkDelInvoice.Size = new System.Drawing.Size(74, 21);
            this.linkDelInvoice.TabIndex = 187;
            this.linkDelInvoice.TabStop = true;
            this.linkDelInvoice.Text = "     Delete";
            this.toolTip1.SetToolTip(this.linkDelInvoice, "Delete invoice");
            this.linkDelInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelInvoice_LinkClicked);
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
            this.linkPrintInvoice.Location = new System.Drawing.Point(9, 11);
            this.linkPrintInvoice.Name = "linkPrintInvoice";
            this.linkPrintInvoice.Size = new System.Drawing.Size(63, 21);
            this.linkPrintInvoice.TabIndex = 186;
            this.linkPrintInvoice.TabStop = true;
            this.linkPrintInvoice.Text = "     Print";
            this.toolTip1.SetToolTip(this.linkPrintInvoice, "Print customer name");
            this.linkPrintInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintInvoice_LinkClicked);
            // 
            // linkPayDebt
            // 
            this.linkPayDebt.AutoSize = true;
            this.linkPayDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPayDebt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPayDebt.Image = global::PrintingPress.Properties.Resources.icons8_cash_in_hand_24px_2;
            this.linkPayDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPayDebt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPayDebt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.linkPayDebt.Location = new System.Drawing.Point(254, 11);
            this.linkPayDebt.Name = "linkPayDebt";
            this.linkPayDebt.Size = new System.Drawing.Size(94, 21);
            this.linkPayDebt.TabIndex = 185;
            this.linkPayDebt.TabStop = true;
            this.linkPayDebt.Text = "      Pay debt";
            this.toolTip1.SetToolTip(this.linkPayDebt, "pay selected  balance");
            this.linkPayDebt.Visible = false;
            this.linkPayDebt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPayDebt_LinkClicked);
            // 
            // linkAccount
            // 
            this.linkAccount.AutoSize = true;
            this.linkAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkAccount.Image = global::PrintingPress.Properties.Resources.icons8_account_24px_2;
            this.linkAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.linkAccount.Location = new System.Drawing.Point(78, 11);
            this.linkAccount.Name = "linkAccount";
            this.linkAccount.Size = new System.Drawing.Size(90, 21);
            this.linkAccount.TabIndex = 184;
            this.linkAccount.TabStop = true;
            this.linkAccount.Text = "      Account";
            this.toolTip1.SetToolTip(this.linkAccount, " customer account");
            this.linkAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAccount_LinkClicked);
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(165)))), ((int)(((byte)(181)))));
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(917, 35);
            this.panHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Dashboard";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // Customer_dashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 514);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer_dashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer dashboard";
            this.Load += new System.EventHandler(this.Customer_dashboardFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panLeftHead.ResumeLayout(false);
            this.panLeftHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panRigtbody.ResumeLayout(false);
            this.panRigtbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panLeftHead;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panRigtbody;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.LinkLabel linkPrintCusitner;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.LinkLabel linkPayDebt;
        private System.Windows.Forms.LinkLabel linkAccount;
        private System.Windows.Forms.LinkLabel linkPrintInvoice;
        private System.Windows.Forms.LinkLabel linkDeleteCustomer;
        private System.Windows.Forms.LinkLabel linkDelInvoice;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
    }
}