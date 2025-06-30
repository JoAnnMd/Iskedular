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
    public partial class PendingRequest : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;

        public PendingRequest(IServiceProvider serviceProvider, ReservationService reservationService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = reservationService;
        }

        private async void PendingRequest_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;
            CenterContentPanel();
            await LoadPendingRequests();
        }

        private void PendingRequest_Resize(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        private void CenterContentPanel()
        {
            if (panelMainContentWrapper != null && panelContentToCenter != null)
            {
                int x = (panelMainContentWrapper.Width - panelContentToCenter.Width) / 2;
                int y = (panelMainContentWrapper.Height - panelContentToCenter.Height) / 2;
                panelContentToCenter.Location = new Point(x, y);
            }
        }

        private async Task LoadPendingRequests()
        {
            var pendingReservations = await _reservationService.GetReservationsAsync(status: ReservationStatus.Pending);
            pendingRequestsPanel.Controls.Clear();

            foreach (var reservation in pendingReservations)
            {
                var panel = new Panel
                {
                    Width = 700,
                    Height = 120,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var details = new Label
                {
                    Text = $"Room: {reservation.Room?.Name}\nDate: {reservation.StartTime:MMM dd, yyyy}\nTime: {reservation.StartTime:hh\\:mm tt} - {reservation.EndTime:hh\\:mm tt}\nPurpose: {reservation.Purpose}",
                    AutoSize = false,
                    Width = 450,
                    Height = 100,
                    Location = new Point(10, 10)
                };

                var approveBtn = new Button
                {
                    Text = "Approve",
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Width = 100,
                    Height = 35,
                    Location = new Point(470, 20)
                };
                approveBtn.Click += async (s, e) =>
                {
                    reservation.Status = ReservationStatus.Approved;
                    await _reservationService.UpdateReservationAsync(reservation);
                    await LoadPendingRequests();
                };

                var rejectBtn = new Button
                {
                    Text = "Reject",
                    BackColor = Color.DarkRed,
                    ForeColor = Color.White,
                    Width = 100,
                    Height = 35,
                    Location = new Point(470, 65)
                };
                rejectBtn.Click += async (s, e) =>
                {
                    reservation.Status = ReservationStatus.Cancelled;
                    await _reservationService.UpdateReservationAsync(reservation);
                    await LoadPendingRequests();
                };

                panel.Controls.Add(details);
                panel.Controls.Add(approveBtn);
                panel.Controls.Add(rejectBtn);
                pendingRequestsPanel.Controls.Add(panel);
            }
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }
    }
}
