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


        public FileHandler(string fp1 = "ProblemLogFile.txt")// if somthing isn't running right its apears in the file location.
        {
            this.filePath = fp1;
        }
        
       public void WriteToTXT(List<string> FList) // this try method is used to write to the files. if file does not exist it creates a new one.
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
                foreach(string forcastData in FList)
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


        public List<string> ReadFromTXT()// this method is used to read form files.
        {
            List<string> adm = new List<string>();
            try
            {
                if (File.Exists(this.filePath))
                {
                    stream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);
                    while (!reader.EndOfStream)
                    {
                        adm.Add(reader.ReadLine());

                    }
                }
                else
                {
                    stream = new FileStream(this.filePath, FileMode.Create);
                    reader = new StreamReader(stream);
                }
                
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();// close the connections.
                stream.Close();
            }

            return adm;
        }
    }
}
