using EventsManager.Controllers;
using EventsManager.Providers.Event;
using EventsManager.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EventsManager
{
    public partial class UserForm : Form
    {
        private int eventId;

        private static Authentication Authentication = Authentication.GetInstance;
        int userId = Authentication.LoggedUser.id;
        String userLogin = Authentication.LoggedUser.login; 

        private List<EventProvider> availableEvents = EventProvider.GetEvents();

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
                    signUpView.Hide();
                    break;
                case "signUpView":
                    signUpView.Show();
                    break;


            }
        }

        private void eventNameInput_SelectedIndexChanged(object sender, EventArgs e)
        {


            int key = ((KeyValuePair<int, String>)eventNameInput.SelectedItem).Key;
            this.eventId = key;

            EventProvider selectedEvent = EventProvider.GetEventById(key);

            //get event agenda and show it 
            if (selectedEvent != null)
            {
                dateLabel.Text = selectedEvent.date.ToString();
                eventAgenda.Text = selectedEvent.agenda;

            }




        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            //load default view for a user 
            this.navigateView(); 
            
            //welcome user assign login to panel
            userLoginLabel.Text = "Witaj, " + userLogin;



            //TODO delete the events that the user has already signed up for
            UserEventProvider UEP = new UserEventProvider(userId);
            List<UserEventProvider> userEvents = UEP.GetUserEvents(); 


            //set the available events  to combobox with distinction for the events that the user already signed up for
            Dictionary<int, String> comboSource = new Dictionary<int, String>();

            this.availableEvents.ForEach(Event =>
            {
                if(userEvents.Find((evt) => { return evt.id == Event.id; }) == null)
                {
                    comboSource.Add(Event.id, Event.name);

                }

            });
            eventNameInput.DataSource = new BindingSource(comboSource, null);
            eventNameInput.DisplayMember = "Value";
            eventNameInput.ValueMember = "Key";


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


            }
            this.UserForm_Load(null, null); 


            



            //Console.WriteLine($"{choosenParticipant.Name}");

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
