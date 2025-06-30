using System;
using System.Drawing; // Make sure this is included
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

        public FormAddEditRoom(RoomService roomService)
        {
            InitializeComponent();
            _roomService = roomService;

            // Set up form to fill the primary screen when loaded as a dialog
            this.StartPosition = FormStartPosition.Manual; // Important for setting Bounds later
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;

            // Initially hide the standard window buttons if they were not removed by FormBorderStyle.None
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false; // Hides minimize, maximize, and close buttons
        }

        // Method to set the room for editing, or null for adding a new room.
        // This is your existing method and is crucial!
        public void SetRoom(Room? roomToEdit)
        {
            _currentRoom = roomToEdit;
            if (_currentRoom != null)
            {
                // Populate fields for editing
                labelFormTitle.Text = "Edit Room"; // Set header title
                textBoxRoomName.Text = _currentRoom.Name;
                numericUpDownCapacity.Value = _currentRoom.Capacity;
                textBoxFloor.Text = _currentRoom.Floor;
                checkBoxHasProjector.Checked = _currentRoom.HasProjector;
                checkBoxHasWhiteboard.Checked = _currentRoom.HasWhiteboard;
                checkBoxHasTV.Checked = _currentRoom.HasTV;
                checkBoxHasAirConditioning.Checked = _currentRoom.HasAirConditioning;
                checkBoxHasSoundSystem.Checked = _currentRoom.HasSoundSystem;
                numericUpDownNumberOfComputers.Value = _currentRoom.NumberOfComputers;
            }
            else
            {
                // Clear fields for adding new room
                labelFormTitle.Text = "Add New Room"; // Set header title
                textBoxRoomName.Clear();
                numericUpDownCapacity.Value = 1; // Default to a minimum capacity
                textBoxFloor.Clear();
                checkBoxHasProjector.Checked = false;
                checkBoxHasWhiteboard.Checked = false;
                checkBoxHasTV.Checked = false;
                checkBoxHasAirConditioning.Checked = false;
                checkBoxHasSoundSystem.Checked = false;
                numericUpDownNumberOfComputers.Value = 0;
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
            if (string.IsNullOrWhiteSpace(textBoxFloor.Text))
            {
                MessageBox.Show("Floor cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownNumberOfComputers.Value < 0)
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
                        Floor = textBoxFloor.Text.Trim(),
                        HasProjector = checkBoxHasProjector.Checked,
                        HasWhiteboard = checkBoxHasWhiteboard.Checked,
                        HasTV = checkBoxHasTV.Checked,
                        HasAirConditioning = checkBoxHasAirConditioning.Checked,
                        HasSoundSystem = checkBoxHasSoundSystem.Checked,
                        NumberOfComputers = (int)numericUpDownNumberOfComputers.Value
                    };
                    await _roomService.AddRoomAsync(newRoom);
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update existing room
                    _currentRoom.Name = textBoxRoomName.Text.Trim();
                    _currentRoom.Capacity = (int)numericUpDownCapacity.Value;
                    _currentRoom.Floor = textBoxFloor.Text.Trim();
                    _currentRoom.HasProjector = checkBoxHasProjector.Checked;
                    _currentRoom.HasWhiteboard = checkBoxHasWhiteboard.Checked;
                    _currentRoom.HasTV = checkBoxHasTV.Checked;
                    _currentRoom.HasAirConditioning = checkBoxHasAirConditioning.Checked;
                    _currentRoom.HasSoundSystem = checkBoxHasSoundSystem.Checked;
                    _currentRoom.NumberOfComputers = (int)numericUpDownNumberOfComputers.Value;

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
            // Position the form to cover the whole screen after it loads
            this.Bounds = Screen.PrimaryScreen!.Bounds;
            AdjustLayout(); // Adjust layout once form is sized
        }

        // Method to adjust layout of controls
        private void AdjustLayout()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Center the header title
            labelFormTitle.Location = new Point((panelHeader.Width - labelFormTitle.Width) / 2,
                                                (panelHeader.Height - labelFormTitle.Height) / 2);

            // Center the content panel
            panelContent.Location = new Point((formWidth - panelContent.Width) / 2,
                                              (formHeight - panelContent.Height) / 2);

            // Position Save and Cancel buttons below the content panel
            int buttonsTotalWidth = buttonSave.Width + buttonCancel.Width + 20; // 20px space between buttons
            int buttonsStartX = (formWidth - buttonsTotalWidth) / 2;
            int buttonsY = panelContent.Bottom + 30; // 30px below the content panel

            buttonSave.Location = new Point(buttonsStartX, buttonsY);
            buttonCancel.Location = new Point(buttonsStartX + buttonSave.Width + 20, buttonsY);
        }

        // Add a Resize event handler to adjust layout if the form is resized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState != FormWindowState.Minimized)
            {
                AdjustLayout();
            }
        }
    }
}