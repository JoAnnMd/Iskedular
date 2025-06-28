using System;
using System.Windows.Forms;
using Iskedular.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Models;
using System.Drawing;

namespace UI_WinForms
{
    public partial class Form7 : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionService _sessionService; // ADDED: Inject SessionService

        public Form7(UserService userService, IServiceProvider serviceProvider, SessionService sessionService) // MODIFIED: Add SessionService to constructor
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
            _sessionService = sessionService; // Assign the injected SessionService

            textBox7.PasswordChar = '*';

            this.Load += Form7_Load;
            this.Resize += Form7_Resize;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox5's TextChanged event is here.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 signUpForm = _serviceProvider.GetRequiredService<Form8>();
            signUpForm.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            CenterPanel();
        }

        private void Form7_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            if (mainContentPanel != null)
            {
                int x = (this.ClientSize.Width - mainContentPanel.Width) / 2;
                int y = (this.ClientSize.Height - mainContentPanel.Height) / 2;

                mainContentPanel.Location = new Point(x, y);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13's TextChanged event is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for when the email textbox content changes is here.
        }

        // The loginButton_Click event now handles role-based redirection.
        private async void loginButton_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();
            string password = textBox7.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@"))
            {
                MessageBox.Show("Please enter a valid email address format (e.g., user@example.com).", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var authenticatedUser = await _userService.AuthenticateUserAsync(email, password);

                if (authenticatedUser != null)
                {
                    // ADDED: Set the authenticated user in the SessionService
                    _sessionService.SetLoggedInUser(authenticatedUser);

                    // Check the user's role and redirect accordingly
                    if (authenticatedUser.Role == UserRole.Admin)
                    {
                        MessageBox.Show("Admin Login Successful!", "Welcome Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin_Dashboard adminDashboard = _serviceProvider.GetRequiredService<Admin_Dashboard>();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else if (authenticatedUser.Role == UserRole.Student)
                    {
                        MessageBox.Show("Student Login Successful!", "Welcome Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 userDashboard = _serviceProvider.GetRequiredService<Form1>();
                        userDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login successful, but role not recognized. Access denied.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox7.Clear();
                        textBox2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login Error: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during login. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
