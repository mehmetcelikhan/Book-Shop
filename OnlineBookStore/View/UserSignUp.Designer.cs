namespace OnlineBookStore
{
    partial class UserSignUp
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
            this.tbSignupUsername = new System.Windows.Forms.TextBox();
            this.btnSignupSignup = new System.Windows.Forms.Button();
            this.tbSignupPassword = new System.Windows.Forms.TextBox();
            this.tbSignupName = new System.Windows.Forms.TextBox();
            this.tbSignupAddress = new System.Windows.Forms.TextBox();
            this.tbSignupEmail = new System.Windows.Forms.TextBox();
            this.tbSignupGender = new System.Windows.Forms.TextBox();
            this.lbSignUpUsername = new System.Windows.Forms.Label();
            this.lbSignUpPassword = new System.Windows.Forms.Label();
            this.lbSignUpName = new System.Windows.Forms.Label();
            this.lbSignUpAddress = new System.Windows.Forms.Label();
            this.lbSignUpEmail = new System.Windows.Forms.Label();
            this.lbSignUpGender = new System.Windows.Forms.Label();
            this.llUserLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbSignupUsername
            // 
            this.tbSignupUsername.Location = new System.Drawing.Point(115, 59);
            this.tbSignupUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupUsername.Name = "tbSignupUsername";
            this.tbSignupUsername.Size = new System.Drawing.Size(150, 20);
            this.tbSignupUsername.TabIndex = 0;
            this.tbSignupUsername.Click += new System.EventHandler(this.tbSignupUsername_Click);
            this.tbSignupUsername.TextChanged += new System.EventHandler(this.tbSignupUsername_TextChanged);
            // 
            // btnSignupSignup
            // 
            this.btnSignupSignup.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSignupSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignupSignup.Location = new System.Drawing.Point(115, 203);
            this.btnSignupSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignupSignup.Name = "btnSignupSignup";
            this.btnSignupSignup.Size = new System.Drawing.Size(149, 25);
            this.btnSignupSignup.TabIndex = 6;
            this.btnSignupSignup.Text = "SignUp";
            this.btnSignupSignup.UseVisualStyleBackColor = false;
            this.btnSignupSignup.Click += new System.EventHandler(this.btnSignupSignup_Click);
            // 
            // tbSignupPassword
            // 
            this.tbSignupPassword.Location = new System.Drawing.Point(115, 83);
            this.tbSignupPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupPassword.Name = "tbSignupPassword";
            this.tbSignupPassword.Size = new System.Drawing.Size(150, 20);
            this.tbSignupPassword.TabIndex = 1;
            // 
            // tbSignupName
            // 
            this.tbSignupName.Location = new System.Drawing.Point(115, 107);
            this.tbSignupName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupName.Name = "tbSignupName";
            this.tbSignupName.Size = new System.Drawing.Size(150, 20);
            this.tbSignupName.TabIndex = 2;
            // 
            // tbSignupAddress
            // 
            this.tbSignupAddress.Location = new System.Drawing.Point(115, 131);
            this.tbSignupAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupAddress.Name = "tbSignupAddress";
            this.tbSignupAddress.Size = new System.Drawing.Size(150, 20);
            this.tbSignupAddress.TabIndex = 3;
            // 
            // tbSignupEmail
            // 
            this.tbSignupEmail.Location = new System.Drawing.Point(115, 155);
            this.tbSignupEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupEmail.Name = "tbSignupEmail";
            this.tbSignupEmail.Size = new System.Drawing.Size(150, 20);
            this.tbSignupEmail.TabIndex = 4;
            // 
            // tbSignupGender
            // 
            this.tbSignupGender.Location = new System.Drawing.Point(115, 179);
            this.tbSignupGender.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignupGender.Name = "tbSignupGender";
            this.tbSignupGender.Size = new System.Drawing.Size(150, 20);
            this.tbSignupGender.TabIndex = 5;
            // 
            // lbSignUpUsername
            // 
            this.lbSignUpUsername.AutoSize = true;
            this.lbSignUpUsername.Location = new System.Drawing.Point(50, 62);
            this.lbSignUpUsername.Name = "lbSignUpUsername";
            this.lbSignUpUsername.Size = new System.Drawing.Size(58, 13);
            this.lbSignUpUsername.TabIndex = 7;
            this.lbSignUpUsername.Text = "Username:";
            // 
            // lbSignUpPassword
            // 
            this.lbSignUpPassword.AutoSize = true;
            this.lbSignUpPassword.Location = new System.Drawing.Point(52, 86);
            this.lbSignUpPassword.Name = "lbSignUpPassword";
            this.lbSignUpPassword.Size = new System.Drawing.Size(56, 13);
            this.lbSignUpPassword.TabIndex = 8;
            this.lbSignUpPassword.Text = "Password:";
            // 
            // lbSignUpName
            // 
            this.lbSignUpName.AutoSize = true;
            this.lbSignUpName.Location = new System.Drawing.Point(70, 110);
            this.lbSignUpName.Name = "lbSignUpName";
            this.lbSignUpName.Size = new System.Drawing.Size(38, 13);
            this.lbSignUpName.TabIndex = 9;
            this.lbSignUpName.Text = "Name:";
            // 
            // lbSignUpAddress
            // 
            this.lbSignUpAddress.AutoSize = true;
            this.lbSignUpAddress.Location = new System.Drawing.Point(60, 134);
            this.lbSignUpAddress.Name = "lbSignUpAddress";
            this.lbSignUpAddress.Size = new System.Drawing.Size(48, 13);
            this.lbSignUpAddress.TabIndex = 10;
            this.lbSignUpAddress.Text = "Address:";
            // 
            // lbSignUpEmail
            // 
            this.lbSignUpEmail.AutoSize = true;
            this.lbSignUpEmail.Location = new System.Drawing.Point(73, 158);
            this.lbSignUpEmail.Name = "lbSignUpEmail";
            this.lbSignUpEmail.Size = new System.Drawing.Size(35, 13);
            this.lbSignUpEmail.TabIndex = 11;
            this.lbSignUpEmail.Text = "Email:";
            // 
            // lbSignUpGender
            // 
            this.lbSignUpGender.AutoSize = true;
            this.lbSignUpGender.Location = new System.Drawing.Point(63, 182);
            this.lbSignUpGender.Name = "lbSignUpGender";
            this.lbSignUpGender.Size = new System.Drawing.Size(45, 13);
            this.lbSignUpGender.TabIndex = 12;
            this.lbSignUpGender.Text = "Gender:";
            // 
            // llUserLogin
            // 
            this.llUserLogin.AutoSize = true;
            this.llUserLogin.Location = new System.Drawing.Point(5, 234);
            this.llUserLogin.Name = "llUserLogin";
            this.llUserLogin.Size = new System.Drawing.Size(58, 13);
            this.llUserLogin.TabIndex = 13;
            this.llUserLogin.TabStop = true;
            this.llUserLogin.Text = "User Login";
            this.llUserLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserLogin_LinkClicked);
            // 
            // UserSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 252);
            this.Controls.Add(this.llUserLogin);
            this.Controls.Add(this.lbSignUpGender);
            this.Controls.Add(this.lbSignUpEmail);
            this.Controls.Add(this.lbSignUpAddress);
            this.Controls.Add(this.lbSignUpName);
            this.Controls.Add(this.lbSignUpPassword);
            this.Controls.Add(this.lbSignUpUsername);
            this.Controls.Add(this.tbSignupGender);
            this.Controls.Add(this.tbSignupEmail);
            this.Controls.Add(this.tbSignupAddress);
            this.Controls.Add(this.tbSignupName);
            this.Controls.Add(this.tbSignupPassword);
            this.Controls.Add(this.btnSignupSignup);
            this.Controls.Add(this.tbSignupUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserSignUp";
            this.Text = "UserSignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserSignUp_FormClosed);
            this.Load += new System.EventHandler(this.UserSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSignupUsername;
        private System.Windows.Forms.Button btnSignupSignup;
        private System.Windows.Forms.TextBox tbSignupPassword;
        private System.Windows.Forms.TextBox tbSignupName;
        private System.Windows.Forms.TextBox tbSignupAddress;
        private System.Windows.Forms.TextBox tbSignupEmail;
        private System.Windows.Forms.TextBox tbSignupGender;
        private System.Windows.Forms.Label lbSignUpUsername;
        private System.Windows.Forms.Label lbSignUpPassword;
        private System.Windows.Forms.Label lbSignUpName;
        private System.Windows.Forms.Label lbSignUpAddress;
        private System.Windows.Forms.Label lbSignUpEmail;
        private System.Windows.Forms.Label lbSignUpGender;
        private System.Windows.Forms.LinkLabel llUserLogin;
    }
}