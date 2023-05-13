namespace new_pet_shop
{
    partial class product
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
            this.cmbpcatagory = new System.Windows.Forms.ComboBox();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.txtproductquntity = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductdelete = new System.Windows.Forms.Button();
            this.txtproducredit = new System.Windows.Forms.Button();
            this.btnproductsave = new System.Windows.Forms.Button();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(28)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.cmbpcatagory);
            this.panel1.Controls.Add(this.txtproductprice);
            this.panel1.Controls.Add(this.txtproductquntity);
            this.panel1.Controls.Add(this.txtproductname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtproductdelete);
            this.panel1.Controls.Add(this.txtproducredit);
            this.panel1.Controls.Add(this.btnproductsave);
            this.panel1.Location = new System.Drawing.Point(26, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 217);
            this.panel1.TabIndex = 1;
            // 
            // cmbpcatagory
            // 
            this.cmbpcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpcatagory.FormattingEnabled = true;
            this.cmbpcatagory.Items.AddRange(new object[] {
            "Bird",
            "Dog",
            "Cat",
            "Food"});
            this.cmbpcatagory.Location = new System.Drawing.Point(342, 83);
            this.cmbpcatagory.Name = "cmbpcatagory";
            this.cmbpcatagory.Size = new System.Drawing.Size(204, 33);
            this.cmbpcatagory.TabIndex = 17;
            // 
            // txtproductprice
            // 
            this.txtproductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductprice.Location = new System.Drawing.Point(978, 86);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(234, 30);
            this.txtproductprice.TabIndex = 16;
            // 
            // txtproductquntity
            // 
            this.txtproductquntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductquntity.Location = new System.Drawing.Point(682, 86);
            this.txtproductquntity.Name = "txtproductquntity";
            this.txtproductquntity.Size = new System.Drawing.Size(234, 30);
            this.txtproductquntity.TabIndex = 15;
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(70, 86);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(234, 30);
            this.txtproductname.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(975, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(679, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(67, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = " Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(339, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Catagory";
            // 
            // txtproductdelete
            // 
            this.txtproductdelete.Location = new System.Drawing.Point(777, 168);
            this.txtproductdelete.Name = "txtproductdelete";
            this.txtproductdelete.Size = new System.Drawing.Size(139, 33);
            this.txtproductdelete.TabIndex = 8;
            this.txtproductdelete.Text = "Delete";
            this.txtproductdelete.UseVisualStyleBackColor = true;
            this.txtproductdelete.Click += new System.EventHandler(this.txtproductdelete_Click);
            // 
            // txtproducredit
            // 
            this.txtproducredit.Location = new System.Drawing.Point(553, 168);
            this.txtproducredit.Name = "txtproducredit";
            this.txtproducredit.Size = new System.Drawing.Size(139, 33);
            this.txtproducredit.TabIndex = 7;
            this.txtproducredit.Text = "Edit";
            this.txtproducredit.UseVisualStyleBackColor = true;
            this.txtproducredit.Click += new System.EventHandler(this.txtproducredit_Click);
            // 
            // btnproductsave
            // 
            this.btnproductsave.Location = new System.Drawing.Point(325, 168);
            this.btnproductsave.Name = "btnproductsave";
            this.btnproductsave.Size = new System.Drawing.Size(139, 33);
            this.btnproductsave.TabIndex = 6;
            this.btnproductsave.Text = "Save";
            this.btnproductsave.UseVisualStyleBackColor = true;
            this.btnproductsave.Click += new System.EventHandler(this.btnproductsave_Click);
            // 
            // ProductDGV
            // 
            this.ProductDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(25, 305);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 24;
            this.ProductDGV.Size = new System.Drawing.Size(1282, 376);
            this.ProductDGV.TabIndex = 2;
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(631, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product List";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(7)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1329, 713);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "product";
            this.Text = "product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtproductdelete;
        private System.Windows.Forms.Button txtproducredit;
        private System.Windows.Forms.Button btnproductsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpcatagory;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.TextBox txtproductquntity;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}