using System.Configuration;
using TournamentFormApp.DataAccess;

namespace TournamentFormApp
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

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
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }



    }
}
