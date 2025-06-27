using System;
using System.Windows.Forms;
using Iskedular.Core.Services; // For IUserService
using Microsoft.Extensions.DependencyInjection; // For IServiceProvider
using Iskedular.Models; // User model was referenced

namespace UI_WinForms
{
    public partial class Form7 : Form
    {
        // MODIFIED: Depend on the interface IUserService, not the concrete UserService
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        // MODIFIED: Constructor now accepts IUserService
        public Form7(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService; // Assign the injected IUserService
            _serviceProvider = serviceProvider;

            textBox7.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox5's TextChanged event is here.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigation to the Sign Up page (Form8) was performed using DI.
            Form8 signUpForm = _serviceProvider.GetRequiredService<Form8>();
            signUpForm.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13's TextChanged event is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for when the email textbox content changes is here.
        }

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
                // Call AuthenticateUserAsync on the IUserService interface
                var authenticatedUser = await _userService.AuthenticateUserAsync(email, password);

                if (authenticatedUser != null)
                {
                    MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigation to User Dashboard (Form1) was performed using DI.
                    Form1 userDashboard = _serviceProvider.GetRequiredService<Form1>();
                    userDashboard.Show();
                    this.Hide();
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