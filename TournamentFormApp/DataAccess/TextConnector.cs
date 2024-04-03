using TournamentFormApp.Models;
using TournamentFormApp.DataAccess.TextHelpers;
namespace TournamentFormApp.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
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
        
    }
}
