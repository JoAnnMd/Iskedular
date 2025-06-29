using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iskedular.Models;
using Iskedular.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace UI_WinForms
{
    public partial class Form2 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService;
        private readonly ReservationService _reservationService;
        private readonly SessionService _sessionService;
        private List<Room> _rooms;

        private Dictionary<string, Panel> _roomPanels;

        public Form2(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<RoomService>();
            _reservationService = _serviceProvider.GetRequiredService<ReservationService>();
            _sessionService = _serviceProvider.GetRequiredService<SessionService>();
            this.Load += Form2_Load;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            MapRoomControls();
            await LoadRooms();
            LoadTimeSlots();
            await UpdateRoomPanels();
        }

        private void MapRoomControls()
        {
            _roomPanels = new Dictionary<string, Panel>
            {
                { "A 101", P1 }, { "A 102", P2 }, { "A 103", P3 }, { "A 104", P4 },
                { "A 105", P5 }, { "A 106", P6 }, { "A 201", P7 }, { "A 202", P8 },
                { "A 203", P9 }, { "A 204", P10 }, { "A 205", P11 }, { "A 206", P12 },
                { "Roth Room #1", PRoth1 }, { "Roth Room #2", PRoth2 },
                { "AVR", PAVR }, { "COMLAB", PCOMLAB }
            };

            foreach (var kvp in _roomPanels)
            {
                if (kvp.Value == null)
                    System.Diagnostics.Debug.WriteLine($"Panel for {kvp.Key} is null!");
            }
        }

        private async Task LoadRooms()
        {
            _rooms = await _roomService.GetAllRoomsAsync();
            foreach (var room in _rooms)
                System.Diagnostics.Debug.WriteLine($"Loaded room: {room.Name}");
        }

        private void LoadTimeSlots()
        {
            comboBoxTime.Items.Clear();
            for (int hour = 8; hour <= 20; hour++)
            {
                var time = new DateTime(2000, 1, 1, hour, 0, 0);
                comboBoxTime.Items.Add(time.ToString("hh:mm tt"));
            }
            comboBoxTime.SelectedIndex = 0;
        }

        private async void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateRoomPanels();
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            await UpdateRoomPanels();
        }

        private async Task UpdateRoomPanels()
        {
            if (_rooms == null || _rooms.Count == 0)
            {
                System.Diagnostics.Debug.WriteLine("No rooms loaded.");
                return;
            }

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            var selectedTime = comboBoxTime.SelectedItem?.ToString();
            if (!DateTime.TryParse(selectedTime, out var parsedTime))
            {
                System.Diagnostics.Debug.WriteLine("Selected time is invalid.");
                return;
            }
            DateTime selectedDateTime = selectedDate.AddHours(parsedTime.Hour).AddMinutes(parsedTime.Minute);

            var reservations = await _reservationService.GetReservationsAsync();
            var filteredReservations = reservations
                .Where(r => r.StartTime.Date == selectedDate)
                .ToList();

            foreach (var roomName in _roomPanels.Keys)
            {
                var panel = _roomPanels[roomName];

                var room = _rooms.FirstOrDefault(r =>
                    r.Name.Replace(" ", "").Equals(roomName.Replace(" ", ""), StringComparison.OrdinalIgnoreCase));
                if (room != null)
                {
                    bool isBooked = filteredReservations.Any(r =>
                        r.RoomId == room.Id &&
                        selectedDateTime >= r.StartTime && selectedDateTime < r.EndTime);

                    System.Diagnostics.Debug.WriteLine($"Panel: {panel.Name}, Room: {room.Name}, Booked: {isBooked}");

                    panel.BackColor = isBooked ? Color.Maroon : Color.LawnGreen;
                }
                else
                {
                    panel.BackColor = Color.LightGray;
                    System.Diagnostics.Debug.WriteLine($"Room {roomName} not found in loaded rooms.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(_serviceProvider);
            homeForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = new Form3(_serviceProvider, _roomService, _reservationService, _sessionService);
            reserveForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = _serviceProvider.GetRequiredService<Form4>();
            profileForm.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label23_Click(object sender, EventArgs e) { }
        private void label21_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
