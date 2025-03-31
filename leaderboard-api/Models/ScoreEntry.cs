namespace LeaderboardApi.Models
{
    public class ScoreEntry(int id, int rank, double score, Player player, Vehicle vehicle, Track track, int ghostId, DateOnly date)
    {
        public int Id { get; set; } = id;
        public int Rank { get; set; } = rank;
        public double Score { get; set; } = score;
        public Player Player { get; set; } = player;
        public Vehicle Vehicle { get; set; } = vehicle;
        public Track Track { get; set; } = track;
        public int GhostId { get; set; } = ghostId;
        public DateOnly Date { get; set; } = date;

        public static List<ScoreEntry> GetScores() =>
        [
            new(1, 1, 37.5, Player.GetById(1), Vehicle.GetById(1), Track.GetById(1), 1, new DateOnly(2025, 3, 30)),
            new(2, 2, 39.7, Player.GetById(2), Vehicle.GetById(1), Track.GetById(1), 2, new DateOnly(2025, 3, 30)),
            new(3, 3, 40.1, Player.GetById(3), Vehicle.GetById(1), Track.GetById(1), 3, new DateOnly(2025, 3, 30))
        ];
    }
}
