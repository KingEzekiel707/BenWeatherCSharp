using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeatherForcastingSystem
{
   public class FileHandler
    {
        private string filePath;
        private FileStream stream;
        private StreamReader reader;
        private StreamWriter writer;


        public FileHandler(string fp1 = "ProblemLogFile.txt")
        {
            this.filePath = fp1;
        }
        
       public void WriteToTXT(List<Forcast> FList)
        {
            try
            {
                if (File.Exists(this.filePath))
                {
                    stream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                }
                writer = new StreamWriter(stream);
                foreach(Forcast forcastData in FList)
                {
                    writer.WriteLine(forcastData.ToString());
                    writer.Flush();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }

    }
}
