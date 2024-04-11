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


    }
}
