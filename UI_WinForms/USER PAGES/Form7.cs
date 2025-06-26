using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // UserService was used
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used
using Iskedular.Models; // User model was referenced

namespace UI_WinForms // This namespace matched the form's actual namespace
{
    public partial class Form7 : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider; // Used for creating other forms via DI

        // The constructor was set up for Dependency Injection.
        // It receives UserService and IServiceProvider.
        public Form7(UserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;

            // PasswordChar for the password textbox was set for security.
            textBox7.PasswordChar = '*'; // Based on the form's design, textBox7 is for password.
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox5's TextChanged event is here.
        }

        // The button2_Click event was configured as the "Sign Up" button click handler.
        private void button2_Click(object sender, EventArgs e)
        {
            // Navigation to the Sign Up page (Form8) was performed using DI.
            Form8 signUpForm = _serviceProvider.GetRequiredService<Form8>();
            signUpForm.Show();              // Form8 was shown.
            this.Hide();                    // Form7 was hidden.
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Setup code for Form7 when it loaded was added here.
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13's TextChanged event is here.
        }

        // The TextChanged event for the email textbox (textBox2) was added.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for when the email textbox content changes is here.
        }

        // The loginButton_Click event handles the login attempt with database integration.
        // The button was confirmed to be named 'loginButton'.
        private async void loginButton_Click(object sender, EventArgs e)
        {
            // Textbox names for email (textBox2) and password (textBox7) were confirmed.
            string email = textBox2.Text.Trim();
            string password = textBox7.Text;

            // Basic Input Validation was performed.
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

            // Basic Email Format Validation was performed.
            if (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@"))
            {
                MessageBox.Show("Please enter a valid email address format (e.g., user@example.com).", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authentication Against Database using UserService was performed.
            try
            {
                var authenticatedUser = await _userService.AuthenticateUserAsync(email, password);

                if (authenticatedUser != null)
                {
                    MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigation to User Dashboard (Form1) was performed using DI.
                    Form1 userDashboard = _serviceProvider.GetRequiredService<Form1>();
                    userDashboard.Show();
                    this.Hide(); // The login form (Form7) was hidden.
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Clear(); // The password field was cleared for security.
                    textBox2.Focus(); // The cursor was put back in the email field.
                }
            }
            catch (Exception ex)
            {
                // The exception during login was logged for debugging purposes.
                Console.WriteLine($"Login Error: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during login. Please try again later.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
