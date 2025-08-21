using Microsoft.EntityFrameworkCore;
using rent_a_car.models;

namespace rent_a_car.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
    }
}
