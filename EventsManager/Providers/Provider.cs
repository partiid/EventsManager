using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EventsManager.Providers
{
    internal  class Provider
    {
        public DataTable dataTable = new DataTable();
        public MySqlDataReader dataReader;


        public DbConnector db = DbConnector.GetInstance;
        public MySqlConnection connection = DbConnector.connection;

        public Provider() {
           
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
        public DataTable ExecSelectQuery(String query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);

                

            } catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }
            return dataTable; 

           
        }

        public void ExecDeleteQuery(String query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery(); 


        }

        public void ExecUpdateQuery(object obj, string tableName, int condition)
        {
            try
            {

                PropertyInfo[] info = obj.GetType().GetProperties();


                //build query out of object 
                String pair = ""; 

                int numberOfInfo = info.Count();
                int counter = 0;

                foreach (var prop in info)
                {
                    counter++;
                    if (prop.Name != "id")
                    {
                        
                        if (counter == numberOfInfo)
                        {
                            if (prop.PropertyType.Name != "Int32")

                            {
                                pair += $"{prop.Name}='{prop.GetValue(obj)}', ";


                            }
                            else
                            {
                                pair += $"{prop.Name}={prop.GetValue(obj)}, ";

                            }



                        }
                        else
                        {
                            if (prop.PropertyType.Name != "Int32")
                            {
                                pair += $"{prop.Name}='{prop.GetValue(obj)}', ";


                            }
                            else
                            {
                                pair += $"{prop.Name}={prop.GetValue(obj)}, ";

                            }




                        }


                    }




                }
                //splice the last comma 
                


                String queryBuilder = $"UPDATE {tableName} SET {pair} where id={condition}";

                Regex r = new Regex(@",");
                MatchCollection result = r.Matches(queryBuilder);

                int matches_counter = 0;
                int remove_index = 0; 
                foreach (Match match in result)
                {
                    matches_counter++; 
                    if(matches_counter == result.Count)
                    {
                        remove_index = match.Index; 

                    }
                }

                if (result.Count > 0)
                {

                    queryBuilder = queryBuilder.Remove(remove_index, 1);
                }

                Console.WriteLine(queryBuilder);

                MySqlCommand command = new MySqlCommand(queryBuilder, connection);

                command.ExecuteNonQuery(); 

            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
                
                    }

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
