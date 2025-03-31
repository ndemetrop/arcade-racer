namespace LeaderboardApi.Models
{
    public class Country(int id, string code, string name)
    {
        public int Id { get; set; } = id;
        public string Code { get; set; } = code;
        public string Name { get; set; } = name;

        public static List<Country> GetCountries() =>
        [
            new(1, "US", "United States")
        ];

        public static Country GetById(int cid)
        {
            return GetCountries().FindLast(c => c.Id == cid);
        }
    }
}
