using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrackerApp.Models
{
    //this class should be coming back from DB table
    public class Exercise
    {
        public string exName { get; set; }
        public int sets { get; set; }
        public int reps { get; set; }
    }
}
