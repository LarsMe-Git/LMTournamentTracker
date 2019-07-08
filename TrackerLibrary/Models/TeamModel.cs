using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one team in the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// represents teammembers
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// represent the team name
        /// </summary>
        public string TeamName { get; set; }


    }
}
