using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was added for DI navigation

namespace UI_WinForms
{
    public partial class Form9 : Form
    {
        private readonly IServiceProvider _serviceProvider; // A field for IServiceProvider was added.

        // The constructor was updated to receive IServiceProvider from the DI container.
        public Form9(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox8_TextChanged is here.
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox5_TextChanged is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox2_TextChanged is here.
        }

        // The textBox3_Click event was configured to navigate to admin_bookings.
        private void textBox3_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13_TextChanged is here.
        }

        // The button2_Click event was configured to navigate to admin bookings.
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1_TextChanged is here.
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox9_TextChanged is here.
        }

        // The textBox1_Click event was configured to navigate to Available Rooms.
        private void textBox1_Click(object sender, EventArgs e)
        {
            Available_Rooms availableRoomsForm = _serviceProvider.GetRequiredService<Available_Rooms>(); // The form was retrieved from DI.
            availableRoomsForm.Show();
            this.Hide();
        }

        // The textBox2_Click event was configured to navigate to Form11 (Requests).
        private void textBox2_Click(object sender, EventArgs e)
        {
            Form11 form11 = _serviceProvider.GetRequiredService<Form11>(); // The form was retrieved from DI.
            form11.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (Rooms).
        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = _serviceProvider.GetRequiredService<Form13>(); // The form was retrieved from DI.
            form13.Show();
            this.Hide();
        }

        // The button3_Click event was configured to navigate to Form11 (Requests).
        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = _serviceProvider.GetRequiredService<Form11>(); // The form was retrieved from DI.
            form11.Show();
            this.Hide();
        }

        // The button4_Click event was configured to navigate to Form18 (Accounts/Profile).
        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>(); // The form was retrieved from DI.
            form18.Show();
            this.Hide();
        }
    }
}
