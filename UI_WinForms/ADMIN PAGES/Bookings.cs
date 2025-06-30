using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using Iskedular.Models;

namespace UI_WinForms
{
    public partial class admin_bookings : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;

        public admin_bookings(IServiceProvider serviceProvider, ReservationService reservationService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = reservationService;
            this.Load += admin_bookings_Load;
        }

        private async void admin_bookings_Load(object sender, EventArgs e)
        {
            var approvedBookings = await _reservationService.GetApprovedReservationsAsync();
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var next7Days = today.AddDays(7);
            var next14Days = today.AddDays(14);

            foreach (var reservation in approvedBookings.OrderBy(r => r.StartTime))
            {
                var card = CreateBookingCard(reservation);

                if (reservation.StartTime.Date == today)
                    flowLayoutPanel1.Controls.Add(card);
                else if (reservation.StartTime.Date == tomorrow)
                    flowLayoutPanel2.Controls.Add(card);
                else if (reservation.StartTime.Date > tomorrow)
                {
                    if (reservation.StartTime.Date <= next7Days)
                        AddWithGroupHeader(flowLayoutPanel3, "This Week", card);
                    else if (reservation.StartTime.Date <= next14Days)
                        AddWithGroupHeader(flowLayoutPanel3, "Next Week", card);
                    else
                        AddWithGroupHeader(flowLayoutPanel3, "Future", card);
                }
            }
        }

        private void AddWithGroupHeader(FlowLayoutPanel panel, string groupLabel, Panel card)
        {
            Control? lastHeader = panel.Controls.OfType<Label>().LastOrDefault(lbl => lbl.Text == groupLabel);
            if (lastHeader == null)
            {
                var header = new Label
                {
                    Text = groupLabel,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    AutoSize = true,
                    Padding = new Padding(5),
                    Margin = new Padding(10, 20, 0, 5),
                    ForeColor = Color.Black
                };
                panel.Controls.Add(header);
            }

            panel.Controls.Add(card);
        }

        private Panel CreateBookingCard(Reservation reservation)
        {
            var card = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(300, 190),
                Margin = new Padding(10),
                BackColor = reservation.StartTime.Date == DateTime.Today
                    ? Color.White
                    : reservation.StartTime.Date == DateTime.Today.AddDays(1)
                        ? Color.Beige
                        : Color.Honeydew
            };

            var roomLabel = new Label
            {
                Text = $"Room: {reservation.Room?.Name}",
                AutoSize = false,
                Width = card.Width - 20,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10)
            };

            var timeLabel = new Label
            {
                Text = $"Time: {reservation.StartTime:hh:mm tt} - {reservation.EndTime:hh:mm tt}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 35)
            };

            var programLabel = new Label
            {
                Text = $"Program: {reservation.Program}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 60)
            };

            var yearLabel = new Label
            {
                Text = $"Year: {reservation.YearSection}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 80)
            };

            var profLabel = new Label
            {
                Text = $"Prof: {reservation.Professor}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 100)
            };

            var purposeLabel = new Label
            {
                Text = $"Purpose: {reservation.Purpose}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 120)
            };

            var requestedByLabel = new Label
            {
                Text = $"Requested by: {reservation.User?.FirstName} {reservation.User?.LastName}",
                AutoSize = false,
                Width = card.Width - 20,
                Location = new Point(10, 140)
            };

            card.Controls.Add(roomLabel);
            card.Controls.Add(timeLabel);
            card.Controls.Add(programLabel);
            card.Controls.Add(yearLabel);
            card.Controls.Add(profLabel);
            card.Controls.Add(purposeLabel);
            card.Controls.Add(requestedByLabel);

            // Show the reservation date only if it's in the Upcoming tab
            if (reservation.StartTime.Date > DateTime.Today)
            {
                var reservationDateLabel = new Label
                {
                    Text = $"Reservation Date: {reservation.StartTime:MMMM dd, yyyy}",
                    AutoSize = false,
                    Width = card.Width - 20,
                    Location = new Point(10, 160),
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                    ForeColor = Color.DimGray
                };
                card.Controls.Add(reservationDateLabel);
            }

            return card;
        }





        private void button6_Click(object sender, EventArgs e)
        {
            var form15 = _serviceProvider.GetRequiredService<Bookings_Total>();
            form15.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<admin_bookings>();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form = _serviceProvider.GetRequiredService<Rooms_Main>();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form11 = _serviceProvider.GetRequiredService<PendingRequest>();
            form11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
