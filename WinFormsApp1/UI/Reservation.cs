using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.UI
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }
    }
}
