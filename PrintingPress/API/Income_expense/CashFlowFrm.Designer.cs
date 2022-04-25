namespace PrintingPress.API.Income_expense
{
    partial class CashFlowFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashFlowFrm));
            this.linkSetExpense = new System.Windows.Forms.LinkLabel();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.cmbHeading = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtexpensename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panDrag = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panBody = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbTransc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panDrag.SuspendLayout();
            this.panBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkSetExpense
            // 
            this.linkSetExpense.AutoSize = true;
            this.linkSetExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkSetExpense.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkSetExpense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSetExpense.Location = new System.Drawing.Point(5, 262);
            this.linkSetExpense.Name = "linkSetExpense";
            this.linkSetExpense.Size = new System.Drawing.Size(92, 21);
            this.linkSetExpense.TabIndex = 72;
            this.linkSetExpense.TabStop = true;
            this.linkSetExpense.Text = "Set expense";
            this.linkSetExpense.Visible = false;
            // 
            // cmbCode
            // 
            this.cmbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(70, 29);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(122, 25);
            this.cmbCode.TabIndex = 60;
            this.cmbCode.SelectedIndexChanged += new System.EventHandler(this.cmbCode_SelectedIndexChanged);
            // 
            // cmbHeading
            // 
            this.cmbHeading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHeading.FormattingEnabled = true;
            this.cmbHeading.Location = new System.Drawing.Point(70, 63);
            this.cmbHeading.Name = "cmbHeading";
            this.cmbHeading.Size = new System.Drawing.Size(294, 25);
            this.cmbHeading.TabIndex = 61;
            this.cmbHeading.SelectedIndexChanged += new System.EventHandler(this.cmbHeading_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Heading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Code";
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CustomFormat = "yyy-mm-dd";
            this.dateTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(70, 202);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(120, 26);
            this.dateTimeDate.TabIndex = 69;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(222, 254);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 29);
            this.btnSubmit.TabIndex = 67;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Desc.";
            // 
            // txtcost
            // 
            this.txtcost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcost.Location = new System.Drawing.Point(70, 165);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(159, 29);
            this.txtcost.TabIndex = 63;
            this.txtcost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcost_KeyDown);
            this.txtcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcost_KeyPress);
            // 
            // txtexpensename
            // 
            this.txtexpensename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtexpensename.Location = new System.Drawing.Point(70, 94);
            this.txtexpensename.Name = "txtexpensename";
            this.txtexpensename.Size = new System.Drawing.Size(294, 29);
            this.txtexpensename.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cost";
            // 
            // panDrag
            // 
            this.panDrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panDrag.Controls.Add(this.lblHeading);
            this.panDrag.Controls.Add(this.btnclose);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(0, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(382, 22);
            this.panDrag.TabIndex = 64;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(3, 1);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(71, 20);
            this.lblHeading.TabIndex = 35;
            this.lblHeading.Text = "Expense";
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(356, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 22);
            this.btnclose.TabIndex = 19;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panBody
            // 
            this.panBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBody.Controls.Add(this.btnExit);
            this.panBody.Controls.Add(this.cmbTransc);
            this.panBody.Controls.Add(this.label7);
            this.panBody.Controls.Add(this.linkSetExpense);
            this.panBody.Controls.Add(this.cmbCode);
            this.panBody.Controls.Add(this.cmbHeading);
            this.panBody.Controls.Add(this.label6);
            this.panBody.Controls.Add(this.label4);
            this.panBody.Controls.Add(this.dateTimeDate);
            this.panBody.Controls.Add(this.btnSubmit);
            this.panBody.Controls.Add(this.label3);
            this.panBody.Controls.Add(this.label1);
            this.panBody.Controls.Add(this.txtcost);
            this.panBody.Controls.Add(this.txtexpensename);
            this.panBody.Controls.Add(this.label2);
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(0, 22);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(382, 314);
            this.panBody.TabIndex = 73;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Blue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(128, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 29);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "Close";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbTransc
            // 
            this.cmbTransc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTransc.FormattingEnabled = true;
            this.cmbTransc.Items.AddRange(new object[] {
            "Cash",
            "Transfer",
            "Bank",
            "POS"});
            this.cmbTransc.Location = new System.Drawing.Point(70, 134);
            this.cmbTransc.Name = "cmbTransc";
            this.cmbTransc.Size = new System.Drawing.Size(159, 25);
            this.cmbTransc.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Transc.";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // CashFlowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 336);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.panDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashFlowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashFlowFrm";
            this.panDrag.ResumeLayout(false);
            this.panDrag.PerformLayout();
            this.panBody.ResumeLayout(false);
            this.panBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkSetExpense;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.ComboBox cmbHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtexpensename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panDrag;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panBody;
        private System.Windows.Forms.ComboBox cmbTransc;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnExit;
    }
}