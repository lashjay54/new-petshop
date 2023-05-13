namespace new_pet_shop
{
    partial class welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnbilling = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnemployee = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(77)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee Name";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(28)))), ((int)(((byte)(149)))));
            this.mainPanel.Location = new System.Drawing.Point(184, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1129, 678);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(22, 136);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(139, 33);
            this.btnwelcome.TabIndex = 25;
            this.btnwelcome.Text = "Welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(22, 640);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(139, 33);
            this.btnlogout.TabIndex = 24;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnbilling
            // 
            this.btnbilling.Location = new System.Drawing.Point(22, 537);
            this.btnbilling.Name = "btnbilling";
            this.btnbilling.Size = new System.Drawing.Size(139, 33);
            this.btnbilling.TabIndex = 23;
            this.btnbilling.Text = "Billing";
            this.btnbilling.UseVisualStyleBackColor = true;
            this.btnbilling.Click += new System.EventHandler(this.btnbilling_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(22, 459);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(139, 33);
            this.btncustomer.TabIndex = 22;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.Location = new System.Drawing.Point(22, 377);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(139, 33);
            this.btnemployee.TabIndex = 21;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = true;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(22, 300);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(139, 33);
            this.btnproduct.TabIndex = 20;
            this.btnproduct.Text = "Product";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(22, 220);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(139, 33);
            this.btnhome.TabIndex = 19;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(7)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1329, 713);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnbilling);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnemployee);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnwelcome;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnbilling;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnhome;
    }
}