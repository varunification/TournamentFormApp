using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentFormApp.Models;

namespace TournamentFormApp
{
    public interface IDataConnection
    {
        // no need to declare private or public as interface is always public
        PrizeModel CreatePrize(PrizeModel model);
    }
}
