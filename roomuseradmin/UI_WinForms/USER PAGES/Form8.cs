using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // For IUserService
using Microsoft.Extensions.DependencyInjection; // For IServiceProvider
using Iskedular.Models; // User model was referenced

namespace UI_WinForms
{
    public partial class Form8 : Form
    {
        // MODIFIED: Depend on the interface IUserService, not the concrete UserService
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        // MODIFIED: Constructor now accepts IUserService
        public Form8(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService; // Assign the injected IUserService
            _serviceProvider = serviceProvider;

            textBox9.PasswordChar = '*';
            textBox12.PasswordChar = '*';
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text.Trim();
            string lastName = textBox4.Text.Trim();
            string email = textBox6.Text.Trim();
            string password = textBox9.Text;
            string confirmPassword = textBox12.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@"))
            {
                MessageBox.Show("Please enter a valid email address format (e.g., user@example.com).", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password did not match.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox9.Clear();
                textBox12.Clear();
                textBox9.Focus();
                return;
            }

            try
            {
                // Call RegisterUserAsync on the IUserService interface
                var newUser = await _userService.RegisterUserAsync(firstName, lastName, email, password);

                if (newUser != null)
                {
                    MessageBox.Show("Account created successfully! You can now log in.", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigation back to the Login page (Form7) was performed using DI.
                    Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email already registered. Please use a different email or log in.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sign Up Error: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during registration. Please try again later.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigation back to the Login page (Form7) was performed using DI.
            Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
            loginForm.Show();
            this.Hide();
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