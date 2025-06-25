// In Iskedular.Core/Models/Reservation.cs
using System;
using System.Collections.Generic;

namespace Iskedular.Models // <-- This line should be 'Iskedular.Core.Models'
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
        // These are typically initialized to new instances if they are always expected to exist
        // or marked as nullable if EF Core might load them as null sometimes (e.g., if lazy loading isn't configured)
        // For now, initializing in constructor is a good practice to resolve warnings.
        public virtual User User { get; set; }
        public virtual Room Room { get; set; }

        // Constructor to initialize non-nullable reference type properties
        public Reservation()
        {
            Purpose = string.Empty; // Initialize string to empty
            User = new User();      // Initialize User object
            Room = new Room();      // Initialize Room object
        }

        // You might also have a constructor for creating reservations with initial data
        // If so, ensure all non-nullable properties are passed or initialized there too.
        // public Reservation(string purpose, DateTime startTime, DateTime endTime, int userId, int roomId)
        // {
        //     Purpose = purpose;
        //     StartTime = startTime;
        //     EndTime = endTime;
        //     UserId = userId;
        //     RoomId = roomId;
        //     Status = ReservationStatus.Pending; // Default status
        //     User = new User(); // Or retrieve/set from existing user if using DI
        //     Room = new Room(); // Or retrieve/set from existing room if using DI
        // }
    }
}