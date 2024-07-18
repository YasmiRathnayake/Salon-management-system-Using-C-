using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.IO;
using System.Security.Cryptography;

namespace E2046324AppointmentManagementForBridalSalon
{
    public partial class Services : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MF9JKN5;Initial Catalog=DiyaBridalSalon;Integrated Security=True");

        public Services()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog OD = new OpenFileDialog();
            // image filters  
            OD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(OD.FileName);
                //storing the location of the pic in variable  
                string location = OD.FileName;
                txtFilePath.Text = location;
                //storing the filename of the pic in variable  
                string fileName = OD.SafeFileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string fPath = txtFilePath.Text;
            string ServiceId = txtServiceId.Text;
            string Service = txtService.Text;
            string Amount = txtAmount.Text;
            

            if (ServiceId == "" || Service == "" || Amount == "")
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

                        string query = "INSERT INTO Services (ImagePath,ServiceId,Service,Amount) values(@im,@servId,@serv,@amo)";
                        
                       // SqlConnection con= new SqlConnection(query);
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader myReader;
                        cmd.Parameters.AddWithValue("@im", fPath);
                        cmd.Parameters.AddWithValue("@servId", ServiceId);
                        cmd.Parameters.AddWithValue("@serv", Service);
                        cmd.Parameters.AddWithValue("@amo", Amount);
                       
                        myReader = cmd.ExecuteReader();
                       
                        cmd.CommandText = "INSERT INTO Services (Service,Amount,Image) values(@serv,@amo,@im)";
                     

                        
                        MessageBox.Show("Record Instered Successfully");

                        connection.Close();
                        DisplayData();

                        txtFilePath.Clear();
                        txtServiceId.Clear();
                        txtService.Clear();
                        txtAmount.Clear();
                        
                        pictureBox1.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Services";
                SqlDataAdapter DA = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                var ds = new DataSet();
                DA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                DataTable dt = new DataTable();
                connection.Close();
            }
        }

            private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtServiceId.Text == "" || txtService.Text == "" || txtAmount.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Services WHERE ID = " + pictureBox1.Image + "";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted succsessfully!");
                    connection.Close();
                    DisplayData();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtServiceId.Text == "" || txtService.Text == "" || txtAmount.Text == "" )
            {
                MessageBox.Show("Please fill required fields");
            }
            else
            {
                try
                {

                    connection.Open();
                    string query = "UPDATE Services SET ServiceId ='" + txtServiceId.Text + "' Service ='" + txtService.Text + "',Amount ='" + txtAmount.Text + "', where ImagePath = '" + txtFilePath.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated succsessfully!");
                    connection.Close();
                    DisplayData();

                    txtService.Clear();
                    txtAmount.Clear();
                    pictureBox1.Hide();
                    txtFilePath.Clear();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {

        }
    }

}






            
                
                

                


                
        


