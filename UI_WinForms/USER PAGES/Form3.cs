using Iskedular.Data;
using Iskedular.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form3 : Form
    {
        private readonly ApplicationDbContext _context;

        public Form3()
        {
            InitializeComponent();
            _context = RuntimeDbContextFactory.Create(); // ✅ fixed constructor usage

            LoadRooms();
            LoadTimeSlots();
        }

        private void LoadRooms()
        {
            var rooms = _context.Rooms.ToList();
            comboBox1.DataSource = rooms;
            comboBox1.DisplayMember = "Name"; // Make sure Room model has a Name property
            comboBox1.ValueMember = "Id";
        }

        private void LoadTimeSlots()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[]
            {
                "8:00am - 12:00pm",
                "1:00pm - 5:00pm",
                "5:00pm - 9:00pm"
            });
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is not int selectedRoomId)
            {
                MessageBox.Show("No room selected.");
                return;
            }

            var selectedRoom = _context.Rooms.FirstOrDefault(r => r.Id == selectedRoomId);
            var selectedTime = comboBox2.Text;
            var selectedDate = monthCalendar1.SelectionStart.Date;
            var purpose = textBox11.Text.Trim();
            var professor = textBox13.Text.Trim();
            int userId = 1; // Placeholder

            DateTime startTime, endTime;
            switch (selectedTime)
            {
                case "8:00am - 12:00pm":
                    startTime = selectedDate.AddHours(8);
                    endTime = selectedDate.AddHours(12);
                    break;
                case "1:00pm - 5:00pm":
                    startTime = selectedDate.AddHours(13);
                    endTime = selectedDate.AddHours(17);
                    break;
                case "5:00pm - 9:00pm":
                    startTime = selectedDate.AddHours(17);
                    endTime = selectedDate.AddHours(21);
                    break;
                default:
                    MessageBox.Show("Invalid time slot selected.");
                    return;
            }

            bool isAlreadyBooked = _context.Reservations.Any(r =>
                r.RoomId == selectedRoomId &&
                r.StartTime == startTime &&
                r.EndTime == endTime
            );

            if (isAlreadyBooked)
            {
                MessageBox.Show("This room is already booked for the selected time and date.");
                return;
            }

            var reservation = new Reservation
            {
                RoomId = selectedRoomId,
                UserId = userId,
                Purpose = purpose,
                StartTime = startTime,
                EndTime = endTime,
                Status = ReservationStatus.Pending
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            MessageBox.Show("Reservation booked successfully!");
        }

        // Placeholder buttons
        private void button5_Click(object sender, EventArgs e) => MessageBox.Show("Home clicked");
        private void button6_Click(object sender, EventArgs e) => MessageBox.Show("Reserve clicked");
        private void button7_Click(object sender, EventArgs e) => MessageBox.Show("Rooms clicked");
        private void button4_Click(object sender, EventArgs e) => Close(); // Exit or logout
    }
}
