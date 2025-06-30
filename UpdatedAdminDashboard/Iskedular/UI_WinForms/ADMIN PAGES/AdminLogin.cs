using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // UserService and SessionService were used
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used
using Iskedular.Models; // User model and UserRole enum were referenced
using Microsoft.Extensions.Configuration; // IConfiguration was injected

namespace UI_WinForms
{
    public partial class AdminLogin : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration; // Configuration was made available for reading appsettings
        private readonly SessionService _sessionService; // The SessionService was injected.

        // The constructor was updated for Dependency Injection.
        // It now receives UserService, IServiceProvider, IConfiguration, and SessionService.
        public AdminLogin(UserService userService, IServiceProvider serviceProvider, IConfiguration configuration, SessionService sessionService)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
            _configuration = configuration; // Injected configuration was assigned.
            _sessionService = sessionService; // Injected SessionService was assigned.

            // The PasswordChar for the admin password textbox was set for security.
            textBox7.PasswordChar = '*'; // Based on the form's design, textBox7 is for password.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Logic for handling PictureBox click event is here.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling TextChanged event is here.
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // Initialization logic for the form was added here.
            // Fullscreen setup for the admin login screen was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'

            // IMPORTANT: Remove or comment out the problematic foreach loop here that ChatGPT added earlier.
            // That loop was causing issues with centering the mainContentPanel.
            // Example:
            // foreach (Control ctrl in this.Controls)
            // {
            //     ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
            // }

            // Ensure the mainContentPanel is centered in the form.
            // This positioning needs to happen here if the form's Bounds are set dynamically in Load.
            if (mainContentPanel != null)
            {
                mainContentPanel.Left = (this.ClientSize.Width - mainContentPanel.Width) / 2;
                mainContentPanel.Top = (this.ClientSize.Height - mainContentPanel.Height) / 2;
            }
        }

        // The button4_Click event handles the admin login attempt.
        private async void button4_Click(object sender, EventArgs e) // This is the login button
        {
            string email = textBox2.Text.Trim();    // textBox2 was used for Email
            string password = textBox7.Text; // textBox7 was used for Password

            // Input Validation was performed.
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email Format Validation was performed.
            if (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@"))
            {
                MessageBox.Show("Please enter a valid email address format (e.g., admin@example.com).", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authentication Against Database using UserService was performed.
            try
            {
                // Authenticated user information was retrieved using UserService.
                var authenticatedUser = await _userService.AuthenticateUserAsync(email, password);

                if (authenticatedUser != null)
                {
                    // The authenticated user's role was checked.
                    if (authenticatedUser.Role == UserRole.Admin)
                    {
                        // The expected hash of the initial default password was retrieved from appsettings.json.
                        // A nullable string type and null check were used for configuration value, addressing CS8600.
                        string? initialDefaultPasswordHash = _configuration.GetSection("AdminSettings:InitialDefaultPasswordHash").Value;

                        // The authenticated user was set in the SessionService.
                        _sessionService.SetLoggedInUser(authenticatedUser); // The logged-in user was stored.

                        // A check was performed to see if the current password hash matched the initial default hash and if the hash existed.
                        if (!string.IsNullOrEmpty(initialDefaultPasswordHash) && authenticatedUser.PasswordHash == initialDefaultPasswordHash)
                        {
                            // Default password was detected, and a password change was required.
                            MessageBox.Show("Welcome Admin! For security, please change your default password immediately.", "Password Change Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigation to Form18 (Accounts/Admin Panel) was performed using the service provider.
                            Form18 adminAccountsForm = _serviceProvider.GetRequiredService<Form18>();
                            adminAccountsForm.SetForcePasswordChange(true); // A flag was set to indicate a forced password change.
                            adminAccountsForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // The password was not the initial default, so the system proceeded to the regular Admin Dashboard.
                            MessageBox.Show("Admin Login Successful!", "Welcome Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin_Dashboard adminDashboard = _serviceProvider.GetRequiredService<Admin_Dashboard>(); // Form9 was retrieved from DI.
                            adminDashboard.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        // The user exists but was not an admin.
                        MessageBox.Show("Access Denied: You do not have administrator privileges.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox7.Clear(); // The password textbox was cleared.
                    }
                }
                else
                {
                    // Authentication failed (email not found or password incorrect).
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Clear(); // The password textbox was cleared.
                    textBox2.Focus(); // The email textbox received focus.
                }
            }
            catch (Exception ex)
            {
                // An unexpected error during admin login was handled.
                Console.WriteLine($"Admin Login Error: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during admin login. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Other event handlers like TextChanged for textBox2 or textBox7 are here.
    }
}
