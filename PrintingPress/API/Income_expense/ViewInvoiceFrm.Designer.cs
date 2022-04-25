namespace PrintingPress.API.Income_expense
{
    partial class ViewInvoiceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInvoiceFrm));
            this.totalsTimer = new System.Windows.Forms.Timer(this.components);
            this.pandHeader = new System.Windows.Forms.Panel();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panWait = new System.Windows.Forms.Panel();
            this.cmbHeading = new System.Windows.Forms.ComboBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dtCasflowFrom = new System.Windows.Forms.DateTimePicker();
            this.dtCasflowTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panMonthly = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthIncome = new System.Windows.Forms.Label();
            this.lblCurIncome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCashInBank = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCashAthand = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panTodayFlow = new System.Windows.Forms.Panel();
            this.dateCash = new System.Windows.Forms.DateTimePicker();
            this.lblTodayBank = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTodayCash = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTodayDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonthExpense = new System.Windows.Forms.Label();
            this.lblCurExpense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.lblInfor = new System.Windows.Forms.Label();
            this.picMonthly = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picMoneyBag = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picWait = new System.Windows.Forms.PictureBox();
            this.linkView = new System.Windows.Forms.LinkLabel();
            this.linkPrintRecords = new System.Windows.Forms.LinkLabel();
            this.linkReceipt = new System.Windows.Forms.LinkLabel();
            this.linkDelCashflow = new System.Windows.Forms.LinkLabel();
            this.linkCashRefresh = new System.Windows.Forms.LinkLabel();
            this.pandHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panMonthly.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panTodayFlow.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoneyBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            this.SuspendLayout();
            // 
            // totalsTimer
            // 
            this.totalsTimer.Enabled = true;
            this.totalsTimer.Interval = 3000;
            this.totalsTimer.Tick += new System.EventHandler(this.totalsTimer_Tick);
            // 
            // pandHeader
            // 
            this.pandHeader.Controls.Add(this.lblPageHeading);
            this.pandHeader.Controls.Add(this.txtSearch);
            this.pandHeader.Controls.Add(this.label1);
            this.pandHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pandHeader.Location = new System.Drawing.Point(0, 0);
            this.pandHeader.Name = "pandHeader";
            this.pandHeader.Size = new System.Drawing.Size(959, 44);
            this.pandHeader.TabIndex = 5;
            // 
            // lblPageHeading
            // 
            this.lblPageHeading.AutoSize = true;
            this.lblPageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblPageHeading.Location = new System.Drawing.Point(10, 6);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(120, 32);
            this.lblPageHeading.TabIndex = 11;
            this.lblPageHeading.Text = "Invoice ";
            this.lblPageHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(430, 9);
            this.txtSearch.MaximumSize = new System.Drawing.Size(738, 27);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(523, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(367, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panWait);
            this.panel1.Controls.Add(this.linkView);
            this.panel1.Controls.Add(this.linkPrintRecords);
            this.panel1.Controls.Add(this.linkReceipt);
            this.panel1.Controls.Add(this.cmbHeading);
            this.panel1.Controls.Add(this.linkDelCashflow);
            this.panel1.Controls.Add(this.linkCashRefresh);
            this.panel1.Controls.Add(this.dgvDetails);
            this.panel1.Controls.Add(this.dtCasflowFrom);
            this.panel1.Controls.Add(this.dtCasflowTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 368);
            this.panel1.TabIndex = 6;
            // 
            // panWait
            // 
            this.panWait.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panWait.Controls.Add(this.lblInfor);
            this.panWait.Controls.Add(this.picWait);
            this.panWait.Location = new System.Drawing.Point(239, 39);
            this.panWait.Name = "panWait";
            this.panWait.Size = new System.Drawing.Size(390, 317);
            this.panWait.TabIndex = 201;
            this.toolTip1.SetToolTip(this.panWait, "Please wait");
            this.panWait.Visible = false;
            // 
            // cmbHeading
            // 
            this.cmbHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHeading.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHeading.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHeading.FormattingEnabled = true;
            this.cmbHeading.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbHeading.Location = new System.Drawing.Point(685, 9);
            this.cmbHeading.MaximumSize = new System.Drawing.Size(500, 0);
            this.cmbHeading.Name = "cmbHeading";
            this.cmbHeading.Size = new System.Drawing.Size(271, 23);
            this.cmbHeading.TabIndex = 198;
            this.cmbHeading.Visible = false;
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
            this.dgvDetails.Location = new System.Drawing.Point(3, 35);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(953, 331);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.Click += new System.EventHandler(this.dgvDetails_Click);
            this.dgvDetails.DoubleClick += new System.EventHandler(this.dgvDetails_DoubleClick);
            // 
            // dtCasflowFrom
            // 
            this.dtCasflowFrom.CustomFormat = "dd/MM/yyyy";
            this.dtCasflowFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCasflowFrom.Location = new System.Drawing.Point(45, 6);
            this.dtCasflowFrom.Name = "dtCasflowFrom";
            this.dtCasflowFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtCasflowFrom.Size = new System.Drawing.Size(85, 25);
            this.dtCasflowFrom.TabIndex = 189;
            this.dtCasflowFrom.ValueChanged += new System.EventHandler(this.dtCasflowFrom_ValueChanged);
            // 
            // dtCasflowTo
            // 
            this.dtCasflowTo.CustomFormat = "dd/MM/yyyy";
            this.dtCasflowTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCasflowTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCasflowTo.Location = new System.Drawing.Point(172, 6);
            this.dtCasflowTo.Name = "dtCasflowTo";
            this.dtCasflowTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtCasflowTo.Size = new System.Drawing.Size(89, 25);
            this.dtCasflowTo.TabIndex = 190;
            this.dtCasflowTo.ValueChanged += new System.EventHandler(this.dtCasflowTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 191;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 192;
            this.label3.Text = "To";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 109);
            this.panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.50478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panMonthly, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panTodayFlow, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 109);
            this.tableLayoutPanel1.TabIndex = 200;
            // 
            // panMonthly
            // 
            this.panMonthly.AutoScroll = true;
            this.panMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panMonthly.Controls.Add(this.label2);
            this.panMonthly.Controls.Add(this.picMonthly);
            this.panMonthly.Controls.Add(this.lblMonthIncome);
            this.panMonthly.Controls.Add(this.lblCurIncome);
            this.panMonthly.Controls.Add(this.pictureBox4);
            this.panMonthly.Controls.Add(this.label8);
            this.panMonthly.Controls.Add(this.pictureBox7);
            this.panMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMonthly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panMonthly.Location = new System.Drawing.Point(3, 3);
            this.panMonthly.Name = "panMonthly";
            this.panMonthly.Size = new System.Drawing.Size(253, 103);
            this.panMonthly.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cur.>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Current month\'s income");
            // 
            // lblMonthIncome
            // 
            this.lblMonthIncome.AutoSize = true;
            this.lblMonthIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(176)))));
            this.lblMonthIncome.Location = new System.Drawing.Point(43, 43);
            this.lblMonthIncome.Name = "lblMonthIncome";
            this.lblMonthIncome.Size = new System.Drawing.Size(44, 20);
            this.lblMonthIncome.TabIndex = 5;
            this.lblMonthIncome.Text = "0.00";
            this.lblMonthIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurIncome
            // 
            this.lblCurIncome.AutoSize = true;
            this.lblCurIncome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblCurIncome.Location = new System.Drawing.Point(47, 77);
            this.lblCurIncome.Name = "lblCurIncome";
            this.lblCurIncome.Size = new System.Drawing.Size(49, 17);
            this.lblCurIncome.TabIndex = 4;
            this.lblCurIncome.Text = "0,00.00";
            this.lblCurIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCurIncome, "Current month\'s income");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Monthly Income";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblCashInBank);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lblCashAthand);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel4.Location = new System.Drawing.Point(506, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 103);
            this.panel4.TabIndex = 198;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(99, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "(Current month)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCashInBank
            // 
            this.lblCashInBank.AutoSize = true;
            this.lblCashInBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCashInBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lblCashInBank.Location = new System.Drawing.Point(28, 80);
            this.lblCashInBank.Name = "lblCashInBank";
            this.lblCashInBank.Size = new System.Drawing.Size(35, 15);
            this.lblCashInBank.TabIndex = 8;
            this.lblCashInBank.Text = "0.00";
            this.lblCashInBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label13.Location = new System.Drawing.Point(9, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cash in bank";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCashAthand
            // 
            this.lblCashAthand.AutoSize = true;
            this.lblCashAthand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCashAthand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lblCashAthand.Location = new System.Drawing.Point(32, 31);
            this.lblCashAthand.Name = "lblCashAthand";
            this.lblCashAthand.Size = new System.Drawing.Size(35, 15);
            this.lblCashAthand.TabIndex = 5;
            this.lblCashAthand.Text = "0.00";
            this.lblCashAthand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label11.Location = new System.Drawing.Point(4, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cash at hand";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTodayFlow
            // 
            this.panTodayFlow.AutoScroll = true;
            this.panTodayFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panTodayFlow.Controls.Add(this.dateCash);
            this.panTodayFlow.Controls.Add(this.lblTodayBank);
            this.panTodayFlow.Controls.Add(this.pictureBox5);
            this.panTodayFlow.Controls.Add(this.label12);
            this.panTodayFlow.Controls.Add(this.lblTodayCash);
            this.panTodayFlow.Controls.Add(this.pictureBox6);
            this.panTodayFlow.Controls.Add(this.label15);
            this.panTodayFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTodayFlow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panTodayFlow.Location = new System.Drawing.Point(721, 3);
            this.panTodayFlow.Name = "panTodayFlow";
            this.panTodayFlow.Size = new System.Drawing.Size(235, 103);
            this.panTodayFlow.TabIndex = 200;
            // 
            // dateCash
            // 
            this.dateCash.CalendarFont = new System.Drawing.Font("Segoe UI", 18F);
            this.dateCash.CustomFormat = "dd/MM/yyyy";
            this.dateCash.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateCash.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCash.Location = new System.Drawing.Point(51, 3);
            this.dateCash.Name = "dateCash";
            this.dateCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateCash.Size = new System.Drawing.Size(88, 25);
            this.dateCash.TabIndex = 190;
            this.dateCash.ValueChanged += new System.EventHandler(this.dateCash_ValueChanged);
            // 
            // lblTodayBank
            // 
            this.lblTodayBank.AutoSize = true;
            this.lblTodayBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTodayBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lblTodayBank.Location = new System.Drawing.Point(28, 80);
            this.lblTodayBank.Name = "lblTodayBank";
            this.lblTodayBank.Size = new System.Drawing.Size(35, 15);
            this.lblTodayBank.TabIndex = 8;
            this.lblTodayBank.Text = "0.00";
            this.lblTodayBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTodayBank, "cash in bank");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(9, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "In bank";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayCash
            // 
            this.lblTodayCash.AutoSize = true;
            this.lblTodayCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTodayCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.lblTodayCash.Location = new System.Drawing.Point(32, 31);
            this.lblTodayCash.Name = "lblTodayCash";
            this.lblTodayCash.Size = new System.Drawing.Size(35, 15);
            this.lblTodayCash.TabIndex = 5;
            this.lblTodayCash.Text = "0.00";
            this.lblTodayCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTodayCash, "Cash at hand");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label15.Location = new System.Drawing.Point(4, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cash";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblTodayDebt);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.picMoneyBag);
            this.panel3.Controls.Add(this.lblMonthExpense);
            this.panel3.Controls.Add(this.lblCurExpense);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Location = new System.Drawing.Point(262, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 103);
            this.panel3.TabIndex = 197;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(131, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Td.>";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label10, "Today debt");
            // 
            // lblTodayDebt
            // 
            this.lblTodayDebt.AutoSize = true;
            this.lblTodayDebt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTodayDebt.Location = new System.Drawing.Point(169, 84);
            this.lblTodayDebt.Name = "lblTodayDebt";
            this.lblTodayDebt.Size = new System.Drawing.Size(49, 17);
            this.lblTodayDebt.TabIndex = 11;
            this.lblTodayDebt.Text = "0,00.00";
            this.lblTodayDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTodayDebt, "Today debt");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cur.>";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label6, "current month\'s debt");
            // 
            // lblMonthExpense
            // 
            this.lblMonthExpense.AutoSize = true;
            this.lblMonthExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(219)))), ((int)(((byte)(230)))));
            this.lblMonthExpense.Location = new System.Drawing.Point(43, 46);
            this.lblMonthExpense.Name = "lblMonthExpense";
            this.lblMonthExpense.Size = new System.Drawing.Size(44, 20);
            this.lblMonthExpense.TabIndex = 5;
            this.lblMonthExpense.Text = "0.00";
            this.lblMonthExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurExpense
            // 
            this.lblCurExpense.AutoSize = true;
            this.lblCurExpense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblCurExpense.Location = new System.Drawing.Point(52, 83);
            this.lblCurExpense.Name = "lblCurExpense";
            this.lblCurExpense.Size = new System.Drawing.Size(49, 17);
            this.lblCurExpense.TabIndex = 4;
            this.lblCurExpense.Text = "0,00.00";
            this.lblCurExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCurExpense, "current month\'s debt");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monthly Debt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitTimer
            // 
            this.WaitTimer.Interval = 10;
            this.WaitTimer.Tick += new System.EventHandler(this.WaitTimer_Tick);
            // 
            // lblInfor
            // 
            this.lblInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.lblInfor.Location = new System.Drawing.Point(0, 274);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(387, 26);
            this.lblInfor.TabIndex = 10;
            this.lblInfor.Text = "Please wait... preparing print page";
            this.lblInfor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picMonthly
            // 
            this.picMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMonthly.Image = global::PrintingPress.Properties.Resources.icons8_money_bag_100px_1;
            this.picMonthly.Location = new System.Drawing.Point(-267, 19);
            this.picMonthly.Name = "picMonthly";
            this.picMonthly.Size = new System.Drawing.Size(68, 65);
            this.picMonthly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonthly.TabIndex = 6;
            this.picMonthly.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PrintingPress.Properties.Resources.icons8_naira_48px;
            this.pictureBox4.Location = new System.Drawing.Point(13, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::PrintingPress.Properties.Resources.icons8_money_bag_100px_1;
            this.pictureBox7.Location = new System.Drawing.Point(184, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 65);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintingPress.Properties.Resources.icons8_naira_24px;
            this.pictureBox1.Location = new System.Drawing.Point(8, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PrintingPress.Properties.Resources.icons8_naira_24px;
            this.pictureBox3.Location = new System.Drawing.Point(8, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PrintingPress.Properties.Resources.icons8_naira_24px;
            this.pictureBox5.Location = new System.Drawing.Point(8, 79);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PrintingPress.Properties.Resources.icons8_naira_24px;
            this.pictureBox6.Location = new System.Drawing.Point(8, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // picMoneyBag
            // 
            this.picMoneyBag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMoneyBag.Image = global::PrintingPress.Properties.Resources.icons8_money_bag_100px;
            this.picMoneyBag.Location = new System.Drawing.Point(168, 15);
            this.picMoneyBag.Name = "picMoneyBag";
            this.picMoneyBag.Size = new System.Drawing.Size(67, 65);
            this.picMoneyBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMoneyBag.TabIndex = 6;
            this.picMoneyBag.TabStop = false;
            this.picMoneyBag.Click += new System.EventHandler(this.picMoneyBag_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrintingPress.Properties.Resources.icons8_naira_48px;
            this.pictureBox2.Location = new System.Drawing.Point(13, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            this.picWait.Size = new System.Drawing.Size(197, 153);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWait.TabIndex = 0;
            this.picWait.TabStop = false;
            this.toolTip1.SetToolTip(this.picWait, "Please wait");
            // 
            // linkView
            // 
            this.linkView.AutoSize = true;
            this.linkView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkView.Image = global::PrintingPress.Properties.Resources.icons8_eye_24px;
            this.linkView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkView.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkView.Location = new System.Drawing.Point(504, 8);
            this.linkView.Name = "linkView";
            this.linkView.Size = new System.Drawing.Size(73, 21);
            this.linkView.TabIndex = 203;
            this.linkView.TabStop = true;
            this.linkView.Text = "       item ";
            this.toolTip1.SetToolTip(this.linkView, "view invoice items");
            this.linkView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkView_LinkClicked);
            // 
            // linkPrintRecords
            // 
            this.linkPrintRecords.AutoSize = true;
            this.linkPrintRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPrintRecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkPrintRecords.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkPrintRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPrintRecords.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPrintRecords.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkPrintRecords.Location = new System.Drawing.Point(434, 8);
            this.linkPrintRecords.Name = "linkPrintRecords";
            this.linkPrintRecords.Size = new System.Drawing.Size(63, 21);
            this.linkPrintRecords.TabIndex = 202;
            this.linkPrintRecords.TabStop = true;
            this.linkPrintRecords.Text = "     Print";
            this.linkPrintRecords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrintRecords_LinkClicked);
            // 
            // linkReceipt
            // 
            this.linkReceipt.AutoSize = true;
            this.linkReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkReceipt.Image = global::PrintingPress.Properties.Resources.icons8_receipt_24px;
            this.linkReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReceipt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkReceipt.Location = new System.Drawing.Point(584, 7);
            this.linkReceipt.Name = "linkReceipt";
            this.linkReceipt.Size = new System.Drawing.Size(81, 21);
            this.linkReceipt.TabIndex = 199;
            this.linkReceipt.TabStop = true;
            this.linkReceipt.Text = "     Receipt";
            this.toolTip1.SetToolTip(this.linkReceipt, "Print receipt");
            this.linkReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReceipt_LinkClicked);
            // 
            // linkDelCashflow
            // 
            this.linkDelCashflow.AutoSize = true;
            this.linkDelCashflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDelCashflow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkDelCashflow.Image = global::PrintingPress.Properties.Resources.Cancel_20px;
            this.linkDelCashflow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDelCashflow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDelCashflow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkDelCashflow.Location = new System.Drawing.Point(357, 8);
            this.linkDelCashflow.Name = "linkDelCashflow";
            this.linkDelCashflow.Size = new System.Drawing.Size(74, 21);
            this.linkDelCashflow.TabIndex = 196;
            this.linkDelCashflow.TabStop = true;
            this.linkDelCashflow.Text = "     Delete";
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
            this.linkCashRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))));
            this.linkCashRefresh.Location = new System.Drawing.Point(267, 8);
            this.linkCashRefresh.Name = "linkCashRefresh";
            this.linkCashRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkCashRefresh.TabIndex = 195;
            this.linkCashRefresh.TabStop = true;
            this.linkCashRefresh.Text = "     Refresh";
            this.linkCashRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCashRefresh_LinkClicked);
            // 
            // ViewInvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(959, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pandHeader);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewInvoiceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Record";
            this.Load += new System.EventHandler(this.ViewInvoiceFrm_Load);
            this.pandHeader.ResumeLayout(false);
            this.pandHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panMonthly.ResumeLayout(false);
            this.panMonthly.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panTodayFlow.ResumeLayout(false);
            this.panTodayFlow.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoneyBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer totalsTimer;
        private System.Windows.Forms.Panel pandHeader;
        private System.Windows.Forms.Label lblPageHeading;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbHeading;
        private System.Windows.Forms.LinkLabel linkDelCashflow;
        private System.Windows.Forms.LinkLabel linkCashRefresh;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DateTimePicker dtCasflowFrom;
        private System.Windows.Forms.DateTimePicker dtCasflowTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCashInBank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCashAthand;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picMoneyBag;
        private System.Windows.Forms.Label lblMonthExpense;
        private System.Windows.Forms.Label lblCurExpense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panMonthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMonthly;
        private System.Windows.Forms.Label lblMonthIncome;
        private System.Windows.Forms.Label lblCurIncome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panTodayFlow;
        private System.Windows.Forms.Label lblTodayBank;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTodayCash;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTodayDebt;
        private System.Windows.Forms.LinkLabel linkReceipt;
        private System.Windows.Forms.DateTimePicker dateCash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panWait;
        private System.Windows.Forms.PictureBox picWait;
        private System.Windows.Forms.Timer WaitTimer;
        private System.Windows.Forms.LinkLabel linkPrintRecords;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel linkView;
        private System.Windows.Forms.Label lblInfor;
    }
}