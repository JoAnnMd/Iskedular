// In Iskedular.Core/Models/Room.cs (Adjust namespace if different, e.g., Iskedular.Core.Models)
using System.Collections.Generic;

namespace Iskedular.Core.Models
{
    public class Room
    {
        public int Id { get; set; }

        // Non-nullable string property initialized in the constructor
        public string Name { get; set; } // e.g., "Room 401" or "Computer Lab A"

        public int Capacity { get; set; }
        public bool HasProjector { get; set; }
        public bool HasWhiteboard { get; set; }
        // Add any other features as simple boolean flags

        // Navigation property: A room can have many reservations.
        // Collections should always be initialized to prevent NullReferenceExceptions
        public virtual ICollection<Reservation> Reservations { get; set; }

        // Constructor to initialize non-nullable reference type properties
        public Room()
        {
            Name = string.Empty; // Initialize string to empty
            Reservations = new List<Reservation>(); // Initialize the collection
        }
    }
}