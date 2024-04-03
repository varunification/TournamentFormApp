﻿namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

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
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get Back from the form a PrizeModel
            //Take the PrizeModel and put it into our List of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();

        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void RemoveSelectedPlayersTeamButton_Click(object sender, EventArgs e)
        {
            if (tournamentTeamListBox.SelectedItem != null)
            {
                if (tournamentTeamListBox.SelectedItem is TeamModel t)
                {
                    selectedTeams.Remove(t);
                    availableTeams.Add(t);
                    WireUpLists();
                }
            }
        }



        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            //PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (prizesListBox.SelectedItem != null)
            {
                if (prizesListBox.SelectedItem is PrizeModel p)
                {
                    selectedPrizes.Remove(p);
                    WireUpLists();
                }

            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate Data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);


            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry fee",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;

            }

            // Create Tournament Model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;


            //TODO -- Wireup Matching
            TournamentLogic.CreateRounds(tm);


            //Create Tournament Entry
            // Create all of the prozes entries
            // Create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();


        }
    }
}
