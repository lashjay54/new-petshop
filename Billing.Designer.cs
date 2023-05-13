namespace new_pet_shop
{
    partial class billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            this.txtbillcustomername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbbillcustomerid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbillproductquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbillproductprice = new System.Windows.Forms.TextBox();
            this.txtbillreset = new System.Windows.Forms.Button();
            this.btnbilladdtobill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbillproductname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BillGDV = new System.Windows.Forms.DataGridView();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillGDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbillcustomername
            // 
            this.txtbillcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillcustomername.Location = new System.Drawing.Point(268, 87);
            this.txtbillcustomername.Name = "txtbillcustomername";
            this.txtbillcustomername.Size = new System.Drawing.Size(234, 30);
            this.txtbillcustomername.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(265, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = " Customer Name";
            // 
            // ProductDGV
            // 
            this.ProductDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(23, 460);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 24;
            this.ProductDGV.Size = new System.Drawing.Size(615, 225);
            this.ProductDGV.TabIndex = 20;
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(28)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.cmbbillcustomerid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbillcustomername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 158);
            this.panel1.TabIndex = 19;
            // 
            // cmbbillcustomerid
            // 
            this.cmbbillcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbillcustomerid.FormattingEnabled = true;
            this.cmbbillcustomerid.Location = new System.Drawing.Point(29, 87);
            this.cmbbillcustomerid.Name = "cmbbillcustomerid";
            this.cmbbillcustomerid.Size = new System.Drawing.Size(234, 33);
            this.cmbbillcustomerid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(28)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtbillproductquantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbillproductprice);
            this.panel2.Controls.Add(this.txtbillreset);
            this.panel2.Controls.Add(this.btnbilladdtobill);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtbillproductname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(23, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 181);
            this.panel2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label10.Location = new System.Drawing.Point(409, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Product Quntity";
            // 
            // txtbillproductquantity
            // 
            this.txtbillproductquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillproductquantity.Location = new System.Drawing.Point(412, 86);
            this.txtbillproductquantity.Name = "txtbillproductquantity";
            this.txtbillproductquantity.Size = new System.Drawing.Size(174, 30);
            this.txtbillproductquantity.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(215, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product Price";
            // 
            // txtbillproductprice
            // 
            this.txtbillproductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillproductprice.Location = new System.Drawing.Point(218, 86);
            this.txtbillproductprice.Name = "txtbillproductprice";
            this.txtbillproductprice.Size = new System.Drawing.Size(174, 30);
            this.txtbillproductprice.TabIndex = 19;
            // 
            // txtbillreset
            // 
            this.txtbillreset.Location = new System.Drawing.Point(344, 148);
            this.txtbillreset.Name = "txtbillreset";
            this.txtbillreset.Size = new System.Drawing.Size(139, 33);
            this.txtbillreset.TabIndex = 18;
            this.txtbillreset.Text = "Reset";
            this.txtbillreset.UseVisualStyleBackColor = true;
            this.txtbillreset.Click += new System.EventHandler(this.txtbillreset_Click);
            // 
            // btnbilladdtobill
            // 
            this.btnbilladdtobill.Location = new System.Drawing.Point(169, 148);
            this.btnbilladdtobill.Name = "btnbilladdtobill";
            this.btnbilladdtobill.Size = new System.Drawing.Size(139, 33);
            this.btnbilladdtobill.TabIndex = 17;
            this.btnbilladdtobill.Text = "Add To Bill";
            this.btnbilladdtobill.UseVisualStyleBackColor = true;
            this.btnbilladdtobill.Click += new System.EventHandler(this.btnbilladdtobill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(17, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product Name";
            // 
            // txtbillproductname
            // 
            this.txtbillproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillproductname.Location = new System.Drawing.Point(20, 86);
            this.txtbillproductname.Name = "txtbillproductname";
            this.txtbillproductname.Size = new System.Drawing.Size(174, 30);
            this.txtbillproductname.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product";
            // 
            // BillGDV
            // 
            this.BillGDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.BillGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGDV.Location = new System.Drawing.Point(763, 55);
            this.BillGDV.Name = "BillGDV";
            this.BillGDV.RowHeadersWidth = 51;
            this.BillGDV.RowTemplate.Height = 24;
            this.BillGDV.Size = new System.Drawing.Size(537, 344);
            this.BillGDV.TabIndex = 23;
            this.BillGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillGDV_CellContentClick);
            // 
            // TransactionDGV
            // 
            this.TransactionDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDGV.Location = new System.Drawing.Point(703, 513);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.RowHeadersWidth = 51;
            this.TransactionDGV.RowTemplate.Height = 24;
            this.TransactionDGV.Size = new System.Drawing.Size(597, 172);
            this.TransactionDGV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(948, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Transactions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(930, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Products Bill";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(1126, 405);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(174, 30);
            this.txttotal.TabIndex = 28;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(763, 405);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(139, 33);
            this.btnprint.TabIndex = 29;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.txtprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(7)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1329, 713);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransactionDGV);
            this.Controls.Add(this.BillGDV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing";
            this.Text = "billing";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillGDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbillcustomername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbbillcustomerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbillproductname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BillGDV;
        private System.Windows.Forms.DataGridView TransactionDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbillproductquantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbillproductprice;
        private System.Windows.Forms.Button txtbillreset;
        private System.Windows.Forms.Button btnbilladdtobill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}