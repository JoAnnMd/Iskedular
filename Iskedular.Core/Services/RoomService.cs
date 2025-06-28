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
        // CHANGED: Inject IDbContextFactory instead of ApplicationDbContext directly
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        // The constructor injects the DbContext Factory.
        public RoomService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        // Retrieves a room by its ID.
        public async Task<Room?> GetRoomByIdAsync(int roomId)
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Rooms.FindAsync(roomId);
            }
        }

        // Retrieves all rooms from the database.
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Rooms.ToListAsync();
            }
        }

        // Adds a new room to the database.
        public async Task<Room> AddRoomAsync(Room newRoom)
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Rooms.Add(newRoom);
                await context.SaveChangesAsync();
                return newRoom;
            }
        }

        // Updates an existing room's details.
        public async Task<bool> UpdateRoomAsync(Room roomToUpdate)
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingRoom = await context.Rooms.FindAsync(roomToUpdate.Id);
                if (existingRoom == null)
                {
                    return false; // Room not found.
                }

                // The properties of the existing room were updated with the new values.
                existingRoom.Name = roomToUpdate.Name;
                existingRoom.Capacity = roomToUpdate.Capacity;
                existingRoom.HasProjector = roomToUpdate.HasProjector;
                existingRoom.HasWhiteboard = roomToUpdate.HasWhiteboard;

                await context.SaveChangesAsync();
                return true;
            }
        }

        // Deletes a room by its ID.
        public async Task<bool> DeleteRoomAsync(int roomId)
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var roomToDelete = await context.Rooms.FindAsync(roomId);
                if (roomToDelete == null)
                {
                    return false; // Room not found.
                }

                context.Rooms.Remove(roomToDelete);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
