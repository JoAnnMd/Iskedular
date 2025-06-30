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
            await LoadRejectedRequests();
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
            pendingReservations = pendingReservations.OrderBy(r => r.StartTime).ToList();
            pendingRequestsPanel.Controls.Clear();

            GroupAndDisplayReservations(pendingReservations, pendingRequestsPanel, isRejected: false);
        }

        private async Task LoadRejectedRequests()
        {
            var rejectedReservations = await _reservationService.GetReservationsAsync(status: ReservationStatus.Cancelled);
            rejectedReservations = rejectedReservations.OrderBy(r => r.StartTime).ToList();
            rejectedRequestsPanel.Controls.Clear();

            GroupAndDisplayReservations(rejectedReservations, rejectedRequestsPanel, isRejected: true);
        }

        private void GroupAndDisplayReservations(
            System.Collections.Generic.List<Reservation> reservations,
            FlowLayoutPanel panel,
            bool isRejected)
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var oneWeekFromNow = today.AddDays(7);

            var grouped = reservations.GroupBy(reservation =>
            {
                var date = reservation.StartTime.Date;
                if (date == today) return "Today";
                if (date == tomorrow) return "Tomorrow";
                if (date <= oneWeekFromNow) return "This Week";
                return "Future";
            });

            foreach (var group in grouped)
            {
                var header = new Label
                {
                    Text = group.Key,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = false,
                    Height = 30,
                    Width = panel.Width - 20,
                    Margin = new Padding(5, 15, 5, 5)
                };
                panel.Controls.Add(header);

                foreach (var reservation in group)
                {
                    var resPanel = new Panel
                    {
                        Width = 700,
                        Height = 120,
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    var details = new Label
                    {
                        Text = $"Room: {reservation.Room?.Name}" +
                               $"\nRequested by: {reservation.User?.FirstName} {reservation.User?.LastName}" +
                               $"\nProgram & Section: {reservation.User?.ProgramSection}" +
                               $"\nDate: {reservation.StartTime:MMM dd, yyyy}" +
                               $"\nTime: {reservation.StartTime:hh\\:mm tt} - {reservation.EndTime:hh\\:mm tt}" +
                               $"\nPurpose: {reservation.Purpose}",
                        AutoSize = false,
                        Width = 450,
                        Height = 100,
                        Location = new Point(10, 10)
                    };
                    resPanel.Controls.Add(details);

                    if (isRejected)
                    {
                        var restoreBtn = new Button
                        {
                            Text = "Restore",
                            BackColor = Color.Orange,
                            ForeColor = Color.White,
                            Width = 100,
                            Height = 35,
                            Location = new Point(470, 20)
                        };
                        restoreBtn.Click += async (s, e) =>
                        {
                            reservation.Status = ReservationStatus.Pending;
                            await _reservationService.UpdateReservationAsync(reservation);
                            await LoadRejectedRequests();
                            await LoadPendingRequests();
                        };

                        var deleteBtn = new Button
                        {
                            Text = "Delete",
                            BackColor = Color.DarkRed,
                            ForeColor = Color.White,
                            Width = 100,
                            Height = 35,
                            Location = new Point(470, 65)
                        };
                        deleteBtn.Click += async (s, e) =>
                        {
                            await _reservationService.DeleteReservationAsync(reservation.Id);
                            await LoadRejectedRequests();
                        };

                        resPanel.Controls.Add(restoreBtn);
                        resPanel.Controls.Add(deleteBtn);
                    }
                    else
                    {
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
                            await LoadRejectedRequests();
                        };

                        resPanel.Controls.Add(approveBtn);
                        resPanel.Controls.Add(rejectBtn);
                    }

                    panel.Controls.Add(resPanel);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<admin_bookings>();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Rooms_Main>();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form18>();
            form.Show();
            this.Hide();
        }

        private void pendingRequestsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}