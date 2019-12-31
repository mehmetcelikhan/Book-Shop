namespace OnlineBookStore
{
    partial class Cart
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvShoppingCartDetails = new System.Windows.Forms.ListView();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.tbCreditCard = new System.Windows.Forms.TextBox();
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(184, 389);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(293, 82);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "PLACE ORDER:";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(22, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 82);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Customer Panel";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(22, 311);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lvShoppingCartDetails
            // 
            this.lvShoppingCartDetails.Location = new System.Drawing.Point(22, 62);
            this.lvShoppingCartDetails.Margin = new System.Windows.Forms.Padding(2);
            this.lvShoppingCartDetails.Name = "lvShoppingCartDetails";
            this.lvShoppingCartDetails.Size = new System.Drawing.Size(455, 241);
            this.lvShoppingCartDetails.TabIndex = 1;
            this.lvShoppingCartDetails.UseCompatibleStateImageBehavior = false;
            this.lvShoppingCartDetails.View = System.Windows.Forms.View.Details;
            this.lvShoppingCartDetails.SelectedIndexChanged += new System.EventHandler(this.lvShoppingCartDetails_SelectedIndexChanged);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(103, 311);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 6;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Checked = true;
            this.rdbCredit.Location = new System.Drawing.Point(345, 314);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(77, 17);
            this.rdbCredit.TabIndex = 7;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Credit Card";
            this.rdbCredit.UseVisualStyleBackColor = true;
            this.rdbCredit.CheckedChanged += new System.EventHandler(this.rdbCredit_CheckedChanged);
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(428, 314);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(49, 17);
            this.rdbCash.TabIndex = 8;
            this.rdbCash.Text = "Cash";
            this.rdbCash.UseVisualStyleBackColor = true;
            this.rdbCash.CheckedChanged += new System.EventHandler(this.rdbCash_CheckedChanged);
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Location = new System.Drawing.Point(322, 350);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(155, 20);
            this.tbCreditCard.TabIndex = 9;
            // 
            // lbCreditCard
            // 
            this.lbCreditCard.AutoSize = true;
            this.lbCreditCard.Location = new System.Drawing.Point(214, 353);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.Size = new System.Drawing.Size(102, 13);
            this.lbCreditCard.TabIndex = 10;
            this.lbCreditCard.Text = "Credit Card Number:";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 481);
            this.Controls.Add(this.lbCreditCard);
            this.Controls.Add(this.tbCreditCard);
            this.Controls.Add(this.rdbCash);
            this.Controls.Add(this.rdbCredit);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lvShoppingCartDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cart_FormClosed);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvShoppingCartDetails;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.TextBox tbCreditCard;
        private System.Windows.Forms.Label lbCreditCard;
    }
}