using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// represents the first name of a person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// represents the last name of a person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// represents the mail address of a person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// represents the number of a person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
