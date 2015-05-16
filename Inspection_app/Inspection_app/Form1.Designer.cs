namespace Inspection_app
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
            this.groupBoxVisitorInfo = new System.Windows.Forms.GroupBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblEventAcc = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.btnVisitorsOverview = new System.Windows.Forms.Button();
            this.btnAccountsOverview = new System.Windows.Forms.Button();
            this.btnCampingOverview = new System.Windows.Forms.Button();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.btnShowProfit = new System.Windows.Forms.Button();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.comboBoxShopID = new System.Windows.Forms.ComboBox();
            this.lblShopIncome = new System.Windows.Forms.Label();
            this.lblShopId = new System.Windows.Forms.Label();
            this.groupBoxArticle = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSoldQunatity = new System.Windows.Forms.Button();
            this.lblAmountLeft = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboBoxProductID = new System.Windows.Forms.ComboBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.groupBoxVisitorInfo.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            this.groupBoxArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVisitorInfo
            // 
            this.groupBoxVisitorInfo.Controls.Add(this.btnHistory);
            this.groupBoxVisitorInfo.Controls.Add(this.comboBoxId);
            this.groupBoxVisitorInfo.Controls.Add(this.btnShowStatus);
            this.groupBoxVisitorInfo.Controls.Add(this.txtName);
            this.groupBoxVisitorInfo.Controls.Add(this.txtStatus);
            this.groupBoxVisitorInfo.Controls.Add(this.txtBalance);
            this.groupBoxVisitorInfo.Controls.Add(this.lblEventAcc);
            this.groupBoxVisitorInfo.Controls.Add(this.lblStatus);
            this.groupBoxVisitorInfo.Controls.Add(this.lblName);
            this.groupBoxVisitorInfo.Controls.Add(this.lblId);
            this.groupBoxVisitorInfo.Location = new System.Drawing.Point(18, 29);
            this.groupBoxVisitorInfo.Name = "groupBoxVisitorInfo";
            this.groupBoxVisitorInfo.Size = new System.Drawing.Size(228, 194);
            this.groupBoxVisitorInfo.TabIndex = 0;
            this.groupBoxVisitorInfo.TabStop = false;
            this.groupBoxVisitorInfo.Text = "Visitor Info";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(121, 156);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(90, 25);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Show History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // comboBoxId
            // 
            this.comboBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(111, 35);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(100, 21);
            this.comboBoxId.TabIndex = 9;
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Location = new System.Drawing.Point(18, 156);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(90, 25);
            this.btnShowStatus.TabIndex = 8;
            this.btnShowStatus.Text = "Show Status";
            this.btnShowStatus.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(111, 66);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Location = new System.Drawing.Point(111, 96);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalance.Location = new System.Drawing.Point(111, 126);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // lblEventAcc
            // 
            this.lblEventAcc.AutoSize = true;
            this.lblEventAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventAcc.Location = new System.Drawing.Point(15, 127);
            this.lblEventAcc.Name = "lblEventAcc";
            this.lblEventAcc.Size = new System.Drawing.Size(67, 15);
            this.lblEventAcc.TabIndex = 3;
            this.lblEventAcc.Text = "Ballance:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(15, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(15, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId.Location = new System.Drawing.Point(15, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxInfo.Location = new System.Drawing.Point(271, 37);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(265, 297);
            this.richTextBoxInfo.TabIndex = 1;
            this.richTextBoxInfo.Text = "";
            // 
            // btnVisitorsOverview
            // 
            this.btnVisitorsOverview.Location = new System.Drawing.Point(66, 276);
            this.btnVisitorsOverview.Name = "btnVisitorsOverview";
            this.btnVisitorsOverview.Size = new System.Drawing.Size(126, 25);
            this.btnVisitorsOverview.TabIndex = 2;
            this.btnVisitorsOverview.Text = "Visitors Overview";
            this.btnVisitorsOverview.UseVisualStyleBackColor = true;
            // 
            // btnAccountsOverview
            // 
            this.btnAccountsOverview.Location = new System.Drawing.Point(66, 244);
            this.btnAccountsOverview.Name = "btnAccountsOverview";
            this.btnAccountsOverview.Size = new System.Drawing.Size(126, 25);
            this.btnAccountsOverview.TabIndex = 3;
            this.btnAccountsOverview.Text = "Accounts Overview";
            this.btnAccountsOverview.UseVisualStyleBackColor = true;
            this.btnAccountsOverview.Click += new System.EventHandler(this.btnAccountsOverview_Click);
            // 
            // btnCampingOverview
            // 
            this.btnCampingOverview.Location = new System.Drawing.Point(66, 309);
            this.btnCampingOverview.Name = "btnCampingOverview";
            this.btnCampingOverview.Size = new System.Drawing.Size(126, 25);
            this.btnCampingOverview.TabIndex = 4;
            this.btnCampingOverview.Text = "Camping Overview";
            this.btnCampingOverview.UseVisualStyleBackColor = true;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.btnShowProfit);
            this.groupBoxShop.Controls.Add(this.txtProfit);
            this.groupBoxShop.Controls.Add(this.comboBoxShopID);
            this.groupBoxShop.Controls.Add(this.lblShopIncome);
            this.groupBoxShop.Controls.Add(this.lblShopId);
            this.groupBoxShop.Location = new System.Drawing.Point(557, 29);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(212, 146);
            this.groupBoxShop.TabIndex = 5;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "Shop Overview";
            // 
            // btnShowProfit
            // 
            this.btnShowProfit.Location = new System.Drawing.Point(64, 107);
            this.btnShowProfit.Name = "btnShowProfit";
            this.btnShowProfit.Size = new System.Drawing.Size(104, 25);
            this.btnShowProfit.TabIndex = 6;
            this.btnShowProfit.Text = "Show Profit";
            this.btnShowProfit.UseVisualStyleBackColor = true;
            // 
            // txtProfit
            // 
            this.txtProfit.BackColor = System.Drawing.SystemColors.Window;
            this.txtProfit.Location = new System.Drawing.Point(95, 67);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(100, 20);
            this.txtProfit.TabIndex = 11;
            // 
            // comboBoxShopID
            // 
            this.comboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShopID.FormattingEnabled = true;
            this.comboBoxShopID.Location = new System.Drawing.Point(95, 34);
            this.comboBoxShopID.Name = "comboBoxShopID";
            this.comboBoxShopID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxShopID.TabIndex = 11;
            // 
            // lblShopIncome
            // 
            this.lblShopIncome.AutoSize = true;
            this.lblShopIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopIncome.Location = new System.Drawing.Point(17, 68);
            this.lblShopIncome.Name = "lblShopIncome";
            this.lblShopIncome.Size = new System.Drawing.Size(45, 15);
            this.lblShopIncome.TabIndex = 2;
            this.lblShopIncome.Text = "Profit:";
            // 
            // lblShopId
            // 
            this.lblShopId.AutoSize = true;
            this.lblShopId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopId.Location = new System.Drawing.Point(17, 35);
            this.lblShopId.Name = "lblShopId";
            this.lblShopId.Size = new System.Drawing.Size(62, 15);
            this.lblShopId.TabIndex = 1;
            this.lblShopId.Text = "Shop ID:";
            // 
            // groupBoxArticle
            // 
            this.groupBoxArticle.Controls.Add(this.textBox1);
            this.groupBoxArticle.Controls.Add(this.btnSoldQunatity);
            this.groupBoxArticle.Controls.Add(this.lblAmountLeft);
            this.groupBoxArticle.Controls.Add(this.txtQuantity);
            this.groupBoxArticle.Controls.Add(this.lblQuantity);
            this.groupBoxArticle.Controls.Add(this.comboBoxProductID);
            this.groupBoxArticle.Controls.Add(this.lblProductID);
            this.groupBoxArticle.Location = new System.Drawing.Point(557, 185);
            this.groupBoxArticle.Name = "groupBoxArticle";
            this.groupBoxArticle.Size = new System.Drawing.Size(212, 159);
            this.groupBoxArticle.TabIndex = 6;
            this.groupBoxArticle.TabStop = false;
            this.groupBoxArticle.Text = "Product Overview";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(106, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btnSoldQunatity
            // 
            this.btnSoldQunatity.Location = new System.Drawing.Point(36, 124);
            this.btnSoldQunatity.Name = "btnSoldQunatity";
            this.btnSoldQunatity.Size = new System.Drawing.Size(143, 25);
            this.btnSoldQunatity.TabIndex = 16;
            this.btnSoldQunatity.Text = "Show Product overview";
            this.btnSoldQunatity.UseVisualStyleBackColor = true;
            // 
            // lblAmountLeft
            // 
            this.lblAmountLeft.AutoSize = true;
            this.lblAmountLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountLeft.Location = new System.Drawing.Point(6, 95);
            this.lblAmountLeft.Name = "lblAmountLeft";
            this.lblAmountLeft.Size = new System.Drawing.Size(60, 15);
            this.lblAmountLeft.TabIndex = 17;
            this.lblAmountLeft.Text = "In stock:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.Location = new System.Drawing.Point(106, 62);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(6, 63);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(94, 15);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity sold:";
            // 
            // comboBoxProductID
            // 
            this.comboBoxProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductID.FormattingEnabled = true;
            this.comboBoxProductID.Location = new System.Drawing.Point(106, 29);
            this.comboBoxProductID.Name = "comboBoxProductID";
            this.comboBoxProductID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProductID.TabIndex = 13;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductID.Location = new System.Drawing.Point(6, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(78, 15);
            this.lblProductID.TabIndex = 12;
            this.lblProductID.Text = "Product ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 356);
            this.Controls.Add(this.groupBoxArticle);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.btnCampingOverview);
            this.Controls.Add(this.btnAccountsOverview);
            this.Controls.Add(this.btnVisitorsOverview);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.groupBoxVisitorInfo);
            this.Name = "Form1";
            this.Text = "Event status";
            this.groupBoxVisitorInfo.ResumeLayout(false);
            this.groupBoxVisitorInfo.PerformLayout();
            this.groupBoxShop.ResumeLayout(false);
            this.groupBoxShop.PerformLayout();
            this.groupBoxArticle.ResumeLayout(false);
            this.groupBoxArticle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVisitorInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblEventAcc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnVisitorsOverview;
        private System.Windows.Forms.Button btnAccountsOverview;
        private System.Windows.Forms.Button btnCampingOverview;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.Button btnShowProfit;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.ComboBox comboBoxShopID;
        private System.Windows.Forms.Label lblShopIncome;
        private System.Windows.Forms.Label lblShopId;
        private System.Windows.Forms.GroupBox groupBoxArticle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSoldQunatity;
        private System.Windows.Forms.Label lblAmountLeft;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox comboBoxProductID;
        private System.Windows.Forms.Label lblProductID;

    }
}

