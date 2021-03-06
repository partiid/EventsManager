using EventsManager.Providers;
using EventsManager.Providers.Event;
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

namespace EventsManager.AdminForms
{
    public partial class AddResourceForm : Form
    {

        private String formType = "";
        Provider prov = new Provider();
        public AddResourceForm()
        {
            InitializeComponent();
        }
        public AddResourceForm(String formType)
        {
            InitializeComponent(); 
            this.formType = formType;

            this.populateForm(); 
        }
       

        private void populateForm()
        {
            
            Font font = new Font("Georgia", 16);

            switch (this.formType)
            {
                case "user":
                    prov = new UserProvider();
                    break;
                case "event":
                    prov = new EventProvider();
                    break;
                case "userEvent":
                    prov = new UserEventProvider();
                    break; 
            }

            Console.WriteLine(prov.GetType().Name);

            PropertyInfo[] propertyInfos = prov.GetType().GetProperties();
            

            foreach(var property in propertyInfos)
            {
                if(property.Name != "id")
                {
                    Console.WriteLine(property.Name);
                    Label label = new Label();
                    label.Text = property.Name;
                    label.Font = font; 
                    panelLabels.Controls.Add(label);

                    TextBox field = new TextBox();
                    field.BackColor = Color.White;
                    field.ForeColor = Color.Black;
                    field.Text = "";
                    field.Font = font;
                    field.Name = property.Name;

                    panelFields.Controls.Add(field);
                }
                


            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

    
            //set properties of an object based on field value and name generated in populateForm            
            foreach (var field in panelFields.Controls)
            {
                TextBox fieldSender = (TextBox)field;

                dynamic changedObj = Convert.ChangeType(fieldSender.Text, prov.GetType().GetProperty(fieldSender.Name).PropertyType);
                Utils.SetProperty(prov, fieldSender.Name, changedObj);

                fieldSender.Text = ""; 
            }

            prov.ExecInsertQuery(prov, this.formType);

            //Dialog dialog = new Dialog();
            //dialog.Show(); 

            MessageBox.Show("Pomyślnie dodano"); 


        }
    }
}
