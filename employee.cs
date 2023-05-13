using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace new_pet_shop
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            DisplayEmployees();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MSii\Documents\petshopDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEmployees()
        {
            con.Open();
            String Query = "Select * from Employeetbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeesDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            txtemployeename.Text = "";
            txtemployeeaddress.Text = "";
            txtemployeetelephone.Text = "";
            txtemployeepassword.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;

        private void btnemployeesave_Click(object sender, EventArgs e)
        {
            if (txtemployeename.Text == "" || txtemployeeaddress.Text == "" || txtemployeetelephone.Text == "" || txtemployeepassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass) values(@EN,@EA,@ED,@EP,@EPa)",con);
                    cmd.Parameters.AddWithValue("@EN", txtemployeename.Text);
                    cmd.Parameters.AddWithValue("@EA", txtemployeeaddress.Text);
                    cmd.Parameters.AddWithValue("@ED", empdateofbirth.MaxDate);
                    cmd.Parameters.AddWithValue("@EP", txtemployeetelephone.Text);
                    cmd.Parameters.AddWithValue("@EPa", txtemployeepassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    con.Close();
                    DisplayEmployees();
                    Clear();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        
        private void EmployeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemployeename.Text = EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtemployeeaddress.Text = EmployeesDGV.SelectedRows[0].Cells[2].Value.ToString();
            empdateofbirth.Text = EmployeesDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtemployeetelephone.Text = EmployeesDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtemployeepassword.Text = EmployeesDGV.SelectedRows[0].Cells[5].Value.ToString();
            if(txtemployeename.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void btnemployeeedit_Click(object sender, EventArgs e)
        {
            if (txtemployeename.Text == "" || txtemployeeaddress.Text == "" || txtemployeetelephone.Text == "" || txtemployeepassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update  EmployeeTbl set EmpName=@EN,EmpAdd=@EA,EmpDOB=@ED,EmpPhone=@EP,EmpPass=@EPa where EmpNum=@EKey", con);
                    cmd.Parameters.AddWithValue("@EN", txtemployeename.Text);
                    cmd.Parameters.AddWithValue("@EA", txtemployeeaddress.Text);
                    cmd.Parameters.AddWithValue("@ED", empdateofbirth.MaxDate);
                    cmd.Parameters.AddWithValue("@EP", txtemployeetelephone.Text);
                    cmd.Parameters.AddWithValue("@EPa", txtemployeepassword.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated!");
                    con.Close();
                    DisplayEmployees();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnemployeedelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select An Employee");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum = @EmpKey", con);
                    cmd.Parameters.AddWithValue("@EmpKey",Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted!");
                    con.Close();
                    DisplayEmployees();
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
