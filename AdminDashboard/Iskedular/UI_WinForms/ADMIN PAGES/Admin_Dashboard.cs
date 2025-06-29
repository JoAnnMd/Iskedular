using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Threading.Tasks;
using Iskedular.Core.Services;
using Iskedular.Models;
using System.Linq;
using System.Text;

namespace UI_WinForms
{
    public partial class Admin_Dashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;
        private readonly RoomService _roomService;
        private readonly UserService _userService;

        public Admin_Dashboard(IServiceProvider serviceProvider, ReservationService reservationService, RoomService roomService, UserService userService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = reservationService;
            _roomService = roomService;
            _userService = userService;

            this.Load += new System.EventHandler(this.Form9_Load);
            this.Activated += Admin_Dashboard_Activated;
        }

        private async void Form9_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            // --- Dynamic Centering Logic ---
            int screenWidth = this.ClientSize.Width;
            int screenHeight = this.ClientSize.Height;

            pictureBox1.Size = new Size(screenWidth, 89);
            pictureBox1.Location = new Point(0, 0);

            pictureBox4.Location = new Point(20, (pictureBox1.Height - pictureBox4.Height) / 2);
            textBox4.Location = new Point(pictureBox4.Right + 10, (pictureBox1.Height - textBox4.Height) / 2);

            int buttonSpacing = 15;
            int currentRightPosition = screenWidth - 20;

            button4.Location = new Point(currentRightPosition - button4.Width, (pictureBox1.Height - button4.Height) / 2);
            currentRightPosition = button4.Left - buttonSpacing;
            button3.Location = new Point(currentRightPosition - button3.Width, (pictureBox1.Height - button3.Height) / 2);
            currentRightPosition = button3.Left - buttonSpacing;
            button5.Location = new Point(currentRightPosition - button5.Width, (pictureBox1.Height - button5.Height) / 2);
            currentRightPosition = button5.Left - buttonSpacing;
            button1.Location = new Point(currentRightPosition - button1.Width, (pictureBox1.Height - button1.Height) / 2);
            currentRightPosition = button1.Left - buttonSpacing;
            button2.Location = new Point(currentRightPosition - button2.Width, (pictureBox1.Height - button2.Height) / 2);

            textBox5.Location = new Point((screenWidth - textBox5.Width) / 2, pictureBox1.Bottom + 20);

            int infoBoxHeight = textBox1.Height;
            int infoBoxWidth = textBox1.Width;
            int infoBoxSpacing = 20;
            int totalInfoBoxesWidth = (infoBoxWidth * 4) + (infoBoxSpacing * 3);

            int startXInfoBoxes = (screenWidth - totalInfoBoxesWidth) / 2;
            int infoBoxY = textBox5.Bottom + 30;

            textBox1.Location = new Point(startXInfoBoxes, infoBoxY);
            textBox2.Location = new Point(textBox1.Right + infoBoxSpacing, infoBoxY);
            textBox3.Location = new Point(textBox2.Right + infoBoxSpacing, infoBoxY);
            textBox6.Location = new Point(textBox3.Right + infoBoxSpacing, infoBoxY);

            textBox9.Location = new Point(textBox1.Left + (textBox1.Width - textBox9.Width) / 2, textBox1.Top + 15);
            textBox10.Location = new Point(textBox1.Left + (textBox1.Width - textBox10.Width) / 2, textBox1.Top + 50);

            textBox11.Location = new Point(textBox2.Left + (textBox2.Width - textBox11.Width) / 2, textBox2.Top + 15);
            textBox12.Location = new Point(textBox2.Left + (textBox2.Width - textBox12.Width) / 2, textBox2.Top + 50);

            textBox15.Location = new Point(textBox3.Left + (textBox3.Width - textBox15.Width) / 2, textBox3.Top + 15);
            textBox13.Location = new Point(textBox3.Left + (textBox3.Width - textBox13.Width) / 2, textBox3.Top + 50);

            textBox16.Location = new Point(textBox6.Left + (textBox6.Width - textBox16.Width) / 2, textBox6.Top + 15);
            textBox14.Location = new Point(textBox6.Left + (textBox6.Width - textBox14.Width) / 2, textBox6.Top + 50);

            int activityBoxY = infoBoxY + infoBoxHeight + 50;
            int activityBoxCalculatedHeight = screenHeight - activityBoxY - 20;
            int finalActivityBoxHeight = (activityBoxCalculatedHeight > 130) ? activityBoxCalculatedHeight : 130;

            textBox7.Size = new Size(screenWidth - 100, finalActivityBoxHeight);
            textBox7.Location = new Point((screenWidth - textBox7.Width) / 2, activityBoxY);

            textBox17.Location = new Point(textBox7.Left + 17, textBox7.Top + 18);

            // Positioning for the new ListBox (listBoxActivityLog)
            listBoxActivityLog.Location = new Point(textBox7.Left + 17, textBox17.Bottom + 5);
            listBoxActivityLog.Size = new Size(textBox7.Width - 34, textBox7.Height - (textBox17.Bottom - textBox7.Top + 5 + 10));
            listBoxActivityLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Call the new method to load dynamic data on initial load
            await LoadDashboardData();
        }

        private async void Admin_Dashboard_Activated(object sender, EventArgs e)
        {
            await LoadDashboardData();
        }

        private async Task LoadDashboardData()
        {
            try
            {
                // Get counts for dashboard boxes
                int totalRooms = (await _roomService.GetAllRoomsAsync()).Count;
                textBox10.Text = totalRooms.ToString();

                int pendingRequests = (await _reservationService.GetReservationsAsync(status: ReservationStatus.Pending)).Count;
                textBox12.Text = pendingRequests.ToString();

                int todaysBookings = (await _reservationService.GetReservationsAsync(date: DateTime.Today, status: ReservationStatus.Approved)).Count;
                textBox13.Text = todaysBookings.ToString();

                int totalUsers = (await _userService.GetAllUsersAsync()).Count;
                textBox14.Text = totalUsers.ToString();

                // Update Activity Content using ListBox
                listBoxActivityLog.Items.Clear();

                var recentReservations = await _reservationService.GetReservationsAsync(includePast: false);
                recentReservations = recentReservations.OrderByDescending(r => r.StartTime).Take(5).ToList();

                if (recentReservations.Any())
                {
                    foreach (var res in recentReservations)
                    {
                        string roomName = (await _roomService.GetRoomByIdAsync(res.RoomId))?.Name ?? "Unknown Room";
                        string userName = (await _userService.GetUserByIdAsync(res.UserId))?.Username ?? "Unknown User";

                        string activityEntry = $"[{res.Status}] {roomName} booked by {userName} on {res.StartTime:MMM dd, hh:mm tt}";
                        listBoxActivityLog.Items.Add(activityEntry);
                    }
                }
                else
                {
                    listBoxActivityLog.Items.Add("No recent activity.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", "Dashboard Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers for navigation and other text boxes
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox1_Click(object sender, EventArgs e)
        {
            Available_Rooms availableRoomsForm = _serviceProvider.GetRequiredService<Available_Rooms>();
            availableRoomsForm.Show();
            this.Hide();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>();
            form11.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form13 = _serviceProvider.GetRequiredService<Rooms_Main>();
            form13.Show();
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
        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboardForm = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            dashboardForm.Show();
            this.Hide();
        }

        // Event handler for the "Total Users" textbox (textBox6)
        private void textBox6_Click(object sender, EventArgs e)
        {
            Form18 adminProfileForm = _serviceProvider.GetRequiredService<Form18>();
            adminProfileForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}