namespace OnlineBookStore
{
    partial class AdminPanel
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.gbAdminMenu = new System.Windows.Forms.GroupBox();
            this.btnMusicCD = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbAdminSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.gbAdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvTable.Location = new System.Drawing.Point(38, 157);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 28;
            this.dgvTable.Size = new System.Drawing.Size(1302, 600);
            this.dgvTable.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(32, 25);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(219, 62);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // gbAdminMenu
            // 
            this.gbAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbAdminMenu.Controls.Add(this.btnMusicCD);
            this.gbAdminMenu.Controls.Add(this.btnMagazine);
            this.gbAdminMenu.Controls.Add(this.btnBook);
            this.gbAdminMenu.Controls.Add(this.btnCustomer);
            this.gbAdminMenu.Location = new System.Drawing.Point(38, 26);
            this.gbAdminMenu.Name = "gbAdminMenu";
            this.gbAdminMenu.Size = new System.Drawing.Size(1300, 106);
            this.gbAdminMenu.TabIndex = 2;
            this.gbAdminMenu.TabStop = false;
            this.gbAdminMenu.Text = "Admin Menu";
            // 
            // btnMusicCD
            // 
            this.btnMusicCD.Location = new System.Drawing.Point(890, 25);
            this.btnMusicCD.Name = "btnMusicCD";
            this.btnMusicCD.Size = new System.Drawing.Size(219, 62);
            this.btnMusicCD.TabIndex = 5;
            this.btnMusicCD.Text = "MusicCD";
            this.btnMusicCD.UseVisualStyleBackColor = true;
            this.btnMusicCD.Click += new System.EventHandler(this.btnMusicCD_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.Location = new System.Drawing.Point(600, 25);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(219, 62);
            this.btnMagazine.TabIndex = 4;
            this.btnMagazine.Text = "Magazine";
            this.btnMagazine.UseVisualStyleBackColor = true;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(314, 25);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(219, 62);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 780);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(219, 62);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add New Row";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 780);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(219, 62);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 780);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 62);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(946, 778);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(391, 61);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lbAdminSearch
            // 
            this.lbAdminSearch.AutoSize = true;
            this.lbAdminSearch.Location = new System.Drawing.Point(806, 802);
            this.lbAdminSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdminSearch.Name = "lbAdminSearch";
            this.lbAdminSearch.Size = new System.Drawing.Size(130, 20);
            this.lbAdminSearch.TabIndex = 10;
            this.lbAdminSearch.Text = "Search by Name:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 877);
            this.Controls.Add(this.lbAdminSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAdminMenu);
            this.Controls.Add(this.dgvTable);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.gbAdminMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox gbAdminMenu;
        private System.Windows.Forms.Button btnMusicCD;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbAdminSearch;
    }
}