using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GymTrackerApp.Models;
using Newtonsoft.Json;

namespace GymTrackerApp.Data
{
    /*
        {
        "_id": {
            "$oid": "5a2539f4f36d280fefe2fd44"
        },
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
        } 
    */
   
    //Gym session consists of session date and list of exercise objects containing names, sets and reps of exercises done.
    public class GymSession
    {
        [JsonProperty(PropertyName ="date")]
        public DateTime sessionDate;

        [JsonProperty(PropertyName = "exercises")]
        public List<Exercise> exercises;        
    }
}
