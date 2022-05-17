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
using EventsManager.AdminForms;
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

        private String selectedView = "user";

        //selected row in a table 
        private Object selectedRow = null; 

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
        private bool isRowSelected()
        {
            if(selectedRow != null)
            {
                return true; 
            }
            return false; 
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

            List<UserEventProvider> requests = new List<UserEventProvider>(UserEventProvider.GetAllUserEvents());
            dataTable.DataSource = requests;

            /*
                        List<userRequest> userRequests = new List<userRequest>();  
                        *//*
                        dataTable.ColumnCount = 2;
                        dataTable.Columns[0].Name = "Użytkownik";
                        dataTable.Columns[1].Name = "Wydarzenie"; *//*

                        //populate rows
                        foreach(var request in requests)
                        {
                            UserProvider user = UserProvider.GetUserById(request.userId);
                            EventProvider Event = EventProvider.GetEventById(request.eventId);

                            userRequest ureq = new userRequest(user.login, Event.name, request.requestApproved); 
                            userRequests.Add(ureq); 

                            //string[] rowScheme = { $"{user.login}", $"{Event.name}" };

                            //dataTable.Rows.Add(rowScheme); 

                        }*/







        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.FetchUsersData();

        }

      
        private void dataTable_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        public void UpdateData(string sv)
        {
            switch (sv)
            {
                case "user":
                    this.FetchUsersData();
                    break;
                case "event":
                    this.FetchEventsData();
                    break;
                case "userevent":
                    this.FetchRequestsData();
                    break; 

            }
        }
        private void navigateUsers_Click(object sender, EventArgs e)
        {
            this.selectedRow = null; 
            this.selectedView = "user";

            this.FetchUsersData(); 
        }

        private void navigateEvents_Click(object sender, EventArgs e)
        {
            this.selectedRow = null;
            this.selectedView = "event";
            this.FetchEventsData(); 
        }

        private void navigateRequests_Click(object sender, EventArgs e)
        {
            this.selectedRow = null;
            this.selectedView = "userevent";
            this.FetchRequestsData(); 
        }

       

        private void addButton_Click(object sender, EventArgs e)
        {
            AddResourceForm form = new AddResourceForm(this.selectedView);


            form.ShowDialog(); 




        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if(this.isRowSelected() == true)
            {

                EditResourceForm form = new EditResourceForm(this.selectedView, this.selectedRow);
                form.ShowDialog();
                

            } else
            {
                MessageBox.Show("Musisz najpierw wybrać rząd!"); 
            }



            


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Provider prov = new Provider(); 

            if(this.isRowSelected() == true)
            {
                prov.ExecDeleteQuery($"delete from {this.selectedView} where id={(int)selectedRow.GetType().GetProperty("id").GetValue(selectedRow, null)}");

                this.UpdateData(this.selectedView); 

                MessageBox.Show("Usunięto");
            }
        }

        private class userRequest
        {
            public String user { get; set; }
            public String Event { get; set; }

            public int approved { get; set; }

            public userRequest(String user, String Event, int approved)
            {
                this.user = user;
                this.Event = Event;
                this.approved = approved;
            }

        }

        private void dataTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Console.WriteLine("row header event click event fired");
            switch (selectedView)
            {
                case "user":
                    selectedRow = dataTable.SelectedRows[0].DataBoundItem as UserProvider;

                    break;
                case "event":
                    selectedRow = dataTable.SelectedRows[0].DataBoundItem as EventProvider;
                    break;
                case "userevent":
                    selectedRow = dataTable.SelectedRows[0].DataBoundItem as UserEventProvider;
                    break;
            }


        }
    }
}
