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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
            DisplayProduct();
        }
        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MSii\Documents\petshopDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayProduct()
        {
            con.Open();
            String Query = "Select * from ProductTbl"; 
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            txtproductname.Text = "";
            txtproductquntity.Text = "";
            txtproductprice.Text = "";
            cmbpcatagory.SelectedIndex = 0;
            
        }

        private void btnproductsave_Click(object sender, EventArgs e)
        {
            if (txtproductname.Text == "" || cmbpcatagory.SelectedIndex == -1 || txtproductquntity.Text == "" || txtproductprice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl (PrName,PrCat,PrQty,PrPrice) values(@PN,@PC,@PQ,@PP)", con);
                    cmd.Parameters.AddWithValue("@PN", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@PC", cmbpcatagory.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@PQ", txtproductquntity.Text);
                    cmd.Parameters.AddWithValue("@PP", txtproductprice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Aded!!");
                    con.Close();
                    DisplayProduct();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            txtproductname.Text = ProductDGV.Rows[row].Cells[1].Value.ToString();
            cmbpcatagory.Text = ProductDGV.Rows[row].Cells[2].Value.ToString();
            txtproductquntity.Text = ProductDGV.Rows[row].Cells[3].Value.ToString();
            txtproductprice.Text = ProductDGV.Rows[row].Cells[4].Value.ToString();
            if (txtproductname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.Rows[row].Cells[0].Value.ToString());
            }
        }

        private void txtproductdelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Product");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PrId = @PKey", con);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted!");
                    con.Close();
                    DisplayProduct();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtproducredit_Click(object sender, EventArgs e)
        {
            if (txtproductname.Text == "" || cmbpcatagory.SelectedIndex == -1 || txtproductquntity.Text == "" || txtproductprice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update ProductTbl set PrName=@PN,PrCat=@PC,PrQty=@PQ,PrPrice=@PP where PrId=@PKey", con);
                    cmd.Parameters.AddWithValue("@PN", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@PC", cmbpcatagory.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@PQ", txtproductquntity.Text);
                    cmd.Parameters.AddWithValue("@PP", txtproductprice.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Edited!");
                    con.Close();
                    DisplayProduct();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
