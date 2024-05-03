using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace cafemgmt
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Likhitha Reddy\OneDrive\Documents\cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "SELECT * from ItemTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            ItemsGridView.DataSource = dt.Tables[0];
            con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            this.Hide();
            uorder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserForm uform = new UserForm();
            this.Hide();
            uform.Show();
        }

        private void INoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                con.Open();
                string query = "Insert into ItemTable values('" + ItemNoTb.Text + "','" + ItemNameTb.Text + "','" + ItemcatTb.SelectedItem.ToString() + "','"+ItemPriceTb.Text+"')";
                SqlCommand cmd = con.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText= query;
                cmd.ExecuteNonQuery();
            con.Close();
                MessageBox.Show("Item Inserted Successfully");

        
                populate();
            
            }

        private void ItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ItemsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = ItemsGridView.Rows[e.RowIndex];

                // Get data from the selected row and populate TextBox controls
                ItemNoTb.Text = selectedRow.Cells["ItemNo"].Value?.ToString() ?? "";
                ItemNameTb.Text = selectedRow.Cells["ItemName"].Value?.ToString() ?? "";
                ItemcatTb.SelectedItem = selectedRow.Cells["Itemcat"].Value?.ToString() ?? "";
                ItemPriceTb.Text = selectedRow.Cells["ItemPrice"].Value?.ToString() ?? "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (ItemNoTb.Text == "")
            {
                MessageBox.Show("Select the User to be deleted");
            }
            else
            {
                con.Open();
                string query = "DELETE from ItemTable where ItemNo='" + ItemNoTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Deleted Successfully");

                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNoTb.Text == "" || ItemNameTb.Text == "" || ItemcatTb.Text == "" || ItemPriceTb.Text=="")
            {
                MessageBox.Show("Fill all the fields");

            }
            else
            {
                con.Open();
                string query = "update ItemTable set ItemName='" + ItemNameTb.Text + "',Itemcat='" + ItemcatTb.Text + "',ItemPrice='"+ItemPriceTb.Text+"' where ItemNo='" + ItemNoTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Updated");
                con.Close();
                populate();

            }
        }
    }
    }

