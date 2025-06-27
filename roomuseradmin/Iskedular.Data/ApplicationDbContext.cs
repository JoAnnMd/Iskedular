using Microsoft.EntityFrameworkCore;
using Iskedular.Models;
using System;

namespace Iskedular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Room> Rooms { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;
        public DbSet<Announcement> Announcements { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure unique emails
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // Static password hash for admin: "BSIT2-2adminiskedular"
            const string staticAdminHash = "$2b$10$QXOBvclWGFmC5DQCWhoY8e.tQuhG2kDYyFiNOsTwLQkkxgKte/wwK";

            // Seed initial admin user
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "Admin",
                    Email = "admin@iskedular.com",
                    PasswordHash = staticAdminHash,
                    Role = UserRole.Admin,
                    DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc) // Static DateTime
                }
            );

            // Seed room data (already using static values)
            modelBuilder.Entity<Room>().HasData(
                // 1st Floor
                new Room { Id = 1, Name = "Room 101", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 2, Name = "Room 102", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 3, Name = "Room 103", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 4, Name = "Room 104", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 5, Name = "Room 105", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 6, Name = "Room 106", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },

                // 2nd Floor
                new Room { Id = 7, Name = "Room 201", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 8, Name = "Room 202", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 9, Name = "Room 203", Capacity = 40, HasWhiteboard = true, HasProjector = true, HasTV = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 10, Name = "Room 204", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 11, Name = "Room 205", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },
                new Room { Id = 12, Name = "Room 206", Capacity = 40, HasWhiteboard = true, HasTV = true, HasProjector = false, IsComputerLab = false, HasAirConditioning = false },

                // Special Rooms
                new Room
                {
                    Id = 13,
                    Name = "Computer Laboratory",
                    Capacity = 20,
                    IsComputerLab = true,
                    HasWhiteboard = true,
                    HasTV = true,
                    HasProjector = false,
                    HasAirConditioning = true
                },
                new Room
                {
                    Id = 14,
                    Name = "Audio Visual Room",
                    Capacity = 60,
                    HasWhiteboard = true,
                    HasTV = true,
                    HasProjector = true,
                    HasAirConditioning = true,
                    IsComputerLab = false
                }
            );

            // Seed initial announcement data with STATIC DateTime values
            modelBuilder.Entity<Announcement>().HasData(
                new Announcement
                {
                    Id = 1,
                    Title = "Welcome to Iskedular!",
                    Content = "We are excited to launch the new Room Reservation System. Please explore the new features!",
                    PublishDate = new DateTime(2024, 6, 19, 10, 0, 0, DateTimeKind.Utc), // Example: June 19, 2024, 10:00 AM UTC
                    ExpiryDate = null,
                    IsActive = true
                },
                new Announcement
                {
                    Id = 2,
                    Title = "Scheduled Maintenance",
                    Content = "The system will undergo maintenance on [Date] from [Start Time] to [End Time]. Expect temporary downtime.",
                    PublishDate = new DateTime(2024, 6, 24, 9, 0, 0, DateTimeKind.Utc), // Example: June 24, 2024, 09:00 AM UTC
                    ExpiryDate = new DateTime(2024, 7, 1, 17, 0, 0, DateTimeKind.Utc), // Example: July 1, 2024, 05:00 PM UTC
                    IsActive = true
                },
                new Announcement
                {
                    Id = 3,
                    Title = "Old Announcement (Expired)",
                    Content = "This announcement should no longer be visible.",
                    PublishDate = new DateTime(2024, 5, 1, 12, 0, 0, DateTimeKind.Utc), // Example: May 1, 2024, 12:00 PM UTC
                    ExpiryDate = new DateTime(2024, 6, 25, 23, 59, 59, DateTimeKind.Utc), // Example: June 25, 2024, 11:59 PM UTC
                    IsActive = true
                },
                 new Announcement
                 {
                     Id = 4,
                     Title = "New Room Added: Collaboration Hub",
                     Content = "We've added a new flexible space. Check Room 301 for details!",
                     PublishDate = new DateTime(2024, 6, 26, 17, 0, 0, DateTimeKind.Utc), // Example: Today, 5:00 PM UTC
                     ExpiryDate = null,
                     IsActive = true
                 }
            );
        }
    }
}