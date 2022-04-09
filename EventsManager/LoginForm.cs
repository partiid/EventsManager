using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsManager.User; 
using System.Windows.Forms;
using EventsManager.Controllers;
using EventsManager.Providers.Event;
using EventsManager.Providers;

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




            //validate the fields 


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
                
                if (user.role.ToString() == "user")
                {
                    this.Hide(); 
                    UserForm userForm = new UserForm();
                    userForm.ShowDialog();

                    this.Close(); 
                    
                } else
                {
                    //todo implement admin form and show it 

                }
                

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
