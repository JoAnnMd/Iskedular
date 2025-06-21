// In Iskedular.Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
// Remove 'using System.Collections.Generic;' as it's not needed here
using Iskedular.Core.Models; // Change 'YourApp.Core.Models' to 'Iskedular.Core.Models'

namespace Iskedular.Data // Change 'YourApp.Data' to 'Iskedular.Data'
{
    public class ApplicationDbContext : DbContext
    {
        // Add a DbSet for each of your models. This tells EF Core to create a table for each one.
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // IMPORTANT: Replace "YourServerName" with the actual name of your SQL Server instance.
            // If you're using a local SQL Server Express, it might be something like ".\SQLEXPRESS" or "(localdb)\MSSQLLocalDB"
            optionsBuilder.UseSqlServer(@"Server=YourServerName;Database=ClassroomReservationDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}