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
    public partial class AdminRegister : Form
    {
        private Color originalFullnameLabelColor;
        private Color originalEmailLabelColor;
        private Color originalPasswordLabelColor;
        private Color originalPhoneNumberLabelColor;
        public AdminRegister()
        {
            InitializeComponent();

            originalFullnameLabelColor = lblFullname.BackColor;
            originalEmailLabelColor = lblEmail.BackColor;
            originalPasswordLabelColor = lblPassword.BackColor;
            originalPhoneNumberLabelColor = lblPhoneNumber.BackColor;

            lblFullname.MouseEnter += TxtFullname_MouseEnter;
            lblFullname.MouseLeave += TxtFullname_MouseLeave;

            lblEmail.MouseEnter += TxtEmail_MouseEnter;
            lblEmail.MouseLeave += TxtEmail_MouseLeave;

            lblPassword.MouseEnter += TxtPassword_MouseEnter;
            lblPassword.MouseLeave += TxtPassword_MouseLeave;

            lblPhoneNumber.MouseEnter += TxtPhoneNumber_MouseEnter;
            lblPhoneNumber.MouseLeave += TxtPhoneNumber_MouseLeave;
        }
        private void TxtFullname_MouseEnter(object sender, EventArgs e)
        {
            lblFullname.BackColor = Color.Gray; 
        }

        private void TxtFullname_MouseLeave(object sender, EventArgs e)
        {
            lblFullname.BackColor = originalFullnameLabelColor; 
        }

        private void TxtEmail_MouseEnter(object sender, EventArgs e)
        {
            lblEmail.BackColor = Color.Gray; 
        }

        private void TxtEmail_MouseLeave(object sender, EventArgs e)
        {
            lblEmail.BackColor = originalEmailLabelColor; 
        }

        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {
            lblPassword.BackColor = Color.Gray; 
        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            lblPassword.BackColor = originalPasswordLabelColor; 
        }

        private void TxtPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            lblPhoneNumber.BackColor = Color.Gray; 
        }

        private void TxtPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            lblPhoneNumber.BackColor = originalPhoneNumberLabelColor; 
        }
        private void AdminRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
