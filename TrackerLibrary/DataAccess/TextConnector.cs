using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers; // extension Methods, not usable in other classes unless using this namespace

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";


        // TODO wire up the createProze for text files
        //Load the text file
        //convert text to List of Prize model
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find the mx id and add the new record with new ID max +1
            int currentId = 1;

            if (prizes.Count > 0)
            {
               currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            
            model.Id = currentId;
            //currentId += 1;
            prizes.Add(model);

            // Convert prize to list string
            // save the liststring to text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
