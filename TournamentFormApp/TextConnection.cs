using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentFormApp.Models;

namespace TournamentFormApp
{
    public class TextConnection : IDataConnection
    {
        PrizeModel IDataConnection.CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
