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
using System.Web.UI.WebControls;

namespace cafemgmt
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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
        void filterbycat()
        {
            con.Open();
            string query = "SELECT * from ItemTable where Itemcat='" + categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            ItemsGridView.DataSource = dt.Tables[0];
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("itemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(string));
            table.Columns.Add("TotalAmt", typeof(int));
            OrdersGridView.DataSource = table;
            Datetb.Text=DateTime.Today.Date.ToString();


        }
        int num = 0;
        int unitprice, total;
        string item, cat;
        int flag = 0;
        DataTable table=new DataTable();
        int sum = 0;

        private void labelorder_Click(object sender, EventArgs e)
        {

        }

        private void ItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = ItemsGridView.Rows[e.RowIndex];

                // Get data from the selected row and populate TextBox controls
                item = selectedRow.Cells["ItemName"].Value?.ToString() ?? "";
                cat = selectedRow.Cells["Itemcat"].Value?.ToString() ?? "";
                unitprice = Convert.ToInt32(selectedRow.Cells["ItemPrice"].Value?.ToString() ?? "");
            }
            flag = 1;
        }

        private void Datetb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into OrdersTbl values('" + OrderNumtb.Text + "','" + Datetb.Text + "','" + SellerNametb.Text + "','"+labelorder.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Inserted Successfully");

            con.Close();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Quantitytb.Text == "")
            {
                MessageBox.Show("Enter the Quantity of Items");

            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the products to be ordered");

            }
            else
            {
                num = num + 1;
                total = unitprice * Convert.ToInt32(Quantitytb.Text);
                table.Rows.Add(num, item, cat, unitprice, total);
                OrdersGridView.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            labelorder.Text = ""+sum;
        }

        private void categorycb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycat();
        }
    }
}
