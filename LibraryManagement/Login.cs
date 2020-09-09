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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            /*
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from UserLogin", con);

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
            con.Close();*/
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection("data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true");

            SqlDataAdapter sda = new SqlDataAdapter("Select * from UserLogin where UserID ='" + getId.Text.ToString() + "'and Password ='" + getPass.Text.ToString() + "'", con);
            DataTable DT = new DataTable();
            sda.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                WelcomeWindow firstWindow = new WelcomeWindow(getId.Text.ToString());
                firstWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            borrower_info userinfo = new borrower_info();
            userinfo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
