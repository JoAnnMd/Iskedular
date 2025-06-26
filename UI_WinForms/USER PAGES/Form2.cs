using Iskedular.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form2 : Form
    {
        private readonly ApplicationDbContext _context;

        // Room name -> (panel, isFaculty)
        private Dictionary<string, (Panel panel, bool isFaculty)> roomPanelMap;

        public Form2()
        {
            InitializeComponent();
            _context = RuntimeDbContextFactory.Create();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeRoomMappings();
            UpdateRoomStatuses(monthCalendar1.SelectionStart.Date);
        }

        private void InitializeRoomMappings()
        {
            roomPanelMap = new Dictionary<string, (Panel, bool)>()
            {
                { "101", (panel18, false) },
                { "102", (panel17, false) },
                { "103", (panel16, false) },
                { "104", (panel15, false) },
                { "105", (panel14, false) },
                { "106", (panel13, false) },
                { "201", (panel12, false) },
                { "202", (panel11, false) },
                { "203", (panel10, false) },
                { "204", (panel9,  false) },
                { "205", (panel7,  false) },
                { "206", (panel8,  false) },
                { "Guard House", (panel4, true) },
                { "Gymnasium",   (panel5, true) },
                { "Roth Room #1", (panel19, false) },
                { "Roth Room #2", (panel20, false) },
                { "Chapel", (panel21, true) },
                { "AVR",    (panel22, false) },
                { "COMLAB", (panel23, false) }
            };
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var selectedDate = e.Start.Date;
            UpdateRoomStatuses(selectedDate);
        }

        private void UpdateRoomStatuses(DateTime date)
        {
            var allReservations = _context.Reservations
                .Where(r => r.StartTime.Date == date)
                .ToList();

            foreach (var roomEntry in roomPanelMap)
            {
                string roomName = roomEntry.Key;
                var (panel, isFaculty) = roomEntry.Value;

                // Default color
                panel.BackColor = Color.LightGreen;

                if (isFaculty)
                {
                    panel.BackColor = Color.Yellow;
                }
                else
                {
                    // Get the room ID for the current room name
                    var room = _context.Rooms.FirstOrDefault(r => r.Name == roomName);
                    if (room != null)
                    {
                        bool isBooked = allReservations.Any(res => res.RoomId == room.Id);
                        if (isBooked)
                        {
                            panel.BackColor = Color.Maroon;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = new Form3();
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = new Form4();
            profileForm.Show();
            this.Hide();
        }
    }
}
