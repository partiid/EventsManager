using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsManager.Providers; 
namespace EventsManager.Controllers
{
    internal class Authentication
    {
        public static Authentication instance = null;
        public UserProvider LoggedUser { get; set; }  

        public String login { get;  set; }
        public String password { get;  set; }

        private UserProvider UserProvider = new UserProvider(); 

        //TODO implement user ban after 3 bad attempts 

        public Authentication() { }
        public  Authentication(string login, string password)
        {
            this.login = login;
            this.password = password;
            
        }
        public static Authentication GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Authentication();
                }
                return instance;
            }
        }
       

        public Boolean Authenticate()
        {
            try
            {
                UserProvider user = UserProvider.GetUserByLogin(this.login);

                //determine if password for a user is a match 
                if (user != null)
                {
                    
                    if (user.password == this.password)
                    {
                        LoggedUser = new UserProvider(user.id, user.login, user.password, user.role);


                        Console.WriteLine($"{LoggedUser.id}, {LoggedUser.login}, {LoggedUser.password}, {LoggedUser.role}"); 
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
