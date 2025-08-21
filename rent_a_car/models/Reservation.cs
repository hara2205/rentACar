namespace rent_a_car.models
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public int UserID { get; set; }
        public Users User { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
