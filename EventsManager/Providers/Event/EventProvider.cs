using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManager.Providers.Event
{
    internal class EventProvider : Provider
    {
        public int id { get; set; }
        public String name { get; set; }
        public String agenda { get; set; }
        public DateTime date { get; set; }

        public EventProvider() { }
        public EventProvider(int id, String name, String agenda, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.agenda = agenda;
            this.date = date; 

        }

        public List<EventProvider> GetEvents()
        {
            List<EventProvider> events = new List<EventProvider>();
            ExecQuery("SELECT * FROM event"); 

            events = Utils.ToList<EventProvider>(dataTable);

            ClearData(); 


            return events; 
        }

        

    }
}
