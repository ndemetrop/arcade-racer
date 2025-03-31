namespace LeaderboardApi.Models
{
    public class Track(int id, string name, Location location)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public Location Location { get; set; } = location;

        public static List<Track> GetTracks() =>
        [
            new(1, "Template Track", Location.GetById(1))
        ];

        public static Track GetById(int tid)
        {
            return GetTracks().FindLast(t => t.Id == tid);
        }
    }
}
