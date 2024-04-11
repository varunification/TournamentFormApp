using TournamentFormApp.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form { 

        //List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            //selectTeamDropDown.DataSource = null;
            //selectTeamDropDown.DataSource = availableTeams;
            //selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamListBox.DataSource = null;
            tournamentTeamListBox.DataSource = selectedTeams;
            tournamentTeamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

        }
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                //availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
           
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get Back from the form a PrizeModel
            //Take the PrizeModel and put it into our List of selected prizes
            

        }

        public void TeamComplete(TeamModel model)
        {
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void RemoveSelectedPlayersTeamButton_Click(object sender, EventArgs e)
        {
        }



        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            //PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate Data
            


           


        }
    }
}
