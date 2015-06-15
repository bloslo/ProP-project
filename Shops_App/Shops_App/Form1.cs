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

namespace Shops_App
{
    public partial class Form1 : Form
    {
        private DBLink link;
        private RFID buyer;
        private List<Product> order;

        public Form1()
        {
            InitializeComponent();

            link = new DBLink();

            LoadProducts();
            InitializeRFID();
            comboBoxShopID.SelectedIndex = 0;

            order = new List<Product>();
        }

        private void InitializeRFID()
        {
            try
            {
                buyer = new RFID();
                buyer.open();
                buyer.waitForAttachment(3000);
                MessageBox.Show("RFID successfully attached!");
                buyer.Antenna = true;
                buyer.LED = true;
                buyer.Tag += new TagEventHandler(ProcessTag);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Attach the RFID reader!");
            }
        }

        private void ProcessTag(object sender, TagEventArgs e)
        {
            ClearTextBoxes(this);
            listBoxOrdered.Items.Clear();
            Visitor vis = link.FindVisitor(e.Tag);

            try
            {
                txtID.Text = vis.UserID.ToString();
                txtRFID.Text = e.Tag;
                btnAddItem.Enabled = true;
            }
            catch (NullReferenceException)
            {
                btnAddItem.Enabled = false;
                btnRemoveItem.Enabled = false;
                MessageBox.Show("Visitor not found!");
            }
        }

        private void LoadProducts()
        {
            listBoxAll.Items.Clear();

            foreach (Product prod in link.AllProducts())
            {
                listBoxAll.Items.Add(prod.DisplayInfo());
            }
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control box in parent.Controls)
            {
                if (box is TextBox)
                    (box as TextBox).Clear();
            }
        }

        private void UpdateOrderedListBox()
        {
            listBoxOrdered.Items.Clear();

            foreach (Product consum in order)
                listBoxOrdered.Items.Add(consum.DisplayInfo());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<Product> all = link.AllProducts();
            bool updated = false;

            try
            {
                for (int index = 0; index < all.Count; index++)
                {
                    if (listBoxAll.SelectedIndex == index)
                    {
                        Product.Purchase(all[index]);

                        if (order.Count != 0)
                        {
                            foreach (Product item in order)
                            {
                                if (item.ProductID == all[index].ProductID)
                                {
                                    item.Quantity += 1;
                                    UpdateOrderedListBox();
                                    updated = true;
                                }
                            }

                            if (updated == false)
                            {
                                order.Add(all[index]);
                                UpdateOrderedListBox();
                            }

                        }
                        else
                        {
                            order.Add(all[index]);
                            UpdateOrderedListBox();
                        }

                        link.DecreaseQuantity(all[index].ProductID);

                        if (txtTotal.Text == "")
                        {
                            txtTotal.Text += all[index].Price;
                            btnRemoveItem.Enabled = true;
                        }
                        else
                        {
                            decimal total = all[index].Price + Convert.ToDecimal(txtTotal.Text);
                            txtTotal.Text = total.ToString();
                        }
                    }
                }

                LoadProducts();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select product!");
            }
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                link.RegisterPurchase(Convert.ToInt32(txtID.Text), Convert.ToInt32(comboBoxShopID.SelectedItem), order);

                txtBalanceLeft.Text = link.Buy(txtRFID.Text, Convert.ToDecimal(txtTotal.Text)).ToString();
                btnAddItem.Enabled = false;
                btnRemoveItem.Enabled = false;
                order.Clear();
                btnMakePayment.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Order some food/drinks!");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxOrdered.Items.Count != 0)
            {
                for (int j = 0; j < order.Count; j++)
                {
                    if (j == listBoxOrdered.SelectedIndex && listBoxOrdered.Items.Count != 0)
                    {
                        listBoxOrdered.Items.RemoveAt(j);
                        decimal total = Convert.ToDecimal(txtTotal.Text) - order[j].Price;
                        txtTotal.Text = total.ToString();
                        link.RestoreQuantity(order[j].ProductID, order[j].Quantity);
                        order.RemoveAt(j);

                        break;
                    }
                }

                LoadProducts();
            }
            else
                MessageBox.Show("No items to remove!");
        }

        

        
    }
}
