namespace PrintingPress.API.Income_expense
{
    partial class InvoiceGenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceGenFrm));
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeadCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHeading = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCustomerInfor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvoiceItems = new System.Windows.Forms.GroupBox();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picWait = new System.Windows.Forms.PictureBox();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.panHeader.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCustomerInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.dgInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.Salmon;
            this.panHeader.Controls.Add(this.lblHeader);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(887, 37);
            this.panHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 30);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Prepare invoice";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.groupBox1);
            this.gbDetails.Controls.Add(this.gbCustomerInfor);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbDetails.Location = new System.Drawing.Point(6, 43);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(319, 391);
            this.gbDetails.TabIndex = 8;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHeadCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbHeading);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.lblHeading);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(5, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 241);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // lblHeadCode
            // 
            this.lblHeadCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeadCode.Location = new System.Drawing.Point(217, 99);
            this.lblHeadCode.Name = "lblHeadCode";
            this.lblHeadCode.Size = new System.Drawing.Size(98, 21);
            this.lblHeadCode.TabIndex = 74;
            this.lblHeadCode.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Heading";
            // 
            // cmbHeading
            // 
            this.cmbHeading.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHeading.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHeading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHeading.FormattingEnabled = true;
            this.cmbHeading.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbHeading.Location = new System.Drawing.Point(6, 39);
            this.cmbHeading.Name = "cmbHeading";
            this.cmbHeading.Size = new System.Drawing.Size(286, 25);
            this.cmbHeading.TabIndex = 2;
            this.cmbHeading.SelectedIndexChanged += new System.EventHandler(this.cmbHeading_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbCategory.Location = new System.Drawing.Point(7, 95);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 25);
            this.cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Image = global::PrintingPress.Properties.Resources.add_24px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(244, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAdd, "Add item to invoice");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Code";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtAmount.Location = new System.Drawing.Point(103, 206);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 29);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtDesc
            // 
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDesc.Location = new System.Drawing.Point(4, 152);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(288, 29);
            this.txtDesc.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(4, 128);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(122, 21);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Decription (size)";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQty.Location = new System.Drawing.Point(4, 206);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 29);
            this.txtQty.TabIndex = 5;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantity";
            // 
            // gbCustomerInfor
            // 
            this.gbCustomerInfor.Controls.Add(this.label6);
            this.gbCustomerInfor.Controls.Add(this.txtContact);
            this.gbCustomerInfor.Controls.Add(this.cmbCode);
            this.gbCustomerInfor.Controls.Add(this.lblCode);
            this.gbCustomerInfor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbCustomerInfor.Location = new System.Drawing.Point(8, 21);
            this.gbCustomerInfor.Name = "gbCustomerInfor";
            this.gbCustomerInfor.Size = new System.Drawing.Size(302, 114);
            this.gbCustomerInfor.TabIndex = 72;
            this.gbCustomerInfor.TabStop = false;
            this.gbCustomerInfor.Text = "Customer infor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContact.Location = new System.Drawing.Point(75, 79);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(219, 27);
            this.txtContact.TabIndex = 1;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // cmbCode
            // 
            this.cmbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbCode.Location = new System.Drawing.Point(6, 44);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(288, 28);
            this.cmbCode.TabIndex = 0;
            this.cmbCode.SelectedIndexChanged += new System.EventHandler(this.cmbCode_SelectedIndexChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(1, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(52, 21);
            this.lblCode.TabIndex = 19;
            this.lblCode.Text = "Name";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Description,
            this.Qty,
            this.Amount,
            this.Heading,
            this.Id});
            this.dgvDetails.Location = new System.Drawing.Point(6, 24);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(543, 308);
            this.dgvDetails.TabIndex = 10;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Heading
            // 
            this.Heading.HeaderText = "Heading";
            this.Heading.Name = "Heading";
            this.Heading.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // dgInvoiceItems
            // 
            this.dgInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvoiceItems.Controls.Add(this.dgvDetails);
            this.dgInvoiceItems.Controls.Add(this.btnPrepare);
            this.dgInvoiceItems.Controls.Add(this.btnRemove);
            this.dgInvoiceItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgInvoiceItems.Location = new System.Drawing.Point(332, 48);
            this.dgInvoiceItems.Name = "dgInvoiceItems";
            this.dgInvoiceItems.Size = new System.Drawing.Size(555, 386);
            this.dgInvoiceItems.TabIndex = 73;
            this.dgInvoiceItems.TabStop = false;
            this.dgInvoiceItems.Text = "Invoice Items";
            // 
            // btnPrepare
            // 
            this.btnPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrepare.FlatAppearance.BorderSize = 0;
            this.btnPrepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepare.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrepare.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnPrepare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepare.Location = new System.Drawing.Point(285, 345);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(93, 28);
            this.btnPrepare.TabIndex = 8;
            this.btnPrepare.Text = "Prepare";
            this.btnPrepare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemove.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(176, 345);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 28);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // picWait
            // 
            this.picWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWait.BackColor = System.Drawing.Color.White;
            this.picWait.Image = global::PrintingPress.Properties.Resources.Spinner2_1s_200px;
            this.picWait.Location = new System.Drawing.Point(185, 157);
            this.picWait.Name = "picWait";
            this.picWait.Size = new System.Drawing.Size(702, 294);
            this.picWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWait.TabIndex = 74;
            this.picWait.TabStop = false;
            this.toolTip1.SetToolTip(this.picWait, "Please wait");
            this.picWait.Visible = false;
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 10;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // InvoiceGenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 451);
            this.Controls.Add(this.picWait);
            this.Controls.Add(this.dgInvoiceItems);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.panHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceGenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceGenFrm_FormClosed);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCustomerInfor.ResumeLayout(false);
            this.gbCustomerInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.dgInvoiceItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.GroupBox gbCustomerInfor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox dgInvoiceItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHeading;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label lblHeadCode;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.PictureBox picWait;
    }
}