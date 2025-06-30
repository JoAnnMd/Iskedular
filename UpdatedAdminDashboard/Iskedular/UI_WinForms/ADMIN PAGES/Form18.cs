using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Models;
using Iskedular.Core.Services;
using System.Drawing; // Needed for Point and Size

namespace UI_WinForms
{
    public partial class Form18 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly SessionService _sessionService;
        private bool _forcePasswordChange = false;

        public Form18(IServiceProvider serviceProvider, SessionService sessionService)
        {
            InitializeComponent(); // This sets up the controls based on Designer.cs

            _serviceProvider = serviceProvider;
            _sessionService = sessionService;

            // THESE ARE THE CRITICAL LINES FOR TRUE FULLSCREEN (Borderless, covering taskbar)
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal; // Set to Normal first, then apply Bounds
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Use Bounds to cover the entire screen

            // Manually hook up the Load event
            this.Load += new System.EventHandler(this.Form18_Load);

            // Hook up the button6_Click event
            this.button6.Click += new System.EventHandler(this.button6_Click);
        }

        public void SetForcePasswordChange(bool force)
        {
            _forcePasswordChange = force;
            if (_forcePasswordChange)
            {
                MessageBox.Show("Please click the 'Change Password' button to update your default password.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            if (_sessionService.LoggedInUser == null || _sessionService.LoggedInUser.Role != UserRole.Admin)
            {
                MessageBox.Show("Admin context missing or insufficient privileges. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_forcePasswordChange)
            {
                // The MessageBox from SetForcePasswordChange already guides the user.
            }

            // --- Dynamic Centering and Fullscreen Adjustment Logic ---
            // Ensure client size is based on the actual screen bounds for accurate positioning
            int screenWidth = this.ClientSize.Width;
            int screenHeight = this.ClientSize.Height;

            // 1. Position and size the red header (pictureBox1) to span full width
            pictureBox1.Size = new Size(screenWidth, pictureBox1.Height);
            pictureBox1.Location = new Point(0, 0);

            // 2. Center elements within the red header (pictureBox1)
            // Logo (pictureBox4)
            pictureBox4.Location = new Point(20, (pictureBox1.Height - pictureBox4.Height) / 2);

            // Iskedular Text (textBox4)
            textBox4.Location = new Point(pictureBox4.Right + 10, (pictureBox1.Height - textBox4.Height) / 2);

            // Navigation Buttons (Bookings, Rooms, Dashboard, Requests, Account)
            int buttonSpacing = 15;
            int currentRightPosition = screenWidth - 20;

            button4.Location = new Point(currentRightPosition - button4.Width, (pictureBox1.Height - button4.Height) / 2);
            currentRightPosition = button4.Left - buttonSpacing;

            button3.Location = new Point(currentRightPosition - button3.Width, (pictureBox1.Height - button3.Height) / 2);
            currentRightPosition = button3.Left - buttonSpacing;

            button5.Location = new Point(currentRightPosition - button5.Width, (pictureBox1.Height - button5.Height) / 2);
            currentRightPosition = button5.Left - buttonSpacing;

            button1.Location = new Point(currentRightPosition - button1.Width, (pictureBox1.Height - button1.Height) / 2);
            currentRightPosition = button1.Left - buttonSpacing;

            button2.Location = new Point(currentRightPosition - button2.Width, (pictureBox1.Height - button2.Height) / 2);

            // 3. Position "Accounts" title (textBox5)
            textBox5.Location = new Point(50, pictureBox1.Bottom + 20);

            // 4. Position "Users" title (textBox1)
            textBox1.Location = new Point(textBox5.Left, textBox5.Bottom + 30);

            // 5. Center and position the TableLayoutPanel (the table with Name/Email)
            int tablePanelWidth = tableLayoutPanel1.Width;
            int tablePanelHeight = tableLayoutPanel1.Height;

            int startXTablePanel = (screenWidth - tablePanelWidth) / 2;
            int tablePanelY = textBox1.Bottom + 20;

            tableLayoutPanel1.Location = new Point(startXTablePanel, tablePanelY);

            // 6. Position the Admin profile picture and text (right side)
            int adminAreaRightMargin = 50;
            pictureBox2.Location = new Point(screenWidth - pictureBox2.Width - adminAreaRightMargin, textBox5.Top);
            textBox3.Location = new Point(pictureBox2.Left + (pictureBox2.Width - textBox3.Width) / 2, pictureBox2.Bottom + 10);

            // 7. Position Logout and Change Password buttons
            int buttonMargin = 20;
            button6.Location = new Point(screenWidth - button6.Width - adminAreaRightMargin, textBox3.Bottom + 30);
            button7.Location = new Point(screenWidth - button7.Width - adminAreaRightMargin, button6.Bottom + buttonMargin);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User? loggedInAdmin = _sessionService.LoggedInUser;

            if (loggedInAdmin == null)
            {
                MessageBox.Show("Cannot change password: No logged-in admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form6 changePasswordForm = _serviceProvider.GetRequiredService<Form6>();
            changePasswordForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form13 = _serviceProvider.GetRequiredService<Rooms_Main>();
            form13.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>();
            form11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already on Accounts page (Profile).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _sessionService.ClearSession();
            Form19 form19 = _serviceProvider.GetRequiredService<Form19>();
            form19.Show();
            this.Hide();
        }
    }
}