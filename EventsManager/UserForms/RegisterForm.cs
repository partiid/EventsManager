using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventsManager.Providers; 

namespace EventsManager.UserForms
{
    public partial class RegisterForm : Form
    {
        private static UserProvider UserProvider = new UserProvider(); 
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SignupButton_click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            string lastname = this.lastname.Text;
            string email = this.email.Text;
            string password = this.password.Text;
            string login = this.login.Text;

            string defaultRole = "user"; 

            if(this.validateFields() == 0)
            {
                UserProvider newUser = new UserProvider(login, password, defaultRole, name, password);

                newUser.AddUser(newUser);

                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog(); 

                this.Close(); 


            } else
            {
                MessageBox.Show("Nie udało się dodać użytkownika. SPrawdź błędy.");
            }




        }

        private int validateFields()
        {
            string name = this.name.Text;
            string lastname = this.lastname.Text;
            string email = this.email.Text;
            string password = this.password.Text;
            string login = this.login.Text;

            int errors = 0; 

            //validate email 
            try
            {
                MailAddress validEmail = new MailAddress(email); 


            }catch(FormatException)
            {
                errors = 1;
                this.errors.Text = "Email niepoprawny";
            }

            return errors; 


        }
    }
}
