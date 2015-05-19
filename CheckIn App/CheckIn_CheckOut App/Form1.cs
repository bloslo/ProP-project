using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace CheckIn_CheckOut_App
{
    public partial class Form1 : Form
    {
        private DBHelper helper;
        private RFID checkIn;

        public Form1()
        {
            InitializeComponent();

            helper = new DBHelper();

            LoadRFIDReader();
            btnPay.Enabled = false;
        }

        private void LoadRFIDReader()
        {
            try
            {
                checkIn = new RFID();
                checkIn.open();
                checkIn.waitForAttachment(1000);
                MessageBox.Show("RFID Reader has successfully connected.");
                checkIn.Antenna = true;
                checkIn.LED = true;
                checkIn.Tag += new TagEventHandler(ProcessTag);
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show("Check if you have connected the RFID.");
            }
        }

        private void ProcessTag(object sender, TagEventArgs e)
        {
            ClearAllTextBoxes(this);
            helper.CheckVisitor(e.Tag);
            Visitor vis = helper.GetVisitor(e.Tag);

            try
            {
                txtID.Text = vis.ID.ToString();
                txtRFID.Text = e.Tag;
                txtFirstName.Text = vis.FirstName;
                txtLastName.Text = vis.LastName;
                txtBalance.Text = vis.Balance.ToString();
                txtStatus.Text = vis.Status.ToString();
                txtEntranceFee.Text = vis.EntranceFee;

                if (vis.EntranceFee == "Paid")
                    btnPay.Enabled = false;
                else
                    btnPay.Enabled = true;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Visitor not found!");
            }
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control box in parent.Controls)
            {
                if (box is TextBox)
                    (box as TextBox).Clear();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtBalance.Text) < 65)
            {
                MessageBox.Show("Insufficient funds! \nThe entrance fee is €55 + €10 extra for paying on the entrance.");
            }
            else
            {
                helper.Pay(txtRFID.Text);
                Visitor vis = helper.GetVisitor(txtRFID.Text);

                txtBalance.Text = vis.Balance.ToString();
                txtEntranceFee.Text = vis.EntranceFee;
                btnPay.Enabled = false;
            }
        }
    }
}
