// In Iskedular.Core/Models/User.cs (Adjust namespace if different, e.g., Iskedular.Core.Models)
using System;
using System.Collections.Generic;

namespace Iskedular.Core.Models
{
    public enum UserRole { Student, Admin }

    public class User
    {
        public int Id { get; set; }

        // Non-nullable string properties initialized in the constructor
        public string Email { get; set; }
        public string PasswordHash { get; set; } // We will store a HASH, not the password!
        public string FullName { get; set; }

        public UserRole Role { get; set; } = UserRole.Student;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        // Navigation property: A user can have many reservations.
        // Collections should always be initialized to prevent NullReferenceExceptions
        public virtual ICollection<Reservation> Reservations { get; set; }

        // Constructor to initialize non-nullable reference type properties
        public User()
        {
            Email = string.Empty;        // Initialize string
            PasswordHash = string.Empty; // Initialize string
            FullName = string.Empty;     // Initialize string
            Reservations = new List<Reservation>(); // Initialize the collection
        }
    }
}