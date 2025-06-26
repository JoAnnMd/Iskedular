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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // --- Placeholder for final database saving logic (Future Implementation) ---
            // This is where you would take the confirmed data (which you'd likely pass
            // from Form3 to Form5, or retrieve from Form5's displayed fields)
            // and commit it to your database via your EF Core service.

            // Example:
            // bool saveSuccess = _reservationService.ConfirmAndSaveBooking(confirmedBookingData);
            // if (saveSuccess)
            // {
            //     MessageBox.Show("Booking confirmed and saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
            // else
            // {
            //     MessageBox.Show("Failed to save booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     // Maybe return to Form3 or show an error screen
            //     return;
            // }

            // For now, we'll simulate successful saving.
            MessageBox.Show("Information saved! (Simulated)", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- Navigate back to Form1 (Dashboard) ---
            Form1 dashboardForm = new Form1(); // Create an instance of Form1
            dashboardForm.Show();              // Show Form1
            this.Hide();                       // Hide Form5
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // --- Navigate back to Form3 (Reserve/Edit screen) ---
            Form3 reserveForm = new Form3(); // Create an instance of Form3
            reserveForm.Show();              // Show Form3
            this.Hide();                     // Hide Form5
        }
    }
}
