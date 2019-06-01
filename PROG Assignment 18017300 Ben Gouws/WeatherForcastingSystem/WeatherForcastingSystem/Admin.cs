using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForcastingSystem
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)// when button(Back) is clicked.
        {
            frmMain mainForm = new frmMain();
            Form.ActiveForm.Hide();
            mainForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)// when button(Login) is clicked.
        {
            string username,password;
            username = txtUsername.Text;
            password = txtPassword.Text;




            User us = new User(username, password);
            us.CheckAdmin();
        }
    }
}
