namespace OnlineBookStore
{
    partial class CustomerPanel
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
            this.gbCustomerPanelMenu = new System.Windows.Forms.GroupBox();
            this.btnCustomerPanelCart = new System.Windows.Forms.Button();
            this.btnCustomerPanelAccount = new System.Windows.Forms.Button();
            this.btnCustomerPanelMusicCD = new System.Windows.Forms.Button();
            this.btnCustomerPanelMagazine = new System.Windows.Forms.Button();
            this.btnCustomerPanelBook = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLoggedAs = new System.Windows.Forms.Label();
            this.tbItemSearch = new System.Windows.Forms.TextBox();
            this.gbCustomerPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerPanelMenu
            // 
            this.gbCustomerPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbCustomerPanelMenu.Controls.Add(this.btnCustomerPanelCart);
            this.gbCustomerPanelMenu.Controls.Add(this.btnCustomerPanelAccount);
            this.gbCustomerPanelMenu.Controls.Add(this.btnCustomerPanelMusicCD);
            this.gbCustomerPanelMenu.Controls.Add(this.btnCustomerPanelMagazine);
            this.gbCustomerPanelMenu.Controls.Add(this.btnCustomerPanelBook);
            this.gbCustomerPanelMenu.Location = new System.Drawing.Point(33, 95);
            this.gbCustomerPanelMenu.Name = "gbCustomerPanelMenu";
            this.gbCustomerPanelMenu.Size = new System.Drawing.Size(1300, 100);
            this.gbCustomerPanelMenu.TabIndex = 3;
            this.gbCustomerPanelMenu.TabStop = false;
            this.gbCustomerPanelMenu.Text = "Menu";
            // 
            // btnCustomerPanelCart
            // 
            this.btnCustomerPanelCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerPanelCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPanelCart.Location = new System.Drawing.Point(1050, 25);
            this.btnCustomerPanelCart.Name = "btnCustomerPanelCart";
            this.btnCustomerPanelCart.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerPanelCart.TabIndex = 6;
            this.btnCustomerPanelCart.Text = "Cart";
            this.btnCustomerPanelCart.UseVisualStyleBackColor = false;
            this.btnCustomerPanelCart.Click += new System.EventHandler(this.btnCustomerPanelCart_Click);
            // 
            // btnCustomerPanelAccount
            // 
            this.btnCustomerPanelAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerPanelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPanelAccount.Location = new System.Drawing.Point(800, 25);
            this.btnCustomerPanelAccount.Name = "btnCustomerPanelAccount";
            this.btnCustomerPanelAccount.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerPanelAccount.TabIndex = 1;
            this.btnCustomerPanelAccount.Text = "Account";
            this.btnCustomerPanelAccount.UseVisualStyleBackColor = false;
            this.btnCustomerPanelAccount.Click += new System.EventHandler(this.btnCustomerPanelAccount_Click);
            // 
            // btnCustomerPanelMusicCD
            // 
            this.btnCustomerPanelMusicCD.Location = new System.Drawing.Point(550, 25);
            this.btnCustomerPanelMusicCD.Name = "btnCustomerPanelMusicCD";
            this.btnCustomerPanelMusicCD.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerPanelMusicCD.TabIndex = 5;
            this.btnCustomerPanelMusicCD.Text = "MusicCD";
            this.btnCustomerPanelMusicCD.UseVisualStyleBackColor = true;
            this.btnCustomerPanelMusicCD.Click += new System.EventHandler(this.btnCustomerPanelMusicCD_Click);
            // 
            // btnCustomerPanelMagazine
            // 
            this.btnCustomerPanelMagazine.Location = new System.Drawing.Point(300, 25);
            this.btnCustomerPanelMagazine.Name = "btnCustomerPanelMagazine";
            this.btnCustomerPanelMagazine.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerPanelMagazine.TabIndex = 4;
            this.btnCustomerPanelMagazine.Text = "Magazine";
            this.btnCustomerPanelMagazine.UseVisualStyleBackColor = true;
            this.btnCustomerPanelMagazine.Click += new System.EventHandler(this.btnCustomerPanelMagazine_Click);
            // 
            // btnCustomerPanelBook
            // 
            this.btnCustomerPanelBook.Location = new System.Drawing.Point(50, 25);
            this.btnCustomerPanelBook.Name = "btnCustomerPanelBook";
            this.btnCustomerPanelBook.Size = new System.Drawing.Size(200, 60);
            this.btnCustomerPanelBook.TabIndex = 3;
            this.btnCustomerPanelBook.Text = "Book";
            this.btnCustomerPanelBook.UseVisualStyleBackColor = true;
            this.btnCustomerPanelBook.Click += new System.EventHandler(this.btnCustomerPanelBook_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Location = new System.Drawing.Point(33, 202);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1300, 619);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // lbLoggedAs
            // 
            this.lbLoggedAs.AutoSize = true;
            this.lbLoggedAs.Location = new System.Drawing.Point(328, 48);
            this.lbLoggedAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoggedAs.Name = "lbLoggedAs";
            this.lbLoggedAs.Size = new System.Drawing.Size(128, 20);
            this.lbLoggedAs.TabIndex = 8;
            this.lbLoggedAs.Text = "You\'re logged as";
            // 
            // tbItemSearch
            // 
            this.tbItemSearch.Location = new System.Drawing.Point(942, 28);
            this.tbItemSearch.Multiline = true;
            this.tbItemSearch.Name = "tbItemSearch";
            this.tbItemSearch.Size = new System.Drawing.Size(391, 61);
            this.tbItemSearch.TabIndex = 10;
            this.tbItemSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItemSearch_KeyPress);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 846);
            this.Controls.Add(this.tbItemSearch);
            this.Controls.Add(this.lbLoggedAs);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gbCustomerPanelMenu);
            this.Name = "CustomerPanel";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "CustomerPanel";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerPanel_FormClosed);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.gbCustomerPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerPanelMenu;
        private System.Windows.Forms.Button btnCustomerPanelMusicCD;
        private System.Windows.Forms.Button btnCustomerPanelAccount;
        private System.Windows.Forms.Button btnCustomerPanelMagazine;
        private System.Windows.Forms.Button btnCustomerPanelBook;
        private System.Windows.Forms.Button btnCustomerPanelCart;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Label lbLoggedAs;
        private System.Windows.Forms.TextBox tbItemSearch;
    }
}