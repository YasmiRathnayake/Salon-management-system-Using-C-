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
    public partial class CashierDashBoard : Form
    {
        public CashierDashBoard()
        {
            InitializeComponent();
        }

        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm customerRegistrationForm = new CustomerRegistrationForm();
            customerRegistrationForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Services service= new Services();
            service.Show();
            this.Hide();
        }
    }
}
