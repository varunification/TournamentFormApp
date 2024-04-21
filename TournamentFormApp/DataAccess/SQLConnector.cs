using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Data;
using System.Drawing;
using TournamentFormApp.Models;

namespace TournamentFormApp.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;
            }
        }
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PriceAmount);
                p.Add("@PrizePercentage", model.PricePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                foreach (PersonModel person in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.id);
                    p.Add("@PersonId", person.Id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);

                }
                return model;

            }
        }
        private void saveTournaments(TournamentModel model, IDbConnection connection)
        { 
            var p = new DynamicParameters();
                p.Add("@TournamentName", model.TournamentName);
                p.Add("@EntryFee", model.EntryFee);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[dbo].[spTournament_Insert]", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
        }

        private void saveTournamentPrizes(PrizeModel prize,TournamentModel model ,IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentId", model.Id);
            p.Add("@PrizeId", prize.Id);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("[dbo].[spTournamentPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
        }

        private void saveTournamentEntries(TeamModel teams, TournamentModel model, IDbConnection connection)
        {
           var p = new DynamicParameters();
            p.Add("@TournamentId", model.Id);
            p.Add("@TeamId", teams.id);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("[dbo].[spTournamentEntries_Insert]", p, commandType: CommandType.StoredProcedure);
        }

        private void SaveTournamentsRounds( TournamentModel model , IDbConnection connection)
        {
            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel matchupModel in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchupModel.MatchupRound);
                    p.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("[dbo].[spMatchups_Insert]", p, commandType: CommandType.StoredProcedure);
                    matchupModel.Id = p.Get<int>("@Id");
                    foreach (MatchupEntryModel entry in matchupModel.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchupModel.Id);
                        p.Add("@ParentMatchupId", entry.ParentMatchup);
                        if(entry.TeamCompeting != null)
                        p.Add("@TeamCompetingId", entry.TeamCompeting.id);
                        else
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("[dbo].[spMatchupEntries_Insert]", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

    public void createTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("Tournaments")))
            {
               saveTournaments(model, connection);
                foreach (PrizeModel prize in model.prizes)
                {
                    saveTournamentPrizes(prize,model, connection);

                }

                foreach (var teams in model.EnteredTeams)
                {
                   
                    saveTournamentEntries(teams, model, connection);    
                }
                TournamentLogic.CreateRounds(model);
                SaveTournamentsRounds(model, connection);
            }
        }

        public List<PersonModel> GetPersonAll()
        {
            List<PersonModel> output = new List<PersonModel>();

            using(IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("")))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeamAll()
        {
            List<TeamModel> output = new();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.cnnValue("")))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(var  team in output)
                {
                    DynamicParameters p = new();
                    p.Add("@TeamId", team.id);
                    team.TeamMembers= connection.Query<PersonModel>("[dbo].[spTeamMembers_GetByTeam]", p, commandType: CommandType.StoredProcedure).AsList();
                }
            }

            return output;
        }
    }
}
