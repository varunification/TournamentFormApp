﻿namespace TournamentFormApp.Models
{
    public class TeamModel
    {
        public int id { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
