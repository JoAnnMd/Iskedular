using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace UI_WinForms
{
    public partial class admin_bookings : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public admin_bookings(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void admin_bookings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            LoadBookings();
        }

        private void LoadBookings()
        {
            flowLayoutPanelBookings.Controls.Clear();

            // TODO: Replace this with real database fetching later
            for (int i = 1; i <= 5; i++) // Dummy 5 sample boxes
            {
                Panel bookingPanel = new Panel
                {
                    Width = 250,
                    Height = 120,
                    BackColor = Color.LightGray,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label bookingLabel = new Label
                {
                    Text = $"Sample Booking {i}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                bookingPanel.Controls.Add(bookingLabel);
                flowLayoutPanelBookings.Controls.Add(bookingPanel);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bookings_Total form15 = _serviceProvider.GetRequiredService<Bookings_Total>();
            form15.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form9.Show();
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
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }
    }
}
