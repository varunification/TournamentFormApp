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
            IConfiguration config = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .Build();
            GlobalConfig.InitializeConnections(DatabaseType.sql);
            Application.Run(new TournamentDashboardForm());
        }
    }
}