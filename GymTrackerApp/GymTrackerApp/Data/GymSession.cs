using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GymTrackerApp.Models;

namespace GymTrackerApp.Data
{
    //Gym session consists of session date and list of exercise objects containing names, sets and reps of exercises done.
    public class GymSession
    {
        public DateTime sessionDate;
        public List<Exercise> exercises;        
    }
}
