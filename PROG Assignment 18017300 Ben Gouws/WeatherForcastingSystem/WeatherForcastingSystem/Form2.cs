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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)// When button(Back) is clicked.
        {
            frmMain mainForm = new frmMain();
            Form.ActiveForm.Hide();
            mainForm.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)// When button(Login) is clicked 
        {
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;

            User us = new User(sUsername, sPassword);
            FileHandler fh = new FileHandler("User.csv"); // call file handler
            List<string> userinfo = new List<string>();
            if (us.Comp(fh.ReadFromTXT()))// compairing username and pasword t oones inside file.
            {
                frmLogin frm2 =(frmLogin) Form.ActiveForm;
                
                frmMain MainForm = new frmMain();// switch back t omain form with objects enabled.
                
                MainForm.Show();
                MainForm.enableObjects();
                frm2.Hide();




            }
            else
            {
                MessageBox.Show("Username or password is incorect.");
            }    
            
           
        }
    }
}
