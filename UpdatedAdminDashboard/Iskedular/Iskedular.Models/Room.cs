// File: Iskedular.Models/Room.cs
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

        public bool HasProjector { get; set; }
        public bool HasWhiteboard { get; set; }
        public bool HasTV { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasSoundSystem { get; set; }
        public int NumberOfComputers { get; set; } = 0;

        [Required(ErrorMessage = "Floor information is required.")]
        [MaxLength(50)]
        public string Floor { get; set; } = string.Empty;
    }
}