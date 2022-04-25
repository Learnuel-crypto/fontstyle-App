namespace PrintingPress.API.General_reports
{
    partial class GeneralReportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralReportFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkReceipt = new System.Windows.Forms.LinkLabel();
            this.crpReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 29);
            this.panel1.TabIndex = 0;
            // 
            // linkReceipt
            // 
            this.linkReceipt.AutoSize = true;
            this.linkReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linkReceipt.Image = global::PrintingPress.Properties.Resources.Print_20px;
            this.linkReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkReceipt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkReceipt.Location = new System.Drawing.Point(694, 5);
            this.linkReceipt.Name = "linkReceipt";
            this.linkReceipt.Size = new System.Drawing.Size(63, 21);
            this.linkReceipt.TabIndex = 189;
            this.linkReceipt.TabStop = true;
            this.linkReceipt.Text = "     Print";
            this.linkReceipt.Visible = false;
            // 
            // crpReportViewer
            // 
            this.crpReportViewer.ActiveViewIndex = -1;
            this.crpReportViewer.AutoScroll = true;
            this.crpReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crpReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpReportViewer.Location = new System.Drawing.Point(0, 29);
            this.crpReportViewer.Name = "crpReportViewer";
            this.crpReportViewer.ReuseParameterValuesOnRefresh = true;
            this.crpReportViewer.ShowRefreshButton = false;
            this.crpReportViewer.Size = new System.Drawing.Size(769, 576);
            this.crpReportViewer.TabIndex = 1;
            this.crpReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // GeneralReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 605);
            this.Controls.Add(this.crpReportViewer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralReportFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpReportViewer;
        private System.Windows.Forms.LinkLabel linkReceipt;

       
    }
}