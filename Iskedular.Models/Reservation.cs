using System;
using System.Collections.Generic;

namespace Iskedular.Models // <-- This line should be 'Iskedular.Core.Models'
{
    public enum ReservationStatus { Pending, Approved, Cancelled, Completed }

    public class Reservation
    {
        public int Id { get; set; }

       
        public string Purpose { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        
        public int UserId { get; set; }
        public int RoomId { get; set; }

        
        public virtual User User { get; set; }
        public virtual Room Room { get; set; }

        public string Program { get; set; } = string.Empty;
        public string YearSection { get; set; } = string.Empty;
        public string Professor { get; set; } = string.Empty;


        public Reservation()
        {
            Purpose = string.Empty; // Initialize string to empty
            
        }

        
    }
}