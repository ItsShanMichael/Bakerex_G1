using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakerex_Practice
{
    public partial class Login : Form
    {
        private Color originalEmailLabelColor;
        private Color originalPasswordLabelColor;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

            originalEmailLabelColor = lblUsername.BackColor;
            originalPasswordLabelColor = lblPassword.BackColor;

            txtEmail.MouseEnter += TxtEmail_MouseEnter;
            txtEmail.MouseLeave += TxtEmail_MouseLeave;
            txtEmail.Leave += TxtEmail_Leave;

            txtPassword.MouseEnter += TxtPassword_MouseEnter;
            txtPassword.MouseLeave += TxtPassword_MouseLeave;
            txtPassword.Leave += TxtPassword_Leave;
        }

        private void TxtEmail_MouseEnter(object sender, EventArgs e)
        {
            lblUsername.BackColor = Color.Gray;
        }

        private void TxtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (!txtEmail.Focused)
            {
                lblUsername.BackColor = originalEmailLabelColor; 
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            lblUsername.BackColor = originalEmailLabelColor;
        }

        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {
            lblPassword.BackColor = Color.Gray;
        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (!txtPassword.Focused)
            {
                lblPassword.BackColor = originalPasswordLabelColor; 
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.BackColor = originalPasswordLabelColor; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainUser mainUserForm = new MainUser();
            mainUserForm.Show();

            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLoginForm = new AdminLogin();
            AdminLoginForm.Show();

            this.Hide();
        }

        private void txtSignup_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();

            this.Hide();
        }
    }
}
