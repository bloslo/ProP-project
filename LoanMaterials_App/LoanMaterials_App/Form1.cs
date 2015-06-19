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

namespace LoanMaterials_App
{
    public partial class Form1 : Form
    {
        private DB_Connection connector;
        private RFID reader;
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();

            connector = new DB_Connection();
            items = new List<Item>();

            InitializeRFID();
            LoadAllItems();
        }

        private void LoadAllItems()
        {
            lbAllItems.Items.Clear();

            try
            {
                foreach (Item item in connector.GetAllItems())
                {
                    lbAllItems.Items.Add(item.Info());
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Items not loaded!");
            }
        }

        private void InitializeRFID()
        {
            try
            {
                reader = new RFID();
                reader.open();
                reader.waitForAttachment(3000);
                MessageBox.Show("RFID reader attached successfully!");
                reader.Antenna = true;
                reader.LED = true;
                reader.Tag += new TagEventHandler(ProcessTag);
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                    (child as TextBox).Clear();
            }
        }

        private void ProcessTag(object sender, TagEventArgs e)
        {
            ClearTextBoxes(this);
            listBoxLoanedItems.Items.Clear();
            Visitor vis = connector.GetVisitor(e.Tag);

            try
            {
                txtRFID.Text = e.Tag;
                txtID.Text = vis.ID.ToString();
                txtRentDate.Text = DateTime.Now.Date.ToString("dd-MMMM-yyyy");
                btnAddItem.Enabled = true;
            }
            catch (NullReferenceException)
            {
                btnAddItem.Enabled = false;
                btnRemoveItem.Enabled = false;
                MessageBox.Show("No such visitor!");
            }
        }

        private void UpdateLoanedLoanedLB()
        {
            listBoxLoanedItems.Items.Clear();

            foreach (Item i in items)
                listBoxLoanedItems.Items.Add(i.Info());
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = Convert.ToDecimal(txtTotal.Text);
                connector.Register(Convert.ToInt32(txtID.Text), items, total);

                txtBalanceLeft.Text = connector.Pay(txtRFID.Text, Convert.ToDecimal(txtTotal.Text)).ToString();

                btnAddItem.Enabled = false;
                btnRemoveItem.Enabled = false;
                listBoxLoanedItems.Items.Clear();
                items.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Borrow some items!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            listBoxLoanedItems.Items.Clear();
            List<Item> loaned = connector.LoanedItems(Convert.ToInt32(txtID.Text));
            int orderId = 0;

            if (loaned.Count != 0)
            {
                foreach (Item item in loaned)
                {
                    connector.DiscardItem(item.ItemID, item.Quantity);
                }

                listBoxLoanedItems.Items.Clear();
                txtReturnDate.Text = DateTime.Now.Date.ToString("dd-MMMM-yyyy");
                connector.Return(Convert.ToInt32(txtID.Text));
                LoadAllItems();
            }
            else
                MessageBox.Show("No items for return!");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<Item> allItems = connector.GetAllItems();
            bool updated = false;


            for (int index = 0; index < allItems.Count; index++)
            {

                if (lbAllItems.SelectedIndex == index)
                {
                    Item.TakeFromStock(allItems[index]);

                    if (items.Count != 0)
                    {
                        foreach (Item item in items)
                        {
                            if (item.ItemID == allItems[index].ItemID)
                            {
                                item.Quantity += 1;
                                UpdateLoanedLoanedLB();
                                updated = true;
                            }
                        }

                        if (updated == false)
                        {
                            items.Add(allItems[index]);
                            UpdateLoanedLoanedLB();
                        }
                    }
                    else
                    {
                        items.Add(allItems[index]);
                        UpdateLoanedLoanedLB();
                    }

                    connector.BorrowItem(allItems[index].ItemID);

                    if (txtTotal.Text == "")
                    {
                        txtTotal.Text += allItems[index].Price;
                        btnRemoveItem.Enabled = true;
                    }
                    else
                    {
                        decimal total = allItems[index].Price + Convert.ToDecimal(txtTotal.Text);
                        txtTotal.Text = total.ToString();
                    }
                }
            }

            LoadAllItems();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxLoanedItems.Items.Count != 0)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (j == listBoxLoanedItems.SelectedIndex)
                    {
                        listBoxLoanedItems.Items.RemoveAt(j);
                        decimal total = Convert.ToDecimal(txtTotal.Text) - items[j].Price;
                        txtTotal.Text = total.ToString();
                        connector.DiscardItem(items[j].ItemID, items[j].Quantity);
                        items.RemoveAt(j);

                        break;
                    }
                }

                LoadAllItems();
            }
            else
                MessageBox.Show("No items to discard!");
        }

        private void btnShowRentedItems_Click(object sender, EventArgs e)
        {
            listBoxLoanedItems.Items.Clear();

            try
            {
                foreach (Item item in connector.LoanedItems(Convert.ToInt32(txtID.Text)))
                {
                    listBoxLoanedItems.Items.Add(item.ShortInfo());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Check a tag!");
            }
        }

        
    }
}
