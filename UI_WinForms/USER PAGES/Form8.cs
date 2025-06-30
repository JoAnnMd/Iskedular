using System;
using System.Windows.Forms;
using Iskedular.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Models;
using System.Drawing;
using System.Linq; // Added for password validation checks
using System.Text; // Added for StringBuilder
using System.Collections.Generic; // Added for List<string> to collect errors

namespace UI_WinForms
{
    public partial class Form8 : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionService _sessionService; // Added for session management
        // Removed: ErrorProvider declarations are no longer needed.


        public Form8(UserService userService, IServiceProvider serviceProvider, SessionService sessionService)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
            _sessionService = sessionService; // Assign injected session service

            textBox9.PasswordChar = '*';    // Password field
            textBox12.PasswordChar = '*';   // Confirm Password field

            // Removed: ErrorProvider initializations and configurations are no longer needed.
            // errorProviderPassword = new ErrorProvider();
            // errorProviderPassword.ContainerControl = this;
            // errorProviderPassword.SetIconAlignment(textBox9, ErrorIconAlignment.MiddleRight);
            // errorProviderPassword.SetIconPadding(textBox9, 5);

            // errorProviderConfirmPassword = new ErrorProvider();
            // errorProviderConfirmPassword.ContainerControl = this;
            // errorProviderConfirmPassword.SetIconAlignment(textBox12, ErrorIconAlignment.MiddleRight);
            // errorProviderConfirmPassword.SetIconPadding(textBox12, 5);

            // errorProviderEmail = new ErrorProvider();
            // errorProviderEmail.ContainerControl = this;
            // errorProviderEmail.SetIconAlignment(textBox6, ErrorIconAlignment.MiddleRight);
            // errorProviderEmail.SetIconPadding(textBox6, 5);

            // errorProviderFirstName = new ErrorProvider();
            // errorProviderFirstName.ContainerControl = this;
            // errorProviderFirstName.SetIconAlignment(textBox2, ErrorIconAlignment.MiddleRight);
            // errorProviderFirstName.SetIconPadding(textBox2, 5);

            // errorProviderLastName = new ErrorProvider();
            // errorProviderLastName.ContainerControl = this;
            // errorProviderLastName.SetIconAlignment(textBox4, ErrorIconAlignment.MiddleRight);
            // errorProviderLastName.SetIconPadding(textBox4, 5);

            // Removed: Clear errors on TextChanged events as ErrorProvider is removed.
            // textBox2.TextChanged += (s, e) => errorProviderFirstName.SetError(textBox2, "");
            // textBox4.TextChanged += (s, e) => errorProviderLastName.SetError(textBox4, "");
            // textBox6.TextChanged += (s, e) => errorProviderEmail.SetError(textBox6, "");
            // textBox9.TextChanged += (s, e) => errorProviderPassword.SetError(textBox9, "");
            // textBox12.TextChanged += (s, e) => errorProviderConfirmPassword.SetError(textBox12, "");


            this.Load += Form8_Load;
            this.Resize += Form8_Resize;
        }

        // The button1_Click event handles the "Sign Up" button click.
        private async void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox2.Text.Trim(); // Full Name
            string programSection = textBox4.Text.Trim(); // Program & Section
            string email = textBox6.Text.Trim();
            string password = textBox9.Text;
            string confirmPassword = textBox12.Text;

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(fullName))
            {
                errors.Add("Full Name is required.");
            }
            if (string.IsNullOrEmpty(programSection))
            {
                errors.Add("Program & Section is required.");
            }
            if (string.IsNullOrEmpty(email))
            {
                errors.Add("Email is required.");
            }
            if (string.IsNullOrEmpty(password))
            {
                errors.Add("Password is required.");
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                errors.Add("Confirm Password is required.");
            }

            if (!string.IsNullOrEmpty(email) && (!email.Contains("@") || email.IndexOf(".") <= email.IndexOf("@")))
            {
                errors.Add("Please enter a valid email address format (e.g., user@example.com).");
            }

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword) && password != confirmPassword)
            {
                errors.Add("Passwords do not match.");
                textBox9.Clear();
                textBox12.Clear();
                textBox9.Focus();
            }

            if (!string.IsNullOrEmpty(password))
            {
                StringBuilder passwordErrors = new StringBuilder();
                if (password.Length < 8)
                {
                    passwordErrors.AppendLine("- At least 8 characters long.");
                }
                if (!password.Any(char.IsDigit))
                {
                    passwordErrors.AppendLine("- At least one number.");
                }
                if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    passwordErrors.AppendLine("- At least one symbol (e.g., !, @, #, $).");
                }
                if (passwordErrors.Length > 0)
                {
                    errors.Add($"Password must meet the following criteria:\n{passwordErrors.ToString()}");
                    textBox9.Clear();
                    textBox12.Clear();
                    textBox9.Focus();
                }
            }

            if (errors.Count > 0)
            {
                MessageBox.Show("Please correct the following errors:\n\n" + string.Join("\n", errors), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // For now, split fullName into first and last name for the User model
                string firstName = fullName;
                string lastName = ""; // Not used anymore
                var newUser = await _userService.RegisterUserAsync(firstName, lastName, email, password, programSection);

                if (newUser != null)
                {
                    MessageBox.Show("Account created successfully! You can now log in.", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sessionService.SetLoggedInUser(newUser);
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
            Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
            loginForm.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            CenterPanel();
        }

        private void Form8_Resize(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox9's TextChanged event is here.
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            // Logic for Form8_Load_1 event is here.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
