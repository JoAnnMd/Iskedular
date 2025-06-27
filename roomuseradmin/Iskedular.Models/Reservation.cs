// In Iskedular.Core/Models/Reservation.cs
using System;
using System.Collections.Generic;

namespace Iskedular.Models // This namespace is consistent with Room.cs
{
    public enum ReservationStatus { Pending, Approved, Cancelled, Completed }

    public class Reservation
    {
        public int Id { get; set; }

        // Non-nullable string properties initialized in the constructor
        public string Purpose { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        // Foreign Keys (these are value types, so no nullability warning)
        public int UserId { get; set; }
        public int RoomId { get; set; }

        // Navigation properties: Links to the related User and Room objects
        public virtual User User { get; set; }
        public virtual Room Room { get; set; }

        // Constructor to initialize non-nullable reference type properties
        public Reservation()
        {
            Purpose = string.Empty; // Initialize string to empty
            // It's generally better to let EF Core handle the loading of navigation properties.
            // Initializing them to new instances here can lead to issues if you're not careful
            // about how you attach entities to the DbContext. For now, we'll keep them as is
            // as per your original code to avoid breaking changes, but be aware this might
            // be refactored later if you encounter unexpected behavior with navigation properties.
            User = new User();
            Room = new Room();
        }

        // Optional: You might want a constructor for creating reservations with initial data
        public Reservation(string purpose, DateTime startTime, DateTime endTime, int userId, int roomId)
        {
            Purpose = purpose;
            StartTime = startTime;
            EndTime = endTime;
            UserId = userId;
            RoomId = roomId;
            Status = ReservationStatus.Pending; // Default status
            User = new User(); // Initialize to prevent null reference, but ideally loaded by EF
            Room = new Room(); // Initialize to prevent null reference, but ideally loaded by EF
        }
    }
}