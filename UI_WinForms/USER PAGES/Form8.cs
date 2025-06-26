using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // UserService was used
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used
using Iskedular.Models; // User model was referenced

namespace UI_WinForms // This namespace matched the form's actual namespace
{
    public partial class Form8 : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider; // Used for creating other forms via DI

        // The constructor was set up for Dependency Injection.
        public Form8(UserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;

            // PasswordChar for password textboxes was set for security.
            textBox9.PasswordChar = '*'; // Based on the form's design, textBox9 is for password.
            textBox12.PasswordChar = '*'; // Based on the form's design, textBox12 is for confirm password.
        }

        // The button1_Click event was configured as the "Sign Up" button click handler.
        private async void button1_Click(object sender, EventArgs e)
        {
            // Data from Form8's textboxes was retrieved.
            string firstName = textBox2.Text.Trim(); // textBox2 was used for First Name
            string lastName = textBox4.Text.Trim();  // textBox4 was used for Last Name
            string email = textBox6.Text.Trim();     // textBox6 was used for Email
            string password = textBox9.Text;         // textBox9 was used for Password
            string confirmPassword = textBox12.Text; // textBox12 was used for Confirm Password

            // Basic Sign-Up Input Validation was performed.
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic Email Format Validation was performed.
            if (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@"))
            {
                MessageBox.Show("Please enter a valid email address format (e.g., user@example.com).", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password and Confirm Password Matching Validation was performed.
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password did not match.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox9.Clear(); // Password fields were cleared for security.
                textBox12.Clear();
                textBox9.Focus(); // Focus was set back to the password field.
                return;
            }

            // User registration using UserService (Database Integration) was performed.
            try
            {
                var newUser = await _userService.RegisterUserAsync(firstName, lastName, email, password);

                if (newUser != null)
                {
                    MessageBox.Show("Account created successfully! You can now log in.", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigation back to the Login page (Form7) was performed using DI.
                    Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
                    loginForm.Show();
                    this.Hide(); // Form8 was hidden.
                }
                else
                {
                    MessageBox.Show("Email already registered. Please use a different email or log in.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus(); // Focus was set back to the email field.
                }
            }
            catch (Exception ex)
            {
                // The exception was logged for debugging.
                Console.WriteLine($"Sign Up Error: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during registration. Please try again later.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The button2_Click event was configured as the "Login" button on Form8.
        private void button2_Click(object sender, EventArgs e)
        {
            // Navigation back to the Login page (Form7) was performed using DI.
            Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
            loginForm.Show();
            this.Hide(); // Form8 was hidden.
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Setup code for Form8 when it loaded was added here.
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox9's TextChanged event is here.
        }
    }
}
