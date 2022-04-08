using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EventsManager.User;

namespace EventsManager.Controllers
{

    internal class UserController
    {
        List<UserProvider> users { get; set; }
        UserProvider user { get; set; }

        public UserController(UserProvider user)
        {
            this.user = user; 
        }

        public UserController(List<UserProvider> users)
        {
            this.users = users; 
        }






    }
}
