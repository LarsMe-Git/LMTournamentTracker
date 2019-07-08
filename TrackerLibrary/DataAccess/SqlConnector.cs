using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        // TODO make the createPrize method actually save to the database
        /// <summary>
        /// saves a new prize in the database
        /// </summary>
        /// <param name="model"> the prize information</param>
        /// <returns>the prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
