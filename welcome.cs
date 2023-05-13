using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_pet_shop
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        public void loadPanel(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            loadPanel(new product());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            loadPanel(new home());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            loadPanel(new product());
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            loadPanel(new employee());
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            loadPanel(new customer());
        }

        private void btnbilling_Click(object sender, EventArgs e)
        {
            loadPanel(new billing());
        }
    }
}
