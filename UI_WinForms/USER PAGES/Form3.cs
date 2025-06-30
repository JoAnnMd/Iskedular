using Iskedular.Core.Services;
using Iskedular.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form3 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService;
        private readonly ReservationService _reservationService;
        private readonly SessionService _sessionService;

        public Form3(IServiceProvider serviceProvider, RoomService roomService, ReservationService reservationService, SessionService sessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = roomService;
            _reservationService = reservationService;
            _sessionService = sessionService;
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            this.Load += new EventHandler(Form3_Load);
            this.Resize += new EventHandler(Form3_Resize);
        }

        private void PopulateAmPmComboBoxes()
        {
            if (Controls.Find("comboBoxStartAmPm", true).FirstOrDefault() is ComboBox startAmPmComboBox)
            {
                startAmPmComboBox.Items.Clear();
                startAmPmComboBox.Items.Add("AM");
                startAmPmComboBox.Items.Add("PM");
                startAmPmComboBox.SelectedIndex = 0; // Default to AM
            }

            if (Controls.Find("comboBoxEndAmPm", true).FirstOrDefault() is ComboBox endAmPmComboBox)
            {
                endAmPmComboBox.Items.Clear();
                endAmPmComboBox.Items.Add("AM");
                endAmPmComboBox.Items.Add("PM");
                endAmPmComboBox.SelectedIndex = 0; // Default to AM
            }
        }

        private TimeSpan ConvertTo24HourTime(TimeSpan time12Hr, string ampm)
        {
            int hours = time12Hr.Hours;
            int minutes = time12Hr.Minutes;

            if (ampm.ToUpper() == "PM" && hours < 12)
            {
                hours += 12;
            }
            else if (ampm.ToUpper() == "AM" && hours == 12) // Midnight (12 AM)
            {
                hours = 0;
            }
            // For 12 PM, hours remains 12
            // For 1 AM to 11 AM, hours remains as is

            return new TimeSpan(hours, minutes, 0);
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;
            CenterContentPanel();
            await LoadRoomsIntoComboBox();
            PopulateProgramAndYearSectionComboBoxes();
            PopulateAmPmComboBoxes();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        private void CenterContentPanel()
        {
            if (panelMainContentWrapper != null && panelContentToCenter != null)
            {
                int x = (panelMainContentWrapper.Width - panelContentToCenter.Width) / 2;
                int y = (panelMainContentWrapper.Height - panelContentToCenter.Height) / 2;
                panelContentToCenter.Location = new System.Drawing.Point(x, y);
            }
        }

        private async Task LoadRoomsIntoComboBox()
        {
            try
            {
                List<Room> allRooms = await _roomService.GetAllRoomsAsync();
                comboBox1.DataSource = allRooms;
                comboBox1.DisplayMember = "Name"; // Display Room.Name
                comboBox1.ValueMember = "Id";    // Use Room.Id as the actual value
                comboBox1.SelectedIndex = -1; // No room selected by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateProgramAndYearSectionComboBoxes()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Bachelor of Science in Information Technology (BSIT)");
            comboBox2.Items.Add("Bachelor of Business Technology and Livelihood Education major in Home Economics(BBTLEDHE)");
            comboBox2.Items.Add("Bachelor of Business Technology and Livelihood Education major in Information Communication and Technology (BTLEDICT)");
            comboBox2.Items.Add("Bachelor of Science in Business Administration major in Human Resource Management (BSBAHRM)");
            comboBox2.Items.Add("Bachelor of Science in Business Administration major in Marketing Management (BSBA-MM)");
            comboBox2.Items.Add("Bachelor of Science in Entrepreneurship (BSENTREP)");
            comboBox2.Items.Add("Bachelor of Public Administration with specialization in Fiscal Administration (BPAFA)");
            comboBox2.Items.Add("Diploma in Office Management Technology Medical Office Management (DOMTMOM)");
            comboBox2.SelectedIndex = -1;

            comboBox3.Items.Clear();
            comboBox3.Items.Add("1-1");
            comboBox3.Items.Add("1-2");
            comboBox3.Items.Add("2-1");
            comboBox3.Items.Add("2-2");
            comboBox3.Items.Add("3-1");
            comboBox3.Items.Add("3-2");
            comboBox3.Items.Add("4-1");
            comboBox3.Items.Add("4-2");
            comboBox3.SelectedIndex = -1; // No section selected by default
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.Date < DateTime.Today)
            {
                MessageBox.Show("Past dates cannot be selected for reservations.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthCalendar1.SetDate(DateTime.Today); // Reset to today if a past date was somehow selected
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = _serviceProvider.GetRequiredService<Form1>(); // Use DI
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = _serviceProvider.GetRequiredService<Form2>(); // Use DI
            roomsForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Reserve screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var currentUser = _sessionService.LoggedInUser;
            if (currentUser != null)
            {
                Form4 profileForm = new Form4(_serviceProvider, currentUser);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not logged in. Please log in first.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("You cannot book for a past date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text) || !TimeSpan.TryParse(textBox6.Text, out TimeSpan startTimeSpan))
            {
                MessageBox.Show("Please enter a valid start time (HH:MM).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text) || !TimeSpan.TryParse(textBox7.Text, out TimeSpan endTimeSpan))
            {
                MessageBox.Show("Please enter a valid end time (HH:MM).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxStartAmPm.SelectedItem == null)
            {
                MessageBox.Show("Please select AM or PM for the start time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string startAmPm = comboBoxStartAmPm.SelectedItem.ToString()!;
            TimeSpan startTime24Hr = ConvertTo24HourTime(startTimeSpan, startAmPm);
            DateTime startDateTime = selectedDate.Add(startTime24Hr);

            if (comboBoxEndAmPm.SelectedItem == null)
            {
                MessageBox.Show("Please select AM or PM for the end time.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string endAmPm = comboBoxEndAmPm.SelectedItem.ToString()!;
            TimeSpan endTime24Hr = ConvertTo24HourTime(endTimeSpan, endAmPm);
            DateTime endDateTime = selectedDate.Add(endTime24Hr);

            if (endDateTime <= startDateTime)
            {
                MessageBox.Show("End time must be after start time.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Please enter the purpose of the reservation.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox13.Text))
            {
                MessageBox.Show("Please enter the professor's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a program.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a year and section.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRoomId = (int)comboBox1.SelectedValue!;
            string selectedRoomName = comboBox1.Text;

            var currentUser = _sessionService.LoggedInUser;
            if (currentUser == null)
            {
                MessageBox.Show("User not logged in. Please log in to make a reservation.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form7 loginForm = _serviceProvider.GetRequiredService<Form7>();
                loginForm.Show();
                this.Hide();
                return;
            }

            try
            {
                bool hasOverlap = await _reservationService.HasOverlappingReservation(selectedRoomId, startDateTime, endDateTime);
                if (hasOverlap)
                {
                    MessageBox.Show("The selected room is not available at the chosen time. Please choose a different time or room.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reservation newReservation = new Reservation
                {
                    RoomId = selectedRoomId,
                    UserId = currentUser.Id,
                    StartTime = startDateTime,
                    EndTime = endDateTime,
                    Purpose = textBox11.Text.Trim(),
                    Program = comboBox2.Text,
                    YearSection = comboBox3.Text,
                    Professor = textBox13.Text.Trim(),
                    Status = ReservationStatus.Pending
                };

                await _reservationService.AddReservationAsync(newReservation);

                Form5 confirmationForm = _serviceProvider.GetRequiredService<Form5>();
                confirmationForm.SetReservation(newReservation, selectedRoomName);
                confirmationForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                    message += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show($"An error occurred while submitting the reservation: {message}", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
    }
}