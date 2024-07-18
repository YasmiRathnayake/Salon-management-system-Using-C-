namespace E2046324AppointmentManagementForBridalSalon
{
    partial class CashierDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashBoard));
            this.btnCustomerRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomizeServices = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerRegister
            // 
            this.btnCustomerRegister.BackColor = System.Drawing.Color.Silver;
            this.btnCustomerRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegister.Image")));
            this.btnCustomerRegister.Location = new System.Drawing.Point(109, 229);
            this.btnCustomerRegister.Name = "btnCustomerRegister";
            this.btnCustomerRegister.Size = new System.Drawing.Size(227, 185);
            this.btnCustomerRegister.TabIndex = 0;
            this.btnCustomerRegister.Text = "Customer Registration";
            this.btnCustomerRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerRegister.UseVisualStyleBackColor = false;
            this.btnCustomerRegister.Click += new System.EventHandler(this.btnCustomerRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cashier DashBoard";
            // 
            // btnCustomizeServices
            // 
            this.btnCustomizeServices.BackColor = System.Drawing.Color.Silver;
            this.btnCustomizeServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomizeServices.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomizeServices.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomizeServices.Image")));
            this.btnCustomizeServices.Location = new System.Drawing.Point(328, 230);
            this.btnCustomizeServices.Name = "btnCustomizeServices";
            this.btnCustomizeServices.Size = new System.Drawing.Size(227, 185);
            this.btnCustomizeServices.TabIndex = 2;
            this.btnCustomizeServices.Text = "Customize Services";
            this.btnCustomizeServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomizeServices.UseVisualStyleBackColor = false;
            this.btnCustomizeServices.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(552, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 185);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bill Preparation";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CashierDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCustomizeServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomizeServices;
        private System.Windows.Forms.Button button2;
    }
}