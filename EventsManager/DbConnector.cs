using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Dynamic; 
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EventsManager
{
    public sealed class DbConnector 

    {
        private static DbConnector instance = null;

        private static String connectionString = "server=localhost;database=eventsmanager;user id=manager;pwd=Zaq1@WSX;"; 

        public static MySqlConnection connection { get; private set; }

        
        public DbConnector()
        {
            
                MySqlConnection conn = new MySqlConnection(connectionString);
                connection = conn;
            try
            {
                Debug.WriteLine("Connecting to db...");
                connection.Open();
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    Debug.WriteLine("Connected to db");
                }

            } catch(Exception e)
            {

                Debug.WriteLine("Could not connect to db. Connection is now closing..." + e.ToString());
                
            }

            
                        
        }

        public static DbConnector GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DbConnector(); 
                }
                return instance;
            }
        }
        

      
        private Boolean checkConnection()
        { 
            if(connection.State != System.Data.ConnectionState.Open)
            {
                return false; 
            } else
            {
                return true; 
            }
        }

        
        

        
    }
}
