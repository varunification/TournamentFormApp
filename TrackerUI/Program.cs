using Microsoft.Extensions.Configuration;
using TournamentFormApp;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            
            GlobalConfig.InitializeConnections(DatabaseType.sql);
            Application.Run(new CreateTournamentForm());
        }
    }
}