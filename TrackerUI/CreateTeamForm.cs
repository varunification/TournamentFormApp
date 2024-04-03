﻿namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            Wireuplists();
        }



        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "ABC", LastName = "XYZ" });
            availableTeamMembers.Add(new PersonModel { FirstName = "DEF", LastName = "PQR" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "GHI", LastName = "MNO" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "LOP", LastName = "RST" });

        }

        private void Wireuplists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            tournamentTeamMembersListBox.DataSource = null;

            tournamentTeamMembersListBox.DataSource = selectedTeamMembers;
            tournamentTeamMembersListBox.DisplayMember = "FullName";

        }
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailAddressValue.Text;
                p.PhoneNumber = phoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                Wireuplists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailAddressValue.Text = "";
                phoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("Fill in all fields");
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
            if (emailAddressValue.Text.Length == 0)
            {
                return false;
            }
            if (phoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                Wireuplists();
            }

        }

        private void deleteSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = tournamentTeamMembersListBox.SelectedItem as PersonModel;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                Wireuplists();
            }



        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close();


        }
    }
}
