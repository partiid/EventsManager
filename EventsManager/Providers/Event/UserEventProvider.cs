using EventsManager.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManager.Providers.Event
{
    internal class UserEventProvider : Provider
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int eventId { get; set; }

        public int partOption { get; set; }
        public int foodOption { get; set; }

        public int requestApproved { get; set; }

        private static UserProvider UserProvider = new UserProvider();
        private static EventProvider EventProvider = new EventProvider(); 


        public UserEventProvider() { }
        public UserEventProvider(int userId) {
            this.userId = userId; 
        }
        public UserEventProvider(int id, int userId, int eventId)
        {
            this.id = id;
            this.userId = userId;
            this.eventId = eventId;

        }

        public UserEventProvider(int userId, int eventId, int partOption, int foodOption)
        {
            this.userId = userId;
            this.eventId = eventId;
            this.partOption = partOption;
            this.foodOption = foodOption;

        }
       

        public void AddUserEvent(UserEventProvider userEvent)
        {
            ExecInsertQuery(userEvent, "userevent"); 

        }
        
        public void UpdateRequestApproved(bool approved)
        {
            ExecUpdateQuery($"UPDATE userevent set approved={approved}"); 

        }
        
        public List<UserEventProvider> GetUserEventRequests()
        {
            ExecSelectQuery($"select * from userevent where requestApproved = 0;");
            List<UserEventProvider> userRequests = new List<UserEventProvider>(Utils.ToList<UserEventProvider>(dataTable));

            ClearData();
            return userRequests; 
        }
        public List<UserEventProvider> GetUserEvents()
        {
            ExecSelectQuery($"select * from userevent where userId={userId} AND requestApproved=1;");
            List<UserEventProvider> userEvents = new List<UserEventProvider>(Utils.ToList<UserEventProvider>(dataTable)); 

            ClearData();

            return userEvents; 

        }

        public String GetParticipantOption(int option)
        {
            String participantOption = "";
            switch (option)
            {
                case 1:
                    participantOption = "Słuchacz";
                    break;
                case 2:
                    participantOption = "Autor";
                    break;
                case 3:
                    participantOption = "Sponsor";
                    break;
                case 4:
                    participantOption = "Organizator";
                    break;

            }
            return participantOption;
        }
        public String GetFoodOption(int option)
        {
            String foodOption = ""; 
            switch (option)
            {
                case 1:
                    foodOption = "Bez preferencji";
                    break;
                case 2:
                    foodOption = "Wege";
                    break;
                case 3:
                    foodOption = "Bez glutenu";
                    break;

            }
            return foodOption; 
        }




        

        

    }
}
