// File: UI_WinForms/Form19.cs
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using Iskedular.Models;
using System.Drawing; // For UI adjustments
using System.Threading.Tasks;

namespace UI_WinForms
{
    public partial class Form19 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserService _userService;
        private readonly SessionService _sessionService;
        private readonly ActivityLogService _activityLogService;

        // Constructor now accepts injected services
        public Form19(IServiceProvider serviceProvider, UserService userService,
                      SessionService sessionService, ActivityLogService activityLogService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = userService;
            _sessionService = sessionService;
            _activityLogService = activityLogService;

            this.Load += Form19_Load;
            this.Resize += Form19_Resize;

            // Hook up your buttons' click events if not already done in the designer
            // Example assuming button1 is for Student Login, button2 for Admin Login
            // this.button1.Click += button1_Click;
            // this.button2.Click += button2_Click;
        }

        private async void Form19_Load(object? sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            CenterTableLayoutPanel(); // Ensure tableLayoutPanel1 is a control on your form

            await CheckInitialAdminStatus(); // Use await for async call
        }

        private async Task CheckInitialAdminStatus()
        {
            try
            {
                int userCount = await _userService.GetTotalUserCountAsync();
                if (userCount == 0)
                {
                    MessageBox.Show("No users found in the database. An initial admin user 'admin@iskedular.com' with password 'AdminPass123!' has been seeded during database migration. Please log in using these credentials.", "Initial Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking initial admin status: {ex.Message}", "Database Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form19_Resize(object? sender, EventArgs e)
        {
            CenterTableLayoutPanel();
        }

        private void CenterTableLayoutPanel()
        {
            // Ensure tableLayoutPanel1 is a control on your Form19
            if (tableLayoutPanel1 != null)
            {
                int x = (this.ClientSize.Width - tableLayoutPanel1.Width) / 2;
                int y = (this.ClientSize.Height - tableLayoutPanel1.Height) / 2;
                tableLayoutPanel1.Location = new System.Drawing.Point(x, y);
            }
        }

        // Example: If button1 is for Student Login
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 studentLoginForm = _serviceProvider.GetRequiredService<Form7>();
                studentLoginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening student login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Example: If button2 is for Admin Login
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AdminLogin adminLoginForm = _serviceProvider.GetRequiredService<AdminLogin>();
                adminLoginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening admin login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add any other methods/event handlers for your Form19 functionality here
    }
}