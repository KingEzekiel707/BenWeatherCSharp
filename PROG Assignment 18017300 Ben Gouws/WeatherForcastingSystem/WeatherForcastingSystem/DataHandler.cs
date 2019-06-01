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
        public DataHandler(string connectionstringP = "default") // set a connection.
        {
            this.connectionstring = ConfigurationManager.ConnectionStrings[connectionstringP].ConnectionString;
            connection = new SqlConnection(this.connectionstring);
        }



        public DataTable selectCities()    // Get data from city table.
        {
            datatable = new DataTable();
            string query = "SELECT [City] FROM [dbo].[City_tbl]";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;

        }
        public DataTable InsertCity(string city)    // Insert data from Form 1 to city table.
        {
            datatable = new DataTable();
            string query = "INSERT [dbo].[City_tbl] ([City]) Values("+ city +");";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;

        }
        public DataTable selectAcounts()    // Get data from city table.
        {
            datatable = new DataTable();
            string query = "SELECT * FROM [dbo].[Accounts_tbl]";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return datatable;

        }
    }
}


        






