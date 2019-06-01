using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WeatherForcastingSystem
{
    public partial class frmAdminControlls : Form
    {
        public frmAdminControlls()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)// return to main form when the button(Done) is clicked.
        {
            frmMain mainForm = new frmMain();
            Form.ActiveForm.Hide();
            mainForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)// hide exrta options till button(Add User) clicked.
        {
            lblUsername.Show();
            lblpassword.Show();
            txtUsername.Show();
            txtPassword.Show();
            btnApply.Show();

        }

        private void frmAdminControlls_Load(object sender, EventArgs e)// load the form.
        {
            lblUsername.Hide();
            lblpassword.Hide();
            txtUsername.Hide();
            txtPassword.Hide();
            btnApply.Hide();
            DataHandler dh = new DataHandler("");// call file handler to use user file.
            
            List<string> userinfo = new  List<string>();
            

            foreach (string name in fh.ReadFromTXT())
            {
                string[] lines = name.Split(',');
                userinfo.Add(lines[0]);

            }
            cmbUsername.DataSource = userinfo;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            Boolean adminP;
                                            //Collect data from objects.
            username = txtUsername.Text;
            password = txtPassword.Text;
            adminP = cbAdmin.Checked;
            
            
          
            FileHandler fh = new FileHandler("User.csv");
            User us = new User();
            us.SUsername = txtUsername.Text;
            if (us.cUser(fh.ReadFromTXT()))         // check if username alread
            {
                MessageBox.Show("This username is already taken.");
            }
            else                                   // Add a new user to the f
            {
                us.SPassword = password;
                us.BAdmin = adminP;
                List<string> TheList = new List<string>();
                TheList.Add(us.ToString());
                fh.WriteToTXT(TheList);
            }
            MessageBox.Show("User has been created.");
        }
    }
}
//FileHandler fh = new FileHandler("User.csv");