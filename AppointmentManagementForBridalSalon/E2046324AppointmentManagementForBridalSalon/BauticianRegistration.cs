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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net.NetworkInformation;

namespace E2046324AppointmentManagementForBridalSalon
{
    public partial class BeauticianRegistration : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MF9JKN5;Initial Catalog=DiyaBridalSalon;Integrated Security=True");

        public BeauticianRegistration()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string EmpID = txtEmpID.Text;
            string EmpName=txtEmpName.Text;
            string EmpAddress = txtEmpAddress.Text;
            string EmpContact = txtEmpContact.Text;
            //DateTime date = DateTime.MaxValue;
            ////string format = "YYYY-MM-DD";
            
            if(EmpID == "" ||EmpName == "" ||EmpAddress== ""|EmpContact == "")
            {
                MessageBox.Show("Please Fill The Required Fields");
            }
            else
            {
                try
                {
                    using (var connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        //string query = $"INSERT INTO BeauticianRegisterTable VALUES('{EmpID}','{EmpName}','{EmpAddress}','{EmpContact}')";
                        //SqlCommand cmd = new SqlCommand(query, connection);
                        //MessageBox.Show("Record Instered Successfully");
                        //cmd.ExecuteNonQuery();
                        SqlCommand cmd = new SqlCommand("INSERT INTO BeauticianRegistration (EmpID,EmpName,EmpAddress,EmpContact) values(@Eid,@En,@Ea,@Ec)", connection);
                        cmd.Parameters.AddWithValue("@Eid", EmpID);
                        cmd.Parameters.AddWithValue("@En", EmpName);
                        cmd.Parameters.AddWithValue("@Ea", EmpAddress);
                        cmd.Parameters.AddWithValue("@Ec", EmpContact);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Instered Successfully");

                        connection.Close();
                        DisplayData();

                        txtEmpID.Clear();
                        txtEmpName.Clear();
                        txtEmpAddress.Clear();
                        txtEmpContact.Clear();

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void DisplayData()
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BeauticianRegistration";
                SqlDataAdapter DA = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder= new SqlCommandBuilder(DA); 
                var ds = new DataSet(); 
                DA.Fill(ds);
                dgvBeauticianReg.DataSource = ds.Tables[0];
                DataTable dt = new DataTable();
                connection.Close();
            }
               

        }

        private void BeauticianRegistration_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM BeauticianRegistration WHERE EmpID = " + txtEmpID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted succsessfully!");
                    connection.Close();
                    DisplayData();

                    txtEmpID.Clear();
                    txtEmpName.Clear();
                    txtEmpAddress.Clear();
                    txtEmpContact.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "" || txtEmpName.Text == "" || txtEmpAddress.Text == "" || txtEmpContact.Text == "") 
            {
                MessageBox.Show("Please fill required fields");
            }
            else
            {
                try
                {

                    connection.Open();
                    string query = "UPDATE BeauticianRegistration SET EmpName ='" + txtEmpName.Text + "',EmpAddress ='" + txtEmpAddress.Text + "',EmpContact ='" + txtEmpContact.Text + "' where EmpID = '" + txtEmpID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated succsessfully!");
                    connection.Close();
                    DisplayData();

                    txtEmpID.Clear();
                    txtEmpName.Clear();
                    txtEmpAddress.Clear();
                    txtEmpContact.Clear();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
         //int Key=0;
        private void dgvBeauticianReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            { 
                int EmpID = int.Parse(dgvBeauticianReg.Rows[e.RowIndex].Cells[0].Value.ToString());
                string EmpName = dgvBeauticianReg.Rows[e.RowIndex].Cells[1].Value.ToString();
                string EmpAddress = dgvBeauticianReg.Rows[e.RowIndex].Cells[2].Value.ToString();
                int EmpContact = int.Parse (dgvBeauticianReg.Rows[e.RowIndex].Cells[3].Value.ToString());


                txtEmpID.Text = EmpID.ToString();
                txtEmpName.Text = EmpName;
                txtEmpAddress.Text = EmpAddress;
                txtEmpContact.Text = EmpContact.ToString();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
