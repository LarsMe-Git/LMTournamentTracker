using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represent the current place
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// represent the name of current place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// represent the amount the tournament will give
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// represents the percentage of the amount a place gets
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;

            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
