namespace PrintingPress.API.Startups
{
    partial class CreateUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserFrm));
            this.label6 = new System.Windows.Forms.Label();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.combRole = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Create Staff Account";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.checkActive.Location = new System.Drawing.Point(12, 318);
            this.checkActive.Margin = new System.Windows.Forms.Padding(2);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(82, 25);
            this.checkActive.TabIndex = 100;
            this.checkActive.Text = "Active";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.Label17.Location = new System.Drawing.Point(18, 145);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(88, 21);
            this.Label17.TabIndex = 94;
            this.Label17.Text = "Username";
            // 
            // combRole
            // 
            this.combRole.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.combRole.FormattingEnabled = true;
            this.combRole.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Secretary",
            "Designer",
            "Operator"});
            this.combRole.Location = new System.Drawing.Point(12, 280);
            this.combRole.Name = "combRole";
            this.combRole.Size = new System.Drawing.Size(246, 29);
            this.combRole.TabIndex = 99;
            this.combRole.Text = "choose role";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(12, 169);
            this.txtUsername.MaxLength = 500;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 27);
            this.txtUsername.TabIndex = 97;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.Label4.Location = new System.Drawing.Point(18, 253);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 21);
            this.Label4.TabIndex = 95;
            this.Label4.Text = "Role";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.Label18.Location = new System.Drawing.Point(18, 199);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(82, 21);
            this.Label18.TabIndex = 96;
            this.Label18.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 27);
            this.txtPassword.TabIndex = 98;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 113;
            this.label3.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(12, 115);
            this.txtContact.MaxLength = 500;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(246, 27);
            this.txtContact.TabIndex = 111;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 112;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 59);
            this.txtName.MaxLength = 500;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 27);
            this.txtName.TabIndex = 110;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreate.Image = global::PrintingPress.Properties.Resources.Ok_24px;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(174, 338);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 28);
            this.btnCreate.TabIndex = 114;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 374);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.combRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create user account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkActive;
        internal System.Windows.Forms.Label Label17;
        private System.Windows.Forms.ComboBox combRole;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
    }
}