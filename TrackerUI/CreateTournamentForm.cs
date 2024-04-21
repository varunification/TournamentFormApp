using System.DirectoryServices.ActiveDirectory;
using TournamentFormApp;
using TournamentFormApp.Models;
//tournamentTeamListBox
namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeamAll();
        List<TeamModel> selectedTeams = new();
        List<PrizeModel> prize = new();

        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            Initializelists();
            //WireUpLists();
        }


        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                Initializelists();
            }
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // call the create prize form
            // we need to get back from the form a price model
            // we need to addd that to the list of selected prices

            CreatePrizeForm frm = new(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get Back from the form a PrizeModel
            //Take the PrizeModel and put it into our List of selected prizes

            selectedPrizes.Add(model);
            Initializelists();
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
            //validate data
            // create our tournament model
            // create tournament entry
            // create all of the prices entries
            // create all of the team entries
            // create our matchups

            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("you need to enter a valid entry fee", "Invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();

            tm.EntryFee = fee;

            tm.prizes = selectedPrizes;
            tm.TournamentName = tournamentNameValue.Text;
            tm.EnteredTeams = selectedTeams;
            TournamentLogic.CreateRounds(tm);
            GlobalConfig.Connections.createTournament(tm);
            //GlobalConfig.Connections.SaveTournamentsRounds()

        }

        private void Initializelists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamListBox.DataSource = new List<TeamModel>();
            tournamentTeamListBox.DataSource = selectedTeams;
            tournamentTeamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

        }

        public void teamComplete(TeamModel team)
        {
            selectedTeams.Add(team);
            Initializelists();

        }

        private void createNewTeamLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new(this);
            frm.Show();
        }

        private void RemoveSelectedPlayersTeamButton_Click_1(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                Initializelists();
            }

        }

        private void removeSelectedPrizeButton_Click_1(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                Initializelists();
            }
        }

        private void entryFeeValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
