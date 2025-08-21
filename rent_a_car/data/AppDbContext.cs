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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Primarni ključevi
            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserID);

            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.VehicleID);

            modelBuilder.Entity<Reservation>()
                .HasKey(r => r.ReservationID);

            // Relacije
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Vehicle)
                .WithMany()
                .HasForeignKey(r => r.VehicleID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
