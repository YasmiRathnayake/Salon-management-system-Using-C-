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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if(progressBar1.Value == 100)
            {
                
                timer.Stop();
                HomePage Hpage = new HomePage();
                Hpage.Show();
                //LoadingForm lForm = new LoadingForm();
                this.Hide();

            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
