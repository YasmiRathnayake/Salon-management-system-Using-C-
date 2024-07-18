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
    public partial class cashierLogIn : Form
    {
        public cashierLogIn()
        {
            InitializeComponent();
        }

        private void btnCashLogIn_Click(object sender, EventArgs e)
        {
            string CashName = txtCashName.Text;
            string CashPassword = txtCashPassword.Text;

            try
            {
                if (CashName.Equals("cashier") && CashPassword.Equals("cashier123"))
                {
                    CashierDashBoard cdb = new CashierDashBoard();
                    cdb.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("The password or username you have entered is incorrect.Please Try again.");
                    txtCashName.Clear();
                    txtCashPassword.Clear();
                    txtCashName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cashierLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
