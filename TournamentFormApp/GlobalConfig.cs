using System.Configuration;
using System.Runtime.CompilerServices;
using TournamentFormApp.DataAccess;

namespace TournamentFormApp
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
        private static string connectionstring = "Server=DESKTOP-PJH5AQK;Database=Tournaments;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=true;";
        public static void InitializeConnections(DatabaseType db)
        {
            if (db==DatabaseType.sql)
            {
                //do something database related
                SQLConnector sql = new SQLConnector();
                  Connections = sql;
            }
            else if (db==DatabaseType.textFile)
            {
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string cnnValue(string name)
        {
            return connectionstring;
        }
    }
}
