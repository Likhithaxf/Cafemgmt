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

namespace cafemgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Likhitha Reddy\OneDrive\Documents\cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static string user; 

        private void button1_Click(object sender, EventArgs e)
        {
            /*UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();*/
            user = UnameTb.Text;
            if(UnameTb.Text==""||passwordtb.Text=="")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from T where Uname='" + UnameTb.Text + "'and Upassword='" + passwordtb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    UserOrder uorder = new UserOrder();
                    uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                con.Close();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
