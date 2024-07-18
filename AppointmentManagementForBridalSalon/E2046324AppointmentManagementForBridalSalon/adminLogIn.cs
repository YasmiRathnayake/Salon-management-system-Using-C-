using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2046324AppointmentManagementForBridalSalon
{
    public partial class adminLogIn : Form
    {
        public adminLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string UserName = txtUName.Text;
            string Password = txtPassword.Text;

            try
            {
                if(UserName.Equals("Admin") && Password.Equals("12345"))
                {
                    Reports reports = new Reports();
                    reports.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("The password or username you have entered is incorrect.Please Try again.");
                    txtUName.Clear();
                    txtPassword.Clear();
                    txtUName.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminLogIn_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
