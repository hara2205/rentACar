namespace rent_a_car.models
{
    public class Users
    {
        public int UserID { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!; // hashirana lozinka
        public string? Phone { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
    }
}
