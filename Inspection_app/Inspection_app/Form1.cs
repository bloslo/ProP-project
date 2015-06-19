using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inspection_app
{
    public partial class Form1 : Form
    {
        DB_Connector retriever;

        public Form1()
        {
            InitializeComponent();

            retriever = new DB_Connector();

            LoadVisIDs();
            LoadProdIDs();
            comboBoxShopID.SelectedIndex = 0;
        }

        private void LoadVisIDs()
        {
            try
            {
                foreach (int id in retriever.GetAllVisitorsID())
                {
                    comboBoxId.Items.Add(id);
                }

                comboBoxId.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProdIDs()
        {
            try
            {
                foreach (int prodId in retriever.ProductsIDs())
                {
                    comboBoxProductID.Items.Add(prodId);
                }

                comboBoxProductID.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Visitor person = retriever.GetVisitor(Convert.ToInt32(comboBoxId.Text));

                txtName.Text = person.Name;
                txtBalance.Text = person.AccountBalance.ToString();
                txtStatus.Text = person.Status;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, select visitor ID from the combobox!");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int visId = Convert.ToInt32(comboBoxId.Text);

                Visitor vis = retriever.GetVisitor(visId);
                decimal foodExpenses = retriever.FoodExpenses(visId);
                decimal transfered = retriever.TransferedMoney(visId);

                string output = string.Format("Entrance Price: {0} \nFood Expenses: {1:F2} \nTransfered money: {2:F2}",
                    vis.EntranceFee, foodExpenses, transfered);

                txtName.Text = vis.Name;
                richTextBoxInfo.Clear();
                richTextBoxInfo.AppendText(output);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Select visitor ID from the combobox!");
            }
        }

        private void btnShowProfit_Click(object sender, EventArgs e)
        {
            try
            {
                int shopId = Convert.ToInt32(comboBoxShopID.Text);

                txtProfit.Text = retriever.ShopProfit(shopId).ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoldQunatity_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(comboBoxProductID.Text);

                Product prod = retriever.ProductOverview(productId);

                txtProductName.Text = prod.Name;
                txtQuantity.Text = prod.UnitsSold.ToString();
                txtStock.Text = prod.Stock.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("This item has not yet sold any units!");
            }
        }

        private void btnVisitorsOverview_Click(object sender, EventArgs e)
        {
            try
            {
                int comingVisitors = retriever.FutureVisitors();
                int presentVisitors = retriever.PresentVisitors();
                int leftVisitors = retriever.LeftVisitors();

                string display = string.Format("Visitors yet to come: {0} \nVisitors visiting the event: {1} " +
                    "\nVisitors that left the event: {2}", comingVisitors, presentVisitors, leftVisitors);

                richTextBoxInfo.Clear();

                richTextBoxInfo.AppendText(display);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccountsOverview_Click(object sender, EventArgs e)
        {
            try
            {
                decimal shopsProfits = retriever.AllShopsRevenue();
                decimal itemsProfit = retriever.RevenueRentedItems();
                decimal allEventAcc = retriever.TotalAllEventAcc();

                string result = string.Format("Total of all event accounts: {0} \nTotal revenue from shops: {1} " +
                    "\nTotal revenue from rented items: {2}", allEventAcc, shopsProfits, itemsProfit);

                richTextBoxInfo.Clear();

                richTextBoxInfo.AppendText(result);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCampingOverview_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxInfo.Clear();

                foreach (Camp spot in retriever.FreeCampSpots())
                {
                    richTextBoxInfo.AppendText(spot.Info());
                    richTextBoxInfo.AppendText("\n\n");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
