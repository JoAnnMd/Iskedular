// In Iskedular.Core/Services/AnnouncementService.cs
using Iskedular.Data; // Assuming your DbContext is in Iskedular.Data
using Iskedular.Models; // Assuming your models are in Iskedular.Models
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iskedular.Core.Services
{
    // Interface for dependency injection and testability
    public interface IAnnouncementService
    {
        Task<List<Announcement>> GetActiveAnnouncementsAsync();
        // Add other announcement-related methods (e.g., CreateAnnouncement, UpdateAnnouncement, etc.)
    }

    public class AnnouncementService : IAnnouncementService
    {
        private readonly ApplicationDbContext _context;

        public AnnouncementService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a list of active announcements.
        /// Announcements are active if their IsActive flag is true
        /// and their ExpiryDate is either null or in the future (compared to UTC Now).
        /// </summary>
        /// <returns>A list of Announcement objects, ordered by PublishDate (descending).</returns>
        public async Task<List<Announcement>> GetActiveAnnouncementsAsync()
        {
            return await _context.Announcements
                                 .Where(a => a.IsActive && (a.ExpiryDate == null || a.ExpiryDate > DateTime.UtcNow))
                                 .OrderByDescending(a => a.PublishDate) // Most recent first
                                 .ToListAsync();
        }
    }
}
