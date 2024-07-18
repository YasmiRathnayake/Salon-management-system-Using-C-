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

namespace E2046324AppointmentManagementForBridalSalon
{
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
            ComboBox();
        }
        void ComboBox()
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
               
                string query = "SELECT * FROM BeauticianRegistration";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    //int id = dr.GetInt32(0);
                    //cmbSelectBeautician.Items.Add(id);

                    cmbSelectBeautician.Items.Add(dr[1].ToString());
                    
                }
                connection.Close();
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string CustomerId = txtCid.Text;
            string FirstName = txtFName.Text;
            string Lastname = txtLName.Text;
            string Address = txtAdd.Text;
            string ContactNumber = txtContact.Text;
            string Beautician = cmbSelectBeautician.Text;
            
            


            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                string connectionString = "Data Source=DESKTOP-MF9JKN5;Initial Catalog=DiyaBridalSalon;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string sqlQuery = "INSERT INTO CustomerRegistration VALUES('" + CustomerId + "''" + FirstName + "','" + Lastname + "','" + Address + "','" + ContactNumber + "','" +Beautician + "')";

                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thank you for registration,Succefully Added");

                txtCid.Clear();
                txtFName.Clear();
                txtLName.Clear();
                txtAdd.Clear();
                cmbSelectBeautician.Items.Clear();
                txtContact.Clear();

               
            }

           



        }

    }
}
