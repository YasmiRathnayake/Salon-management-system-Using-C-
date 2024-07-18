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

namespace E2046324AppointmentManagementForBridalSalon.ServiceImages
{
    public partial class ServiceDashBoard : Form
    {
        public ServiceDashBoard()
        {
            InitializeComponent();
        }

        private void ServiceDashBoard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(2);
                label1.Text = Service.Name;
                label2.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal Service LoadServiceInfo(int id)

        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Services where ID= @id", connection);
                cmd.Parameters.Add("id", SqlDbType.Int);
                cmd.Parameters["id"].Value = id;
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Service", typeof(string));
                dt.Columns.Add("Amount", typeof(int));
                dt.Load(dataReader);
               
                return new Service { Id=id, Name =(string)dt.Rows[0]["Service"], Amount = (int)dt.Rows[0]["Amount"] };

            }




        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(3);
                lbl3.Text = Service.Name;
                lbl4.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect3_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(4);
                lbl5.Text = Service.Name;
                lbl6.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect4_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(5);
                lbl7.Text = Service.Name;
                lbl8.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect5_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(6);
                lbl9.Text = Service.Name;
                lbl10.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect6_Click(object sender, EventArgs e)
        {
            try
            {

                var Service = LoadServiceInfo(7);
                lbl11.Text = Service.Name;
                lbl12.Text = Service.Amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
