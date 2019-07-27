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
       
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // find the mx id and add the new record with new ID max +1
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }


            model.Id = currentId;
            //currentId += 1;
            people.Add(model);

            // Convert prize to list string
            // save the liststring to text file 
            people.SaveToPeopleFile();

        }


        // TODO wire up the createProze for text files
        //Load the text file
        //convert text to List of Prize model
        public void CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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
            prizes.SaveToPrizeFile();


        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();

        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);
            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
