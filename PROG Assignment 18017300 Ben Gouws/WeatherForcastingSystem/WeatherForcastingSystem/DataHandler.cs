using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WeatherForcastingSystem
{
    public class DataHandler
    {
       
        
             private string connectionstring;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable datatable;
        public DataHandler(string connectionstringP = "default")
        {
            this.connectionstring = ConfigurationManager.ConnectionStrings[connectionstringP].ConnectionString;
            connection = new SqlConnection(this.connectionstring);
        }
    }


        }






