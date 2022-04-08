using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsManager.User; 
namespace EventsManager.Controllers
{
    internal class Authentication
    {
        private String login { get;  set; }
        private String password { get;  set; }

        private UserProvider UserProvider = new UserProvider(); 

        //TODO implement user ban after 3 bad attempts 

        public  Authentication(string login, string password)
        {
            this.login = login;
            this.password = password;

            
            
        }

        public Boolean Authenticate()
        {
            try
            {
                UserProvider user = UserProvider.GetUserByLogin(this.login);

                //determine if password for a user is a match 
                if (user != null)
                {
                    Console.WriteLine($"{user.password} :: {this.password}"); 
                    if (user.password == this.password)
                    {
                        return true;
                    }
                    return false; 
                }

                Console.WriteLine($"User found: {user.login}");
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine($"User not found: {ex}");
            }
            return false; 
        }
        
    }
}
