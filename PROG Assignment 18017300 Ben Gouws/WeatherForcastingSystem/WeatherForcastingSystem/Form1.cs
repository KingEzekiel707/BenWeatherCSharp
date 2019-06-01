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
    public partial class frmMain : Form
    {



        
        
        
        // No U
        


        

        

        private void btnEData_Click(object sender, EventArgs e)
        {
           
            string sCity = txtCity.Text;
            string sDate = dTime.Value.ToString();
            int iMinTemp = int.Parse(nudMin.Value.ToString());
            int iMaxTemp = int.Parse(nudMax.Value.ToString());
            string sPercipitation = txtPercipitation.Text;
            int iHumidity = int.Parse(nudHumidity.Value.ToString());
            int iWindSpeed = int.Parse(nudWind.Value.ToString());
            Forcast fs = new Forcast(sCity,sDate,iMinTemp,iMaxTemp,sPercipitation,iHumidity,iWindSpeed);
            fs.Save();
            MessageBox.Show("Forcast has been captured.");





        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e) //Move from main form to user login form.
        {
            frmLogin loginForm = new frmLogin();
            Form.ActiveForm.Hide();
            loginForm.Show();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)// move from main form to admin login.
        {
            frmAdminLogin adminForm = new frmAdminLogin();
            Form.ActiveForm.Hide();
            adminForm.Show();
        }

      

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)// Form 1 load.
        {
            FileHandler cn = new FileHandler("Cities.csv");

            List<string> cityName = new List<string>();


            foreach (string name in cn.ReadFromTXT())
            {
                string[] lines = name.Split(',');
                cityName.Add(lines[0]);

            }
            cmbCity1.DataSource = cityName;
            cmbCity2.DataSource = cityName;

            
            Forcast fs = new Forcast();

            FileHandler fh = new FileHandler("Forcast.csv");
            fh.ReadFromTXT();

            FileHandler cityfile = new FileHandler("Cities.csv");
            cityfile.ReadFromTXT();

            fh = new FileHandler("User.csv");
           
            List<string> Thelist = new List<string>();

           
            User us = new User();
 
            fh.ReadFromTXT();

            cmbCity1.Enabled =false;                // auto disable on startup
            txtCity.Enabled = false;
            nudMin.Enabled = false;
            nudMax.Enabled = false;
            txtPercipitation.Enabled = false;
            nudHumidity.Enabled = false;
            nudWind.Enabled = false;
            dTime.Enabled = false;
            btnSave.Enabled = false;

        }
        public void enableObjects()     // Enable the objects after user has loged in.
        {
            cmbCity1.Enabled = true;
            txtCity.Enabled = true;
            nudMin.Enabled = true;
            nudMax.Enabled = true;
            txtPercipitation.Enabled = true;
            nudHumidity.Enabled = true;
            nudWind.Enabled = true;
            dTime.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {   //set the oposing vaulues so that the opisit values are located.
            int iMaxT = -100;
            int iMinT = 100;
            int iHumy = 0;
            int iWindy = 0;
            string sSelectedCity = cmbCity2.SelectedItem.ToString();
            string sStartDate, sEndDate;
            sStartDate = dStart.Value.ToString();
            sEndDate = dEnd.Value.ToString();

            FileHandler fh = new FileHandler("Forcast.csv");
            List<string> lines = fh.ReadFromTXT();
            
            List<Forcast> flist = new List<Forcast>();
            MessageBox.Show(sSelectedCity);
            foreach (string block in lines)   
            {
                string[] vs = block.Split(',');
                if (vs[0] == sSelectedCity) //Marker
                {
                    string[] dSplit = vs[1].Split(' ');                         
                    string[] x = dSplit[0].Split('/');                     
                    string[] dStartSplit = sStartDate.Split(' ');               
                    string[] s = dStartSplit[0].Split('/');
                    string[] dEndSplit = sEndDate.Split(' ');
                    string[] y= dEndSplit[0].Split('/');


                    //What you are about to see is 15 lines of code in 1 line: Auther Jan De Jager 2019
                    //"Ben your killing me." ~ Jan De Jager 2019
                    //x[0] = Selected year, x[1] = Selected month, x[2] = Selected day
                    //s[0] = Start year, s[1] = start month, s[2] = start day
                    //e[0] = End Year, e[1] = End month, e[2] = End day
                    if (!(((int.Parse(x[0]) <= int.Parse(s[0])) &&(int.Parse(x[1]) <= int.Parse(s[1])) && (int.Parse(x[2]) <= int.Parse(s[2]))) || ((int.Parse(x[0]) >= int.Parse(y[0])) && (int.Parse(x[1]) >= int.Parse(y[1])) && (int.Parse(x[2]) >= int.Parse(y[2])))))
                    {
                        flist.Add(new Forcast(vs[0], vs[1], int.Parse(vs[2].ToString()), int.Parse(vs[3].ToString()), vs[4], int.Parse(vs[5].ToString()), int.Parse(vs[6].ToString()))); //Add
                        if (int.Parse(vs[2]) < iMinT) iMinT = int.Parse(vs[2]);
                        if(int.Parse(vs[3]) > iMinT) iMaxT = int.Parse(vs[3]);
                        if(int.Parse(vs[5]) > iMinT) iHumy = int.Parse(vs[5]);
                        if(int.Parse(vs[6]) > iMinT) iWindy = int.Parse(vs[6]);
                    }
                }
                
                

                
                 
            }
            BindingSource bs = new BindingSource();



            bs.DataSource = flist;
            dgv1.DataSource = bs;
            lblMinTemp.Text = iMinT.ToString();
            lblMaxTemp.Text = iMaxT.ToString();
            lblHumid.Text = iHumy.ToString();
            lblmaxWindy.Text = iWindy.ToString();
            

           

        }

        private void cmbCity1_SelectedIndexChanged(object sender, EventArgs e)// auto add the text of the item sellected to the text box.
        {
            if (true)
            {
                txtCity.Text = cmbCity1.SelectedItem.ToString();

            }
        }
    }
}
 