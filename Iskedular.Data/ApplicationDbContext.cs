using Microsoft.EntityFrameworkCore;
using Iskedular.Models; // User, Room, Reservation models were used
using System; // Required for DateTime

namespace Iskedular.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that accepts DbContextOptions (for DI from Program.cs)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; } // Room model was assumed to exist
        public DbSet<Reservation> Reservations { get; set; } // Reservation model was assumed to exist


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // An index was added to ensure unique emails.
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // A static hash for "BSIT2-2adminiskedular" was defined.
            // This hash was pre-computed and hardcoded to prevent "PendingModelChangesWarning".
            // THIS IS THE CORRECT AND CONSISTENT HASH YOU SHOULD USE.
            const string staticAdminHash = "$2b$10$QXOBvclWGFmC5DQCWhoY8e.tQuhG2kDYyFiNOsTwLQkkxgKte/wwK";


            // Initial admin user data was seeded.
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1, // A unique ID was assigned for the seeded admin user.
                    FirstName = "System",
                    LastName = "Admin",
                    Email = "admin@iskedular.com",
                    PasswordHash = staticAdminHash, // The static hash was used here.
                    Role = UserRole.Admin, // The role was explicitly set to Admin.
                    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc) // DateTime.UtcNow was replaced with a static date to prevent "PendingModelChangesWarning".
                }
            );

            
        }
    }
}
