using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrackerApp.Data
{

    //Create class for Id used in MongoDB collections.
    public class Id
    {
        [JsonProperty(PropertyName = "$oid")]
        public string oid { get; set; }
    }

    //This class should display the data(Hopefully)
    public class dbDataDisplay
    {
        [JsonProperty(PropertyName = "gym_sessions")]
        public List<GymSession> sessions { get; set; }
    }
}
