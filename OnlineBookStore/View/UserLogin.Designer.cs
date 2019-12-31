namespace OnlineBookStore
{
    partial class UserLogin
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
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.btnLoginSignUp = new System.Windows.Forms.Button();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.llMainLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLoginUsername.Location = new System.Drawing.Point(144, 57);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLoginUsername.Multiline = true;
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(228, 36);
            this.tbLoginUsername.TabIndex = 0;
            this.tbLoginUsername.Text = "Username";
            this.tbLoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLoginUsername.Enter += new System.EventHandler(this.tbUserEmail_Enter);
            this.tbLoginUsername.Leave += new System.EventHandler(this.tbUserEmail_Leave);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLogin.Location = new System.Drawing.Point(144, 148);
            this.btnLoginLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(227, 32);
            this.btnLoginLogin.TabIndex = 2;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = false;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLoginSignUp.Location = new System.Drawing.Point(144, 218);
            this.btnLoginSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(227, 22);
            this.btnLoginSignUp.TabIndex = 3;
            this.btnLoginSignUp.Text = "Sign Up";
            this.btnLoginSignUp.UseVisualStyleBackColor = false;
            this.btnLoginSignUp.Click += new System.EventHandler(this.btnLoginSignUp_Click);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLoginPassword.Location = new System.Drawing.Point(144, 102);
            this.tbLoginPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLoginPassword.Multiline = true;
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(228, 36);
            this.tbLoginPassword.TabIndex = 1;
            this.tbLoginPassword.Text = "Password";
            this.tbLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLoginPassword.Enter += new System.EventHandler(this.tbUserPassword_Enter);
            this.tbLoginPassword.Leave += new System.EventHandler(this.tbUserPassword_Leave);
            // 
            // llMainLogin
            // 
            this.llMainLogin.AutoSize = true;
            this.llMainLogin.Location = new System.Drawing.Point(11, 284);
            this.llMainLogin.Name = "llMainLogin";
            this.llMainLogin.Size = new System.Drawing.Size(59, 13);
            this.llMainLogin.TabIndex = 4;
            this.llMainLogin.TabStop = true;
            this.llMainLogin.Text = "Main Login";
            this.llMainLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMainLogin_LinkClicked);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 303);
            this.Controls.Add(this.llMainLogin);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.btnLoginSignUp);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.tbLoginUsername);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLogin";
            this.Opacity = 0.95D;
            this.Text = "UserLogin";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLogin_FormClosed);
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Button btnLoginSignUp;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.LinkLabel llMainLogin;
    }
}

