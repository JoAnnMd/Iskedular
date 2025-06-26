using Iskedular.Data; // For ApplicationDbContext
using Iskedular.Models; // For Room model
using Microsoft.EntityFrameworkCore; // For Entity Framework Core methods
using System.Collections.Generic; // For List<Room>
using System.Linq; // For LINQ queries
using System.Threading.Tasks; // For async operations

namespace Iskedular.Core.Services
{
    // This service handles all operations related to Room management.
    public class RoomService
    {
        private readonly ApplicationDbContext _context; // ApplicationDbContext was injected.

        // The constructor injects the DbContext.
        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieves a room by its ID.
        public async Task<Room?> GetRoomByIdAsync(int roomId)
        {
            return await _context.Rooms.FindAsync(roomId);
        }

        // Retrieves all rooms from the database.
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        // Adds a new room to the database.
        public async Task<Room> AddRoomAsync(Room newRoom)
        {
            _context.Rooms.Add(newRoom);
            await _context.SaveChangesAsync();
            return newRoom;
        }

        // Updates an existing room's details.
        public async Task<bool> UpdateRoomAsync(Room roomToUpdate)
        {
            var existingRoom = await _context.Rooms.FindAsync(roomToUpdate.Id);
            if (existingRoom == null)
            {
                return false; // Room not found.
            }

            // The properties of the existing room were updated with the new values.
            existingRoom.Name = roomToUpdate.Name;
            existingRoom.Capacity = roomToUpdate.Capacity;
            existingRoom.HasProjector = roomToUpdate.HasProjector;
            existingRoom.HasWhiteboard = roomToUpdate.HasWhiteboard;

            await _context.SaveChangesAsync();
            return true;
        }

        // Deletes a room by its ID.
        public async Task<bool> DeleteRoomAsync(int roomId)
        {
            var roomToDelete = await _context.Rooms.FindAsync(roomId);
            if (roomToDelete == null)
            {
                return false; // Room not found.
            }

            _context.Rooms.Remove(roomToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
