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
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public string Status { get; set; }
        public DateTime TimeStarted { get; set; }
        public string TimeRemaining { get; set; }
        public string WinningTeam { get; set; }
        public List<Team> Teams { get; set; }
        public static List<Question> Questions = MakeQuestions();
        
        public Game()
        {
            ScoreTeam1 = 0;
            ScoreTeam2 = 0;
            Status = GameStatus.ACCEPTING_PLAYERS;
        }

        public static List<Question> MakeQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.AddRange(GetFillInTheBlanks());
            // questions.AddRange(GetMultiChoice());
            return questions;
        }

        public static List<FillInTheBlank> GetFillInTheBlanks()
        {
            var apiCallTask = ApiHelper.ApiCall("FillInTheBlank");
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            System.Console.WriteLine(jsonResponse);
            List<FillInTheBlank> questions = JsonConvert.DeserializeObject<List<FillInTheBlank>>(result);
            return questions;
        }

        public static List<MultipleChoice> GetMultiChoice()
        {
            var apiCallTask = ApiHelper.ApiCall("MultipleChoice");
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<MultipleChoice> questions = JsonConvert.DeserializeObject<List<MultipleChoice>>(result);
            return questions;
        }
    }
}