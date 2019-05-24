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
    public partial class Form1 : Form
    {



        
        
        
        
        


        
        static int iMinTemp, iMaxTemp, iWindspeed , iCount, iPrecipitation;
        int x, y;
        int iCity;
        
        
        

         string[] arrCity = new string[iCount];        
        DateTime[] arrDate = new DateTime[iCount];     
        int[] arrMinTemp = new int[iCount];            
        int[] arrMaxTemp = new int[iCount];            
        int[] arrWindSpeed = new int[iCount];         
        int[] arrPrecipitation = new int[iCount];       
        int[] arrHumidity = new int[iCount];            




        string sCity;//to capture the city name and put it in a array later.
        DateTime dDate;//to capture the date and put it in a array later.

        

        private void btnEData_Click(object sender, EventArgs e)
        {
            x = 0;   
                     
                     
           int iMinTemp = Convert.ToInt32(nudMin.Value);              
            int iMaxTemp = Convert.ToInt32(nudMax.Value);              
            int iWindSpeed = Convert.ToInt32(nudWind.Value);            
            int iPrecipitation = Convert.ToInt32(nudPrec.Value);        
            int iHumidity = Convert.ToInt32(nudHumidity.Value);         

            
            arrCity[x] = txtCity.Text;         
            arrDate[x] = dTime.MaxDate;         
            arrMinTemp[x] = iMinTemp;//insirt Minimum tempreture in array.
            arrMaxTemp[x] = iMaxTemp;//insirt Maximum tempreture in array.
            arrPrecipitation[x] = iPrecipitation;//insert Precipitation.
            arrHumidity[x] = iHumidity;
            iCount++;//icrease iCount to move to next array.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        { DateTime dtStart,dtEnd;
            dtStart = dStart.MaxDate;
            dtEnd = dEnd.MinDate;
            x = 1;
            dgv1.Rows[0].Cells[0].Value = "Date";
            dgv1.Rows[0].Cells[1].Value = "City";
            dgv1.Rows[0].Cells[2].Value = "Minimum Tempreture";
            dgv1.Rows[0].Cells[3].Value = "Maximum Tempreture";
            dgv1.Rows[0].Cells[4].Value = "Precipitation";
            dgv1.Rows[0].Cells[5].Value = "Humidty";
            dgv1.Rows[0].Cells[6].Value = "Wind Speed";
            while (x < iCount)
               
            {
                
                
                if( (arrDate[x]> dStart.MaxDate) & (arrDate[x] < dtEnd.Date)  )   
                {
                    dgv1.Rows[x].Cells[0].Value = arrDate[x];//Add to grid view.
                    dgv1.Rows[x].Cells[1].Value = arrCity[x];//Add to grid view.
                    dgv1.Rows[x].Cells[2].Value = arrMinTemp[x];//Add to grid view.
                    dgv1.Rows[x].Cells[3].Value = arrMaxTemp[x];//Add to grid view.
                    dgv1.Rows[x].Cells[4].Value = arrPrecipitation[x];//Add to grid view.
                    dgv1.Rows[x].Cells[5].Value = arrHumidity[x];//Add to grid view.
                    dgv1.Rows[x].Cells[6].Value = arrWindSpeed[x];//Add to grid view.

                }
            } 
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x=0;
            y=0;
            iCount = 0;
            Forcast fs = new Forcast("Brooklen" , Convert.ToDateTime("2019/05/23") , -4 , 18 , "Snow" , 17 , 56  );
            FileHandler fh = new FileHandler("CrossbowCat.txt");
            List<Forcast> theList = new List<Forcast>();
            theList.Add(fs);
            fh.WriteToTXT(theList);

        }
    }
}
