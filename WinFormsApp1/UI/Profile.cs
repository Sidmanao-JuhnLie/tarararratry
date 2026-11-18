using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.UI
{
    public partial class Profile : Form
    {
        
        public Profile()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

       
    }
}
