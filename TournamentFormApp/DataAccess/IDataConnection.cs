using TournamentFormApp.Models;

namespace TournamentFormApp.DataAccess

{
    public interface IDataConnection
    {
        // no need to declare private or public as interface is always public
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        List<PersonModel> GetPersonAll();
        TeamModel CreateTeam(TeamModel model);
    }
}
