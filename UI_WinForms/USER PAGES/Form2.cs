using System;
using System.Collections.Generic;
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

        public Form2(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<RoomService>();
            _reservationService = _serviceProvider.GetRequiredService<ReservationService>();
            _sessionService = _serviceProvider.GetRequiredService<SessionService>();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            comboBoxStartAmPm.Items.AddRange(new[] { "AM", "PM" });
            comboBoxEndAmPm.Items.AddRange(new[] { "AM", "PM" });
            comboBoxStartAmPm.SelectedIndex = 0;
            comboBoxEndAmPm.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            await LoadAvailableRooms();
        }

        private async Task LoadAvailableRooms()
        {
            flowLayoutPanelRooms.Controls.Clear();
            List<Room> rooms = await _roomService.GetAllRoomsAsync();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            string startInput = textBoxStartTime.Text.Trim();
            string endInput = textBoxEndTime.Text.Trim();
            string startAmPm = comboBoxStartAmPm.Text;
            string endAmPm = comboBoxEndAmPm.Text;

            if (!TryParseTime(startInput, startAmPm, out DateTime parsedStart) ||
                !TryParseTime(endInput, endAmPm, out DateTime parsedEnd))
            {
                //MessageBox.Show("Invalid time format. Please enter valid start and end time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDateTime = selectedDate.Add(parsedStart.TimeOfDay);
            DateTime endDateTime = selectedDate.Add(parsedEnd.TimeOfDay);
            if (startDateTime >= endDateTime)
            {
                MessageBox.Show("Start time must be earlier than end time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Reservation> reservations = await _reservationService.GetReservationsAsync(null, selectedDate, ReservationStatus.Approved);

            foreach (Room room in rooms)
            {
                bool isAvailable = !reservations.Any(r => r.RoomId == room.Id && startDateTime < r.EndTime && endDateTime > r.StartTime);

                Panel panel = new Panel
                {
                    Size = new Size(220, 180),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = isAvailable ? Color.LightGreen : Color.LightCoral,
                    Margin = new Padding(10)
                };

                panel.Controls.Add(new Label
                {
                    Text = room.Name,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                });

                panel.Controls.Add(new Label
                {
                    Text = isAvailable ? "Status: Available" : "Status: Occupied",
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    Location = new Point(10, 35),
                    AutoSize = true,
                    ForeColor = isAvailable ? Color.DarkGreen : Color.DarkRed
                });

                panel.Controls.Add(new Label
                {
                    Text = $"Capacity: {room.Capacity}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 55),
                    AutoSize = true
                });

                panel.Controls.Add(new Label
                {
                    Text = $"Floor: {room.Floor}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 75),
                    AutoSize = true
                });

                string features = "";
                if (room.HasProjector) features += "Projector, ";
                if (room.HasWhiteboard) features += "Whiteboard, ";
                if (room.HasTV) features += "TV, ";
                if (room.HasAirConditioning) features += "A/C, ";
                if (room.HasSoundSystem) features += "Sound System, ";
                features = string.IsNullOrWhiteSpace(features) ? "None" : features.TrimEnd(',', ' ');

                panel.Controls.Add(new Label
                {
                    Text = $"Features: {features}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 95),
                    AutoSize = true,
                    MaximumSize = new Size(panel.Width - 20, 0)
                });

                if (room.NumberOfComputers > 0)
                {
                    panel.Controls.Add(new Label
                    {
                        Text = $"Computers: {room.NumberOfComputers}",
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(10, 145),
                        AutoSize = true
                    });
                }

                flowLayoutPanelRooms.Controls.Add(panel);
            }
        }

        private bool TryParseTime(string input, string amPm, out DateTime result)
        {
            input = input.Contains(":") ? input : $"{input}:00";
            return DateTime.TryParse($"{input} {amPm}", out result);
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) => await LoadAvailableRooms();
        private async void comboBoxStartAmPm_SelectedIndexChanged(object sender, EventArgs e) => await LoadAvailableRooms();
        private async void comboBoxEndAmPm_SelectedIndexChanged(object sender, EventArgs e) => await LoadAvailableRooms();
        private async void textBoxStartTime_TextChanged(object sender, EventArgs e) => await LoadAvailableRooms();
        private async void textBoxEndTime_TextChanged(object sender, EventArgs e) => await LoadAvailableRooms();

        private void button4_Click(object sender, EventArgs e)
        {
            var user = _sessionService.LoggedInUser;
            var form = new Form4(_serviceProvider, user);
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form3>();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms screen.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form1>();
            form.Show();
            this.Hide();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}