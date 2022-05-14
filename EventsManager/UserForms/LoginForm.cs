using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsManager.Providers; 
using System.Windows.Forms;
using EventsManager.Controllers;
using EventsManager.Providers.Event;


namespace EventsManager
{
    public partial class LoginForm : Form
    {
        DbConnector database = DbConnector.GetInstance;

        private static UserProvider UserProvider = new UserProvider();
        private static EventProvider EventProvider = new EventProvider();
        private static Authentication Authentication = Authentication.GetInstance; 

        private protected String userLogin = "";
        private protected String userPassword = "";
        private protected String userRole = ""; 
        
        public LoginForm()
        {
            InitializeComponent();
            

        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //TODO validate the fields 


            //authenticate user
            Authentication.login = this.userLogin;
            Authentication.password = this.userPassword; 

            if (Authentication.Authenticate() == false)
            {
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;

                UserProvider user = UserProvider.GetUserByLogin(this.userLogin);
                this.Hide();
                //depending on user role show proper form 
                if (user.role.ToString() == "user")
                {
                    
                    UserForm userForm = new UserForm();
                    userForm.ShowDialog();
                    
                } else
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog(); 
                    
                }
                
                this.Close();

            }
        }
        
        private void loginInput_TextChanged(object sender, EventArgs e)
        {
            this.userLogin = loginInput.Text;
            
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            this.userPassword = passwordInput.Text;
        }
    }
}
