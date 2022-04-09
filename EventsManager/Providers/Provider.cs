using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace EventsManager.Providers
{
    internal  class Provider
    {
        public DataTable dataTable = new DataTable();
        public MySqlDataReader dataReader;


        public DbConnector db = DbConnector.GetInstance;
        public MySqlConnection connection = DbConnector.connection;

        public Provider() { }

        

      
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
        public DataTable ExecSelectQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            
            return dataTable; 
        }

        public void ExecInsertQuery(object obj, String tableName, bool includeId = false)
        {
            PropertyInfo[] info = obj.GetType().GetProperties(); 

            //include id in insert
            if(includeId == false)
            {
                PropertyInfo[] toArray = Array.FindAll(info, (elem) => { return elem.Name != "id"; });
                info = toArray; 
            }

            //build query out of object 
            String columnNames = "(";
            String values = "(";

            int numberOfInfo = info.Count();
            int counter = 0; 

            foreach(var prop in info)
            {
                counter++;
               
                
                    if(counter == numberOfInfo)
                    {
                        if(prop.PropertyType.Name != "Int32")
                        {
                            values += $"'{prop.GetValue(obj)}'";

                        } else
                        {
                            values += $"{prop.GetValue(obj)}";
                        }

                        columnNames += $"{prop.Name}";

                    } else
                    {
                        if (prop.PropertyType.Name != "Int32")
                        {
                            values += $"'{prop.GetValue(obj)}',";

                        }
                        else
                        {
                            values += $"{prop.GetValue(obj)},";
                        }

                        columnNames += $"{prop.Name},";

                    
                    }
                



            }
            columnNames += ")";
            values += ")"; 

            String queryBuilder = $"INSERT INTO {tableName} {columnNames} VALUES {values}";
            Console.WriteLine(queryBuilder);



            MySqlCommand command = new MySqlCommand(queryBuilder, connection);
            command.ExecuteNonQuery();

        }
        public void ClearData()
        {
            dataTable.Clear();
            dataReader.Close();
        }









    }
}
