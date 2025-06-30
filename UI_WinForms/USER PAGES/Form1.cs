using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Models;
using Iskedular.Core.Services;

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;
        private readonly SessionService _sessionService;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = _serviceProvider.GetRequiredService<ReservationService>();
            _sessionService = _serviceProvider.GetRequiredService<SessionService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.Resize += (s, e) => AdjustLayout();
            AdjustLayout();
            _ = LoadUserReservations();
        }

        private void AdjustLayout()
        {
            // Center the calendar
            monthCalendar1.Location = new Point(50, (this.ClientSize.Height - monthCalendar1.Height) / 2);

            // Center the flow panel horizontally
            flowLayoutPanelReservations.Location = new Point(
                (this.ClientSize.Width - flowLayoutPanelReservations.Width - monthCalendar1.Width - 100) / 2 + monthCalendar1.Width + 100,
                150
            );

            // Right-align navbar buttons
            int rightMargin = 20;
            int spacing = 10;
            int buttonWidth = 100;

            button4.Left = this.ClientSize.Width - rightMargin - button4.Width;
            button7.Left = button4.Left - spacing - button7.Width;
            button6.Left = button7.Left - spacing - button6.Width;
            button5.Left = button6.Left - spacing - button5.Width;
        }

        private async Task LoadUserReservations(DateTime? filterDate = null)
        {
            var user = _sessionService.LoggedInUser;
            if (user == null)
            {
                MessageBox.Show("Please log in to view your reservation details.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allReservations = await _reservationService.GetReservationsAsync();
            var userReservations = allReservations
                .Where(r => r.UserId == user.Id)
                .OrderByDescending(r => r.StartTime)
                .ToList();

            if (filterDate.HasValue)
            {
                userReservations = userReservations
                    .Where(r => r.StartTime.Date == filterDate.Value.Date)
                    .ToList();
            }

            flowLayoutPanelReservations.Controls.Clear();

            if (userReservations.Count == 0)
            {
                Label none = new Label
                {
                    Text = "No reservations found.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                };
                flowLayoutPanelReservations.Controls.Add(none);
                return;
            }

            int count = 1;
            foreach (var reservation in userReservations)
            {
                var card = new Panel
                {
                    Width = 700,
                    Height = 200,
                    BackColor = GetStatusColor(reservation.Status),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                var label = new Label
                {
                    Text =
                        $"Reservation #{count++}\n" +
                        $"Room: {reservation.Room?.Name}\n" +
                        $"Date: {reservation.StartTime:MMMM dd, yyyy}\n" +
                        $"Time: {reservation.StartTime:hh:mm tt} - {reservation.EndTime:hh:mm tt}\n" +
                        $"Purpose: {reservation.Purpose}\n" +
                        $"Program: {reservation.Program}\n" +
                        $"Year/Section: {reservation.YearSection}\n" +
                        $"Professor: {reservation.Professor}",
                    Font = new Font("Segoe UI", 10.5F, FontStyle.Regular),
                    AutoSize = false,
                    Width = 670,
                    Height = 160,
                    Location = new Point(10, 10)
                };

                var statusLabel = new Label
                {
                    Text = $"Status: {reservation.Status}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(10, 170)
                };

                card.Controls.Add(label);
                card.Controls.Add(statusLabel);
                flowLayoutPanelReservations.Controls.Add(card);
            }
        }

        private Color GetStatusColor(ReservationStatus status)
        {
            return status switch
            {
                ReservationStatus.Pending => Color.White,
                ReservationStatus.Approved => Color.LightGreen,
                ReservationStatus.Cancelled => Color.IndianRed,
                ReservationStatus.Completed => Color.LightBlue,
                _ => Color.LightGray
            };
        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            await LoadUserReservations(e.Start);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form3>();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form2>();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form4>();
            form.Show();
            this.Hide();
        }

        private void panelTopNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

