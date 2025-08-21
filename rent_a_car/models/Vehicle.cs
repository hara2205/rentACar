namespace rent_a_car.models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }
        public string VehicleType { get; set; } = null!; // npr. SUV, Sedan, Hatchback
        public string? ImageUrl { get; set; }            // putanja ili URL slike
        public bool IsAvailable { get; set; } = true;
    }
}
