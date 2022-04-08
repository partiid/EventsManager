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

namespace EventsManager
{
    public partial class LoginForm : Form
    {
        DbConnector database = DbConnector.GetInstance;

        private static UserProvider UserProvider = new UserProvider();

        private protected String userLogin = "";
        private protected String userPassword = ""; 
        
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
            Authentication auth = new Authentication(this.userLogin, this.userPassword);
            if (auth.Authenticate() == false)
            {
                labelError.Visible = true;
            }
            else
            {

                labelError.Visible = false;
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
