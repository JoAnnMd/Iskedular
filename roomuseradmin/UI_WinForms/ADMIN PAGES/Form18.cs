using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used
using Iskedular.Models; // User model was used
using Iskedular.Core.Services; // UserService and SessionService were used

namespace UI_WinForms // Form18's namespace was confirmed as UI_WinForms
{
    public partial class Form18 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionService _sessionService; // The SessionService was injected.
        // private User? _loggedInAdmin; // Removed: User will be accessed via SessionService
        private bool _forcePasswordChange = false; // A flag was added to indicate if a password change is mandatory.

        // The constructor was updated for Dependency Injection.
        // It now receives IServiceProvider and SessionService from the DI container.
        public Form18(IServiceProvider serviceProvider, SessionService sessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _sessionService = sessionService; // SessionService was assigned.

            // Fullscreen setup for Form18 was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        // The SetLoggedInAdmin method was removed as the logged-in user is now managed by SessionService.
        // public void SetLoggedInAdmin(User adminUser)
        // {
        //     _loggedInAdmin = adminUser;
        // }

        // A method was added to force a password change, called if the initial default password was used.
        public void SetForcePasswordChange(bool force)
        {
            _forcePasswordChange = force;
            if (_forcePasswordChange)
            {
                MessageBox.Show("Please click the 'Change Password' button to update your default password.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Visual cues (like highlighting the button) could be added here.
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // Any specific load logic for Form18 was added here.
            // A check was added to ensure the admin context is present via SessionService.
            if (_sessionService.LoggedInUser == null || _sessionService.LoggedInUser.Role != UserRole.Admin)
            {
                MessageBox.Show("Admin context missing or insufficient privileges. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // The form was closed if no user context was found.
                return;
            }

            // If a password change was forced, a clear prompt or action could be triggered.
            if (_forcePasswordChange)
            {
                // The MessageBox from SetForcePasswordChange already guides the user.
            }
        }

        // The button7_Click event was identified as the "Change Password" button click.
        private void button7_Click(object sender, EventArgs e) // Change Password button
        {
            // The logged-in user was accessed directly from SessionService.
            User? loggedInAdmin = _sessionService.LoggedInUser;

            if (loggedInAdmin == null)
            {
                MessageBox.Show("Cannot change password: No logged-in admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Form6 was retrieved from the DI container.
            Form6 changePasswordForm = _serviceProvider.GetRequiredService<Form6>();

            // The ID of the current logged-in admin is now accessed directly by Form6 from SessionService.
            // Therefore, the call to SetUserToChangePassword was removed.
            // changePasswordForm.SetUserToChangePassword(loggedInAdmin.Id); // This line was removed.

            // Form6 was shown as a dialog, blocking Form18 until Form6 is closed.
            changePasswordForm.ShowDialog();

            // After Form6 closes, additional logic could be added here if needed,
            // for example, to check if the password was successfully changed.
        }

        // Navigation buttons were updated to use Dependency Injection.
        private void button5_Click(object sender, EventArgs e) // Dashboard button
        {
            Form9 form9 = _serviceProvider.GetRequiredService<Form9>(); // Form9 was retrieved from DI.
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // Bookings button
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // admin_bookings was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // Rooms button (Form13)
        {
            Form13 form13 = _serviceProvider.GetRequiredService<Form13>(); // Form13 was retrieved from DI.
            form13.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // Requests button (Form11)
        {
            Form11 form11 = _serviceProvider.GetRequiredService<Form11>(); // Form11 was retrieved from DI.
            form11.Show();
            this.Hide();
        }

        // The button4_Click event for "Profile" which is Form18 itself.
        private void button4_Click(object sender, EventArgs e) // Profile button (Form18 itself)
        {
            MessageBox.Show("Already on Accounts page (Profile).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
