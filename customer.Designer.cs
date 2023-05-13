namespace new_pet_shop
{
    partial class customer
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
            this.txtcustomeraddress = new System.Windows.Forms.TextBox();
            this.txtcustomertelephone = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomerdelete = new System.Windows.Forms.Button();
            this.btncustomeredit = new System.Windows.Forms.Button();
            this.btncustomersave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcustomeraddress
            // 
            this.txtcustomeraddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomeraddress.Location = new System.Drawing.Point(482, 86);
            this.txtcustomeraddress.Multiline = true;
            this.txtcustomeraddress.Name = "txtcustomeraddress";
            this.txtcustomeraddress.Size = new System.Drawing.Size(234, 66);
            this.txtcustomeraddress.TabIndex = 17;
            // 
            // txtcustomertelephone
            // 
            this.txtcustomertelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomertelephone.Location = new System.Drawing.Point(884, 86);
            this.txtcustomertelephone.Name = "txtcustomertelephone";
            this.txtcustomertelephone.Size = new System.Drawing.Size(234, 30);
            this.txtcustomertelephone.TabIndex = 16;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(70, 86);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(234, 30);
            this.txtcustomername.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(881, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telephone";
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
            this.label2.Location = new System.Drawing.Point(67, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = " Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(629, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Customer List";
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(23, 338);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.RowHeadersWidth = 51;
            this.CustomerDGV.RowTemplate.Height = 24;
            this.CustomerDGV.Size = new System.Drawing.Size(1282, 347);
            this.CustomerDGV.TabIndex = 17;
            this.CustomerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(479, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address";
            // 
            // btncustomerdelete
            // 
            this.btncustomerdelete.Location = new System.Drawing.Point(1051, 212);
            this.btncustomerdelete.Name = "btncustomerdelete";
            this.btncustomerdelete.Size = new System.Drawing.Size(139, 33);
            this.btncustomerdelete.TabIndex = 8;
            this.btncustomerdelete.Text = "Delete";
            this.btncustomerdelete.UseVisualStyleBackColor = true;
            this.btncustomerdelete.Click += new System.EventHandler(this.btncustomerdelete_Click);
            // 
            // btncustomeredit
            // 
            this.btncustomeredit.Location = new System.Drawing.Point(851, 212);
            this.btncustomeredit.Name = "btncustomeredit";
            this.btncustomeredit.Size = new System.Drawing.Size(139, 33);
            this.btncustomeredit.TabIndex = 7;
            this.btncustomeredit.Text = "Edit";
            this.btncustomeredit.UseVisualStyleBackColor = true;
            // 
            // btncustomersave
            // 
            this.btncustomersave.Location = new System.Drawing.Point(638, 212);
            this.btncustomersave.Name = "btncustomersave";
            this.btncustomersave.Size = new System.Drawing.Size(139, 33);
            this.btncustomersave.TabIndex = 6;
            this.btncustomersave.Text = "Save";
            this.btncustomersave.UseVisualStyleBackColor = true;
            this.btncustomersave.Click += new System.EventHandler(this.btncustomersave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(28)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.txtcustomeraddress);
            this.panel1.Controls.Add(this.txtcustomertelephone);
            this.panel1.Controls.Add(this.txtcustomername);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncustomerdelete);
            this.panel1.Controls.Add(this.btncustomeredit);
            this.panel1.Controls.Add(this.btncustomersave);
            this.panel1.Location = new System.Drawing.Point(23, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 260);
            this.panel1.TabIndex = 16;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(7)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1329, 713);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.Text = "customer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcustomeraddress;
        private System.Windows.Forms.TextBox txtcustomertelephone;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomerdelete;
        private System.Windows.Forms.Button btncustomeredit;
        private System.Windows.Forms.Button btncustomersave;
        private System.Windows.Forms.Panel panel1;
    }
}