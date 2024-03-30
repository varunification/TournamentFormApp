using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentFormApp
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections {  get; private set; }

        public static void InitializeConnections(bool database=false, bool textFiles=false)
        {
            if (database)
            {
                //do something database related
            }
            if (textFiles)
            {

            }


        }
    }
}
