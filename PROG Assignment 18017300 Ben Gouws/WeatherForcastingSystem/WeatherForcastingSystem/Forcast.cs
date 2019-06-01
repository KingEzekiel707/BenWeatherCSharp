using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcastingSystem
{
    public class Forcast
    {
        private string city;
        private string date;
        private int minTemp;
        private int maxTemp;
        private string precipitation;
        private int humidity;
        private int windSpeed;


        public Forcast()                // a constructor without parmitors
        {

        }

        public Forcast(string city)         // constructor with a paramitor.
        {
            this.City = city;
        }

        public Forcast(string city, string date, int minTemp, int maxTemp, string precipitation,  int humidity, int windSpeed)// constuctor with alot of paramitors.
        {
            this.City = city;
            this.Date = date;
            this.MinTemp = minTemp;
            this.MaxTemp = maxTemp;
            this.Humidity = humidity;
            this.WindSpeed = windSpeed;
            this.Precipitation = precipitation;
        }
                                                                    //gets and sets
        public string City { get => city; set => city = value; }
        public string Date { get => date; set => date = value; }
        public int MinTemp { get => minTemp; set => minTemp = value; }
        public int MaxTemp { get => maxTemp; set => maxTemp = value; }
        public int Humidity { get => humidity; set => humidity = value; }
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }
        public string Precipitation { get => precipitation; set => precipitation = value; }




        public override string ToString()           //tostring method.
        {
            return string.Format(City + "," + Date + "," + MinTemp.ToString() + "," + MaxTemp.ToString() + "," + Precipitation + "," + Humidity.ToString() + "," + WindSpeed.ToString());
        }
        public void Save()          // Save forscast info from form 1 to forcast file.
        {
            FileHandler fh = new FileHandler("Forcast.csv");
            List<string> ls = new List<string>();
            ls.Add((new Forcast(this.City, this.Date, this.MinTemp, this.MaxTemp, this.Precipitation, this.Humidity, this.WindSpeed)).ToString());
            fh.WriteToTXT(ls);
        }
    }
}
