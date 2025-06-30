using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Required for [Required], [MaxLength]
using BCrypt.Net; // This using will work after installing the NuGet package

namespace Iskedular.Models
{
    public enum UserRole { Student, Admin }

    public class User
    {
        public int Id { get; set; }

        // Added FirstName and LastName as expected by UserService
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty; // Initialize to empty string to avoid null

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty; // Initialize to empty string to avoid null

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(256)]
        public string Email { get; set; } = string.Empty; // Initialize to empty string

        [Required(ErrorMessage = "Password hash is required.")]
        public string PasswordHash { get; set; } = string.Empty; // Initialize to empty string

        [MaxLength(100)]
        public string ProgramSection { get; set; } = string.Empty; // Stores the user's program and section

        // You can keep FullName if you wish, but it won't be mapped directly to a DB column by default.
        // It could be a computed property:
        // public string FullName => $"{FirstName} {LastName}";
        // Or if you explicitly need it as a DB column, you'd mark it in OnModelCreating.
        // For now, let's omit it to align with UserService expecting FirstName/LastName.

        public UserRole Role { get; set; } = UserRole.Student;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        // Navigation property: A user can have many reservations.
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>(); // Initialize directly

        // Constructor is not strictly necessary if properties are initialized directly.
        // public User()
        // {
        //    // Properties are initialized directly above, making this constructor redundant
        // }

        // --- Methods for Password Hashing and Verification ---
        // These methods use BCrypt.Net.BCrypt for secure password handling.

        /// <summary>
        /// Hashes a plain text password and stores it in the PasswordHash property.
        /// </summary>
        /// <param name="password">The plain text password to hash.</param>
        public void SetPassword(string password)
        {
            // BCrypt.Net.BCrypt.HashPassword generates a salt automatically
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Verifies a plain text password against the stored hash.
        /// </summary>
        /// <param name="password">The plain text password to verify.</param>
        /// <returns>True if the password matches the hash, false otherwise.</returns>
        public bool VerifyPassword(string password)
        {
            // Ensure PasswordHash exists before attempting verification
            if (string.IsNullOrEmpty(PasswordHash))
            {
                return false;
            }
            // BCrypt.Net.BCrypt.Verify handles salt extraction and comparison
            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }
    }
}
