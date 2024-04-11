using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentFormApp;
using TournamentFormApp.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPersonAll();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Varun", LastName = "Aggarwal" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Barun", LastName = "Adsfdfl" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "joey", LastName = "hsdjkf" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "jok", LastName = "lkl" });
        }

        private void LoadListData()
        {

        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";
            tournamentTeamMembersListBox.DataSource = null;
            tournamentTeamMembersListBox.DataSource = selectedTeamMembers;
            tournamentTeamMembersListBox.DisplayMember = "FullName";



        }

        // Event handler for adding team member
        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {
            // Add logic to add team member
        }

        // Event handler for deleting selected team member
        private void DeleteSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)tournamentTeamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();
            }


        }

        // Event handler for creating a new member
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            // Add logic to create a new member
        }

        // Event handler for creating a team
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            // Add logic to create a team
        }

        private void createMemberButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel model = new PersonModel(firstNameValue.Text, lastNameValue.Text, emailAddressValue.Text, phoneValue.Text);

                GlobalConfig.Connections.CreatePerson(model);

                availableTeamMembers.Add(model);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailAddressValue.Text = "";
                phoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all the fields");
            }
        }
        private bool ValidateForm()
        {

            if (firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0 || emailAddressValue.Text.Length == 0 || phoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void createTeamButton_Click_1(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers =  selectedTeamMembers;

            GlobalConfig.Connections.CreateTeam(t);

            // TODO - If we ain't closing this form after creation reset the form
        }



        private void tournamentTeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeamMemberButton_Click_1(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

            //selectTeamMemberDropDown.Refresh();
            //ournamentTeamMembersListBox.Refresh();


        }
    }
}
