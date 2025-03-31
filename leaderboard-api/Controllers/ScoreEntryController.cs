using LeaderboardApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaderboardApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreEntryController : ControllerBase
    {
        private static readonly List<ScoreEntry> _scores = ScoreEntry.GetScores();

        private readonly ILogger<ScoreEntryController> _logger;

        public ScoreEntryController(ILogger<ScoreEntryController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetScoreEntryList")]
        public IEnumerable<ScoreEntry> Get() => ScoreEntry.GetScores();
    }
}
