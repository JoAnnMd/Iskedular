using Microsoft.EntityFrameworkCore;
using Iskedular.Models; // User, Room, Reservation models were used
using System; // Required for DateTime
using BCrypt.Net; // For password hashing

namespace Iskedular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // Admin user seeding (unchanged from previous version, using fixed hash)
            const string staticAdminHash = "$2b$10$QXOBvclWGFmC5DQCWhoY8e.tQuhG2kDYyFiNOsTwLQkkxgKte/wwK"; // HASH for "BSIT2-2adminiskedular"
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "Admin",
                    Email = "admin@iskedular.com",
                    PasswordHash = staticAdminHash,
                    Role = UserRole.Admin,
                    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            );

            // NEW: All 18 Room Seed Data
            modelBuilder.Entity<Room>().HasData(
                // First Floor Rooms
                new Room { Id = 1, Name = "Room 101", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 2, Name = "Room 102", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 3, Name = "Room 103", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 4, Name = "Room 104", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 5, Name = "Room 105", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 6, Name = "Room 106", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 7, Name = "Roth #1", Capacity = 30, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 8, Name = "Roth #2", Capacity = 30, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 9, Name = "Computer Laboratory", Capacity = 20, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = true, HasSoundSystem = false, NumberOfComputers = 20, Floor = "1st Floor" },
                new Room { Id = 10, Name = "(AVR) Audio Visual Room", Capacity = 150, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = true, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" }, // Assuming AVR means Audio Visual Room, hence higher capacity
                new Room { Id = 11, Name = "Gymnasium", Capacity = 300, HasProjector = true, HasWhiteboard = false, HasTV = false, HasAirConditioning = true, HasSoundSystem = true, NumberOfComputers = 0, Floor = "1st Floor" }, // Assuming Gymnasium is a large area
                new Room { Id = 12, Name = "Chapel", Capacity = 100, HasProjector = true, HasWhiteboard = false, HasTV = false, HasAirConditioning = false, HasSoundSystem = true, NumberOfComputers = 0, Floor = "1st Floor" }, // Assuming Chapel is a large area

                // Second Floor Rooms
                new Room { Id = 13, Name = "Room 201", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" },
                new Room { Id = 14, Name = "Room 202", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" },
                new Room { Id = 15, Name = "Room 203", Capacity = 50, HasProjector = true, HasWhiteboard = true, HasTV = false, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" },
                new Room { Id = 16, Name = "Room 204", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" },
                new Room { Id = 17, Name = "Room 205", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" },
                new Room { Id = 18, Name = "Room 206", Capacity = 40, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = false, HasSoundSystem = false, NumberOfComputers = 0, Floor = "2nd Floor" }
            );
        }
    }
}
