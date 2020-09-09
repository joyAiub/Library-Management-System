using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Transaction : Form
    {
        string ID;
        public Transaction(string id)
        {
            InitializeComponent();
            ID = id;
            //Initialization:
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from TransactionReport  where UserId='" + id + "'", con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView1.DataSource = source;

            //Disconnect
            con.Close();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeWindow w = new WelcomeWindow(ID);
            w.Show();
        }
    }
}
