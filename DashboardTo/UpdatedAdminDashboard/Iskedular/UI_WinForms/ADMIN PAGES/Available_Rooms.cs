// File: UI_WinForms/Available_Rooms.cs
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using System.Collections.Generic;
using Iskedular.Models;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks; // Required for Task

namespace UI_WinForms
{
    public partial class Available_Rooms : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService;
        private readonly ReservationService _reservationService;

        public Available_Rooms(IServiceProvider serviceProvider, RoomService roomService, ReservationService reservationService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = roomService;
            _reservationService = reservationService;

            // Set MinDate for monthCalendar1 to today
            monthCalendar1.MinDate = DateTime.Today;
        }

        // Helper method to convert 12-hour time to 24-hour time
        private TimeSpan ConvertTo24HourTime(TimeSpan time12Hr, string ampm)
        {
            int hours = time12Hr.Hours;
            int minutes = time12Hr.Minutes;

            if (ampm.ToUpper() == "PM" && hours < 12)
            {
                hours += 12;
            }
            else if (ampm.ToUpper() == "AM" && hours == 12) // Midnight (12 AM)
            {
                hours = 0;
            }
            // For 12 PM, hours remains 12
            // For 1 AM to 11 AM, hours remains as is

            return new TimeSpan(hours, minutes, 0);
        }

        private async void Available_Rooms_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            // Initialize AM/PM combo boxes
            comboBox1.Items.Clear(); // Clear existing items first
            comboBox1.Items.AddRange(new string[] { "AM", "PM" });
            comboBox1.SelectedIndex = 0; // Default to AM

            comboBox2.Items.Clear(); // Clear existing items first
            comboBox2.Items.AddRange(new string[] { "AM", "PM" });
            comboBox2.SelectedIndex = 0; // Default to AM

            // Load rooms initially
            await LoadAvailableRooms();
        }

        private async Task LoadAvailableRooms()
        {
            if (flowLayoutPanelRooms == null) return; // Guard against null flowLayoutPanel

            flowLayoutPanelRooms.Controls.Clear();
            List<Room> allRooms = await _roomService.GetAllRoomsAsync();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            // --- Input Validation for Times ---
            TimeSpan startTimeSpan;
            TimeSpan endTimeSpan;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || !TimeSpan.TryParse(textBox1.Text, out startTimeSpan))
            {
                MessageBox.Show("Please enter a valid start time (HH:MM).", "Invalid Time Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select AM or PM for the start time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string startAmPm = comboBox1.SelectedItem.ToString()!;

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !TimeSpan.TryParse(textBox2.Text, out endTimeSpan))
            {
                MessageBox.Show("Please enter a valid end time (HH:MM).", "Invalid Time Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select AM or PM for the end time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string endAmPm = comboBox2.SelectedItem.ToString()!;

            // Convert to 24-hour format and combine with selected date
            DateTime startDateTime = selectedDate.Add(ConvertTo24HourTime(startTimeSpan, startAmPm));
            DateTime endDateTime = selectedDate.Add(ConvertTo24HourTime(endTimeSpan, endAmPm));

            // Validate time range
            if (startDateTime >= endDateTime)
            {
                MessageBox.Show("End time must be after start time.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // --- End Input Validation for Times ---

            // FIX: Corrected the parameters for GetReservationsAsync
            // Original: await _reservationService.GetReservationsAsync(null, selectedDate, ReservationStatus.Approved);
            // Corrected: Using named arguments to specify 'date' and 'status', letting userId and roomId default to null
            List<Reservation> approvedReservations = await _reservationService.GetReservationsAsync(
                date: selectedDate, // Filter by the selected date
                status: ReservationStatus.Approved // Filter for approved reservations
            );

            foreach (Room room in allRooms)
            {
                // Check for overlapping reservations for the current room
                bool isAvailable = !approvedReservations.Any(r =>
                    r.RoomId == room.Id &&
                    startDateTime < r.EndTime && // New reservation starts before existing one ends
                    endDateTime > r.StartTime);  // New reservation ends after existing one starts

                Panel roomPanel = new Panel();
                roomPanel.Size = new Size(220, 180);
                roomPanel.BorderStyle = BorderStyle.FixedSingle;
                roomPanel.Margin = new Padding(10);
                roomPanel.Tag = room;
                roomPanel.BackColor = isAvailable ? Color.LightGreen : Color.LightCoral;

                Label nameLabel = new Label();
                nameLabel.Text = room.Name;
                nameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nameLabel.Location = new Point(10, 10);
                nameLabel.AutoSize = true;

                Label statusLabel = new Label();
                statusLabel.Text = isAvailable ? "Status: Available" : "Status: Occupied";
                statusLabel.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                statusLabel.Location = new Point(10, 35);
                statusLabel.AutoSize = true;
                statusLabel.ForeColor = isAvailable ? Color.DarkGreen : Color.DarkRed;

                Label capacityLabel = new Label();
                capacityLabel.Text = $"Capacity: {room.Capacity}";
                capacityLabel.Font = new Font("Segoe UI", 9);
                capacityLabel.Location = new Point(10, 55);
                capacityLabel.AutoSize = true;

                Label floorLabel = new Label();
                floorLabel.Text = $"Floor: {room.Floor}";
                floorLabel.Font = new Font("Segoe UI", 9);
                floorLabel.Location = new Point(10, 75);
                floorLabel.AutoSize = true;

                string featuresText = "";
                if (room.HasProjector) featuresText += "Projector, ";
                if (room.HasWhiteboard) featuresText += "Whiteboard, ";
                if (room.HasTV) featuresText += "TV, ";
                if (room.HasAirConditioning) featuresText += "A/C, ";
                if (room.HasSoundSystem) featuresText += "Sound System, ";
                featuresText = featuresText.TrimEnd(',', ' ');
                if (string.IsNullOrEmpty(featuresText)) featuresText = "None";

                Label featuresLabel = new Label();
                featuresLabel.Text = $"Features: {featuresText}";
                featuresLabel.Font = new Font("Segoe UI", 9);
                featuresLabel.Location = new Point(10, 95);
                featuresLabel.AutoSize = true;
                featuresLabel.MaximumSize = new Size(roomPanel.Width - 20, 0);

                if (room.NumberOfComputers > 0)
                {
                    Label computersLabel = new Label();
                    computersLabel.Text = $"Computers: {room.NumberOfComputers}";
                    computersLabel.Font = new Font("Segoe UI", 9);
                    computersLabel.Location = new Point(10, 145);
                    computersLabel.AutoSize = true;
                    roomPanel.Controls.Add(computersLabel);
                }

                roomPanel.Controls.Add(nameLabel);
                roomPanel.Controls.Add(statusLabel);
                roomPanel.Controls.Add(capacityLabel);
                roomPanel.Controls.Add(floorLabel);
                roomPanel.Controls.Add(featuresLabel);
                flowLayoutPanelRooms.Controls.Add(roomPanel);
            }
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            await LoadAvailableRooms();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            await LoadAvailableRooms();
        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {
            await LoadAvailableRooms();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAvailableRooms();
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAvailableRooms();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Total_Rooms form10 = _serviceProvider.GetRequiredService<Total_Rooms>();
            form10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form13 = _serviceProvider.GetRequiredService<Rooms_Main>();
            form13.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>();
            form11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox15_TextChanged(object sender, EventArgs e) { }
    }
}