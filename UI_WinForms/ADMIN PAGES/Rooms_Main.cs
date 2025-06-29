using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace UI_WinForms
{
    public partial class Rooms_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Rooms_Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Align buttons horizontally
            AlignButtons();
        }

        private void AlignButtons()
        {
            int formWidth = this.ClientSize.Width;
            int buttonWidth = buttonAvailableRooms.Width;
            int spacing = 20;

            int totalWidth = (buttonWidth * 3) + (spacing * 2);
            int startX = (formWidth - totalWidth) / 2;
            int y = 380;

            buttonAvailableRooms.Location = new Point(startX, y);
            buttonTotalRooms.Location = new Point(startX + buttonWidth + spacing, y);
            buttonRoomsManage.Location = new Point(startX + (buttonWidth + spacing) * 2, y);
        }

        private void buttonAvailableRooms_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Available_Rooms>();
            form.Show();
            this.Hide();
        }

        private void buttonTotalRooms_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Total_Rooms>();
            form.Show();
            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<admin_bookings>();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<PendingRequest>();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Form18>();
            form.Show();
            this.Hide();
        }

        private void Rooms_Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Rooms_Main_Resize(object sender, EventArgs e)
        {
            AlignButtons();
        }

        private void buttonRoomsManage_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormManageRooms>();
            form.Show();
            this.Hide();
        }
    }
}