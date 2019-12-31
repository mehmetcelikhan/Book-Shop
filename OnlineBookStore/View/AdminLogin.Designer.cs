namespace OnlineBookStore
{
    partial class AdminLogin
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
            this.tbLoginAdminUsername = new System.Windows.Forms.TextBox();
            this.tbLoginAdminPassword = new System.Windows.Forms.TextBox();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.llMainLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbLoginAdminUsername
            // 
            this.tbLoginAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginAdminUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLoginAdminUsername.Location = new System.Drawing.Point(42, 62);
            this.tbLoginAdminUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginAdminUsername.Multiline = true;
            this.tbLoginAdminUsername.Name = "tbLoginAdminUsername";
            this.tbLoginAdminUsername.Size = new System.Drawing.Size(228, 36);
            this.tbLoginAdminUsername.TabIndex = 1;
            this.tbLoginAdminUsername.Text = "admin";
            this.tbLoginAdminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLoginAdminPassword
            // 
            this.tbLoginAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginAdminPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLoginAdminPassword.Location = new System.Drawing.Point(42, 102);
            this.tbLoginAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginAdminPassword.Multiline = true;
            this.tbLoginAdminPassword.Name = "tbLoginAdminPassword";
            this.tbLoginAdminPassword.Size = new System.Drawing.Size(228, 36);
            this.tbLoginAdminPassword.TabIndex = 2;
            this.tbLoginAdminPassword.Text = "password123";
            this.tbLoginAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(43, 142);
            this.btnLoginAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(227, 32);
            this.btnLoginAdmin.TabIndex = 3;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // llMainLogin
            // 
            this.llMainLogin.AutoSize = true;
            this.llMainLogin.Location = new System.Drawing.Point(6, 187);
            this.llMainLogin.Name = "llMainLogin";
            this.llMainLogin.Size = new System.Drawing.Size(59, 13);
            this.llMainLogin.TabIndex = 4;
            this.llMainLogin.TabStop = true;
            this.llMainLogin.Text = "Main Login";
            this.llMainLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMainLogin_LinkClicked);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 208);
            this.Controls.Add(this.llMainLogin);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.tbLoginAdminPassword);
            this.Controls.Add(this.tbLoginAdminUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginAdminUsername;
        private System.Windows.Forms.TextBox tbLoginAdminPassword;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.LinkLabel llMainLogin;
    }
}