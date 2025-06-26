using Iskedular.Data;
using Iskedular.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form3 : Form
    {
        private readonly ApplicationDbContext _context;

        public Form3()
        {
            InitializeComponent();
            _context = RuntimeDbContextFactory.Create();

            LoadRooms();      // 💡 loads into comboBox1
            LoadTimeSlots();  // 💡 loads into comboBox2
        }


        private void LoadRooms()
        {
            var rooms = _context.Rooms.ToList();
            comboBox1.DataSource = rooms;
            comboBox1.DisplayMember = "Name";     // What the user sees
            comboBox1.ValueMember = "Id";         // What SelectedValue returns
        }





        private void LoadTimeSlots()
        {
            comboBox2.Items.Clear();

            for (int hour = 6; hour < 21; hour++) // From 6 AM to 8 PM (last slot ends 9 PM)
            {
                var start = DateTime.Today.AddHours(hour);
                var end = start.AddHours(1);
                comboBox2.Items.Add($"{start:hh\\:mmtt} - {end:hh\\:mmtt}".ToLower());
            }

            comboBox2.SelectedIndex = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not Room selectedRoom)
            {
                MessageBox.Show("No room selected.");
                return;
            }

            var selectedTime = comboBox2.Text;
            var selectedDate = monthCalendar1.SelectionStart.Date;
            var purpose = textBox11.Text.Trim();
            var professor = textBox13.Text.Trim();
            int userId = 1;

            DateTime startTime, endTime;

            try
            {
                // Split the selected time string like "6:00am - 7:00am"
                var parts = selectedTime.Split(" - ");
                var start = DateTime.Parse(parts[0]);
                var end = DateTime.Parse(parts[1]);

                // Combine the selected date with the time part
                startTime = selectedDate.Add(start.TimeOfDay);
                endTime = selectedDate.Add(end.TimeOfDay);
            }
            catch
            {
                MessageBox.Show("Invalid time slot selected.");
                return;
            }


            var pending = new PendingReservation
            {
                RoomId = selectedRoom.Id,
                RoomName = selectedRoom.Name,
                Purpose = purpose,
                StartTime = startTime,
                EndTime = endTime,
                UserId = userId
            };

            var confirmForm = new Form5(pending);
            confirmForm.ShowDialog(); // Wait until user confirms or cancels
        }


        // Nav buttons (can be modified later)
        private void button5_Click(object sender, EventArgs e) => MessageBox.Show("Home clicked");
        private void button6_Click(object sender, EventArgs e) => MessageBox.Show("Reserve clicked");
        private void button7_Click(object sender, EventArgs e) => MessageBox.Show("Rooms clicked");
        private void button4_Click(object sender, EventArgs e) => Close(); // Exit
    }
}
