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

    public partial class WelcomeWindow : Form
    {
        string ID, Username;

        public WelcomeWindow(string id)
        {

            InitializeComponent();
            ID = id;

            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from UserLogin where UserId='" + id + "'", con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView2.DataSource = source;

            DataGridViewRow selectedRow = dataGridView2.Rows[0];

            viewId.Text = selectedRow.Cells[0].Value.ToString();
            pass.Text = selectedRow.Cells[1].Value.ToString();
            name.Text = selectedRow.Cells[2].Value.ToString();
            Username = name.Text.ToString();
            this.Text = "Welcome " + Username;

            address.Text = selectedRow.Cells[3].Value.ToString();
            mobile.Text = selectedRow.Cells[4].Value.ToString();
            borrowertype.Text = selectedRow.Cells[5].Value.ToString();
            status.Text = selectedRow.Cells[6].Value.ToString();
            email.Text = selectedRow.Cells[7].Value.ToString();

            dataGridView2.Hide();

            //Disconnect
            con.Close();

            //Borrow Book
            //Initiating SQL Connection:
            SqlConnection con1 = new SqlConnection();

            //ConnectionString:
            con1.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            SqlCommand cmd = new SqlCommand("select * from Book", con1);

            //Opening the connection:
            con1.Open();

            //Execute SQL Query:
            SqlDataReader DR1 = cmd.ExecuteReader();

            //Binding reader to binding source
            BindingSource source1 = new BindingSource();
            source1.DataSource = DR1;

            //Binding gridview or control datacsource to binding source:
            BookGridView.DataSource = source1;

            //Disconnect
            con1.Close();



        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            string sql = "UPDATE UserLogin SET Password = " + " '" + pass.Text + "'" + ",Address = " + " '" + address.Text + "'" + ",MobileNo = " + " '" + mobile.Text + "'" + ",Status = " + " '" + status.Text + "'" + ",Email = " + " '" + email.Text + "'" + "where UserId=" + ID;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                int i = 0;
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("UserId", SqlDbType.VarChar, 50).Value = ID;

                cmd.CommandType = CommandType.Text;
                i = cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
                if (i < 1)
                {
                    MessageBox.Show("Your profile is up to date!");


                }
                else if (i >= 1)
                {
                    MessageBox.Show("Information Successfully updated!");
                }
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                ////////

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
                dataGridView2.DataSource = source;

                dataGridView2.Hide();

                con.Close();
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void BookGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.BookGridView.Rows[e.RowIndex];
                showBookId.Text = r.Cells["BookId"].Value.ToString();
                showBookName.Text = r.Cells["BookName"].Value.ToString();
                showAuthor.Text = r.Cells["Author"].Value.ToString();
                showAvailable.Text = r.Cells["BookQuantity"].Value.ToString();
                if (int.Parse(showAvailable.Text) == 0)
                {
                    MessageBox.Show("Sorry, The Book is Unavaiable .You Can'nt Borrow this book");
                }
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction t = new Transaction(ID);
            t.Show();
        }

        private void showBookId_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void Borrow_Click_1(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            //Generating SQL Query
            string sql = "INSERT INTO TransactionReport(UserId,BookId) VALUES(@param1,@param2)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = viewId.Text.ToString();
                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = int.Parse(showBookId.Text);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }


            if ((int.Parse(showAvailable.Text)) != 0)
            {
                //Initiating SQL Connection:
                SqlConnection con1 = new SqlConnection();


                //ConnectionString:
                con1.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                           "database = Library;" +
                           "integrated security = true";

                //Generating SQL Query
                string sql1 = "UPDATE Book SET BookQuantity = " + " '" + (int.Parse(showAvailable.Text) - 1) + "'" + "where BookId=" + int.Parse(showBookId.Text);
                using (SqlCommand cmd = new SqlCommand(sql1, con1))
                {
                    //Opening the connection:
                    con1.Open();

                    cmd.Parameters.Add("BookId", SqlDbType.Int).Value = int.Parse(showBookId.Text);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //Disconnect
                    con1.Close();


                    BookGridView.Rows.Clear();
                    BookGridView.Refresh();

                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void returnbookbtn_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con1 = new SqlConnection();


            //ConnectionString:
            con1.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                       "database = Library;" +
                       "integrated security = true";

            //Generating SQL Query
            string sql1 = "UPDATE Book SET BookQuantity = " + " '" + (int.Parse(showAvailable.Text)+1) + "'" + "where BookId=" + int.Parse(showBookId.Text);
            using (SqlCommand cmd = new SqlCommand(sql1, con1))
            {
                //Opening the connection:
                con1.Open();

                cmd.Parameters.Add("BookId", SqlDbType.Int).Value = int.Parse(showBookId.Text);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con1.Close();


                BookGridView.Rows.Clear();
                BookGridView.Refresh();

            }
        }

    }
}

