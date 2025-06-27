// In Iskedular.Core/Services/RoomService.cs
using Iskedular.Data; // Assuming your DbContext is in Iskedular.Data
using Iskedular.Models; // Assuming your models are in Iskedular.Models
using Microsoft.EntityFrameworkCore; // Required for IQueryable, Where, ToListAsync
using System.Collections.Generic;
using System.Linq; // Required for .Where
using System.Threading.Tasks;

namespace Iskedular.Core.Services
{
    // Define an interface for the service for better testability and dependency injection
    public interface IRoomService
    {
        Task<List<Room>> GetAllRoomsAsync(bool? hasProjector = null, bool? hasWhiteboard = null, bool? isComputerLab = null, bool? hasTV = null, bool? hasAirConditioning = null);
        Task<Room?> GetRoomByIdAsync(int roomId); // Useful for single room details or reservation process
        // Add other room-related methods (e.g., AddRoom, UpdateRoom, DeleteRoom) if needed
    }

    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a list of all rooms with optional filtering based on room features.
        /// </summary>
        /// <param name="hasProjector">Filter by rooms with a projector (true/false/null for no filter).</param>
        /// <param name="hasWhiteboard">Filter by rooms with a whiteboard (true/false/null for no filter).</param>
        /// <param name="isComputerLab">Filter by computer lab status (true/false/null for no filter).</param>
        /// <param name="hasTV">Filter by rooms with a TV (true/false/null for no filter).</param>
        /// <param name="hasAirConditioning">Filter by rooms with air conditioning (true/false/null for no filter).</param>
        /// <returns>A list of Room objects matching the criteria.</returns>
        public async Task<List<Room>> GetAllRoomsAsync(bool? hasProjector = null, bool? hasWhiteboard = null, bool? isComputerLab = null, bool? hasTV = null, bool? hasAirConditioning = null)
        {
            IQueryable<Room> query = _context.Rooms;

            if (hasProjector.HasValue)
            {
                query = query.Where(r => r.HasProjector == hasProjector.Value);
            }
            if (hasWhiteboard.HasValue)
            {
                query = query.Where(r => r.HasWhiteboard == hasWhiteboard.Value);
            }
            if (isComputerLab.HasValue)
            {
                query = query.Where(r => r.IsComputerLab == isComputerLab.Value);
            }
            // ADDED: Filters for HasTV and HasAirConditioning
            if (hasTV.HasValue)
            {
                query = query.Where(r => r.HasTV == hasTV.Value);
            }
            if (hasAirConditioning.HasValue)
            {
                query = query.Where(r => r.HasAirConditioning == hasAirConditioning.Value);
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// Retrieves a single room by its ID.
        /// </summary>
        /// <param name="roomId">The ID of the room to retrieve.</param>
        /// <returns>The Room object if found, otherwise null.</returns>
        public async Task<Room?> GetRoomByIdAsync(int roomId)
        {
            return await _context.Rooms.FindAsync(roomId);
        }
    }
}