namespace LeaderboardApi.Models
{
    public class Location(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;

        public static List<Location> GetLocations() =>
        [
            new(1, "Template World")
        ];

        public static Location GetById(int lid)
        {
            return GetLocations().FindLast(l => l.Id == lid);
        }
    }
}
