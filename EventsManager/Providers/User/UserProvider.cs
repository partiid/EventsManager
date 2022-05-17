using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace EventsManager.Providers
{
    internal class UserProvider : Provider
    {
        public int id { get; set; }
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

        public void AddUser(UserProvider user)
        {
            ExecInsertQuery(user, "user"); 

        } 
       
        public List<UserProvider> GetUsers()
        {
            ExecSelectQuery("select * from user;"); 

          
            List<UserProvider> users = new List<UserProvider>();

            users = Utils.ToList<UserProvider>(dataTable); 

            //PrintData();
            ClearData(); 

            return users; 


        }
        public UserProvider GetUserById(int id)
        {
            List<UserProvider> users = this.GetUsers();
            UserProvider userFound = users.Find(user =>
            {
                return user.id == id;
            });
            return userFound; 

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

        public void EditUser(UserProvider user)
        {

            int user_id = user.id;
            if(user_id != null)
            {

                //ExecUpdateQuery($"UPDATE user SET login='{user.login}' password='{user.password}' role='{user.role}' where id={user_id}"); 

            }

        }
    }
}
