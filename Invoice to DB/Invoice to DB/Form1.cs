using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Invoice_to_DB
{
    public partial class Form1 : Form
    {
        private DBHelper helper;

        public Form1()
        {
            InitializeComponent();

            helper = new DBHelper();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFile.FileName;
                    btnInvoiceToDB.Enabled = true;
                }
            }
        }

        private List<Deposit> ReadLogFile()
        {
            List<Deposit> deposits;
            FileStream file = null;
            StreamReader reader = null;

            try
            {
                deposits = new List<Deposit>();
                file = new FileStream(txtFilePath.Text, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);

                int depId = 0;
                int userId = 0;
                decimal amount = 0;
                DateTime date = DateTime.Now;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    depId = Convert.ToInt32(line);
                    line = reader.ReadLine();
                    date = Convert.ToDateTime(line);
                    line = reader.ReadLine();
                    userId = Convert.ToInt32(line);
                    line = reader.ReadLine();
                    amount = Convert.ToDecimal(line);
                    deposits.Add(new Deposit(depId, userId, amount, date));

                    if (reader.ReadLine().StartsWith("*"))
                    {
                        continue;
                    }
                }

                return deposits;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                reader.Close();
                file.Close();
            }
        }

        private void btnInvoiceToDB_Click(object sender, EventArgs e)
        {
            try
            {
                helper.InsertDepositsIntoDB(ReadLogFile());

                MessageBox.Show("Successful transaction!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
