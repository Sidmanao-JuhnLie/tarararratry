using WinFormsApp1.UI;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        String username = "admin";
        String password = "System";
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (txtUserName.Text == username)
            {
                if (txtPassword.Text == password)
                {
                    MessageBox.Show($"Welcome, {username}");


                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                }
            }else if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Enter Something!"); 
            }
            else
            {
                MessageBox.Show("Wrong Username!");
            }
        }
    }
}
