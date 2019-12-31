namespace OnlineBookStore
{
    partial class MainLogin
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
            this.btnMainLoginUser = new System.Windows.Forms.Button();
            this.btnMainLoginAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainLoginUser
            // 
            this.btnMainLoginUser.Location = new System.Drawing.Point(71, 100);
            this.btnMainLoginUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainLoginUser.Name = "btnMainLoginUser";
            this.btnMainLoginUser.Size = new System.Drawing.Size(133, 43);
            this.btnMainLoginUser.TabIndex = 0;
            this.btnMainLoginUser.Text = "USER";
            this.btnMainLoginUser.UseVisualStyleBackColor = true;
            this.btnMainLoginUser.Click += new System.EventHandler(this.btnMainLoginUser_Click);
            // 
            // btnMainLoginAdmin
            // 
            this.btnMainLoginAdmin.Location = new System.Drawing.Point(71, 147);
            this.btnMainLoginAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainLoginAdmin.Name = "btnMainLoginAdmin";
            this.btnMainLoginAdmin.Size = new System.Drawing.Size(133, 43);
            this.btnMainLoginAdmin.TabIndex = 1;
            this.btnMainLoginAdmin.Text = "ADMIN";
            this.btnMainLoginAdmin.UseVisualStyleBackColor = true;
            this.btnMainLoginAdmin.Click += new System.EventHandler(this.btnMainLoginAdmin_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 274);
            this.Controls.Add(this.btnMainLoginAdmin);
            this.Controls.Add(this.btnMainLoginUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainLogin";
            this.Text = "MainLogin";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainLogin_FormClosed);
            this.Load += new System.EventHandler(this.MainLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainLoginUser;
        private System.Windows.Forms.Button btnMainLoginAdmin;
    }
}