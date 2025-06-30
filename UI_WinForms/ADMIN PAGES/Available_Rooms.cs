using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using System.Collections.Generic;
using Iskedular.Models;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

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
        }

        private async void Available_Rooms_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            comboBox1.Items.AddRange(new string[] { "AM", "PM" });
            comboBox2.Items.AddRange(new string[] { "AM", "PM" });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            await LoadAvailableRooms();
        }

        private async Task LoadAvailableRooms()
        {
            if (flowLayoutPanelRooms == null) return;

            flowLayoutPanelRooms.Controls.Clear();
            List<Room> allRooms = await _roomService.GetAllRoomsAsync();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            bool validStart = DateTime.TryParse($"{textBox1.Text} {comboBox1.Text}", out DateTime parsedStart);
            bool validEnd = DateTime.TryParse($"{textBox2.Text} {comboBox2.Text}", out DateTime parsedEnd);
            if (!validStart || !validEnd) return;

            DateTime startDateTime = selectedDate.Add(parsedStart.TimeOfDay);
            DateTime endDateTime = selectedDate.Add(parsedEnd.TimeOfDay);
            if (startDateTime >= endDateTime) return;

            List<Reservation> approvedReservations = await _reservationService.GetReservationsAsync(null, selectedDate, ReservationStatus.Approved);

            foreach (Room room in allRooms)
            {
                bool isAvailable = !approvedReservations.Any(r => r.RoomId == room.Id && startDateTime < r.EndTime && endDateTime > r.StartTime);

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