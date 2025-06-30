using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using Iskedular.Models;

namespace UI_WinForms
{
    public partial class Form5 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;
        private Reservation? _currentReservation;

        public Form5(IServiceProvider serviceProvider, ReservationService reservationService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reservationService = reservationService;
        }

        public void SetReservation(Reservation reservation, string roomName)
        {
            _currentReservation = reservation;
            textBox10.Text = $"Room: {roomName} (ID: {reservation.RoomId})\r\n\r\n" +
                             $"Date: {reservation.StartTime:MMMM dd, yyyy}\r\n" +
                             $"Time: {reservation.StartTime:hh\\:mm tt} - {reservation.EndTime:hh\\:mm tt}\r\n\r\n" +
                             $"Purpose:\r\n{reservation.Purpose}\r\n\r\n" +
                             $"Professor: {reservation.Professor}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dashboardForm = _serviceProvider.GetRequiredService<Form1>();
            dashboardForm.Show();
            this.Hide();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (_currentReservation == null)
            {
                MessageBox.Show("No reservation to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                await _reservationService.DeleteReservationAsync(_currentReservation.Id);
                MessageBox.Show("Reservation successfully canceled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
                reserveForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to cancel reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
    }
}