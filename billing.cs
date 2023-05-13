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
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
            GetCustomers();
            DisplayProduct();

        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MSii\Documents\petshopDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetCustomers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Selec CustId from CustomerTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(Rdr);
            cmbbillcustomerid.ValueMember = "CustId";
            cmbbillcustomerid.DataSource = dt;
            con.Close();
        }

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
        private void GetCustName()
        {
            con.Open();
            String Query = "Select * from CustomerTbl where CustId = " + cmbbillcustomerid.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtbillcustomername.Text = dr["CustName"].ToString();
            }
            con.Close();
        }

        private void UpdateStock()
        {
            try
            {
               /* int Newqty = UpdateStock - Convert.ToInt32(txtbillproductquantity.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PrQty=@PQ where PrID=@PKey", con);
                cmd.Parameters.AddWithValue("@PQ", Newqty);
                cmd.Parameters.AddWithValue("@PKey", Key);

                cmd.ExecuteNonQuery();

                con.Close();
                DisplayProduct();
                */

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, GrdTotal = 0;

        private void txtbillreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtbillproductname.Text = "";
            txtbillproductquantity.Text = "";
            //Stock = 0;
            //Key = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbillproductname.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();

           // Stock = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[3].Value.ToString());
            txtbillproductprice.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            if(txtbillproductname.Text == "")
            {
                //Key = 0;
            }
            else
            {
                //Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void txtprint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 300, 600);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int prodid, prodqty, prodprice, total, pos = 60;

        private void BillGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //design bill
        }

        private void btnbilladdtobill_Click(object sender, EventArgs e)
        {
           /* if (txtbillproductquantity.Text == "" || Convert.ToInt32(txtbillproductquantity.Text) > Stock)
            {
                MessageBox.Show("No Enough In House");
            }else if(txtbillproductquantity.Text == "" || Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(txtbillproductquantity.Text) * Convert.ToInt32(txtbillproductprice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGDV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtbillproductname.Text ;
                newRow.Cells[2].Value = txtbillproductquantity.Text;
                newRow.Cells[3].Value = txtbillproductprice.Text;
                newRow.Cells[4].Value = total;
                GrdTotal = GrdTotal + total;
                BillGDV.Rows.Add(newRow);
                n++;
                txttotal.Text = "Rs" + GrdTotal;
                UpdateStock();
                Reset();
            }
           */
        }
    }
}
