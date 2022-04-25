namespace PrintingPress.API.Reports.Invoice_receipt
{
    partial class CRInvoiceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRInvoiceFrm));
            this.CRPInvoiceViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panHead = new System.Windows.Forms.Panel();
            this.linkClose = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRPInvoiceViewer
            // 
            this.CRPInvoiceViewer.ActiveViewIndex = -1;
            this.CRPInvoiceViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRPInvoiceViewer.AutoSize = true;
            this.CRPInvoiceViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPInvoiceViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPInvoiceViewer.Location = new System.Drawing.Point(0, 29);
            this.CRPInvoiceViewer.Name = "CRPInvoiceViewer";
            this.CRPInvoiceViewer.ShowGotoPageButton = false;
            this.CRPInvoiceViewer.ShowGroupTreeButton = false;
            this.CRPInvoiceViewer.ShowParameterPanelButton = false;
            this.CRPInvoiceViewer.ShowRefreshButton = false;
            this.CRPInvoiceViewer.ShowTextSearchButton = false;
            this.CRPInvoiceViewer.Size = new System.Drawing.Size(356, 472);
            this.CRPInvoiceViewer.TabIndex = 0;
            this.CRPInvoiceViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panHead
            // 
            this.panHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHead.Controls.Add(this.linkClose);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Cursor = System.Windows.Forms.Cursors.Default;
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(356, 29);
            this.panHead.TabIndex = 1;
            // 
            // linkClose
            // 
            this.linkClose.ActiveLinkColor = System.Drawing.Color.White;
            this.linkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkClose.BackColor = System.Drawing.Color.Red;
            this.linkClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkClose.LinkColor = System.Drawing.Color.White;
            this.linkClose.Location = new System.Drawing.Point(309, 0);
            this.linkClose.Name = "linkClose";
            this.linkClose.Size = new System.Drawing.Size(46, 22);
            this.linkClose.TabIndex = 1;
            this.linkClose.TabStop = true;
            this.linkClose.Text = "X";
            this.linkClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClose_LinkClicked);
            this.linkClose.Click += new System.EventHandler(this.linkClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt Preview";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // CRInvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 501);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.CRPInvoiceViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRInvoiceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRPInvoiceViewer;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}