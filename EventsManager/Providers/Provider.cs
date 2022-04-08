using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace EventsManager.Providers
{
    internal class Provider
    {
        public DataTable dataTable = new DataTable();
        public MySqlDataReader dataReader;


        public DbConnector db = DbConnector.GetInstance;
        public MySqlConnection connection = DbConnector.connection; 


        public Provider() { }

        public void ClearData()
        {
            dataTable.Clear();
            dataReader.Close(); 
        }
        public void PrintData()
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
