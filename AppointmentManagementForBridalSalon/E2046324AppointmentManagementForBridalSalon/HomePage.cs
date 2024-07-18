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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }
        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f =  Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag= f;
            f.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            loadform(new adminLogIn());
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            loadform(new cashierLogIn());
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
