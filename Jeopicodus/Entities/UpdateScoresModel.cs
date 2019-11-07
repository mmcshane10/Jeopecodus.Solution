using Jeopicodus.Models;

namespace Jeopicodus.Entities
{
    public class UpdateScoresModel
    {
        public Game Game { get; set; }
        public string ActiveTeamId { get; set; }

    }
}