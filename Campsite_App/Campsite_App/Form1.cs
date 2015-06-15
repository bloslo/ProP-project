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

namespace Campsite_App
{
    public partial class Form1 : Form
    {
        private RFID chip;
        private DBHelper helper;

        public Form1()
        {
            InitializeComponent();

            helper = new DBHelper();
            InitializeRFID();
        }

        private void InitializeRFID()
        {
            try
            {
                chip = new RFID();
                chip.open();
                chip.waitForAttachment(3000);
                MessageBox.Show("Reader successfully attached");
                chip.Antenna = true;
                chip.LED = true;
                chip.Tag += new TagEventHandler(ProcessTag);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failed to connect to the RFID reader!");
            }
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                {
                    (child as TextBox).Clear();
                }
            }
        }

        private void ProcessTag(object sender, TagEventArgs e)
        {
            ClearTextBoxes(this);
            Visitor vis = helper.GetVisitor(e.Tag);

            try
            {
                txtTag.Text = e.Tag;
                txtID.Text = vis.ID.ToString();
                txtFName.Text = vis.FirstName;
                txtLName.Text = vis.LastName;
                txtSpotNr.Text = vis.SpotNr;
                txtSpotSection.Text = vis.SpotSection;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid tag");
            }
        }


    }
}
