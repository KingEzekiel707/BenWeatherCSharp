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
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private string precipitation;
        private int humidity;
        private int windSpeed;

        public Forcast()
        {

        }

        public Forcast(string city, DateTime date, int minTemp, int maxTemp, string precipitation,  int humidity, int windSpeed)
        {
            this.City = city;
            this.Date = date;
            this.MinTemp = minTemp;
            this.MaxTemp = maxTemp;
            this.Humidity = humidity;
            this.WindSpeed = windSpeed;
            this.Precipitation = precipitation;
        }

        public string City { get => city; set => city = value; }
        public DateTime Date { get => date; set => date = value; }
        public int MinTemp { get => minTemp; set => minTemp = value; }
        public int MaxTemp { get => maxTemp; set => maxTemp = value; }
        public int Humidity { get => humidity; set => humidity = value; }
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }
        public string Precipitation { get => precipitation; set => precipitation = value; }




        public override string ToString()
        {
            return string.Format(City + "#" + Date.ToString() + "#" + MinTemp.ToString() + "#" + MaxTemp.ToString() + "#" + Precipitation + "#" + Humidity.ToString() + "#" + WindSpeed.ToString());
        }
    }
}
