using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrackerApp.Models
{

    /*
     "gym_sessions": [
        {
            "date": "12-12-2017",
            "exercises": [
                {
                    "name": "Squats",
                    "sets": 3,
                    "reps": 12
                },
                {
                    "name": "Lunges",
                    "sets": 5,
                    "reps": 12
                }
            ]
        }
    ]
    */
    //this class should be for variables coming back from MongoDB document
    public class Exercise
    {
        [JsonProperty(PropertyName="name")]
        public string exName { get; set; }

        [JsonProperty(PropertyName = "sets")]
        public int sets { get; set; }

        [JsonProperty(PropertyName = "reps")]
        public int reps { get; set; }
    }
}
