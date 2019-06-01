using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForcastingSystem
{
   public class User
    {
        private string sUsername;
        private string sPassword;
        private Boolean bAdmin;
        public User()
        {
            
        }
       

        public User(string sUsername, string sPassword, bool bAdmin = false)
        {
            this.SUsername = sUsername;
            this.SPassword = sPassword;
            this.BAdmin = bAdmin;
        }
                                                                                 //Get and Sets
        public string SUsername { get => sUsername; set => sUsername = value; }
        public string SPassword { get => sPassword; set => sPassword = value; }
        public bool BAdmin { get => bAdmin; set => bAdmin = value; }


        public override string ToString()
        {
            return string.Format(SUsername +"," + SPassword + "," + BAdmin.ToString());
        }

        public void CheckAdmin()                            // Check if username and password match and then if user has adim privleges.
        {
            FileHandler fh = new FileHandler("User.csv");
            List<string> userinfo = new List<string>(); 
            if (userinfo.Count() == 0)
            {
                if (Comp(fh.ReadFromTXT()))
                {
                    if (this.bAdmin)
                    {
                        frmAdminLogin AdminForm =(frmAdminLogin)Form.ActiveForm;
                        frmAdminControlls Control = new frmAdminControlls();
                        AdminForm.Hide();
                        Control.Show();

                    }
                    else
                    {
                        MessageBox.Show("You do not have admin privileges on this account.");
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            else
            {
                frmAdminLogin AdminForm = (frmAdminLogin)Form.ActiveForm; //If the users file is not found it allows you access once so that a
                frmAdminControlls Control = new frmAdminControlls();      // username and password can be set.
                AdminForm.Hide();
                Control.Show();
                
            }
            
            

        }
        public bool Comp(List<string> adm)
        {
            


            foreach (string line in adm) // compair username and password for the none admin login.
            {
                string[] info = line.Split(',');
                if ((info[0] == this.sUsername) && (info[1] == this.sPassword))
                {
                    this.BAdmin = Convert.ToBoolean(info[2]);
                    return true;

                }
            }
            return false;

        }


        public bool cUser(List<string> adm)
        {



            foreach (string line in adm) // checking if the username is already taken.
            {
                string[] info = line.Split(',');
                if (info[0] == this.sUsername)
                {
                    
                    return true;

                }
            }
            return false;

        }
    }
   
}
