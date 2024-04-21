using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TournamentFormApp.Models;

namespace TournamentFormApp.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        private static string name = "C://Data//Tournaments//";

        public static string FullFilePath(this string filename)
        {
            return $"{name}\\{ filename }";
        }
        
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PriceAmount = decimal.Parse(cols[3]);
                p.PricePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }


        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                string temp = $"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PriceAmount},{p.PricePercentage}";
                lines.Add(temp);
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();
            foreach(var rr in lines)
            {
                string[] cols = rr.Split(',');
                // id, team name
                TeamModel t = new TeamModel();
                t.id = int.Parse(cols[0]);
                t.TeamName = cols[1];
                string[] personIds = cols[2].Split("|");

                foreach(string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }

            return output;

        }

        public static void SaveToTeamsFile(this List<TeamModel> models, string filename)
        {
            List<string > lines = new List<string>();   
            foreach (var team in models)
            {
                lines.Add($"{team.id},{team.TeamName},{ConvertPeopleListToString(team.TeamMembers)}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString( List<PersonModel> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return output;
            }

            foreach (var person in people) {
                output += $"{person.Id}|";    
            }
            
                output = output.Substring(0, output.Length - 1);
            
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
               PersonModel p = new PersonModel();
                p.Id = int.Parse((string)cols[0]);
                p.FirstName =(cols[1]);
                p.LastName = cols[2];
               p.EmailAddress = cols[3];

                p.CellphoneNumber = cols[4];
                personModels.Add(p);
            }
            return personModels;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string filename) { 
        
        List<string> lines = new List<string>();
            foreach(var p in models)
            {
                string temp = $"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}";
                lines.Add(temp);
            }
        
        File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static List<TournamentModel> convertToTournamentModels(this List<string> lines, string teamFileName, string peopleFile, string prizesfile)
        {
            //id, tournamentname, EntryFee, (id|id|id- entered teams), (id|id|id - Prizes), (Rounds - id^id^id| id^id^id|)
            List<TournamentModel> output = new();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);
            List<PrizeModel> prizes = prizesfile.FullFilePath().LoadFile().ConvertToPrizeModels();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);
                string[] teamids = cols[3].Split("|");
                foreach(string teamid in teamids)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.id == int.Parse(teamid)).First());
                }
                string[] p = cols[4].Split("|");

                foreach(string pid in p)
                {
                    tm.prizes.Add(prizes.Where(x=>x.Id== int.Parse(pid)).First());
                }

                //TODO: create rounds





                output.Add(tm);
            }



           

            return output;
        }

        private static string ConvertToTeamListToString(List<TeamModel> teams)
        {
            StringBuilder output = new StringBuilder();
            if (teams.Count == 0)
            {
                return "";
            }
            foreach(TeamModel team in teams)
            {
                output.AppendLine($"{team.id}|");
            }
            return output.ToString().Substring(0, output.Length - 1);
        }


        public static string ConvertPrizeListToString(this List<PrizeModel> prize)
        {
            StringBuilder output = new StringBuilder();

            if(prize.Count == 0)
            {
                return "";
            }
            foreach(PrizeModel p in prize)
            {
                output.AppendLine($"{p.Id}");
            }
            return output.ToString().Substring(0,output.Length - 1);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if(rounds.Count == 0)
            {
                return "";
            }

            foreach(var r in  rounds)
            {
                output += $"{convertMatchupToString(r)}|";
            }
            return output.Substring(0,output.Length - 1);   

        }

        private static string convertMatchupToString(List<MatchupModel> matchups)
        {
            if(matchups.Count == 0)
            {
                return "";
            }
            string output = "";
           foreach( MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
           return output.Substring(0, output.Length - 1);

        }



        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new();
            foreach(TournamentModel tm in models)
            {
                string temp = 
                    $@"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertToTeamListToString(tm.EnteredTeams)},{ConvertPrizeListToString(tm.prizes)},{ConvertRoundListToString(tm.Rounds)}";
                lines.Add(temp);
            }

        }

    }
}
