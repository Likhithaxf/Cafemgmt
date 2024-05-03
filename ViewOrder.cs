using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafemgmt
{
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Likhitha Reddy\OneDrive\Documents\cafedb.mdf"";Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "SELECT * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dt = new DataSet();
            sda.Fill(dt);
            ViewOrders.DataSource = dt.Tables[0];
            con.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            populate();

        }

        private void ViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display the print dialog
            DialogResult result = printDialog1.ShowDialog();

            // Check the result of the dialog
            if (result == DialogResult.OK)
            {
                // User clicked OK, so print the document
                printDocument1.Print();
            }
            else if (result == DialogResult.Cancel)
            {
                // User clicked Cancel, handle accordingly (e.g., show a message)
                MessageBox.Show("Printing cancelled by the user.");
            }
            else if (result == DialogResult.Abort)
            {
                // Printing was aborted, handle accordingly
                MessageBox.Show("Printing aborted.");
            }
            // Handle other possible DialogResult values if necessary

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===========Order Summary============", new Font("century", 25, FontStyle.Bold), Brushes.Red, new Point(200));
        }
    }
}
