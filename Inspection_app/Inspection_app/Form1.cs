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
        DBExtractor retriever;

        public Form1()
        {
            InitializeComponent();

            retriever = new DBExtractor();
        }

        private void btnAccountsOverview_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.AppendText(retriever.Test().ToString());
        }
    }
}
