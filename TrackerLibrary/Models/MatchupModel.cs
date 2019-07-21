using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents on match in the tournament
    /// </summary>
    public class MatchupModel
    {

        /// <summary>
        /// the unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents set of teams in the match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        public int WinnerId { get; set; }
        /// <summary>
        /// represents the winner in a match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// represents the current round this match takes place
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
