using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using Iskedular.Models;

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;
        private readonly SessionService _sessionService;


        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = _serviceProvider.GetRequiredService<ReservationService>();
            _sessionService = _serviceProvider.GetRequiredService<SessionService>();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadUserReservations();
        }

        private async Task LoadUserReservations()
        {
            var user = _sessionService.LoggedInUser;
            if (user == null)
            {
                userdisplay.Text = "You are not logged in.";
                MessageBox.Show("Please log in to view your reservation details.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userdisplay == null)
            {
                MessageBox.Show("Display area for reservation details is missing (userdisplay is null).", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get all reservations for the current user
            var allReservations = await _reservationService.GetReservationsAsync();
            var userReservations = allReservations
                .Where(r => r.UserId == user.Id)
                .OrderByDescending(r => r.StartTime)
                .ToList();

            if (userReservations.Count == 0)
            {
                userdisplay.Text = "You have no bookings yet.";
                MessageBox.Show("No reservations found for your account.", "No Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Show all reservations
            var sb = new StringBuilder();
            int count = 1;
            foreach (var reservation in userReservations)
            {
                sb.AppendLine($"Reservation #{count++}");
                sb.AppendLine($"Room: {reservation.Room?.Name ?? "N/A"}");
                sb.AppendLine($"Date: {reservation.StartTime:MMMM dd, yyyy}");
                sb.AppendLine($"Time: {reservation.StartTime:hh:mm tt} - {reservation.EndTime:hh:mm tt}");
                sb.AppendLine($"Purpose: {reservation.Purpose}");
                sb.AppendLine($"Program: {reservation.Program}");
                sb.AppendLine($"Year/Section: {reservation.YearSection}");
                sb.AppendLine($"Professor: {reservation.Professor}");
                sb.AppendLine($"Status: {reservation.Status}");
                sb.AppendLine(new string('-', 65));
            }

            userdisplay.Text = sb.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = _serviceProvider.GetRequiredService<Form2>();
            roomsForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = _serviceProvider.GetRequiredService<Form4>();
            profileForm.Show();
            this.Hide();
        }
    }
}