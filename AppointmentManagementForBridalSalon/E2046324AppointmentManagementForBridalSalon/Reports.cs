﻿using System;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeauticianRegistration beautyReg = new BeauticianRegistration();
            beautyReg.Show();  
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesInformation sales =new SalesInformation();
            sales.Show();
            this.Close();
        }
    }
}
