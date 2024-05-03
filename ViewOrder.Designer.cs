namespace cafemgmt
{
    partial class ViewOrder
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
            this.ViewOrders = new System.Windows.Forms.DataGridView();
            this.orderlist = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.orderlist);
            this.panel1.Controls.Add(this.ViewOrders);
            this.panel1.Location = new System.Drawing.Point(33, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 770);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ViewOrders
            // 
            this.ViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.ViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrders.Location = new System.Drawing.Point(29, 105);
            this.ViewOrders.Name = "ViewOrders";
            this.ViewOrders.RowHeadersWidth = 51;
            this.ViewOrders.RowTemplate.Height = 24;
            this.ViewOrders.Size = new System.Drawing.Size(628, 571);
            this.ViewOrders.TabIndex = 4;
            this.ViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewOrders_CellContentClick);
            // 
            // orderlist
            // 
            this.orderlist.AutoSize = true;
            this.orderlist.BackColor = System.Drawing.Color.White;
            this.orderlist.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlist.ForeColor = System.Drawing.Color.DeepPink;
            this.orderlist.Location = new System.Drawing.Point(190, 29);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(179, 33);
            this.orderlist.TabIndex = 5;
            this.orderlist.Text = "List Of Orders";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DeepPink;
            this.close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(252, 694);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(157, 38);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(779, 815);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ViewOrders;
        private System.Windows.Forms.Label orderlist;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}