// File: Iskedular.Core.Services/RoomService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iskedular.Models;
using Iskedular.Data;
using Microsoft.EntityFrameworkCore;

namespace Iskedular.Core.Services
{
    public class RoomService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public RoomService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Room?> GetRoomByIdAsync(int roomId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Rooms.FindAsync(roomId);
            }
        }

        public async Task<List<Room>> GetAllRoomsAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Rooms.ToListAsync();
            }
        }

        public async Task<Room> AddRoomAsync(Room newRoom)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Rooms.Add(newRoom);
                await context.SaveChangesAsync();
                return newRoom;
            }
        }

        public async Task<bool> UpdateRoomAsync(Room roomToUpdate)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingRoom = await context.Rooms.FindAsync(roomToUpdate.Id);
                if (existingRoom == null) return false;

                existingRoom.Name = roomToUpdate.Name;
                existingRoom.Capacity = roomToUpdate.Capacity;
                existingRoom.Floor = roomToUpdate.Floor;
                existingRoom.HasProjector = roomToUpdate.HasProjector;
                existingRoom.HasWhiteboard = roomToUpdate.HasWhiteboard;
                existingRoom.HasTV = roomToUpdate.HasTV;
                existingRoom.HasAirConditioning = roomToUpdate.HasAirConditioning;
                existingRoom.HasSoundSystem = roomToUpdate.HasSoundSystem;
                existingRoom.NumberOfComputers = roomToUpdate.NumberOfComputers;

                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteRoomAsync(int roomId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var roomToDelete = await context.Rooms.FindAsync(roomId);
                if (roomToDelete == null) return false;

                // IMPORTANT: Consider how to handle reservations related to this room.
                // Current DbContext configuration uses DeleteBehavior.Restrict for Room->Reservation,
                // meaning you cannot delete a room if it has existing reservations.
                var hasReservations = await context.Reservations.AnyAsync(r => r.RoomId == roomId);
                if (hasReservations)
                {
                    // You might want to throw an exception or return false with a specific message
                    // indicating that the room cannot be deleted due to existing reservations.
                    // For now, it simply returns false, preventing deletion.
                    return false;
                }

                context.Rooms.Remove(roomToDelete);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}