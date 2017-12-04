using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrackerApp.Data
{
    public class DBData
    {
        //Database name
        public static string DB_NAME = "gym_tracker";
        //Collection name
        public static string COLLECTION_NAME = "JohnJones";
        //API key string
        public static string API_KEY = "MA9NBhJ52pjDQt9bl__k9WzE5ywQqvtx";
        //URL path to the DB API
        public static string DB_API_PATH = $"https://api.mlab.com/api/1/databases/{DB_NAME}/collections/{COLLECTION_NAME}";
        //URL to database collection
        public static string DB_PATH = $"https://api.mlab.com/api/1/databases/{DB_NAME}/collections/{COLLECTION_NAME}?apiKey={API_KEY}";
    }
}
