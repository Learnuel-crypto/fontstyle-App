namespace PrintingPress.API.Income_expense
{
    partial class InvoiceCompleteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceCompleteFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInBank = new System.Windows.Forms.TextBox();
            this.BankAmountlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMehtod = new System.Windows.Forms.ComboBox();
            this.panHead = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.BalancceLabel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblToal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInvoice = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtInBank);
            this.panel1.Controls.Add(this.BankAmountlabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkAuto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbMehtod);
            this.panel1.Controls.Add(this.panHead);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.BalancceLabel);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.lblCash);
            this.panel1.Controls.Add(this.lblToal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtInvoice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtInvoiceID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 303);
            this.panel1.TabIndex = 0;
            // 
            // txtInBank
            // 
            this.txtInBank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtInBank.Location = new System.Drawing.Point(86, 220);
            this.txtInBank.Name = "txtInBank";
            this.txtInBank.Size = new System.Drawing.Size(145, 29);
            this.txtInBank.TabIndex = 4;
            this.txtInBank.Visible = false;
            this.txtInBank.TextChanged += new System.EventHandler(this.txtInBank_TextChanged);
            this.txtInBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInBank_KeyDown);
            this.txtInBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInBank_KeyPress);
            // 
            // BankAmountlabel
            // 
            this.BankAmountlabel.AutoSize = true;
            this.BankAmountlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankAmountlabel.Location = new System.Drawing.Point(2, 223);
            this.BankAmountlabel.Name = "BankAmountlabel";
            this.BankAmountlabel.Size = new System.Drawing.Size(83, 21);
            this.BankAmountlabel.TabIndex = 90;
            this.BankAmountlabel.Text = "Bank Amt.:";
            this.BankAmountlabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProceed);
            this.panel2.Controls.Add(this.btnCancell);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 46);
            this.panel2.TabIndex = 88;
            // 
            // btnProceed
            // 
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProceed.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.Location = new System.Drawing.Point(115, 7);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(96, 28);
            this.btnProceed.TabIndex = 5;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.FlatAppearance.BorderSize = 0;
            this.btnCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancell.Image = global::PrintingPress.Properties.Resources.Cancel_24px;
            this.btnCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancell.Location = new System.Drawing.Point(21, 7);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(89, 28);
            this.btnCancell.TabIndex = 6;
            this.btnCancell.Text = "Cancel";
            this.btnCancell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAuto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkAuto.Location = new System.Drawing.Point(173, 38);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(58, 23);
            this.checkAuto.TabIndex = 7;
            this.checkAuto.Text = "Auto";
            this.toolTip1.SetToolTip(this.checkAuto, "auto generate invoice number");
            this.checkAuto.UseVisualStyleBackColor = true;
            this.checkAuto.Click += new System.EventHandler(this.checkAuto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 86;
            this.label9.Text = "Method:";
            // 
            // cmbMehtod
            // 
            this.cmbMehtod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMehtod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMehtod.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMehtod.FormattingEnabled = true;
            this.cmbMehtod.Items.AddRange(new object[] {
            "Cash",
            "Transfer",
            "Bank",
            "POS",
            "Cash & Transfer",
            "Cash & Bank",
            "Cash & POS"});
            this.cmbMehtod.Location = new System.Drawing.Point(86, 102);
            this.cmbMehtod.Name = "cmbMehtod";
            this.cmbMehtod.Size = new System.Drawing.Size(145, 28);
            this.cmbMehtod.TabIndex = 2;
            this.cmbMehtod.SelectedIndexChanged += new System.EventHandler(this.cmbMehtod_SelectedIndexChanged);
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.Black;
            this.panHead.Controls.Add(this.label8);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(238, 21);
            this.panHead.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 81;
            this.label8.Text = "Complete invoice";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblBalance.Location = new System.Drawing.Point(86, 192);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 21);
            this.lblBalance.TabIndex = 83;
            this.lblBalance.Text = "Total:";
            // 
            // BalancceLabel
            // 
            this.BalancceLabel.AutoSize = true;
            this.BalancceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalancceLabel.Location = new System.Drawing.Point(10, 193);
            this.BalancceLabel.Name = "BalancceLabel";
            this.BalancceLabel.Size = new System.Drawing.Size(66, 21);
            this.BalancceLabel.TabIndex = 82;
            this.BalancceLabel.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtAmount.Location = new System.Drawing.Point(86, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(145, 29);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(5, 163);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(79, 21);
            this.lblCash.TabIndex = 80;
            this.lblCash.Text = "Paid Amt.:";
            // 
            // lblToal
            // 
            this.lblToal.AutoSize = true;
            this.lblToal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblToal.Location = new System.Drawing.Point(86, 135);
            this.lblToal.Name = "lblToal";
            this.lblToal.Size = new System.Drawing.Size(41, 21);
            this.lblToal.TabIndex = 79;
            this.lblToal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Total:";
            // 
            // dtInvoice
            // 
            this.dtInvoice.CustomFormat = "dd/MM/yyyy";
            this.dtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvoice.Location = new System.Drawing.Point(63, 35);
            this.dtInvoice.Name = "dtInvoice";
            this.dtInvoice.Size = new System.Drawing.Size(104, 26);
            this.dtInvoice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Date:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceID.Location = new System.Drawing.Point(86, 67);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(145, 29);
            this.txtInvoiceID.TabIndex = 0;
            this.txtInvoiceID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Invoice ID:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // totalTimer
            // 
            this.totalTimer.Interval = 1000;
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
            // 
            // InvoiceCompleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 303);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceCompleteFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Complete prepare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceCompleteFrm_FormClosed);
            this.Load += new System.EventHandler(this.InvoiceCompleteFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtInvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label BalancceLabel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblToal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMehtod;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Timer totalTimer;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInBank;
        private System.Windows.Forms.Label BankAmountlabel;
    }
}