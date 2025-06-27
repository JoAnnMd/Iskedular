// In Iskedular.Core/Services/ReservationService.cs
using Iskedular.Data; // Assuming your DbContext is in Iskedular.Data
using Iskedular.Models; // Assuming your models are in Iskedular.Models
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq; // Required for .Where, .OrderBy, etc.
using System.Threading.Tasks;

namespace Iskedular.Core.Services
{
    // Interface for dependency injection and testability
    public interface IReservationService
    {
        Task<List<Reservation>> GetUserUpcomingBookingsAsync(int userId);
        Task<Reservation?> GetReservationByIdAsync(int reservationId);
        Task<Reservation> CreateReservationAsync(Reservation newReservation);
        Task<bool> ApproveReservationAsync(int reservationId);
        Task<bool> CancelReservationAsync(int reservationId);
        // Add other reservation-related methods as needed
    }

    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext _context;

        public ReservationService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a list of upcoming bookings for a specific user.
        /// Bookings are considered upcoming if their EndTime is in the future.
        /// </summary>
        /// <param name="userId">The ID of the user whose bookings to retrieve.</param>
        /// <returns>A list of Reservation objects, including Room details, ordered by StartTime.</returns>
        public async Task<List<Reservation>> GetUserUpcomingBookingsAsync(int userId)
        {
            return await _context.Reservations
                                 .Where(r => r.UserId == userId && r.EndTime > DateTime.Now)
                                 .Include(r => r.Room) // Eager load Room details for display
                                 .OrderBy(r => r.StartTime)
                                 .ToListAsync();
        }

        /// <summary>
        /// Retrieves a single reservation by its ID.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation.</param>
        /// <returns>The Reservation object if found, otherwise null.</returns>
        public async Task<Reservation?> GetReservationByIdAsync(int reservationId)
        {
            return await _context.Reservations
                                 .Include(r => r.Room)
                                 .Include(r => r.User)
                                 .FirstOrDefaultAsync(r => r.Id == reservationId);
        }

        /// <summary>
        /// Creates a new reservation in the database.
        /// </summary>
        /// <param name="newReservation">The Reservation object to add.</param>
        /// <returns>The created Reservation object.</returns>
        public async Task<Reservation> CreateReservationAsync(Reservation newReservation)
        {
            _context.Reservations.Add(newReservation);
            await _context.SaveChangesAsync();
            return newReservation;
        }

        /// <summary>
        /// Approves a reservation by setting its status to Approved.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation to approve.</param>
        /// <returns>True if the reservation was approved, false otherwise (e.g., not found or already approved).</returns>
        public async Task<bool> ApproveReservationAsync(int reservationId)
        {
            var reservation = await _context.Reservations.FindAsync(reservationId);
            if (reservation == null) return false;

            if (reservation.Status == ReservationStatus.Pending)
            {
                reservation.Status = ReservationStatus.Approved;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cancels a reservation by setting its status to Cancelled.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation to cancel.</param>
        /// <returns>True if the reservation was canceled, false otherwise.</returns>
        public async Task<bool> CancelReservationAsync(int reservationId)
        {
            var reservation = await _context.Reservations.FindAsync(reservationId);
            if (reservation == null) return false;

            if (reservation.Status == ReservationStatus.Pending || reservation.Status == ReservationStatus.Approved)
            {
                reservation.Status = ReservationStatus.Cancelled;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
