using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafemgmt
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Likhitha Reddy\OneDrive\Documents\cafedb.mdf"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "SELECT * from T";
            SqlDataAdapter sda=new SqlDataAdapter(query, con);
            SqlCommandBuilder builder= new SqlCommandBuilder(sda);
            var dt = new DataSet(); 
            sda.Fill(dt);
            UsersGridView.DataSource = dt.Tables[0];
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder uorder=new UserOrder();
            this.Hide();
            uorder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemsForm iform=new ItemsForm();
            this.Hide();
            iform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into T values('"+UnameTb.Text+"','"+UphoneTb.Text+"','"+UpassTb.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Inserted Successfully");
            
            con.Close();
            populate();
        }

        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = UsersGridView.Rows[e.RowIndex];

                // Get data from the selected row and populate TextBox controls
                UnameTb.Text = selectedRow.Cells["Uname"].Value?.ToString() ?? "";
                UphoneTb.Text = selectedRow.Cells["Uphone"].Value?.ToString() ?? "";
                UpassTb.Text = selectedRow.Cells["Upassword"].Value?.ToString() ?? "";
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(UphoneTb.Text=="")
            {
                MessageBox.Show("Select the User to be deleted");
            }
            else
            {
                con.Open();
                string query = "DELETE from T where Uphone='" + UphoneTb.Text + "'";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully");
                
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text==""||UphoneTb.Text==""||UpassTb.Text=="")
            {
                MessageBox.Show("Fill all the fields");

            }
            else
            {
                con.Open();
                string query = "update T set Uname='" + UnameTb.Text + "',Upassword='" + UpassTb.Text + "' where Uphone='" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                con.Close();
                populate();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
