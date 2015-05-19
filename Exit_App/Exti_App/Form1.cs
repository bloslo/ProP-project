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

namespace Exti_App
{
    public partial class Form1 : Form
    {
        private RFID checkOut;
        private DBExtractor extractor;

        public Form1()
        {
            InitializeComponent();

            extractor = new DBExtractor();
            InitializeRFID();
        }

        private void InitializeRFID()
        {
            try
            {
                checkOut = new RFID();
                checkOut.open();
                checkOut.waitForAttachment(1000);
                MessageBox.Show("RFID reader successfully attached.");
                checkOut.Antenna = true;
                checkOut.LED = true;
                checkOut.Tag += new TagEventHandler(ProcessTag);

            }
            catch (PhidgetException ex)
            {
                MessageBox.Show("Ensure that the RFID is connected.");
            }
        }

        private void ClearAllFormControls(Control parent)
        {
            foreach (Control con in parent.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).Clear();
            }
        }

        private void ProcessTag(object sender, TagEventArgs e)
        {
            extractor.CheckOut(e.Tag);
            Visitor vis = extractor.GetVisitor(e.Tag);
            ClearAllFormControls(this);

            try
            {
                txtRFIDNr.Text = e.Tag;
                txtID.Text = vis.ID.ToString();
                txtFirstName.Text = vis.FirstName;
                txtLastName.Text = vis.LastName;
                txtBalance.Text = vis.Balance.ToString();
                txtStatus.Text = vis.Status;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No such visitor!");
            }
        }
    }
}
