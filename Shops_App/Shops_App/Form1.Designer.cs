namespace Shops_App
{
    partial class Form1
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
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.listBoxOrdered = new System.Windows.Forms.ListBox();
            this.lblOrderedProducts = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalanceLeft = new System.Windows.Forms.TextBox();
            this.lblRFIDNr = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblShopID = new System.Windows.Forms.Label();
            this.comboBoxShopID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxAll
            // 
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.Location = new System.Drawing.Point(12, 53);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.Size = new System.Drawing.Size(343, 355);
            this.listBoxAll.TabIndex = 0;
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.AutoSize = true;
            this.lblAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllProducts.Location = new System.Drawing.Point(12, 27);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(129, 15);
            this.lblAllProducts.TabIndex = 1;
            this.lblAllProducts.Text = "List of all products:";
            // 
            // listBoxOrdered
            // 
            this.listBoxOrdered.FormattingEnabled = true;
            this.listBoxOrdered.Location = new System.Drawing.Point(538, 53);
            this.listBoxOrdered.Name = "listBoxOrdered";
            this.listBoxOrdered.Size = new System.Drawing.Size(343, 355);
            this.listBoxOrdered.TabIndex = 2;
            // 
            // lblOrderedProducts
            // 
            this.lblOrderedProducts.AutoSize = true;
            this.lblOrderedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderedProducts.Location = new System.Drawing.Point(535, 27);
            this.lblOrderedProducts.Name = "lblOrderedProducts";
            this.lblOrderedProducts.Size = new System.Drawing.Size(163, 15);
            this.lblOrderedProducts.TabIndex = 3;
            this.lblOrderedProducts.Text = "List of ordered products:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(402, 207);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(402, 156);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(91, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(257, 458);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(353, 457);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(257, 492);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(87, 15);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance left:";
            // 
            // txtBalanceLeft
            // 
            this.txtBalanceLeft.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalanceLeft.Location = new System.Drawing.Point(353, 491);
            this.txtBalanceLeft.Name = "txtBalanceLeft";
            this.txtBalanceLeft.ReadOnly = true;
            this.txtBalanceLeft.Size = new System.Drawing.Size(100, 20);
            this.txtBalanceLeft.TabIndex = 9;
            // 
            // lblRFIDNr
            // 
            this.lblRFIDNr.AutoSize = true;
            this.lblRFIDNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRFIDNr.Location = new System.Drawing.Point(52, 458);
            this.lblRFIDNr.Name = "lblRFIDNr";
            this.lblRFIDNr.Size = new System.Drawing.Size(66, 15);
            this.lblRFIDNr.TabIndex = 10;
            this.lblRFIDNr.Text = "RFID Nr.:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(52, 492);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // txtRFID
            // 
            this.txtRFID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFID.Location = new System.Drawing.Point(129, 457);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.ReadOnly = true;
            this.txtRFID.Size = new System.Drawing.Size(100, 20);
            this.txtRFID.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(129, 491);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(516, 472);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(95, 23);
            this.btnMakePayment.TabIndex = 14;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblShopID
            // 
            this.lblShopID.AutoSize = true;
            this.lblShopID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopID.Location = new System.Drawing.Point(672, 458);
            this.lblShopID.Name = "lblShopID";
            this.lblShopID.Size = new System.Drawing.Size(62, 15);
            this.lblShopID.TabIndex = 15;
            this.lblShopID.Text = "Shop ID:";
            // 
            // comboBoxShopID
            // 
            this.comboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShopID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxShopID.FormattingEnabled = true;
            this.comboBoxShopID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxShopID.Location = new System.Drawing.Point(740, 457);
            this.comboBoxShopID.Name = "comboBoxShopID";
            this.comboBoxShopID.Size = new System.Drawing.Size(44, 21);
            this.comboBoxShopID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 556);
            this.Controls.Add(this.comboBoxShopID);
            this.Controls.Add(this.lblShopID);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRFIDNr);
            this.Controls.Add(this.txtBalanceLeft);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblOrderedProducts);
            this.Controls.Add(this.listBoxOrdered);
            this.Controls.Add(this.lblAllProducts);
            this.Controls.Add(this.listBoxAll);
            this.Name = "Form1";
            this.Text = "Shop Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.Label lblAllProducts;
        private System.Windows.Forms.ListBox listBoxOrdered;
        private System.Windows.Forms.Label lblOrderedProducts;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalanceLeft;
        private System.Windows.Forms.Label lblRFIDNr;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblShopID;
        private System.Windows.Forms.ComboBox comboBoxShopID;
    }
}

