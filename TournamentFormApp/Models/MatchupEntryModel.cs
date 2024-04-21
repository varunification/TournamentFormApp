namespace TournamentFormApp.Models
{/// <summary>
/// 
/// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        ///  represents one team in the matchup.lp
        /// </summary>
        public int Id { get; set; }  
        public TeamModel TeamCompeting { get; set; }
        public double score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}