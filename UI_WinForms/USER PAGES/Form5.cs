using Iskedular.Data;
using Iskedular.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form5 : Form
    {
        private readonly PendingReservation _pending;
        private readonly ApplicationDbContext _context;

        public Form5(PendingReservation pending)
        {
            InitializeComponent();
            _pending = pending;
            _context = RuntimeDbContextFactory.Create(); // Use same factory as Form3
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Display formatted booking info in the center box
            textBox10.Text =
                $"Room: {_pending.RoomName}\r\n" +
                $"Date: {_pending.StartTime:MMMM dd, yyyy}\r\n" +
                $"Time: {_pending.StartTime:hh:mm tt} - {_pending.EndTime:hh:mm tt}\r\n" +
                $"Purpose: {_pending.Purpose}";
        }

        private void button2_Click(object sender, EventArgs e) // ✅ Confirm Booking
        {
            // Check if the room is already booked for the same time slot
            bool isBooked = _context.Reservations.Any(r =>
                r.RoomId == _pending.RoomId &&
                r.StartTime == _pending.StartTime &&
                r.EndTime == _pending.EndTime);

            if (isBooked)
            {
                MessageBox.Show("The room is already booked for the selected time.");
                this.Close();
                return;
            }

            var reservation = new Reservation
            {
                RoomId = _pending.RoomId,
                Purpose = _pending.Purpose,
                UserId = _pending.UserId,
                StartTime = _pending.StartTime,
                EndTime = _pending.EndTime,
                Status = ReservationStatus.Pending
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            MessageBox.Show("Reservation confirmed successfully!");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) // ❎ Cancel
        {
            MessageBox.Show("Reservation was cancelled.");
            this.Close();
        }
    }
}
