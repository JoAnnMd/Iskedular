using System.ComponentModel.DataAnnotations;

namespace Iskedular.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Room Name is required.")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Capacity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be at least 1.")]
        public int Capacity { get; set; }

        // Existing features
        public bool HasProjector { get; set; }

        public bool HasWhiteboard { get; set; }

        // NEW FEATURES ADDED BELOW:

        // Indicates if the room has a TV.
        public bool HasTV { get; set; }

        // Indicates if the room has Air Conditioning.
        public bool HasAirConditioning { get; set; }

        // Indicates if the room has a Sound System.
        public bool HasSoundSystem { get; set; }

        // Stores the number of computers in the room. Default to 0 if not applicable.
        public int NumberOfComputers { get; set; } = 0; // Default to 0, since not all rooms have computers.

        // Stores the floor on which the room is located.
        [Required(ErrorMessage = "Floor information is required.")]
        [MaxLength(50)]
        public string Floor { get; set; } = string.Empty; // e.g., "1st Floor", "2nd Floor"
    }
}
