using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.UI
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
