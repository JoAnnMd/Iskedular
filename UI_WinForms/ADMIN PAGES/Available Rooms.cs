using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services;
using System.Collections.Generic;
using Iskedular.Models;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace UI_WinForms
{
    public partial class Available_Rooms : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService;

        public Available_Rooms(IServiceProvider serviceProvider, RoomService roomService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = roomService;
        }

        private async void Available_Rooms_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            await LoadAvailableRooms();
        }

        private async Task LoadAvailableRooms()
        {
            if (this.Controls.Find("flowLayoutPanelRooms", true).FirstOrDefault() is FlowLayoutPanel flowLayoutPanelRooms)
            {
                flowLayoutPanelRooms.Controls.Clear();
                List<Room> allRooms = await _roomService.GetAllRoomsAsync();

                foreach (Room room in allRooms)
                {
                    // INCREASED PANEL SIZE TO ACCOMMODATE MORE INFO
                    Panel roomPanel = new Panel();
                    roomPanel.Size = new Size(220, 180); // Increased height and width
                    roomPanel.BorderStyle = BorderStyle.FixedSingle;
                    roomPanel.Margin = new Padding(10);
                    roomPanel.Tag = room;

                    // Dummy logic for availability (replace with real reservation check later)
                    bool isRoomActuallyAvailable = (room.Id % 2 == 0);
                    roomPanel.BackColor = isRoomActuallyAvailable ? Color.LightGreen : Color.LightCoral;

                    Label nameLabel = new Label();
                    nameLabel.Text = room.Name;
                    nameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    nameLabel.Location = new Point(10, 10);
                    nameLabel.AutoSize = true;

                    Label statusLabel = new Label();
                    statusLabel.Text = isRoomActuallyAvailable ? "Status: Available" : "Status: Occupied";
                    statusLabel.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                    statusLabel.Location = new Point(10, 35); // Adjusted Y
                    statusLabel.AutoSize = true;
                    statusLabel.ForeColor = isRoomActuallyAvailable ? Color.DarkGreen : Color.DarkRed;

                    Label capacityLabel = new Label();
                    capacityLabel.Text = $"Capacity: {room.Capacity}";
                    capacityLabel.Font = new Font("Segoe UI", 9);
                    capacityLabel.Location = new Point(10, 55); // Adjusted Y
                    capacityLabel.AutoSize = true;

                    Label floorLabel = new Label(); // NEW: Floor Label
                    floorLabel.Text = $"Floor: {room.Floor}";
                    floorLabel.Font = new Font("Segoe UI", 9);
                    floorLabel.Location = new Point(10, 75); // Adjusted Y
                    floorLabel.AutoSize = true;

                    string featuresText = "";
                    if (room.HasProjector) featuresText += "Projector, ";
                    if (room.HasWhiteboard) featuresText += "Whiteboard, ";
                    if (room.HasTV) featuresText += "TV, "; // NEW: TV
                    if (room.HasAirConditioning) featuresText += "A/C, "; // NEW: Air Conditioning
                    if (room.HasSoundSystem) featuresText += "Sound System, "; // NEW: Sound System

                    // Remove trailing comma and space
                    featuresText = featuresText.TrimEnd(',', ' ');
                    if (string.IsNullOrEmpty(featuresText)) featuresText = "None";

                    Label featuresLabel = new Label();
                    featuresLabel.Text = $"Features: {featuresText}";
                    featuresLabel.Font = new Font("Segoe UI", 9);
                    featuresLabel.Location = new Point(10, 95); // Adjusted Y
                    featuresLabel.AutoSize = true;
                    featuresLabel.MaximumSize = new Size(roomPanel.Width - 20, 0); // Allow text to wrap

                    Label computersLabel = new Label(); // NEW: Computers Label
                    if (room.NumberOfComputers > 0)
                    {
                        computersLabel.Text = $"Computers: {room.NumberOfComputers}";
                        computersLabel.Font = new Font("Segoe UI", 9);
                        computersLabel.Location = new Point(10, 145); // Adjusted Y
                        computersLabel.AutoSize = true;
                    }


                    roomPanel.Controls.Add(nameLabel);
                    roomPanel.Controls.Add(statusLabel);
                    roomPanel.Controls.Add(capacityLabel);
                    roomPanel.Controls.Add(floorLabel); // ADDED
                    roomPanel.Controls.Add(featuresLabel);
                    if (room.NumberOfComputers > 0)
                    {
                        roomPanel.Controls.Add(computersLabel); // ADDED if applicable
                    }

                    roomPanel.Click += (sender, e) => RoomPanel_Click(sender, e, room);

                    flowLayoutPanelRooms.Controls.Add(roomPanel);
                }
            }
            else
            {
                MessageBox.Show("Error: FlowLayoutPanel named 'flowLayoutPanelRooms' NOT FOUND in Available_Rooms. Please check its name in the designer.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RoomPanel_Click(object sender, EventArgs e, Room clickedRoom)
        {
            MessageBox.Show($"Clicked on Room: {clickedRoom.Name}\nCapacity: {clickedRoom.Capacity}\nFloor: {clickedRoom.Floor}", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Existing navigation and other methods below ---
        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = _serviceProvider.GetRequiredService<Form10>();
            form10.Show();
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
            Form13 form13 = _serviceProvider.GetRequiredService<Form13>();
            form13.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = _serviceProvider.GetRequiredService<Form9>();
            form9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = _serviceProvider.GetRequiredService<Form11>();
            form11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e) { /* Logic here */ }
        private void textBox15_TextChanged(object sender, EventArgs e) { /* Logic here */ }
    }
}
