using System;
using System.Collections.Generic;
using System.ComponentModel; // Already present
using System.Data; // Already present
using System.Drawing; // Already present
using System.Linq; // For .Any() - Added if not present
using System.Text; // Already present
using System.Threading.Tasks; // For async/await - Added if not present
using System.Windows.Forms; // Already present

// NEW: Add these using statements for your services and models
using Iskedular.Core.Services;
using Iskedular.Models;
using Microsoft.Extensions.DependencyInjection; // For IServiceProvider.GetRequiredService

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        // NEW: Private fields to hold the injected services
        private readonly IUserService _userService;
        private readonly IReservationService _reservationService;
        private readonly IAnnouncementService _announcementService;
        private readonly IServiceProvider _serviceProvider; // NEW: To get other forms via DI

        // MODIFIED: Constructor now accepts injected services and IServiceProvider
        public Form1(IUserService userService, IReservationService reservationService, IAnnouncementService announcementService, IServiceProvider serviceProvider)
        {
            InitializeComponent(); // Initializes all controls on your form

            // Assign injected service instances to the private fields
            _userService = userService;
            _reservationService = reservationService;
            _announcementService = announcementService;
            _serviceProvider = serviceProvider; // Assign the service provider

            // The Form_Load event handler is already subscribed in InitializeComponent()
            // (Looking at your designer code: Load += Form1_Load;)
            // So no need to re-subscribe here.
        }

        // Existing method:
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Your existing logic for pictureBox1_Click
        }

        // MODIFIED: Form_Load to call the async data loading method
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDashboardData();
        }

        /// <summary>
        /// Asynchronously loads all data required for the user dashboard.
        /// Populates lblWelcomeMessage, txtUpcomingBookings, and txtAnnouncements.
        /// </summary>
        private async Task LoadDashboardData()
        {
            // IMPORTANT: In a real application, you would get the current user's ID
            // from your SessionService or an authenticated user context.
            // For this example, we use the ID of the seeded admin user (ID = 1).
            int currentUserId = 1;

            try
            {
                // 1. Fetch User Data and Update Welcome Message
                User? user = await _userService.GetUserByIdAsync(currentUserId);
                if (user != null)
                {
                    lblWelcomeMessage.Text = $"Welcome, {user.FirstName} {user.LastName}!";
                }
                else
                {
                    lblWelcomeMessage.Text = "Welcome to Iskedular!"; // Fallback message
                }

                // 2. Fetch and Display Upcoming Bookings in txtUpcomingBookings
                List<Reservation> upcomingBookings = await _reservationService.GetUserUpcomingBookingsAsync(currentUserId);

                txtUpcomingBookings.Text = ""; // Clear existing text
                if (upcomingBookings.Any())
                {
                    foreach (var reservation in upcomingBookings)
                    {
                        // Append formatted booking info with new lines
                        // Using null-conditional operator (?. ) for Room.Name in case Room is null
                        txtUpcomingBookings.Text +=
                            $"{reservation.Purpose} - Room: {reservation.Room?.Name ?? "N/A"} " +
                            $"({reservation.StartTime:MMM dd,yyyy hh:mm tt} - {reservation.EndTime:hh:mm tt}) - Status: {reservation.Status}{Environment.NewLine}{Environment.NewLine}";
                    }
                }
                else
                {
                    txtUpcomingBookings.Text = "You have no upcoming bookings.";
                }

                // 3. Fetch and Display Active Announcements in txtAnnouncements
                List<Announcement> activeAnnouncements = await _announcementService.GetActiveAnnouncementsAsync();

                txtAnnouncements.Text = ""; // Clear existing text
                if (activeAnnouncements.Any())
                {
                    foreach (var announcement in activeAnnouncements)
                    {
                        // Append formatted announcement info with new lines
                        txtAnnouncements.Text +=
                            $"{announcement.Title} (Published: {announcement.PublishDate:MMM dd,yyyy}){Environment.NewLine}";
                        txtAnnouncements.Text +=
                            $"  {announcement.Content}{Environment.NewLine}{Environment.NewLine}"; // Double newline for spacing
                    }
                }
                else
                {
                    txtAnnouncements.Text = "No active announcements at the moment.";
                }
            }
            catch (Exception ex)
            {
                // Display an error message to the user and log the full exception
                MessageBox.Show($"An error occurred while loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the full exception (ex.ToString()) to a file or logging service in a real app
            }
        }

        // Existing method:
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Your existing logic for monthCalendar1_DateChanged
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox2_TextChanged
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox4_TextChanged
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox5_TextChanged
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox7_TextChanged
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox8_TextChanged
        }

        // Existing method (appears unused based on designer code provided previously, from previous textBox7)
        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            // Your existing logic for textBox7_TextChanged_1
        }

        // Existing method (appears unused based on designer code provided previously)
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox11_TextChanged
        }

        // Existing method: This was previously hooked to txtUpcomingBookings.
        // It's kept for now, but its content is likely empty or can be removed if not needed.
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox6_TextChanged
        }

        // Existing method:
        private void label2_Click(object sender, EventArgs e)
        {
            // Your existing logic for label2_Click
        }

        // Existing method:
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Your existing logic for pictureBox4_Click
        }

        // Existing method:
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox13_TextChanged
        }

        // MODIFIED: Button7_Click to use DI for navigation (Rooms button)
        private void button7_Click(object sender, EventArgs e)
        {
            // Get Form2 instance via DI, ensuring its dependencies are resolved
            var roomsForm = _serviceProvider.GetRequiredService<Form2>();
            roomsForm.Show();
            this.Hide(); // Hide Form1
        }

        // Existing method: button5_Click (Home button)
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Optionally, you could refresh the dashboard data if you press 'Home' while already on it:
            // await LoadDashboardData();
        }

        // MODIFIED: Button6_Click to use DI for navigation (Reserve button)
        private void button6_Click(object sender, EventArgs e)
        {
            // Get Form3 instance via DI
            var reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide(); // Hide Form1
        }

        // MODIFIED: Button4_Click to use DI for navigation (Profile/Account Settings button)
        private void button4_Click(object sender, EventArgs e)
        {
            // Get Form4 instance via DI
            var profileForm = _serviceProvider.GetRequiredService<Form4>();
            profileForm.Show();
            this.Hide(); // Hide Form1
        }

        // Existing method: This was previously hooked to txtAnnouncements.
        // It's kept for now, but its content is likely empty or can be removed if not needed.
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic for textBox10_TextChanged
        }
    }
}