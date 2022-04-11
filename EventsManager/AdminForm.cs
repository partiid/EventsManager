using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventsManager.Controllers;
using EventsManager.Providers;
using EventsManager.Providers.Event;

namespace EventsManager
{
    public partial class AdminForm : Form
    {
        //instances 
        private static UserProvider UserProvider = new UserProvider();
        private static EventProvider EventProvider = new EventProvider(); 
        private static UserEventProvider UserEventProvider = new UserEventProvider(); 

        private static Authentication Authentication = Authentication.GetInstance;

        //variables 
        private int userId = Authentication.LoggedUser.id;


        public AdminForm()
        {
            InitializeComponent();
        }

        private void ClearDataTable()
        {
            //dataTable.Columns.Clear();
            //dataTable.Rows.Clear(); 
            dataTable.DataSource = null; 
        }
        
        private void FetchUsersData()
        {
            this.ClearDataTable(); 

            List<UserProvider> users = new List<UserProvider>(UserProvider.GetUsers());
            dataTable.DataSource = users;
           /* PropertyInfo[] userProviderProps = UserProvider.GetType().GetProperties();

            //pupulate columns 
            int columnIndex = 0;
            dataTable.ColumnCount = userProviderProps.Count(); 

            foreach(var prop in userProviderProps)
            {
                dataTable.Columns[columnIndex].Name = prop.Name.ToString(); 
                columnIndex++;
            }

            //populate rows 
            foreach(var user in users)
            {
                List<string> rowScheme = new List<string>(); 
                foreach(var prop in userProviderProps)
                {
                    rowScheme.Add((user.GetType().GetProperty(prop.Name).GetValue(user, null).ToString())); 
                    //rowScheme.Append(); 
                }
                string[] toAdd = rowScheme.ToArray(); 
                dataTable.Rows.Add(toAdd); 
            }*/
            
        }

        private void FetchEventsData()
        {
            this.ClearDataTable();
            List<EventProvider> events = new List<EventProvider>(EventProvider.GetEvents());
            dataTable.DataSource = events; 
            /*
            PropertyInfo[] eventProviderProps = EventProvider.GetType().GetProperties();

            //pupulate columns 
            int columnIndex = 0;
            dataTable.ColumnCount = eventProviderProps.Count();

            foreach (var prop in eventProviderProps)
            {
                dataTable.Columns[columnIndex].Name = prop.Name.ToString();
                columnIndex++;
            }

            //populate rows 
            foreach (var Event in events)
            {
                List<string> rowScheme = new List<string>();
                foreach (var prop in eventProviderProps)
                {
                    rowScheme.Add((Event.GetType().GetProperty(prop.Name).GetValue(Event, null).ToString()));
                    //rowScheme.Append(); 
                }
                string[] toAdd = rowScheme.ToArray();
                dataTable.Rows.Add(toAdd);
            }*/

        }
        private void FetchRequestsData()
        {
            this.ClearDataTable();

            List<UserEventProvider> requests = new List<UserEventProvider>(UserEventProvider.GetUserEventRequests());

            
            dataTable.ColumnCount = 2;
            dataTable.Columns[0].Name = "Użytkownik";
            dataTable.Columns[1].Name = "Wydarzenie"; 

            //populate rows
            foreach(var request in requests)
            {
                UserProvider user = UserProvider.GetUserById(request.userId);
                EventProvider Event = EventProvider.GetEventById(request.eventId);

                string[] rowScheme = { $"{user.login}", $"{Event.name}" };

                dataTable.Rows.Add(rowScheme); 

            }


            

        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.FetchUsersData();
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedRow = dataTable.SelectedRows[0].DataBoundItem as 

        }

        private void navigateUsers_Click(object sender, EventArgs e)
        {
            this.FetchUsersData(); 
        }

        private void navigateEvents_Click(object sender, EventArgs e)
        {
            this.FetchEventsData(); 
        }

        private void navigateRequests_Click(object sender, EventArgs e)
        {
            this.FetchRequestsData(); 
        }

       
    }
}
