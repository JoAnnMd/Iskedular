using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // UserService and SessionService were used
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used
using Iskedular.Models; // User model was used

namespace UI_WinForms
{
    public partial class Form6 : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionService _sessionService; // SessionService was injected.
        // private int _userIdToChangePassword; // This field was removed; user ID will be accessed via SessionService.

        // The constructor was updated for Dependency Injection.
        // It now receives UserService, IServiceProvider, and SessionService from the DI container.
        public Form6(UserService userService, IServiceProvider serviceProvider, SessionService sessionService)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
            _sessionService = sessionService; // SessionService was assigned.

            // PasswordChar for password textboxes was set for security.
            // Textbox names were confirmed to be: textBox2 (Old Password), textBox7 (New Password), textBox5 (Confirm Password).
            textBox2.PasswordChar = '*';  // Old Password
            textBox7.PasswordChar = '*';  // New Password
            textBox5.PasswordChar = '*'; // Confirm Password

            // The Change Password button was ensured to be enabled by default.
            // Assuming the button's name in the designer is 'button4'.
            button4.Enabled = true;
        }

        // The SetUserToChangePassword method was removed as the user ID is now accessed via SessionService.
        // public void SetUserToChangePassword(int userId)
        // {
        //     _userIdToChangePassword = userId;
        // }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Addressed CS8602 if present, safe for screen bounds.

            // A check was added to ensure a user is logged in via SessionService before allowing password change.
            if (_sessionService.LoggedInUser == null)
            {
                MessageBox.Show("No user logged in. Please log in before changing password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // The button4_Click event was configured as the "Change Password" button's Click event on Form6.
        private async void button4_Click(object sender, EventArgs e) // This method handles the change password button click.
        {
            // The user ID was accessed directly from SessionService.
            int userIdToChangePassword = _sessionService.LoggedInUser?.Id ?? 0; // The ID was retrieved, or 0 if no user.

            // The user ID was checked to ensure it was valid.
            if (userIdToChangePassword == 0)
            {
                MessageBox.Show("An error occurred: No user specified for password change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // The textboxes were used to get the old, new, and confirm passwords.
            string oldPassword = textBox2.Text;  // Old Password
            string newPassword = textBox7.Text;  // New Password
            string confirmPassword = textBox5.Text; // Confirm Password

            // Input Validation was performed.
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill all password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password and Confirm Password Matching Validation was performed.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password did not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Clear(); // New password field was cleared.
                textBox5.Clear(); // Confirm password field was cleared.
                textBox7.Focus(); // Focus was set to new password field.
                return;
            }

            // Password strength requirements could be added here.
            if (newPassword.Length < 8)
            {
                MessageBox.Show("New password must be at least 8 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Clear(); // New password field was cleared.
                textBox5.Clear(); // Confirm password field was cleared.
                textBox7.Focus(); // Focus was set to new password field.
                return;
            }

            try
            {
                // The current user was fetched to verify the old password.
                // The return type was declared as nullable (User?) to address CS8600.
                User? currentUser = await _userService.GetUserByIdAsync(userIdToChangePassword);
                if (currentUser == null)
                {
                    MessageBox.Show("User not found or session expired. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // The old password was verified against the stored hash.
                if (!currentUser.VerifyPassword(oldPassword)) // The User model's VerifyPassword method was used for verification.
                {
                    MessageBox.Show("Incorrect old password. Please try again.", "Password Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear(); // Old password field was cleared.
                    textBox2.Focus(); // Focus was set to old password field.
                    return;
                }

                // The password was updated using UserService.
                bool success = await _userService.UpdateUserPasswordAsync(userIdToChangePassword, newPassword);

                if (success)
                {
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Form6 was closed after successful change.
                    // Optionally, the session could be cleared if forcing re-login after password change.
                    // _sessionService.ClearSession();
                }
                else
                {
                    MessageBox.Show("Failed to change password. An error might have occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // An unexpected error during password change was handled.
                Console.WriteLine($"Password Change Error: {ex.Message}");
                MessageBox.Show("An unexpected error occurred during password change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Existing methods for TextChanged events.
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13's TextChanged event is here.
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox6's TextChanged event is here.
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox7's TextChanged event is here.
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox8's TextChanged event is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox2's TextChanged event is here.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1's TextChanged event is here.
        }

        // The button5_Click event handles the "Back" or "Cancel" action.
        private void button5_Click(object sender, EventArgs e) // Assuming button5 is the "Back" or "Cancel" button
        {
            this.Close(); // The form was closed, returning to the previous form (Form18 for admin).
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
