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
    public partial class EditResourceForm : Form
    {
        private string formType = "";
        private Provider prov = new Provider();
        private object selectedRow; 

        public EditResourceForm()
        {
            InitializeComponent();
        }

        public EditResourceForm(String formType, Object selectedRow)
        {
            InitializeComponent();
            this.formType = formType;
            this.selectedRow = selectedRow; 
            

            this.populateForm(selectedRow);
        }

        private void populateForm(Object selectedRow)
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
                case "userevent":
                    prov = new UserEventProvider();
                    break;
            }

            Console.WriteLine(prov.GetType().Name);

            PropertyInfo[] propertyInfos = selectedRow.GetType().GetProperties();


            foreach (var property in propertyInfos)
            {
                if (property.Name != "id")
                {

                    Console.WriteLine(property.Name);
                    Label label = new Label();
                    label.Text = property.Name;
                    label.Font = font;

                    panelLabels.Controls.Add(label);

                    TextBox field = new TextBox();
                    field.BackColor = Color.White;
                    field.ForeColor = Color.Black;
                    field.Text = (string)selectedRow.GetType().GetProperty(property.Name).GetValue(selectedRow, null).ToString(); 
                    field.Font = font;
                    field.Name = property.Name;

                    panelFields.Controls.Add(field);
                }



            }
        }

        private void submitEditButton_Click(object sender, EventArgs e)
        {
            foreach (var field in panelFields.Controls)
            {
                TextBox fieldSender = (TextBox)field;

                
                try
                {
                    dynamic changedObj = Convert.ChangeType(fieldSender.Text, prov.GetType().GetProperty(fieldSender.Name).PropertyType);

                    Utils.SetProperty(prov, fieldSender.Name, changedObj);

                    fieldSender.Text = "";
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }


            prov.ExecUpdateQuery(prov, this.formType, (int)selectedRow.GetType().GetProperty("id").GetValue(selectedRow, null));

            
            

            this.Hide();


            //Dialog dialog = new Dialog();
            //dialog.Show(); 

            MessageBox.Show("Pomyślnie Edytowano");
        }
    }
}
