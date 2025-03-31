namespace LeaderboardApi.Models
{
    public class Vehicle(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;

        public static List<Vehicle> GetVehicles() =>
        [
            new(1, "El Carro")
        ];

        public static Vehicle GetById(int vid)
        {
            return GetVehicles().FindLast(v => v.Id == vid);
        }
    }
}
