// File: Iskedular.Models/Reservation.cs
using System;
using System.Collections.Generic;

namespace Iskedular.Models
{
    public enum ReservationStatus { Pending, Approved, Cancelled, Completed }

    public class Reservation
    {
        public int Id { get; set; }

        public string Purpose { get; set; } = string.Empty;

        public DateTime? StartTime { get; set; } // CHANGED TO NULLABLE
        public DateTime? EndTime { get; set; }   // CHANGED TO NULLABLE
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public int UserId { get; set; }
        public int RoomId { get; set; }

        public virtual User? User { get; set; }
        public virtual Room? Room { get; set; }

        public string Program { get; set; } = string.Empty;
        public string YearSection { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;

        public string? ApprovedRejectedByAdmin { get; set; }
        public DateTime? LastModified { get; set; }

        public Reservation() { }
    }
}