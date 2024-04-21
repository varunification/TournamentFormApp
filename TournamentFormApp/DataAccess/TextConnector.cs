using TournamentFormApp.Models;
using TournamentFormApp.DataAccess.TextHelpers;
using System.Linq;

namespace TournamentFormApp.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string peopleFile = "PersonModels.csv";
        private const string teamFile = "TeamModels.csv";
        private const string tournamentFile = "TournamentModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int id = 1;
            if (people.Count > 0)
            {
                id= people.OrderByDescending(x=>x.Id).First().Id +1;

            }

            model.Id = id;
            people.Add(model);
            people.SaveToPeopleFile(peopleFile);
            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;
            if(prizes.Count>0)
                currentId=prizes.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            model.Id = currentId;
            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teammodels = teamFile.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);
            int currentId = 1;
            if (teammodels.Count > 0)
                currentId = teammodels.OrderByDescending(x=>x.id).FirstOrDefault().id + 1;
            model.id = currentId;

            teammodels.Add(model);
            teammodels.SaveToTeamsFile(teamFile);
            return model;

        }

        public void createTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = tournamentFile.FullFilePath().LoadFile().convertToTournamentModels(teamFile, peopleFile, PrizesFile);
            int currentId = 1;
            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x=>x.Id).First().Id + 1;
            }
            model.Id = currentId;

            tournaments.Add(model);
            tournaments.SaveToTournamentFile();
        }

        public List<PersonModel> GetPersonAll()
        {
           return peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        }

        public List<TeamModel> GetTeamAll()
        {
            return teamFile.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);
        }

     
    }
}
