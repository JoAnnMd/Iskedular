using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was added for DI navigation

namespace UI_WinForms
{
    public partial class PendingRequest : Form
    {
        private readonly IServiceProvider _serviceProvider; // A field for IServiceProvider was added.

        // The constructor was updated to receive IServiceProvider from the DI container.
        public PendingRequest(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        // Renamed from Form11_Load for consistency with class name
        private void PendingRequest_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'

            // Initial centering of the content panel
            CenterContentPanel();
        }

        // Added a Resize event handler for dynamic centering
        private void PendingRequest_Resize(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        // Helper method to center the panelContentToCenter within panelMainContentWrapper
        private void CenterContentPanel()
        {
            if (panelMainContentWrapper != null && panelContentToCenter != null)
            {
                int x = (panelMainContentWrapper.Width - panelContentToCenter.Width) / 2;
                int y = (panelMainContentWrapper.Height - panelContentToCenter.Height) / 2;
                panelContentToCenter.Location = new System.Drawing.Point(x, y);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic for tableLayoutPanel1_Paint is here.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1_TextChanged is here.
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox19_TextChanged is here.
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Logic for tableLayoutPanel1_Paint_1 is here.
        }

        // The button2_Click event was configured to navigate to admin bookings.
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (Rooms_Main).
        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form13 = _serviceProvider.GetRequiredService<Rooms_Main>(); // The form was retrieved from DI.
            form13.Show();
            this.Hide();
        }

        // The button5_Click event was configured to navigate to Form9 (Admin_Dashboard).
        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form9 = _serviceProvider.GetRequiredService<Admin_Dashboard>(); // The form was retrieved from DI.
            form9.Show();
            this.Hide();
        }

        // The button3_Click event was configured to navigate to PendingRequest (itself).
        // This might be a navigation to a specific sub-section or a refresh.
        private void button3_Click(object sender, EventArgs e)
        {
            // No action needed as we are already on the Requests page.
            // You might add logic here to refresh request data if needed.
            // For example: LoadPendingRequests();
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
