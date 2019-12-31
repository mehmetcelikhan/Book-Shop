namespace OnlineBookStore
{
    partial class ChangeCustomerInfo
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
            this.lbNameChange = new System.Windows.Forms.Label();
            this.lbPasswordChange = new System.Windows.Forms.Label();
            this.lbAddressChange = new System.Windows.Forms.Label();
            this.lbGenderChange = new System.Windows.Forms.Label();
            this.tbNameChange = new System.Windows.Forms.TextBox();
            this.tbPasswordChange = new System.Windows.Forms.TextBox();
            this.tbAddressChange = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lbRePasswordChange = new System.Windows.Forms.Label();
            this.tbRePasswordChange = new System.Windows.Forms.TextBox();
            this.lbValid = new System.Windows.Forms.Label();
            this.btnCustomerPanel = new System.Windows.Forms.Button();
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.lbShownGender = new System.Windows.Forms.Label();
            this.lbShownEmail = new System.Windows.Forms.Label();
            this.lbShownAddress = new System.Windows.Forms.Label();
            this.lbShownName = new System.Windows.Forms.Label();
            this.lbShownUsername = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.btnChangeGender = new System.Windows.Forms.Button();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameChange
            // 
            this.lbNameChange.AutoSize = true;
            this.lbNameChange.Location = new System.Drawing.Point(353, 63);
            this.lbNameChange.Name = "lbNameChange";
            this.lbNameChange.Size = new System.Drawing.Size(38, 13);
            this.lbNameChange.TabIndex = 0;
            this.lbNameChange.Text = "Name:";
            // 
            // lbPasswordChange
            // 
            this.lbPasswordChange.AutoSize = true;
            this.lbPasswordChange.Location = new System.Drawing.Point(310, 158);
            this.lbPasswordChange.Name = "lbPasswordChange";
            this.lbPasswordChange.Size = new System.Drawing.Size(81, 13);
            this.lbPasswordChange.TabIndex = 1;
            this.lbPasswordChange.Text = "New Password:";
            // 
            // lbAddressChange
            // 
            this.lbAddressChange.AutoSize = true;
            this.lbAddressChange.Location = new System.Drawing.Point(343, 89);
            this.lbAddressChange.Name = "lbAddressChange";
            this.lbAddressChange.Size = new System.Drawing.Size(48, 13);
            this.lbAddressChange.TabIndex = 2;
            this.lbAddressChange.Text = "Address:";
            // 
            // lbGenderChange
            // 
            this.lbGenderChange.AutoSize = true;
            this.lbGenderChange.Location = new System.Drawing.Point(346, 114);
            this.lbGenderChange.Name = "lbGenderChange";
            this.lbGenderChange.Size = new System.Drawing.Size(45, 13);
            this.lbGenderChange.TabIndex = 4;
            this.lbGenderChange.Text = "Gender:";
            // 
            // tbNameChange
            // 
            this.tbNameChange.Location = new System.Drawing.Point(397, 60);
            this.tbNameChange.Name = "tbNameChange";
            this.tbNameChange.Size = new System.Drawing.Size(140, 20);
            this.tbNameChange.TabIndex = 5;
            // 
            // tbPasswordChange
            // 
            this.tbPasswordChange.Location = new System.Drawing.Point(397, 155);
            this.tbPasswordChange.Name = "tbPasswordChange";
            this.tbPasswordChange.Size = new System.Drawing.Size(140, 20);
            this.tbPasswordChange.TabIndex = 6;
            this.tbPasswordChange.UseSystemPasswordChar = true;
            this.tbPasswordChange.TextChanged += new System.EventHandler(this.tbPasswordChange_TextChanged);
            // 
            // tbAddressChange
            // 
            this.tbAddressChange.Location = new System.Drawing.Point(397, 86);
            this.tbAddressChange.Name = "tbAddressChange";
            this.tbAddressChange.Size = new System.Drawing.Size(140, 20);
            this.tbAddressChange.TabIndex = 7;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(397, 112);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(478, 112);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Location = new System.Drawing.Point(254, 210);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(137, 13);
            this.lbCurrentPassword.TabIndex = 11;
            this.lbCurrentPassword.Text = "Enter the current password:";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(397, 207);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(140, 20);
            this.tbCurrentPassword.TabIndex = 12;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(435, 236);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(102, 23);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lbRePasswordChange
            // 
            this.lbRePasswordChange.AutoSize = true;
            this.lbRePasswordChange.Location = new System.Drawing.Point(293, 186);
            this.lbRePasswordChange.Name = "lbRePasswordChange";
            this.lbRePasswordChange.Size = new System.Drawing.Size(98, 13);
            this.lbRePasswordChange.TabIndex = 16;
            this.lbRePasswordChange.Text = "Re-New Password:";
            // 
            // tbRePasswordChange
            // 
            this.tbRePasswordChange.Location = new System.Drawing.Point(397, 181);
            this.tbRePasswordChange.Name = "tbRePasswordChange";
            this.tbRePasswordChange.Size = new System.Drawing.Size(140, 20);
            this.tbRePasswordChange.TabIndex = 17;
            this.tbRePasswordChange.UseSystemPasswordChar = true;
            this.tbRePasswordChange.TextChanged += new System.EventHandler(this.tbRePasswordChange_TextChanged);
            // 
            // lbValid
            // 
            this.lbValid.AutoSize = true;
            this.lbValid.Location = new System.Drawing.Point(543, 171);
            this.lbValid.Name = "lbValid";
            this.lbValid.Size = new System.Drawing.Size(0, 13);
            this.lbValid.TabIndex = 18;
            // 
            // btnCustomerPanel
            // 
            this.btnCustomerPanel.Location = new System.Drawing.Point(37, 236);
            this.btnCustomerPanel.Name = "btnCustomerPanel";
            this.btnCustomerPanel.Size = new System.Drawing.Size(140, 23);
            this.btnCustomerPanel.TabIndex = 15;
            this.btnCustomerPanel.Text = "Back to Customer Panel";
            this.btnCustomerPanel.UseVisualStyleBackColor = true;
            this.btnCustomerPanel.Click += new System.EventHandler(this.btnCustomerPanel_Click);
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.Controls.Add(this.lbShownGender);
            this.gbUserInformation.Controls.Add(this.lbShownEmail);
            this.gbUserInformation.Controls.Add(this.lbShownAddress);
            this.gbUserInformation.Controls.Add(this.lbShownName);
            this.gbUserInformation.Controls.Add(this.lbShownUsername);
            this.gbUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInformation.Location = new System.Drawing.Point(23, 63);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(217, 147);
            this.gbUserInformation.TabIndex = 19;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // lbShownGender
            // 
            this.lbShownGender.AutoSize = true;
            this.lbShownGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownGender.Location = new System.Drawing.Point(11, 98);
            this.lbShownGender.Name = "lbShownGender";
            this.lbShownGender.Size = new System.Drawing.Size(52, 13);
            this.lbShownGender.TabIndex = 5;
            this.lbShownGender.Text = "Gender:";
            // 
            // lbShownEmail
            // 
            this.lbShownEmail.AutoSize = true;
            this.lbShownEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownEmail.Location = new System.Drawing.Point(11, 79);
            this.lbShownEmail.Name = "lbShownEmail";
            this.lbShownEmail.Size = new System.Drawing.Size(41, 13);
            this.lbShownEmail.TabIndex = 4;
            this.lbShownEmail.Text = "Email:";
            // 
            // lbShownAddress
            // 
            this.lbShownAddress.AutoSize = true;
            this.lbShownAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownAddress.Location = new System.Drawing.Point(11, 62);
            this.lbShownAddress.Name = "lbShownAddress";
            this.lbShownAddress.Size = new System.Drawing.Size(49, 13);
            this.lbShownAddress.TabIndex = 3;
            this.lbShownAddress.Text = "Adress:";
            // 
            // lbShownName
            // 
            this.lbShownName.AutoSize = true;
            this.lbShownName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownName.Location = new System.Drawing.Point(11, 46);
            this.lbShownName.Name = "lbShownName";
            this.lbShownName.Size = new System.Drawing.Size(43, 13);
            this.lbShownName.TabIndex = 2;
            this.lbShownName.Text = "Name:";
            // 
            // lbShownUsername
            // 
            this.lbShownUsername.AutoSize = true;
            this.lbShownUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShownUsername.Location = new System.Drawing.Point(11, 29);
            this.lbShownUsername.Name = "lbShownUsername";
            this.lbShownUsername.Size = new System.Drawing.Size(67, 13);
            this.lbShownUsername.TabIndex = 1;
            this.lbShownUsername.Text = "Username:";
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(543, 58);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(96, 23);
            this.btnChangeName.TabIndex = 20;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.Location = new System.Drawing.Point(543, 84);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(96, 23);
            this.btnChangeAddress.TabIndex = 22;
            this.btnChangeAddress.Text = "Change Address";
            this.btnChangeAddress.UseVisualStyleBackColor = true;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // btnChangeGender
            // 
            this.btnChangeGender.Location = new System.Drawing.Point(543, 109);
            this.btnChangeGender.Name = "btnChangeGender";
            this.btnChangeGender.Size = new System.Drawing.Size(96, 23);
            this.btnChangeGender.TabIndex = 23;
            this.btnChangeGender.Text = "Change Gender";
            this.btnChangeGender.UseVisualStyleBackColor = true;
            this.btnChangeGender.Click += new System.EventHandler(this.btnChangeGender_Click);
            // 
            // ChangeCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 289);
            this.Controls.Add(this.btnChangeGender);
            this.Controls.Add(this.btnChangeAddress);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.gbUserInformation);
            this.Controls.Add(this.lbValid);
            this.Controls.Add(this.tbRePasswordChange);
            this.Controls.Add(this.lbRePasswordChange);
            this.Controls.Add(this.btnCustomerPanel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.lbCurrentPassword);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbAddressChange);
            this.Controls.Add(this.tbPasswordChange);
            this.Controls.Add(this.tbNameChange);
            this.Controls.Add(this.lbGenderChange);
            this.Controls.Add(this.lbAddressChange);
            this.Controls.Add(this.lbPasswordChange);
            this.Controls.Add(this.lbNameChange);
            this.Name = "ChangeCustomerInfo";
            this.Text = "ChangeCustomerInfo";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeCustomerInfo_FormClosed);
            this.Load += new System.EventHandler(this.ChangeCustomerInfo_Load);
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameChange;
        private System.Windows.Forms.Label lbPasswordChange;
        private System.Windows.Forms.Label lbAddressChange;
        private System.Windows.Forms.Label lbGenderChange;
        private System.Windows.Forms.TextBox tbNameChange;
        private System.Windows.Forms.TextBox tbPasswordChange;
        private System.Windows.Forms.TextBox tbAddressChange;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lbRePasswordChange;
        private System.Windows.Forms.TextBox tbRePasswordChange;
        private System.Windows.Forms.Label lbValid;
        private System.Windows.Forms.Button btnCustomerPanel;
        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.Label lbShownGender;
        private System.Windows.Forms.Label lbShownEmail;
        private System.Windows.Forms.Label lbShownAddress;
        private System.Windows.Forms.Label lbShownName;
        private System.Windows.Forms.Label lbShownUsername;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.Button btnChangeGender;
    }
}