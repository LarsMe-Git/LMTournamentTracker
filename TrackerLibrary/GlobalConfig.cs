using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); //new way

        public static void InitializeConnections(bool database, bool textFiles)
        {
            //old way: Connections = new List<IDataConnection>();
            if (database == true)
            {
                //TODO Set up sql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles == true)
            {

                //TODO setup properly

                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
