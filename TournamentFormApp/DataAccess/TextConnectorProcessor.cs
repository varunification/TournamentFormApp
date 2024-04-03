using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
    }
}
