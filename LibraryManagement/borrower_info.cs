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
    public partial class borrower_info : Form
    {
        public borrower_info()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string type="Student", status="Active";
            if (UserFaculty.Checked == true)
            {
                type = "Faculty";
            }
            if (InactiveUser.Checked == true)
            {
                status = "Inactive";
            }
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-QPUU33H;" +
                                   "database = Library;" +
                                   "integrated security = true";

            
            //Generating SQL Query
            string sql = "INSERT INTO UserLogin(UserId,Password,Name,Address,MobileNo,BorrowerType,Status,Email) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = userId.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = userPass.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = userName.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = userAddress.Text;
                cmd.Parameters.Add("@param5", SqlDbType.NVarChar, 50).Value = userMobile.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = type;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = status;
                cmd.Parameters.Add("@param8", SqlDbType.VarChar, 50).Value = userEmail.Text;

                if (string.IsNullOrWhiteSpace(userId.Text) && string.IsNullOrWhiteSpace(userPass.Text))
                {
                    MessageBox.Show("Please fill the required information: UserID & Password");
                }
                else
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    this.Hide();
                    Login log = new Login();
                    log.Show();
                }

            }

            
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
