using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was added for DI navigation

namespace UI_WinForms
{
    public partial class Bookings_Total : Form
    {
        private readonly IServiceProvider _serviceProvider; // A field for IServiceProvider was added.

        // The constructor was updated to receive IServiceProvider from the DI container.
        public Bookings_Total(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        // The button2_Click event was configured to navigate to admin bookings.
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (Rooms).
        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form = _serviceProvider.GetRequiredService<Rooms_Main>();
            form.Show();
            this.Hide();
        }

        // The button5_Click event was configured to navigate to Form9 (Dashboard).
        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>(); // The form was retrieved from DI.
            form9.Show();
            this.Hide();
        }

        // The button3_Click event was configured to navigate to Form11 (Requests).
        private void button3_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>(); // The form was retrieved from DI.
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
