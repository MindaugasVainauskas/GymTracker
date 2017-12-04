using GymTrackerApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GymTrackerApp.Data
{
    public class ConnectionHelper
    {
        //method to return all gym sessions from the DB
        public static async Task<List<GymSession>> getAllSessions()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(DBData.DB_PATH);

                var responseText = await response.Content.ReadAsStringAsync();

                //if response returns valid response text.
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //Convert response from database into json.
                    var gym_sessions = JsonConvert.DeserializeObject<List<GymSession>>(responseText);
                    return gym_sessions;
                }
                return null;
               
            }
        }

        //Insert new session into DB.
        public static async Task insertSession(GymSession session)
        {
            using (var client = new HttpClient())
            {
                var address = new Uri(DBData.DB_PATH);

                GymSession newSession = new GymSession();
                newSession.sessionDate = DateTime.Now.ToLocalTime();
                //set up new exercise, sets and reps to add to session
                Exercise newExercise = new Exercise();
                newExercise.exName = "push-ups";
                newExercise.sets = 5;
                newExercise.reps = 12;
                //add new exercise to the list of exercises
                newSession.exercises.Add(newExercise);

                string postBody = JsonConvert.SerializeObject(newSession);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var responseText = await client.PostAsync(address, new StringContent(postBody, Encoding.UTF8, "application/json"));            }
        }
    }
}
