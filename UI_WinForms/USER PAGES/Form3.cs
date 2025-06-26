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
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of Form1 (User Dashboard/Home)
            homeForm.Show();              // Show Form1
            this.Hide();                  // Hide Form3
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = new Form2(); // Create an instance of Form2
            roomsForm.Show();              // Show Form2
            this.Hide();                  // Hide Form3
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // You are already on the Reserve screen (Form3).
            // Similar to Form1's Home button, this keeps you on the current form.
            MessageBox.Show("You are already on the Reserve screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = new Form4(); // Create an instance of Form4
            profileForm.Show();              // Show Form4
            this.Hide();                     // Hide Form3
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // --- Placeholder for collecting reservation data ---
            // In the future, you would get values from your Form3 controls here, e.g.:
            // string selectedRoom = yourRoomComboBox.SelectedItem.ToString();
            // DateTime selectedDate = yourMonthCalendar.SelectionStart;
            // string selectedTime = yourTimeComboBox.SelectedItem.ToString();
            // string purpose = yourPurposeTextBox.Text.Trim();
            // string professor = yourProfessorTextBox.Text.Trim(); // Based on your screenshot

            // --- Placeholder for input validation (before saving to database) ---
            // You would add checks here to ensure all required fields are filled
            // and data is in the correct format.
            // Example:
            // if (string.IsNullOrWhiteSpace(selectedRoom) || selectedDate == DateTime.MinValue || ...)
            // {
            //     MessageBox.Show("Please fill in all reservation details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }


            // --- Placeholder for Database Saving Logic (Future Implementation with EF Core) ---
            // This is where you would integrate with your data layer.
            // For instance:
            // var newReservation = new Reservation
            // {
            //     Room = selectedRoom,
            //     Date = selectedDate,
            //     Time = selectedTime,
            //     Purpose = purpose,
            //     Professor = professor
            // };
            // bool success = _reservationService.SaveReservation(newReservation); // Call a service to save

            // For now, we'll simulate success.
            MessageBox.Show("Reservation request submitted! (Simulated)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // --- Navigate to Form5 after successful (simulated) booking ---
            Form5 confirmationForm = new Form5(); // Create an instance of Form5
            confirmationForm.Show();              // Show Form5
            this.Hide();                          // Hide Form3
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

