namespace LeaderboardApi.Models
{
    public class Player(int id, string username, Country country)
    {
        public int Id { get; set; } = id;
        public string Username { get; set; } = username;
        public Country Country { get; set; } = country;

        public static List<Player> GetPlayers() =>
        [
            new(1, "Player1", Country.GetById(1)),
            new(2, "Player2", Country.GetById(1)),
            new(3, "Player3", Country.GetById(1))
        ];

        public static Player GetById(int pid)
        {
            return GetPlayers().FindLast(p => p.Id == pid);
        }
    }
}
