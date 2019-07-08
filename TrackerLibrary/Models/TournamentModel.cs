using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// represent the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// represent the entry fee for a tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// represent a list of teams competing
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// reprecent prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represents the number of rounds in a tournament
        /// </summary>

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
