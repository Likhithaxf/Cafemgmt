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
    public partial class UserOrder : Form
    {
        public UserOrder()
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
            string query = "SELECT * from ItemTable where Itemcat='"+categorycb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            ItemsGridView.DataSource = dt.Tables[0];
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
            this.Hide();
            ItemsForm Items=new ItemsForm();
            Items.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm uform=new UserForm();
            uform.Show();
        }
        int num = 0;
        int unitprice, total;
        string item,cat;

        private void ItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = ItemsGridView.Rows[e.RowIndex];

                // Get data from the selected row and populate TextBox controls
                item = selectedRow.Cells["ItemName"].Value?.ToString() ?? "";
                cat= selectedRow.Cells["Itemcat"].Value?.ToString() ?? "";
                unitprice = Convert.ToInt32(selectedRow.Cells["ItemPrice"].Value?.ToString() ?? "");
            }
            flag = 1;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Quantitytb.Text=="")
            {
                MessageBox.Show("Enter the Quantity of Items");

            }
            else if(flag==0)
            {
                MessageBox.Show("Select the products to be ordered");

            }
            else
            {
                num = num + 1;
                total = unitprice * Convert.ToInt32(Quantitytb.Text);
                table.Rows.Add(num,item,cat,unitprice,total);
                OrdersGridView.DataSource=table;
                flag = 0;
            }
            sum = sum + total;
            labelorder.Text = ""  + sum;

        }
        DataTable table = new DataTable();
        int flag = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangedCommitted(object sender, EventArgs e)
        {
            filterbycat();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into OrdersTbl values('" + Ordernotb.Text + "','" + Datetb.Text + "','" + sellertb.Text + "','"+labelorder.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created");

            con.Close();
            populate();
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrder view=new ViewOrder();
            view.Show();
        }

        int sum = 0;
       
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Number" ,typeof(int));
            table.Columns.Add("itemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice",typeof(string));
            table.Columns.Add("TotalAmt", typeof (int));
            OrdersGridView.DataSource = table;
            Datetb.Text = DateTime.Today.Date.ToString();
            sellertb.Text = Form1.user;

        }
    }
}
