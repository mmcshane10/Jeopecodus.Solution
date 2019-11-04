using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopicodus.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public string Status { get; set; }
        public DateTime TimeStarted { get; set; }
        public string TimeRemaining { get; set; }
        public string WinningTeam { get; set; }

        public virtual IEnumerable<ApplicationUser> Users {get; set; }
        public static List<Question> Questions()
        {
            List<Question> questions = GetFillInTheBlanks();
            questions.AddRange(GetMultiChoice());
            return questions;
        }

        public static List<Question> GetFillInTheBlanks()
        {
            var apiCallTask = ApiHelper.ApiCall("FillInTheBlank");
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(result);
            return questions;
        }

        public static List<Question> GetMultiChoice()
        {
            var apiCallTask = ApiHelper.ApiCall("MultipleChoice");
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(result);
            return questions;
        }
    }
}