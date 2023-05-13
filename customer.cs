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

namespace new_pet_shop
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            DisplayCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MSii\Documents\petshopDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayCustomers()
        {
            con.Open();
            String Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            txtcustomername.Text = "";
            txtcustomeraddress.Text = "";
            txtcustomertelephone.Text = "";
            
        }

        private void btncustomersave_Click(object sender, EventArgs e)
        {
            if (txtcustomername.Text == "" || txtcustomeraddress.Text == "" || txtcustomertelephone.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl (CustName,CustAdd,CustPhone) values(@CN,@CA,@CP)", con);
                    cmd.Parameters.AddWithValue("@CN", txtcustomername.Text);
                    cmd.Parameters.AddWithValue("@CA", txtcustomeraddress.Text);
                    cmd.Parameters.AddWithValue("@CP", txtcustomertelephone.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added");
                    con.Close();
                    DisplayCustomers();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustomername.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtcustomeraddress.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtcustomertelephone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (txtcustomername.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void btncustomerdelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Customer ");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustId = @CKey", con);
                    cmd.Parameters.AddWithValue("@EmpKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted!");
                    con.Close();
                    DisplayCustomers();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
