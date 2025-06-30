// File: Iskedular.Models/User.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BCrypt.Net;

namespace Iskedular.Models
{
    public enum UserRole { Student, Admin }

    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(256)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password hash is required.")]
        public string PasswordHash { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}".Trim();
        public string Username => Email; // Assuming email is the username for login

        public UserRole Role { get; set; } = UserRole.Student;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public void SetPassword(string password)
        {
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            if (string.IsNullOrEmpty(PasswordHash))
            {
                return false;
            }
            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }
    }
}