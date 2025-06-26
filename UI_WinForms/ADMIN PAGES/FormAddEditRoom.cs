using System;
using System.Windows.Forms;
using Iskedular.Core.Services;
using Iskedular.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace UI_WinForms
{
    public partial class FormAddEditRoom : Form
    {
        private readonly RoomService _roomService;
        private Room? _currentRoom; // Nullable: null for add, Room object for edit

        // Constructor was updated to inject RoomService.
        public FormAddEditRoom(RoomService roomService)
        {
            InitializeComponent();
            _roomService = roomService;

            // Optional: Fullscreen setup
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;
        }

        // Method to set the room for editing, or null for adding a new room.
        public void SetRoom(Room? roomToEdit)
        {
            _currentRoom = roomToEdit;
            if (_currentRoom != null)
            {
                // Populate fields for editing
                this.Text = "Edit Room"; // Set form title
                textBoxRoomName.Text = _currentRoom.Name;
                numericUpDownCapacity.Value = _currentRoom.Capacity;
                textBoxFloor.Text = _currentRoom.Floor; // NEW: Populate Floor
                checkBoxHasProjector.Checked = _currentRoom.HasProjector;
                checkBoxHasWhiteboard.Checked = _currentRoom.HasWhiteboard;
                checkBoxHasTV.Checked = _currentRoom.HasTV; // NEW: Populate HasTV
                checkBoxHasAirConditioning.Checked = _currentRoom.HasAirConditioning; // NEW: Populate HasAirConditioning
                checkBoxHasSoundSystem.Checked = _currentRoom.HasSoundSystem; // NEW: Populate HasSoundSystem
                numericUpDownNumberOfComputers.Value = _currentRoom.NumberOfComputers; // NEW: Populate NumberOfComputers
            }
            else
            {
                // Clear fields for adding new room
                this.Text = "Add New Room"; // Set form title
                textBoxRoomName.Clear();
                numericUpDownCapacity.Value = 1; // Default to a minimum capacity
                textBoxFloor.Clear(); // NEW: Clear Floor
                checkBoxHasProjector.Checked = false;
                checkBoxHasWhiteboard.Checked = false;
                checkBoxHasTV.Checked = false; // NEW: Clear HasTV
                checkBoxHasAirConditioning.Checked = false; // NEW: Clear HasAirConditioning
                checkBoxHasSoundSystem.Checked = false; // NEW: Clear HasSoundSystem
                numericUpDownNumberOfComputers.Value = 0; // NEW: Clear NumberOfComputers
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(textBoxRoomName.Text))
            {
                MessageBox.Show("Room Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownCapacity.Value <= 0)
            {
                MessageBox.Show("Capacity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFloor.Text)) // NEW: Validate Floor
            {
                MessageBox.Show("Floor cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownNumberOfComputers.Value < 0) // NEW: Validate NumberOfComputers
            {
                MessageBox.Show("Number of Computers cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                if (_currentRoom == null)
                {
                    // Add new room
                    Room newRoom = new Room
                    {
                        Name = textBoxRoomName.Text.Trim(),
                        Capacity = (int)numericUpDownCapacity.Value,
                        Floor = textBoxFloor.Text.Trim(), // NEW: Assign Floor
                        HasProjector = checkBoxHasProjector.Checked,
                        HasWhiteboard = checkBoxHasWhiteboard.Checked,
                        HasTV = checkBoxHasTV.Checked, // NEW: Assign HasTV
                        HasAirConditioning = checkBoxHasAirConditioning.Checked, // NEW: Assign HasAirConditioning
                        HasSoundSystem = checkBoxHasSoundSystem.Checked, // NEW: Assign HasSoundSystem
                        NumberOfComputers = (int)numericUpDownNumberOfComputers.Value // NEW: Assign NumberOfComputers
                    };
                    await _roomService.AddRoomAsync(newRoom);
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update existing room
                    _currentRoom.Name = textBoxRoomName.Text.Trim();
                    _currentRoom.Capacity = (int)numericUpDownCapacity.Value;
                    _currentRoom.Floor = textBoxFloor.Text.Trim(); // NEW: Assign Floor
                    _currentRoom.HasProjector = checkBoxHasProjector.Checked;
                    _currentRoom.HasWhiteboard = checkBoxHasWhiteboard.Checked;
                    _currentRoom.HasTV = checkBoxHasTV.Checked; // NEW: Assign HasTV
                    _currentRoom.HasAirConditioning = checkBoxHasAirConditioning.Checked; // NEW: Assign HasAirConditioning
                    _currentRoom.HasSoundSystem = checkBoxHasSoundSystem.Checked; // NEW: Assign HasSoundSystem
                    _currentRoom.NumberOfComputers = (int)numericUpDownNumberOfComputers.Value; // NEW: Assign NumberOfComputers

                    bool updated = await _roomService.UpdateRoomAsync(_currentRoom);
                    if (updated)
                    {
                        MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update room. Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.DialogResult = DialogResult.OK; // Set DialogResult to OK to indicate success
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Set DialogResult to Cancel
            this.Close();
        }

        private void FormAddEditRoom_Load(object sender, EventArgs e)
        {
            // Any specific load logic for FormAddEditRoom.
        }
    }
}
