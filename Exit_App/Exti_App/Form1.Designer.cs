namespace Exti_App
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
            this.lbLoanedStuff = new System.Windows.Forms.ListBox();
            this.lblLoanedStuff = new System.Windows.Forms.Label();
            this.lblRFIDNr = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtRFIDNr = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnMarkAsNotValid = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLoanedStuff
            // 
            this.lbLoanedStuff.FormattingEnabled = true;
            this.lbLoanedStuff.HorizontalScrollbar = true;
            this.lbLoanedStuff.Location = new System.Drawing.Point(12, 43);
            this.lbLoanedStuff.Name = "lbLoanedStuff";
            this.lbLoanedStuff.ScrollAlwaysVisible = true;
            this.lbLoanedStuff.Size = new System.Drawing.Size(307, 212);
            this.lbLoanedStuff.TabIndex = 0;
            // 
            // lblLoanedStuff
            // 
            this.lblLoanedStuff.AutoSize = true;
            this.lblLoanedStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoanedStuff.Location = new System.Drawing.Point(12, 19);
            this.lblLoanedStuff.Name = "lblLoanedStuff";
            this.lblLoanedStuff.Size = new System.Drawing.Size(119, 15);
            this.lblLoanedStuff.TabIndex = 1;
            this.lblLoanedStuff.Text = "Loaned materials";
            // 
            // lblRFIDNr
            // 
            this.lblRFIDNr.AutoSize = true;
            this.lblRFIDNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRFIDNr.Location = new System.Drawing.Point(338, 48);
            this.lblRFIDNr.Name = "lblRFIDNr";
            this.lblRFIDNr.Size = new System.Drawing.Size(66, 15);
            this.lblRFIDNr.TabIndex = 2;
            this.lblRFIDNr.Text = "RFID Nr.:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(338, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // txtRFIDNr
            // 
            this.txtRFIDNr.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFIDNr.Location = new System.Drawing.Point(434, 47);
            this.txtRFIDNr.Name = "txtRFIDNr";
            this.txtRFIDNr.ReadOnly = true;
            this.txtRFIDNr.Size = new System.Drawing.Size(100, 20);
            this.txtRFIDNr.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(338, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(339, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(338, 152);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 15);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(434, 73);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(434, 99);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(434, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalance.Location = new System.Drawing.Point(434, 151);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(339, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Location = new System.Drawing.Point(434, 177);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 13;
            // 
            // btnMarkAsNotValid
            // 
            this.btnMarkAsNotValid.Enabled = false;
            this.btnMarkAsNotValid.Location = new System.Drawing.Point(446, 214);
            this.btnMarkAsNotValid.Name = "btnMarkAsNotValid";
            this.btnMarkAsNotValid.Size = new System.Drawing.Size(75, 35);
            this.btnMarkAsNotValid.TabIndex = 14;
            this.btnMarkAsNotValid.Text = "Mark As\r\nNot Valid";
            this.btnMarkAsNotValid.UseVisualStyleBackColor = true;
            this.btnMarkAsNotValid.Click += new System.EventHandler(this.btnMarkAsNotValid_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(344, 219);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 25);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 268);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnMarkAsNotValid);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtRFIDNr);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRFIDNr);
            this.Controls.Add(this.lblLoanedStuff);
            this.Controls.Add(this.lbLoanedStuff);
            this.Name = "Form1";
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLoanedStuff;
        private System.Windows.Forms.Label lblLoanedStuff;
        private System.Windows.Forms.Label lblRFIDNr;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtRFIDNr;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnMarkAsNotValid;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

