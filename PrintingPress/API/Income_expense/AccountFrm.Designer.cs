namespace PrintingPress.API.Income_expense
{
    partial class AccountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountFrm));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.linkReport = new System.Windows.Forms.LinkLabel();
            this.lblPrint = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkCandH = new System.Windows.Forms.CheckBox();
            this.cmbHeadingList = new System.Windows.Forms.ComboBox();
            this.cmbCodeList = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CashFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CashCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panReport = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listFields = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExpenseHeadingList = new System.Windows.Forms.DataGridView();
            this.gbDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseHeadingList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.checkDate);
            this.gbDetails.Controls.Add(this.linkReport);
            this.gbDetails.Controls.Add(this.lblPrint);
            this.gbDetails.Controls.Add(this.txtSearch);
            this.gbDetails.Controls.Add(this.linkRefresh);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.checkCandH);
            this.gbDetails.Controls.Add(this.cmbHeadingList);
            this.gbDetails.Controls.Add(this.cmbCodeList);
            this.gbDetails.Controls.Add(this.dtpTo);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.dtpFrom);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbDetails.Location = new System.Drawing.Point(4, 27);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(620, 116);
            this.gbDetails.TabIndex = 172;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Search";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkDate.Location = new System.Drawing.Point(509, 84);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(100, 25);
            this.checkDate.TabIndex = 176;
            this.checkDate.Text = "From date";
            this.checkDate.UseVisualStyleBackColor = true;
            // 
            // linkReport
            // 
            this.linkReport.AutoSize = true;
            this.linkReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkReport.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReport.Location = new System.Drawing.Point(278, 87);
            this.linkReport.Name = "linkReport";
            this.linkReport.Size = new System.Drawing.Size(136, 21);
            this.linkReport.TabIndex = 6;
            this.linkReport.TabStop = true;
            this.linkReport.Text = "    Generate report";
            this.linkReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReport_LinkClicked);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrint.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.lblPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrint.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblPrint.Location = new System.Drawing.Point(422, 87);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(59, 21);
            this.lblPrint.TabIndex = 7;
            this.lblPrint.TabStop = true;
            this.lblPrint.Text = "    Print";
            this.lblPrint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPrint_LinkClicked);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(206, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkRefresh.Image = global::PrintingPress.Properties.Resources.Replace_20px1;
            this.linkRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRefresh.Location = new System.Drawing.Point(187, 86);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(83, 21);
            this.linkRefresh.TabIndex = 5;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "     Refresh";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefresh_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "Heading";
            // 
            // checkCandH
            // 
            this.checkCandH.AutoSize = true;
            this.checkCandH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkCandH.Location = new System.Drawing.Point(24, 84);
            this.checkCandH.Name = "checkCandH";
            this.checkCandH.Size = new System.Drawing.Size(155, 25);
            this.checkCandH.TabIndex = 4;
            this.checkCandH.Text = "Code and heading";
            this.checkCandH.UseVisualStyleBackColor = true;
            // 
            // cmbHeadingList
            // 
            this.cmbHeadingList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHeadingList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHeadingList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHeadingList.FormattingEnabled = true;
            this.cmbHeadingList.Location = new System.Drawing.Point(81, 21);
            this.cmbHeadingList.Name = "cmbHeadingList";
            this.cmbHeadingList.Size = new System.Drawing.Size(347, 25);
            this.cmbHeadingList.TabIndex = 1;
            this.cmbHeadingList.SelectedIndexChanged += new System.EventHandler(this.cmbHeadingList_SelectedIndexChanged);
            // 
            // cmbCodeList
            // 
            this.cmbCodeList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCodeList.FormattingEnabled = true;
            this.cmbCodeList.Location = new System.Drawing.Point(81, 52);
            this.cmbCodeList.Name = "cmbCodeList";
            this.cmbCodeList.Size = new System.Drawing.Size(115, 29);
            this.cmbCodeList.TabIndex = 2;
            this.cmbCodeList.SelectedIndexChanged += new System.EventHandler(this.cmbCodeList_SelectedIndexChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyy-mm-dd";
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(498, 49);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(111, 29);
            this.dtpTo.TabIndex = 9;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(470, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 21);
            this.label9.TabIndex = 175;
            this.label9.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Code";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyy-mm-dd";
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(498, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(111, 29);
            this.dtpFrom.TabIndex = 8;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(450, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 173;
            this.label8.Text = "From";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 29);
            this.menuStrip1.TabIndex = 173;
            this.menuStrip1.Text = "ExpenseMenu";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CashFlowToolStripMenuItem,
            this.CashCodesToolStripMenuItem,
            this.jobFlowToolStripMenuItem});
            this.setupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setupToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.Settings_24px;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // CashFlowToolStripMenuItem
            // 
            this.CashFlowToolStripMenuItem.Name = "CashFlowToolStripMenuItem";
            this.CashFlowToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.CashFlowToolStripMenuItem.Text = "Cash Flow Format";
            this.CashFlowToolStripMenuItem.Click += new System.EventHandler(this.CashFlowToolStripMenuItem_Click);
            // 
            // CashCodesToolStripMenuItem
            // 
            this.CashCodesToolStripMenuItem.Name = "CashCodesToolStripMenuItem";
            this.CashCodesToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.CashCodesToolStripMenuItem.Text = "Cash Codes";
            this.CashCodesToolStripMenuItem.Click += new System.EventHandler(this.CashCodesToolStripMenuItem_Click);
            // 
            // jobFlowToolStripMenuItem
            // 
            this.jobFlowToolStripMenuItem.Name = "jobFlowToolStripMenuItem";
            this.jobFlowToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.jobFlowToolStripMenuItem.Text = "Job Category";
            this.jobFlowToolStripMenuItem.Click += new System.EventHandler(this.jobFlowToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewToolStripMenuItem.Image = global::PrintingPress.Properties.Resources.Visible_30px;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.viewToolStripMenuItem.Text = "View ";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.expenseToolStripMenuItem.Text = "Cash Flow";
            // 
            // panReport
            // 
            this.panReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panReport.Controls.Add(this.btnAdd);
            this.panReport.Controls.Add(this.cmbCategory);
            this.panReport.Controls.Add(this.label2);
            this.panReport.Controls.Add(this.btnClose);
            this.panReport.Controls.Add(this.btnRemove);
            this.panReport.Controls.Add(this.listFields);
            this.panReport.Controls.Add(this.label1);
            this.panReport.Controls.Add(this.btnOk);
            this.panReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panReport.Location = new System.Drawing.Point(293, 153);
            this.panReport.Name = "panReport";
            this.panReport.Size = new System.Drawing.Size(308, 314);
            this.panReport.TabIndex = 174;
            this.panReport.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Image = global::PrintingPress.Properties.Resources.add_24px;
            this.btnAdd.Location = new System.Drawing.Point(273, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 28);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(9, 57);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(258, 25);
            this.cmbCategory.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Category";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.Image = global::PrintingPress.Properties.Resources.Cancel_20px;
            this.btnClose.Location = new System.Drawing.Point(275, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemove.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.btnRemove.Location = new System.Drawing.Point(212, 277);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(27, 28);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listFields
            // 
            this.listFields.FormattingEnabled = true;
            this.listFields.ItemHeight = 21;
            this.listFields.Location = new System.Drawing.Point(6, 99);
            this.listFields.Name = "listFields";
            this.listFields.Size = new System.Drawing.Size(294, 172);
            this.listFields.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Category";
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOk.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnOk.Location = new System.Drawing.Point(273, 277);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(27, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvExpenseHeadingList);
            this.groupBox2.Location = new System.Drawing.Point(6, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 338);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            // 
            // dgvExpenseHeadingList
            // 
            this.dgvExpenseHeadingList.AllowUserToAddRows = false;
            this.dgvExpenseHeadingList.AllowUserToDeleteRows = false;
            this.dgvExpenseHeadingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenseHeadingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseHeadingList.Location = new System.Drawing.Point(2, 19);
            this.dgvExpenseHeadingList.Name = "dgvExpenseHeadingList";
            this.dgvExpenseHeadingList.ReadOnly = true;
            this.dgvExpenseHeadingList.Size = new System.Drawing.Size(614, 318);
            this.dgvExpenseHeadingList.TabIndex = 0;
            this.dgvExpenseHeadingList.DoubleClick += new System.EventHandler(this.dgvExpenseHeadingList_DoubleClick);
            // 
            // AccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 496);
            this.Controls.Add(this.panReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.AccountFrm_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panReport.ResumeLayout(false);
            this.panReport.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseHeadingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.LinkLabel linkReport;
        private System.Windows.Forms.LinkLabel lblPrint;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkCandH;
        private System.Windows.Forms.ComboBox cmbHeadingList;
        private System.Windows.Forms.ComboBox cmbCodeList;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.Panel panReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExpenseHeadingList;
        private System.Windows.Forms.ToolStripMenuItem jobFlowToolStripMenuItem;
    }
}