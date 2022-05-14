using EventsManager.Controllers;
using EventsManager.Providers.Event;
using EventsManager.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace EventsManager
{
    public partial class UserForm : Form
    {
        private int eventId;

        private static Authentication Authentication = Authentication.GetInstance;
        int userId = Authentication.LoggedUser.id;
        String userLogin = Authentication.LoggedUser.login;

        

        private static EventProvider EventProvider = new EventProvider();
        private static UserEventProvider UserEventProvider = new UserEventProvider();

        //view variable to distinct between tabs 
        // available tabs 
        // 1. signUpView (sign up for a new event view) 
        // 2. EventsView - events that you signed up
        
        private String viewSelected = "eventsView"; 


        public UserForm()
        {
            InitializeComponent();

            
        }
        private void navigateView()
        {
            switch (viewSelected)
            {
                case "eventsView":
                    eventsView.Show();
                    signUpView.Hide();
                    break;
                case "signUpView":
                    signUpView.Show();
                    eventsView.Hide();
                    break;


            }
            this.FetchAvailableEvents();
            this.FetchUserEvents();

        }
        // <caption>
        // this function fetches available events for a user (if he has not signed up for the event already ) and populates comboBox 
        // </caption> 
        private void FetchAvailableEvents()
        {
            

            List<EventProvider> availableEvents = EventProvider.GetEvents();


            //TODO delete the events that the user has already signed up for
            UserEventProvider UEP = new UserEventProvider(userId);
            List<UserEventProvider> userEvents = UEP.GetUserEvents();

            

            //set the available events  to combobox with distinction for the events that the user already signed up for
            Dictionary<int, String> comboSource = new Dictionary<int, String>();

            availableEvents.ForEach(Event =>
            {
                if (userEvents.Find((evt) => { return evt.eventId == Event.id; }) == null)
                {
                    comboSource.Add(Event.id, Event.name);

                }

            });
            eventNameInput.DisplayMember = "Value";
            eventNameInput.ValueMember = "Key";
            eventNameInput.DataSource = new BindingSource(comboSource, null);
        }

        private void FetchUserEvents()
        {
            UserEventProvider UEP = new UserEventProvider(userId); 

            List<UserEventProvider> userEvents = new List<UserEventProvider>(UEP.GetUserEvents());


            userEventsTable.ColumnCount = 4;

            userEventsTable.Columns[0].Name = "Nazwa wydarzenia";
            userEventsTable.Columns[1].Name = "Data wydarzenia";
            userEventsTable.Columns[2].Name = "Typ uczenictwa";
            userEventsTable.Columns[3].Name = "Opcja wyżywienia";

            //clear the table 
            userEventsTable.Rows.Clear(); 

            foreach(var userEvent in userEvents)
            {
                //get event info from db 
                EventProvider Event = EventProvider.GetEventById(userEvent.eventId);
                String participantType = UserEventProvider.GetParticipantOption(userEvent.partOption);
                String foodOption = UserEventProvider.GetFoodOption(userEvent.foodOption);

                string[] RowScheme = { $"{Event.name}", $"{Event.date}", $"{participantType}", $"{foodOption}" };

                userEventsTable.Rows.Add(RowScheme); 
            }
            userEventsTable.Columns[0].DisplayIndex = 0;
            


        }
        private void eventNameInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int key = ((KeyValuePair<int, String>)eventNameInput.SelectedItem).Key;


            EventProvider selectedEvent = EventProvider.GetEventById(key);
            


            //get event agenda and show it 
            if (selectedEvent != null)
            {
                dateLabel.Text = selectedEvent.date.ToString();
                eventAgenda.Text = selectedEvent.agenda;
                this.eventId = selectedEvent.id;

            }





        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            //load default view for a user 
            this.navigateView();


            //welcome user assign login to panel
            userLoginLabel.Text = "Witaj, " + userLogin;

            this.FetchAvailableEvents();
            this.FetchUserEvents(); 


        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {
            var choosenParticipant = participantPanel.Controls.OfType<RadioButton>()
            .FirstOrDefault(r => r.Checked);

            var choosenFood = foodPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            //save event 
            if(choosenFood != null && choosenParticipant != null)
            {
             
             
                Regex matchPattern = new Regex(@"[A-Za-z]_(\d)");
                Match foodMatch = matchPattern.Match(choosenFood.Name);
                Match participantMatch = matchPattern.Match(choosenParticipant.Name);

                Group partOptId = participantMatch.Groups[1];
                Group foodOptId = foodMatch.Groups[1]; 

                UserEventProvider userEvent = new UserEventProvider(userId, eventId, Convert.ToInt32(partOptId.Value), Convert.ToInt32(foodOptId.Value));
                UserEventProvider.AddUserEvent(userEvent);

                this.FetchAvailableEvents(); 
                
            }
            


            



            

        }

        private void navigateSignUpView_Click(object sender, EventArgs e)
        {
            this.viewSelected = "signUpView";
            this.navigateView(); 
        }

        private void navigateEventsView_Click(object sender, EventArgs e)
        {
            this.viewSelected = "eventsView";
            this.navigateView();
        }

        
    }
    
}
