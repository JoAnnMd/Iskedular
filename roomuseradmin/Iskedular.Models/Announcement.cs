// In Iskedular.Models/Announcement.cs (or Iskedular.Core.Models/Announcement.cs)
using System;

namespace Iskedular.Models // Ensure this namespace matches your other models (e.g., Iskedular.Core.Models)
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; } = DateTime.UtcNow; // Default to UTC now
        public DateTime? ExpiryDate { get; set; } // Nullable, announcement might not expire
        public bool IsActive { get; set; } = true; // Flag to easily show/hide announcements
    }
}