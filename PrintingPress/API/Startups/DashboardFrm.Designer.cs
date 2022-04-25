namespace PrintingPress.API.Startups
{
    partial class DashboardFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtInvoiceTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInvoiceFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtCasflowTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCasflowFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.panMenu = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkReceipt = new System.Windows.Forms.LinkLabel();
            this.linkView = new System.Windows.Forms.LinkLabel();
            this.linkDelete = new System.Windows.Forms.LinkLabel();
            this.linkInvoiceRefresh = new System.Windows.Forms.LinkLabel();
            this.linkDebtReceipt = new System.Windows.Forms.LinkLabel();
            this.linkDelCashflow = new System.Windows.Forms.LinkLabel();
            this.linkCashRefresh = new System.Windows.Forms.LinkLabel();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CashFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CashCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInvoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debtorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 29);
            this.menuStrip1.TabIndex = 174;
            this.menuStrip1.Text = "ExpenseMenu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.linkReceipt);
            this.groupBox2.Controls.Add(this.linkView);
            this.groupBox2.Controls.Add(this.linkDelete);
            this.groupBox2.Controls.Add(this.dtInvoiceTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInvoiceFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkInvoiceRefresh);
            this.groupBox2.Controls.Add(this.dgvInvoice);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 217);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // dtInvoiceTo
            // 
            this.dtInvoiceTo.CustomFormat = "yyy-mm-dd";
            this.dtInvoiceTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtInvoiceTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInvoiceTo.Location = new System.Drawing.Point(200, 26);
            this.dtInvoiceTo.Name = "dtInvoiceTo";
            this.dtInvoiceTo.Size = new System.Drawing.Size(111, 25);
            this.dtInvoiceTo.TabIndex = 183;
            this.dtInvoiceTo.ValueChanged += new System.EventHandler(this.dtInvoiceTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 185;
            this.label1.Text = "To";
            // 
            // dtInvoiceFrom
            // 
            this.dtInvoiceFrom.CustomFormat = "yyy-mm-dd";
            this.dtInvoiceFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtInvoiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInvoiceFrom.Location = new System.Drawing.Point(55, 24);
            this.dtInvoiceFrom.Name = "dtInvoiceFrom";
            this.dtInvoiceFrom.Size = new System.Drawing.Size(111, 25);
            this.dtInvoiceFrom.TabIndex = 182;
            this.dtInvoiceFrom.ValueChanged += new System.EventHandler(this.dtInvoiceFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 184;
            this.label2.Text = "From";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(4, 55);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.Size = new System.Drawing.Size(890, 150);
            this.dgvInvoice.TabIndex = 12;
            this.dgvInvoice.Click += new System.EventHandler(this.dgvInvoice_Click);
            this.dgvInvoice.DoubleClick += new System.EventHandler(this.dgvInvoice_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkDebtReceipt);
            this.groupBox1.Controls.Add(this.linkDelCashflow);
            this.groupBox1.Controls.Add(this.dtCasflowTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtCasflowFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkCashRefresh);
            this.groupBox1.Controls.Add(this.dgvCash);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 167);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cashflow";
            // 
            // dtCasflowTo
            // 
            this.dtCasflowTo.CustomFormat = "yyy-mm-dd";
            this.dtCasflowTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCasflowTo.Location = new System.Drawing.Point(197, 19);
            this.dtCasflowTo.Name = "dtCasflowTo";
            this.dtCasflowTo.Size = new System.Drawing.Size(111, 25);
            this.dtCasflowTo.TabIndex = 183;
            this.dtCasflowTo.ValueChanged += new System.EventHandler(this.dtCasflowTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(169, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 185;
            this.label3.Text = "To";
            // 
            // dtCasflowFrom
            // 
            this.dtCasflowFrom.CustomFormat = "yyy-mm-dd";
            this.dtCasflowFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCasflowFrom.Location = new System.Drawing.Point(52, 19);
            this.dtCasflowFrom.Name = "dtCasflowFrom";
            this.dtCasflowFrom.Size = new System.Drawing.Size(111, 25);
            this.dtCasflowFrom.TabIndex = 182;
            this.dtCasflowFrom.ValueChanged += new System.EventHandler(this.dtCasflowFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 184;
            this.label4.Text = "From";
            // 
            // dgvCash
            // 
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.AllowUserToDeleteRows = false;
            this.dgvCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCash.Location = new System.Drawing.Point(6, 50);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.ReadOnly = true;
            this.dgvCash.Size = new System.Drawing.Size(892, 111);
            this.dgvCash.TabIndex = 79;
            this.dgvCash.Click += new System.EventHandler(this.dgvCash_Click);
            // 
            // panMenu
            // 
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 29);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(934, 41);
            this.panMenu.TabIndex = 176;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.44769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.55231F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 411);
            this.tableLayoutPanel1.TabIndex = 177;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 226);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 173);
            this.panel2.TabIndex = 1;
            // 
            // linkReceipt
            // 
            this.linkReceipt.AutoSize = true;
            this.linkReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkReceipt.Image = global::PrintingPress.Properties.Resources.icons8_receipt_24px;
            this.linkReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReceipt.Location = new System.Drawing.Point(565, 28);
            this.linkReceipt.Name = "linkReceipt";
            this.linkReceipt.Size = new System.Drawing.Size(81, 21);
            this.linkReceipt.TabIndex = 188;
            this.linkReceipt.TabStop = true;
            this.linkReceipt.Text = "     Receipt";
            this.toolTip1.SetToolTip(this.linkReceipt, "Print receipt");
            this.linkReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReceipt_LinkClicked);
            // 
            // linkView
            // 
            this.linkView.AutoSize = true;
            this.linkView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkView.Image = global::PrintingPress.Properties.Resources.icons8_eye_24px;
            this.linkView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkView.Location = new System.Drawing.Point(399, 27);
            this.linkView.Name = "linkView";
            this.linkView.Size = new System.Drawing.Size(80, 21);
            this.linkView.TabIndex = 187;
            this.linkView.TabStop = true;
            this.linkView.Text = "        Items";
            this.toolTip1.SetToolTip(this.linkView, "view invoice items");
            this.linkView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkView_LinkClicked);
            // 
            // linkDelete
            // 
            this.linkDelete.AutoSize = true;
            this.linkDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDelete.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.linkDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDelete.Location = new System.Drawing.Point(485, 27);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(74, 21);
            this.linkDelete.TabIndex = 186;
            this.linkDelete.TabStop = true;
            this.linkDelete.Text = "     Delete";
            this.toolTip1.SetToolTip(this.linkDelete, "Delete invoice");
            this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
            // 
            // linkInvoiceRefresh
            // 
            this.linkInvoiceRefresh.AutoSize = true;
            this.linkInvoiceRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkInvoiceRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkInvoiceRefresh.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkInvoiceRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkInvoiceRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkInvoiceRefresh.Location = new System.Drawing.Point(310, 28);
            this.linkInvoiceRefresh.Name = "linkInvoiceRefresh";
            this.linkInvoiceRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkInvoiceRefresh.TabIndex = 181;
            this.linkInvoiceRefresh.TabStop = true;
            this.linkInvoiceRefresh.Text = "     Refresh";
            this.linkInvoiceRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInvoiceRefresh_LinkClicked);
            // 
            // linkDebtReceipt
            // 
            this.linkDebtReceipt.AutoSize = true;
            this.linkDebtReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDebtReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDebtReceipt.Image = global::PrintingPress.Properties.Resources.icons8_receipt_24px;
            this.linkDebtReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDebtReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDebtReceipt.Location = new System.Drawing.Point(460, 21);
            this.linkDebtReceipt.Name = "linkDebtReceipt";
            this.linkDebtReceipt.Size = new System.Drawing.Size(81, 21);
            this.linkDebtReceipt.TabIndex = 189;
            this.linkDebtReceipt.TabStop = true;
            this.linkDebtReceipt.Text = "     Receipt";
            this.toolTip1.SetToolTip(this.linkDebtReceipt, "Print receipt");
            this.linkDebtReceipt.Visible = false;
            this.linkDebtReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDebtReceipt_LinkClicked);
            // 
            // linkDelCashflow
            // 
            this.linkDelCashflow.AutoSize = true;
            this.linkDelCashflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDelCashflow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDelCashflow.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.linkDelCashflow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDelCashflow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDelCashflow.Location = new System.Drawing.Point(398, 21);
            this.linkDelCashflow.Name = "linkDelCashflow";
            this.linkDelCashflow.Size = new System.Drawing.Size(56, 21);
            this.linkDelCashflow.TabIndex = 187;
            this.linkDelCashflow.TabStop = true;
            this.linkDelCashflow.Text = "     Del.";
            this.toolTip1.SetToolTip(this.linkDelCashflow, "Delete invoice");
            this.linkDelCashflow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelCashflow_LinkClicked);
            // 
            // linkCashRefresh
            // 
            this.linkCashRefresh.AutoSize = true;
            this.linkCashRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCashRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkCashRefresh.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkCashRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCashRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCashRefresh.Location = new System.Drawing.Point(312, 21);
            this.linkCashRefresh.Name = "linkCashRefresh";
            this.linkCashRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkCashRefresh.TabIndex = 181;
            this.linkCashRefresh.TabStop = true;
            this.linkCashRefresh.Text = "     Refresh";
            this.linkCashRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCashRefresh_LinkClicked);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CashFlowToolStripMenuItem,
            this.receiptToolStripMenuItem,
            this.CashCodesToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.jobFlowToolStripMenuItem});
            this.setupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setupToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.icons8_admin_settings_male_24px;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.setupToolStripMenuItem.Text = "Admin";
            // 
            // CashFlowToolStripMenuItem
            // 
            this.CashFlowToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CashFlowToolStripMenuItem.Name = "CashFlowToolStripMenuItem";
            this.CashFlowToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CashFlowToolStripMenuItem.Text = "Setup account";
            this.CashFlowToolStripMenuItem.ToolTipText = "setup account format";
            this.CashFlowToolStripMenuItem.Click += new System.EventHandler(this.CashFlowToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.receiptToolStripMenuItem.Text = "Set receipt";
            this.receiptToolStripMenuItem.ToolTipText = "set invoice receipt details";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // CashCodesToolStripMenuItem
            // 
            this.CashCodesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CashCodesToolStripMenuItem.Name = "CashCodesToolStripMenuItem";
            this.CashCodesToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CashCodesToolStripMenuItem.Text = "Add staff";
            this.CashCodesToolStripMenuItem.ToolTipText = "create staff user account";
            this.CashCodesToolStripMenuItem.Click += new System.EventHandler(this.CashCodesToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.ToolTipText = "view user activities";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // jobFlowToolStripMenuItem
            // 
            this.jobFlowToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.jobFlowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.jobFlowToolStripMenuItem.Name = "jobFlowToolStripMenuItem";
            this.jobFlowToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.jobFlowToolStripMenuItem.Text = "Database";
            this.jobFlowToolStripMenuItem.ToolTipText = "Database operation";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.ToolTipText = "Backup database";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.ToolTipText = "Restore database";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.ToolTipText = "Data base settings";
            this.settingToolStripMenuItem.Visible = false;
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueInvoiceToolStripMenuItem1,
            this.incomeToolStripMenuItem1,
            this.expenseToolStripMenuItem2});
            this.invoiceToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.icons8_cash_in_hand_24px_1;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.invoiceToolStripMenuItem.Text = "Cash flow";
            // 
            // issueInvoiceToolStripMenuItem1
            // 
            this.issueInvoiceToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.issueInvoiceToolStripMenuItem1.Name = "issueInvoiceToolStripMenuItem1";
            this.issueInvoiceToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.issueInvoiceToolStripMenuItem1.Text = "Invoice";
            this.issueInvoiceToolStripMenuItem1.ToolTipText = "issue invoice to customer";
            this.issueInvoiceToolStripMenuItem1.Click += new System.EventHandler(this.issueInvoiceToolStripMenuItem1_Click);
            // 
            // incomeToolStripMenuItem1
            // 
            this.incomeToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.incomeToolStripMenuItem1.Name = "incomeToolStripMenuItem1";
            this.incomeToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.incomeToolStripMenuItem1.Text = "Income";
            this.incomeToolStripMenuItem1.ToolTipText = "Record income";
            this.incomeToolStripMenuItem1.Click += new System.EventHandler(this.incomeToolStripMenuItem1_Click);
            // 
            // expenseToolStripMenuItem2
            // 
            this.expenseToolStripMenuItem2.BackColor = System.Drawing.Color.White;
            this.expenseToolStripMenuItem2.Name = "expenseToolStripMenuItem2";
            this.expenseToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.expenseToolStripMenuItem2.Text = "Expense";
            this.expenseToolStripMenuItem2.ToolTipText = "Record expense";
            this.expenseToolStripMenuItem2.Click += new System.EventHandler(this.expenseToolStripMenuItem2_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseToolStripMenuItem,
            this.invoiceToolStripMenuItem1,
            this.invoiceItemsToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.icons8_transaction_24px;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.viewToolStripMenuItem.Text = "Account";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.expenseToolStripMenuItem.Text = "Cash Flow";
            this.expenseToolStripMenuItem.ToolTipText = "Generate account statement";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            this.invoiceToolStripMenuItem1.ToolTipText = "view invoice records";
            this.invoiceToolStripMenuItem1.Click += new System.EventHandler(this.invoiceToolStripMenuItem1_Click);
            // 
            // invoiceItemsToolStripMenuItem
            // 
            this.invoiceItemsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.invoiceItemsToolStripMenuItem.Name = "invoiceItemsToolStripMenuItem";
            this.invoiceItemsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.invoiceItemsToolStripMenuItem.Text = "Invoice Items";
            this.invoiceItemsToolStripMenuItem.ToolTipText = "View invoice items";
            this.invoiceItemsToolStripMenuItem.Click += new System.EventHandler(this.invoiceItemsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.debtorsToolStripMenuItem});
            this.customersToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.icons8_member_24px;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.viewToolStripMenuItem1.Text = "Account";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // debtorsToolStripMenuItem
            // 
            this.debtorsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.debtorsToolStripMenuItem.Name = "debtorsToolStripMenuItem";
            this.debtorsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.debtorsToolStripMenuItem.Text = "Report";
            this.debtorsToolStripMenuItem.Click += new System.EventHandler(this.debtorsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem,
            this.settingToolStripMenuItem1});
            this.newToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.FacebookMessenger_3;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.newToolStripMenuItem.Text = "Messenger";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.settingToolStripMenuItem1.Text = "Setting";
            this.settingToolStripMenuItem1.Click += new System.EventHandler(this.settingToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginDetailsToolStripMenuItem,
            this.securityQuestionToolStripMenuItem,
            this.appSettingToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.Settings_24px;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // loginDetailsToolStripMenuItem
            // 
            this.loginDetailsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.loginDetailsToolStripMenuItem.Name = "loginDetailsToolStripMenuItem";
            this.loginDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.loginDetailsToolStripMenuItem.Text = "Login details";
            // 
            // securityQuestionToolStripMenuItem
            // 
            this.securityQuestionToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.securityQuestionToolStripMenuItem.Name = "securityQuestionToolStripMenuItem";
            this.securityQuestionToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.securityQuestionToolStripMenuItem.Text = "Security question";
            this.securityQuestionToolStripMenuItem.Click += new System.EventHandler(this.securityQuestionToolStripMenuItem_Click);
            // 
            // appSettingToolStripMenuItem
            // 
            this.appSettingToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.appSettingToolStripMenuItem.Name = "appSettingToolStripMenuItem";
            this.appSettingToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.appSettingToolStripMenuItem.Text = "App setting";
            this.appSettingToolStripMenuItem.Visible = false;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.icons8_sign_out_24px_1;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // DashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardFrm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInvoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityQuestionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCash;
        private System.Windows.Forms.DateTimePicker dtInvoiceTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInvoiceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkInvoiceRefresh;
        private System.Windows.Forms.DateTimePicker dtCasflowTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtCasflowFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkCashRefresh;
        private System.Windows.Forms.LinkLabel linkDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkDelCashflow;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.LinkLabel linkView;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debtorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkReceipt;
        private System.Windows.Forms.LinkLabel linkDebtReceipt;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoiceItemsToolStripMenuItem;
    }
}