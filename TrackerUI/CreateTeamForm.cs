using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUi
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm()
        {
            InitializeComponent();

          //  CreateSampleData(); test Methode für Personen Liste

            WireUpLists();
        }

      

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Lars", LastName = "Meske" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Max", LastName = "Mustermann" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Martha", LastName = "Musterfrau"});
            selectedTeamMembers.Add(new PersonModel { FirstName = "Johannes", LastName = "Schmidt" });
        }


        private void WireUpLists()
        {

            // TODO Refresh DataBinding research
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = phoneNumberValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = " ";
                lastNameValue.Text = " ";
                emailValue.Text = " ";
                phoneNumberValue.Text = " ";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields");
            }
        }

        private bool ValidateForm()
        {
           if (firstNameValue.Text.Length == 0)
            {
                return false;

            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;

            }

            if (emailValue.Text.Length == 0)
            {
                return false;

            }
            if (phoneNumberValue.Text.Length == 0)
            {
                return false;

            }

            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {

                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Add(p);
                availableTeamMembers.Remove(p);

                WireUpLists(); 
            }
        }
    }
}
