using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was added for DI navigation

namespace UI_WinForms
{
    public partial class admin_bookings : Form
    {
        private readonly IServiceProvider _serviceProvider; // A field for IServiceProvider was added.

        // The constructor was updated to receive IServiceProvider from the DI container.
        public admin_bookings(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void admin_bookings_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1_TextChanged is here.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic for panel1_Paint is here.
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Logic for textBox1_TextChanged_1 is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox2_TextChanged is here.
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Logic for label9_Click is here.
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Logic for label11_Click is here.
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox8_TextChanged is here.
        }

        // The button6_Click event was configured to navigate to Form15.
        private void button6_Click(object sender, EventArgs e)
        {
            Form15 form15 = _serviceProvider.GetRequiredService<Form15>(); // The form was retrieved from DI.
            form15.Show();
            this.Hide();
        }

        // The button2_Click event was configured to navigate to admin bookings (itself).
        // This might be a navigation to a specific sub-section or a refresh.
        private void button2_Click(object sender, EventArgs e)
        {
            // The form was retrieved from DI. This might be used for refreshing the current form.
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (Rooms).
        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = _serviceProvider.GetRequiredService<Form13>(); // The form was retrieved from DI.
            form13.Show();
            this.Hide();
        }

        // The button5_Click event was configured to navigate to Form9 (Dashboard).
        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = _serviceProvider.GetRequiredService<Form9>(); // The form was retrieved from DI.
            form9.Show();
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
