namespace cafemgmt
{
    partial class GuestOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quantitytb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelorder = new System.Windows.Forms.Label();
            this.SellerNametb = new System.Windows.Forms.TextBox();
            this.OrderNumtb = new System.Windows.Forms.TextBox();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datetb = new System.Windows.Forms.Label();
            this.Rs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(12, 755);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Rs);
            this.panel1.Controls.Add(this.Datetb);
            this.panel1.Controls.Add(this.Quantitytb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OrdersGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelorder);
            this.panel1.Controls.Add(this.SellerNametb);
            this.panel1.Controls.Add(this.OrderNumtb);
            this.panel1.Controls.Add(this.ItemsGridView);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 730);
            this.panel1.TabIndex = 6;
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
            this.button2.Location = new System.Drawing.Point(615, 673);
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
            this.OrdersGridView.Location = new System.Drawing.Point(406, 423);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(549, 235);
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
            this.labelorder.Location = new System.Drawing.Point(952, 673);
            this.labelorder.Name = "labelorder";
            this.labelorder.Size = new System.Drawing.Size(176, 33);
            this.labelorder.TabIndex = 6;
            this.labelorder.Text = "Order Amount";
            this.labelorder.Click += new System.EventHandler(this.labelorder_Click);
            // 
            // SellerNametb
            // 
            this.SellerNametb.BackColor = System.Drawing.SystemColors.Menu;
            this.SellerNametb.CausesValidation = false;
            this.SellerNametb.Enabled = false;
            this.SellerNametb.Location = new System.Drawing.Point(118, 250);
            this.SellerNametb.Name = "SellerNametb";
            this.SellerNametb.Size = new System.Drawing.Size(134, 22);
            this.SellerNametb.TabIndex = 5;
            this.SellerNametb.Text = "Guest";
            // 
            // OrderNumtb
            // 
            this.OrderNumtb.BackColor = System.Drawing.SystemColors.Menu;
            this.OrderNumtb.CausesValidation = false;
            this.OrderNumtb.Location = new System.Drawing.Point(118, 197);
            this.OrderNumtb.Name = "OrderNumtb";
            this.OrderNumtb.Size = new System.Drawing.Size(134, 22);
            this.OrderNumtb.TabIndex = 4;
            this.OrderNumtb.Text = "Order No";
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
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.categorycb_SelectionChangeCommitted);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Datetb
            // 
            this.Datetb.AutoSize = true;
            this.Datetb.BackColor = System.Drawing.Color.White;
            this.Datetb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datetb.ForeColor = System.Drawing.Color.DeepPink;
            this.Datetb.Location = new System.Drawing.Point(1059, 19);
            this.Datetb.Name = "Datetb";
            this.Datetb.Size = new System.Drawing.Size(69, 33);
            this.Datetb.TabIndex = 12;
            this.Datetb.Text = "Date";
            this.Datetb.Click += new System.EventHandler(this.Datetb_Click);
            // 
            // Rs
            // 
            this.Rs.AutoSize = true;
            this.Rs.BackColor = System.Drawing.Color.White;
            this.Rs.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rs.ForeColor = System.Drawing.Color.DeepPink;
            this.Rs.Location = new System.Drawing.Point(886, 673);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(46, 33);
            this.Rs.TabIndex = 13;
            this.Rs.Text = "RS";
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1340, 811);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Label labelorder;
        private System.Windows.Forms.TextBox SellerNametb;
        private System.Windows.Forms.TextBox OrderNumtb;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantitytb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Datetb;
        private System.Windows.Forms.Label Rs;
    }
}