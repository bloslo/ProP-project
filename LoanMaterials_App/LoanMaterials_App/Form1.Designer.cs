namespace LoanMaterials_App
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
            this.lbAllItems = new System.Windows.Forms.ListBox();
            this.listBoxLoanedItems = new System.Windows.Forms.ListBox();
            this.lblAllItemsList = new System.Windows.Forms.Label();
            this.lblLoanedItems = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalanceLeft = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBalanceLeft = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShowRentedItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllItems
            // 
            this.lbAllItems.FormattingEnabled = true;
            this.lbAllItems.Location = new System.Drawing.Point(12, 64);
            this.lbAllItems.Name = "lbAllItems";
            this.lbAllItems.Size = new System.Drawing.Size(345, 355);
            this.lbAllItems.TabIndex = 0;
            // 
            // listBoxLoanedItems
            // 
            this.listBoxLoanedItems.FormattingEnabled = true;
            this.listBoxLoanedItems.Location = new System.Drawing.Point(565, 64);
            this.listBoxLoanedItems.Name = "listBoxLoanedItems";
            this.listBoxLoanedItems.Size = new System.Drawing.Size(345, 355);
            this.listBoxLoanedItems.TabIndex = 1;
            // 
            // lblAllItemsList
            // 
            this.lblAllItemsList.AutoSize = true;
            this.lblAllItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllItemsList.Location = new System.Drawing.Point(9, 39);
            this.lblAllItemsList.Name = "lblAllItemsList";
            this.lblAllItemsList.Size = new System.Drawing.Size(109, 15);
            this.lblAllItemsList.TabIndex = 2;
            this.lblAllItemsList.Text = "List of all items:";
            // 
            // lblLoanedItems
            // 
            this.lblLoanedItems.AutoSize = true;
            this.lblLoanedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoanedItems.Location = new System.Drawing.Point(562, 39);
            this.lblLoanedItems.Name = "lblLoanedItems";
            this.lblLoanedItems.Size = new System.Drawing.Size(137, 15);
            this.lblLoanedItems.TabIndex = 3;
            this.lblLoanedItems.Text = "List of items to loan:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(411, 183);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(95, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(411, 238);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(66, 485);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRFID.Location = new System.Drawing.Point(66, 457);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 15);
            this.lblRFID.TabIndex = 7;
            this.lblRFID.Text = "RFID:";
            // 
            // txtRFID
            // 
            this.txtRFID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFID.Location = new System.Drawing.Point(136, 454);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.ReadOnly = true;
            this.txtRFID.Size = new System.Drawing.Size(100, 20);
            this.txtRFID.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(136, 482);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(268, 457);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblBalanceLeft
            // 
            this.lblBalanceLeft.AutoSize = true;
            this.lblBalanceLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanceLeft.Location = new System.Drawing.Point(268, 485);
            this.lblBalanceLeft.Name = "lblBalanceLeft";
            this.lblBalanceLeft.Size = new System.Drawing.Size(87, 15);
            this.lblBalanceLeft.TabIndex = 11;
            this.lblBalanceLeft.Text = "Balance left:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(372, 456);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // txtBalanceLeft
            // 
            this.txtBalanceLeft.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalanceLeft.Location = new System.Drawing.Point(372, 484);
            this.txtBalanceLeft.Name = "txtBalanceLeft";
            this.txtBalanceLeft.ReadOnly = true;
            this.txtBalanceLeft.Size = new System.Drawing.Size(100, 20);
            this.txtBalanceLeft.TabIndex = 13;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnDate.Location = new System.Drawing.Point(515, 485);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(88, 15);
            this.lblReturnDate.TabIndex = 14;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRentDate.Location = new System.Drawing.Point(515, 457);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(75, 15);
            this.lblRentDate.TabIndex = 15;
            this.lblRentDate.Text = "Rent Date:";
            // 
            // txtRentDate
            // 
            this.txtRentDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtRentDate.Location = new System.Drawing.Point(626, 456);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.ReadOnly = true;
            this.txtRentDate.Size = new System.Drawing.Size(100, 20);
            this.txtRentDate.TabIndex = 16;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtReturnDate.Location = new System.Drawing.Point(626, 484);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.ReadOnly = true;
            this.txtReturnDate.Size = new System.Drawing.Size(100, 20);
            this.txtReturnDate.TabIndex = 17;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(743, 467);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 18;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(743, 503);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnShowRentedItems
            // 
            this.btnShowRentedItems.Location = new System.Drawing.Point(833, 466);
            this.btnShowRentedItems.Name = "btnShowRentedItems";
            this.btnShowRentedItems.Size = new System.Drawing.Size(75, 55);
            this.btnShowRentedItems.TabIndex = 20;
            this.btnShowRentedItems.Text = "Show Rented Items";
            this.btnShowRentedItems.UseVisualStyleBackColor = true;
            this.btnShowRentedItems.Click += new System.EventHandler(this.btnShowRentedItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 562);
            this.Controls.Add(this.btnShowRentedItems);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.txtRentDate);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtBalanceLeft);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblBalanceLeft);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblLoanedItems);
            this.Controls.Add(this.lblAllItemsList);
            this.Controls.Add(this.listBoxLoanedItems);
            this.Controls.Add(this.lbAllItems);
            this.Name = "Form1";
            this.Text = "Rent Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllItems;
        private System.Windows.Forms.ListBox listBoxLoanedItems;
        private System.Windows.Forms.Label lblAllItemsList;
        private System.Windows.Forms.Label lblLoanedItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalanceLeft;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBalanceLeft;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.TextBox txtRentDate;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnShowRentedItems;
    }
}

