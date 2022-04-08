using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EventsManager.Providers;

namespace EventsManager.User
{
    internal class UserProvider : Provider
    {
        public int id;
        public String login { get; set; }
        public String password { get; set; }
        public String role { get; set; }

        
        
         
        public UserProvider() {
            
        }
        public UserProvider(int id, String login, String password, String role)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public UserProvider(String login, String password)
        {
            this.login = login;
            this.password = password;
        }

       
        public List<UserProvider> GetUsers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM user;", connection);
            dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);

          
            List<UserProvider> users = new List<UserProvider>(); 

            foreach(DataRow row in dataTable.Rows)
            {
                UserProvider user = new UserProvider();
                user.id = Convert.ToInt32(row["id"]);  
                user.login = row["login"].ToString();
                user.password = row["password"].ToString();
                user.role = row["role"].ToString();

                users.Add(user); 

            }

            //PrintData();
            ClearData();

            return users; 


        }
        public UserProvider GetUserByLogin(String login)
        {
            List<UserProvider> users = this.GetUsers();
            UserProvider userFound = users.Find(user =>
            {
                return user.login.ToString() == login;
            });
            return userFound;

        }
    }
}
