// File: Iskedular.Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using Iskedular.Models;
using System; // Required for DateTime (for DateCreated in seed)

namespace Iskedular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; } // Ensure this DbSet is present

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Room and Reservation relationship
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany() // A room can have many reservations (no collection on Room model)
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete on Room if reservations exist

            // Configure User and Reservation relationship
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations) // A user has many reservations
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade); // If a user is deleted, their reservations are deleted

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique(); // Ensure email is unique
                entity.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(u => u.LastName).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(256);
                entity.Property(u => u.PasswordHash).IsRequired();
                entity.Property(u => u.Role).HasConversion<string>(); // Store enum as string in DB
                entity.Property(u => u.DateCreated).HasDefaultValueSql("GETUTCDATE()"); // Auto-set creation date in DB
            });

            // Configure Reservation entity
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(r => r.Purpose).IsRequired().HasMaxLength(500);
                entity.Property(r => r.Program).HasMaxLength(100);
                entity.Property(r => r.YearSection).HasMaxLength(50);
                entity.Property(r => r.Professor).HasMaxLength(100);
                entity.Property(r => r.ApprovedRejectedByAdmin).HasMaxLength(100); // Max length for admin name
                entity.HasIndex(r => r.StartTime); // Add an index for StartTime for better querying
            });

            // Configure ActivityLog entity (if you need specific fluent API for it, add here)
            // modelBuilder.Entity<ActivityLog>(entity => { ... });

            // Seed Admin User (Using your specific hash)
            // The password for this hash is "BSIT2-2adminiskedular"
            const string staticAdminHash = "$2b$10$QXOBvclWGFmC5DQCWhoY8e.tQuhG2kDYyFiNOsTwLQkkxgKte/wwK";
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "Admin",
                    Email = "admin@iskedular.com",
                    PasswordHash = staticAdminHash, // Your specific hash
                    Role = UserRole.Admin,
                    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc) // Your specific date
                }
            );

            // Seed Room Data (Your 18 rooms)
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
                new Room { Id = 10, Name = "(AVR) Audio Visual Room", Capacity = 150, HasProjector = false, HasWhiteboard = true, HasTV = true, HasAirConditioning = true, HasSoundSystem = false, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 11, Name = "Gymnasium", Capacity = 300, HasProjector = true, HasWhiteboard = false, HasTV = false, HasAirConditioning = true, HasSoundSystem = true, NumberOfComputers = 0, Floor = "1st Floor" },
                new Room { Id = 12, Name = "Chapel", Capacity = 100, HasProjector = true, HasWhiteboard = false, HasTV = false, HasAirConditioning = false, HasSoundSystem = true, NumberOfComputers = 0, Floor = "1st Floor" },

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