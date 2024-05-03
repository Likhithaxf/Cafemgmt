namespace cafemgmt
{
    partial class UserOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Quantitytb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelorder = new System.Windows.Forms.Label();
            this.sellertb = new System.Windows.Forms.TextBox();
            this.Ordernotb = new System.Windows.Forms.TextBox();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Datetb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ViewOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Datetb);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Quantitytb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OrdersGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelorder);
            this.panel1.Controls.Add(this.sellertb);
            this.panel1.Controls.Add(this.Ordernotb);
            this.panel1.Controls.Add(this.ItemsGridView);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 730);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepPink;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(281, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 38);
            this.button5.TabIndex = 12;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Quantitytb
            // 
            this.Quantitytb.BackColor = System.Drawing.SystemColors.Menu;
            this.Quantitytb.CausesValidation = false;
            this.Quantitytb.Location = new System.Drawing.Point(118, 307);
            this.Quantitytb.Name = "Quantitytb";
            this.Quantitytb.Size = new System.Drawing.Size(134, 22);
            this.Quantitytb.TabIndex = 11;
            this.Quantitytb.Text = "Quantity";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(530, 674);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Place the Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(118, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(325, 440);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(679, 218);
            this.OrdersGridView.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(586, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your Order";
            // 
            // labelorder
            // 
            this.labelorder.AutoSize = true;
            this.labelorder.BackColor = System.Drawing.Color.White;
            this.labelorder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelorder.ForeColor = System.Drawing.Color.DeepPink;
            this.labelorder.Location = new System.Drawing.Point(750, 674);
            this.labelorder.Name = "labelorder";
            this.labelorder.Size = new System.Drawing.Size(176, 33);
            this.labelorder.TabIndex = 6;
            this.labelorder.Text = "Order Amount";
            this.labelorder.Click += new System.EventHandler(this.label2_Click);
            // 
            // sellertb
            // 
            this.sellertb.BackColor = System.Drawing.SystemColors.Menu;
            this.sellertb.CausesValidation = false;
            this.sellertb.Enabled = false;
            this.sellertb.Location = new System.Drawing.Point(118, 250);
            this.sellertb.Name = "sellertb";
            this.sellertb.Size = new System.Drawing.Size(134, 22);
            this.sellertb.TabIndex = 5;
            this.sellertb.Text = "Seller";
            // 
            // Ordernotb
            // 
            this.Ordernotb.BackColor = System.Drawing.SystemColors.Menu;
            this.Ordernotb.CausesValidation = false;
            this.Ordernotb.Location = new System.Drawing.Point(118, 197);
            this.Ordernotb.Name = "Ordernotb";
            this.Ordernotb.Size = new System.Drawing.Size(134, 22);
            this.Ordernotb.TabIndex = 4;
            this.Ordernotb.Text = "Order No";
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Location = new System.Drawing.Point(406, 127);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.RowHeadersWidth = 51;
            this.ItemsGridView.RowTemplate.Height = 24;
            this.ItemsGridView.Size = new System.Drawing.Size(549, 219);
            this.ItemsGridView.TabIndex = 3;
            this.ItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView_CellContentClick);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.categorycb.Location = new System.Drawing.Point(118, 127);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(157, 39);
            this.categorycb.TabIndex = 2;
            this.categorycb.Text = "Category";
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangedCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(478, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(12, 747);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(1296, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Location = new System.Drawing.Point(12, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DeepPink;
            this.button4.Location = new System.Drawing.Point(12, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Datetb
            // 
            this.Datetb.AutoSize = true;
            this.Datetb.BackColor = System.Drawing.Color.White;
            this.Datetb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datetb.ForeColor = System.Drawing.Color.DeepPink;
            this.Datetb.Location = new System.Drawing.Point(852, 19);
            this.Datetb.Name = "Datetb";
            this.Datetb.Size = new System.Drawing.Size(69, 33);
            this.Datetb.TabIndex = 13;
            this.Datetb.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(698, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "RS";
            // 
            // ViewOrder
            // 
            this.ViewOrder.BackColor = System.Drawing.Color.DeepPink;
            this.ViewOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewOrder.Location = new System.Drawing.Point(943, 674);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(162, 38);
            this.ViewOrder.TabIndex = 15;
            this.ViewOrder.Text = "View Order";
            this.ViewOrder.UseVisualStyleBackColor = false;
            this.ViewOrder.Click += new System.EventHandler(this.ViewOrder_Click);
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1340, 811);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Quantitytb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelorder;
        private System.Windows.Forms.TextBox sellertb;
        private System.Windows.Forms.TextBox Ordernotb;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Datetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewOrder;
    }
}