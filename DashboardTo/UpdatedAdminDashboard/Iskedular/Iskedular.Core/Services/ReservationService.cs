﻿// File: Iskedular.Core.Services/ReservationService.cs
using Iskedular.Data;
using Iskedular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iskedular.Core.Services
{
    public class ReservationService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public ReservationService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Reservation?> GetReservationByIdAsync(int reservationId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Reservations
                    .Include(r => r.Room)
                    .Include(r => r.User)
                    .FirstOrDefaultAsync(r => r.Id == reservationId);
            }
        }

        public async Task<List<Reservation>> GetReservationsAsync(
            int? userId = null,
            int? roomId = null,
            DateTime? date = null,
            ReservationStatus? status = null,
            bool includePast = true)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                IQueryable<Reservation> query = context.Reservations
                    .Include(r => r.Room)
                    .Include(r => r.User);

                if (userId.HasValue)
                    query = query.Where(r => r.UserId == userId.Value);

                if (roomId.HasValue)
                    query = query.Where(r => r.RoomId == roomId.Value);

                if (date.HasValue)
                {
                    DateTime dateStart = date.Value.Date;
                    DateTime dateEnd = date.Value.Date.AddDays(1).AddTicks(-1);

                    query = query.Where(r => r.StartTime < dateEnd && r.EndTime > dateStart);
                }

                if (status.HasValue)
                    query = query.Where(r => r.Status == status.Value);

                if (!includePast)
                {
                    query = query.Where(r => r.EndTime >= DateTime.UtcNow);
                }

                return await query.OrderBy(r => r.StartTime).ToListAsync();
            }
        }

        public async Task<Reservation> AddReservationAsync(Reservation newReservation)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Reservations.Add(newReservation);
                await context.SaveChangesAsync();
                return newReservation;
            }
        }

        public async Task<bool> UpdateReservationAsync(Reservation reservationToUpdate)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingReservation = await context.Reservations.FindAsync(reservationToUpdate.Id);
                if (existingReservation == null) return false;

                existingReservation.Purpose = reservationToUpdate.Purpose;
                existingReservation.StartTime = reservationToUpdate.StartTime;
                existingReservation.EndTime = reservationToUpdate.EndTime;
                existingReservation.Status = reservationToUpdate.Status;
                existingReservation.UserId = reservationToUpdate.UserId;
                existingReservation.RoomId = reservationToUpdate.RoomId;
                existingReservation.Program = reservationToUpdate.Program;
                existingReservation.YearSection = reservationToUpdate.YearSection;
                existingReservation.Professor = reservationToUpdate.Professor;
                existingReservation.ApprovedRejectedByAdmin = reservationToUpdate.ApprovedRejectedByAdmin;
                existingReservation.LastModified = reservationToUpdate.LastModified;

                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteReservationAsync(int reservationId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var reservationToDelete = await context.Reservations.FindAsync(reservationId);
                if (reservationToDelete == null) return false;

                context.Reservations.Remove(reservationToDelete);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Reservation>> GetApprovedReservationsAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Reservations
                    .Where(r => r.Status == ReservationStatus.Approved)
                    .Include(r => r.Room)
                    .Include(r => r.User)
                    .OrderBy(r => r.StartTime)
                    .ToListAsync();
            }
        }

        public async Task<bool> IsRoomOccupied(int roomId, DateTime startTime, DateTime endTime, int? excludeReservationId = null)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (startTime >= endTime)
                {
                    return true;
                }

                var query = context.Reservations
                    .Where(r => r.RoomId == roomId && r.Status == ReservationStatus.Approved)
                    .Where(r => startTime < r.EndTime && endTime > r.StartTime);

                if (excludeReservationId.HasValue)
                {
                    query = query.Where(r => r.Id != excludeReservationId.Value);
                }

                return await query.AnyAsync();
            }
        }
    }
}