namespace LeaderboardApi.Models
{
    public class Maintainer(int id, string username)
    {
        public int Id { get; set; } = id;
        public string Username { get; set; } = username;

        public static List<Maintainer> GetMaintainers() =>
        [
            new(1, "Admin")
        ];

        public static Maintainer GetById(int mid)
        {
            return GetMaintainers().FindLast(m => m.Id == mid);
        }
    }
}
