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



        /// <summary>
        /// ooral waar ek ge-edit het se comments sal >> || << die simbool voor aan he
        /// jammer ek het jou spacing bietjie rond geneek
        /// heya Ben, watch your language ;)
        /// </summary>
        


        // || added static before int
        static int iMinTemp, iMaxTemp, iWindspeed , iCount, iPrecipitation;//Public veriables for task 1
        int x, y;//The possition in the array.
        int iCity;//This is to incrase the city array.
        
        
        // || your varibles where complaining about not being static, so i made them static. but they are still varibles

         string[] arrCity = new string[iCount];        //I need it to take my iCount as a uknown veriable.
        DateTime[] arrDate = new DateTime[iCount];     //I need it to take my iCount as a uknown veriable.
        int[] arrMinTemp = new int[iCount];            //I need it to take my iCount as a uknown veriable.
        int[] arrMaxTemp = new int[iCount];            //I need it to take my iCount as a uknown veriable.
        int[] arrWindSpeed = new int[iCount];         //I need it to take my iCount as a uknown veriable.
        int[] arrPrecipitation = new int[iCount];       //I need it to take my iCount as a uknown veriable.
        int[] arrHumidity = new int[iCount];            //I need it to take my iCount as a uknown veriable.




        string sCity;//to capture the city name and put it in a array later.
        DateTime dDate;//to capture the date and put it in a array later.

        

        private void btnEData_Click(object sender, EventArgs e)
        {
            x = 0;   // || i added converstion becase the value you are trying to store are decimals.
                     // || note converting a decimal to a integer could potential cause loss of sensitive data(google that)
                     // || solution to above problem is then store your values as decimals or reals
           int iMinTemp = Convert.ToInt32(nudMin.Value);              //I want to take numeric up down to int.
            int iMaxTemp = Convert.ToInt32(nudMax.Value);              //I want to take numeric up down to int.
            int iWindSpeed = Convert.ToInt32(nudWind.Value);            //I want to take numeric up down to int.
            int iPrecipitation = Convert.ToInt32(nudPrec.Value);        //I want to take numeric up down to int.
            int iHumidity = Convert.ToInt32(nudHumidity.Value);         //I want to take numeric up down to int.

            // || Once you declare the array, you dont have to use the datatypes infront of it again
            arrCity[x] = txtCity.Text;         //It is not taking my x int. || you where redeclaring the array
            arrDate[x] = dTime.MaxDate;        // it is not taking my x int.  
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
                // || first error was your array's didnt have indexes(die x)
                // || second error, your if didnt encapsulate both arguments( you needed to put both in one bracket)
                if( (arrDate[x]> dStart.MaxDate) & (arrDate[x] < dtEnd.Date)  )   //I need to add the dates between start date and end date to the grid view.
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


        }
    }
}
