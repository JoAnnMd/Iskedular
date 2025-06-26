using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Core.Services; // RoomService was added.
using System.Linq; // For LINQ operations on DataGridView data.
using System.Threading.Tasks; // For async operations.
using Iskedular.Models; // For Room model and UserRole.

namespace UI_WinForms
{
    public partial class Form13 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService; // RoomService was injected.
        private readonly SessionService _sessionService; // SessionService was injected to check user role.

        // The constructor was updated to receive IServiceProvider, RoomService, and SessionService.
        public Form13(IServiceProvider serviceProvider, RoomService roomService, SessionService sessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = roomService; // RoomService was assigned.
            _sessionService = sessionService; // SessionService was assigned.

            // DataGridView column generation was handled in code.
            InitializeDataGridView();
        }

        private async void Form13_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            // Rooms were loaded into the DataGridView when the form loads.
            await LoadRoomsIntoDataGridView();

            // The total and available room counts were updated.
            await UpdateRoomCounts();
        }

        // This method was added to initialize the DataGridView columns.
        private void InitializeDataGridView()
        {
            // Assuming your DataGridView is named 'dataGridViewRooms'
            // If you have a different name, please update this.
            if (this.Controls.Find("dataGridViewRooms", true).FirstOrDefault() is DataGridView dataGridViewRooms)
            {
                dataGridViewRooms.AutoGenerateColumns = false; // Prevents auto-generation of columns from Room object.
                dataGridViewRooms.Columns.Clear(); // Clears any existing columns from designer.

                // Room Name column was added.
                dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "RoomName",
                    HeaderText = "Room Name",
                    DataPropertyName = "Name", // Binds to the 'Name' property of the Room object.
                    ReadOnly = true, // Not editable directly in this view, will use a dedicated edit form.
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Auto-size to fill available space.
                });

                // Capacity column was added.
                dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Capacity",
                    HeaderText = "Capacity",
                    DataPropertyName = "Capacity",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells // Auto-size to fit content.
                });

                // Floor column was added. (NEW)
                dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Floor",
                    HeaderText = "Floor",
                    DataPropertyName = "Floor",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // HasProjector column was added (as CheckBox).
                dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    Name = "HasProjector",
                    HeaderText = "Projector",
                    DataPropertyName = "HasProjector",
                    ReadOnly = true, // Read-only checkbox.
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // HasWhiteboard column was added (as CheckBox).
                dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    Name = "HasWhiteboard",
                    HeaderText = "Whiteboard",
                    DataPropertyName = "HasWhiteboard",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // HasTV column was added (as CheckBox). (NEW)
                dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    Name = "HasTV",
                    HeaderText = "TV",
                    DataPropertyName = "HasTV",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // HasAirConditioning column was added (as CheckBox). (NEW)
                dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    Name = "HasAirConditioning",
                    HeaderText = "A/C",
                    DataPropertyName = "HasAirConditioning",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // HasSoundSystem column was added (as CheckBox). (NEW)
                dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    Name = "HasSoundSystem",
                    HeaderText = "Sound Sys.",
                    DataPropertyName = "HasSoundSystem",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

                // NumberOfComputers column was added. (NEW)
                dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "NumberOfComputers",
                    HeaderText = "Computers",
                    DataPropertyName = "NumberOfComputers",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });


                // Action (Edit) Button Column was added.
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "EditButton";
                editButtonColumn.HeaderText = "Edit";
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true; // Displays "Edit" on all buttons.
                editButtonColumn.Width = 70; // Fixed width for the button.
                editButtonColumn.Visible = _sessionService.LoggedInUser?.Role == UserRole.Admin; // Only visible if admin.
                dataGridViewRooms.Columns.Add(editButtonColumn);

                // Action (Delete) Button Column was added.
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteButton";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true; // Displays "Delete" on all buttons.
                deleteButtonColumn.Width = 70; // Fixed width for the button.
                deleteButtonColumn.Visible = _sessionService.LoggedInUser?.Role == UserRole.Admin; // Only visible if admin.
                dataGridViewRooms.Columns.Add(deleteButtonColumn);

                // Event handler for button clicks within the DataGridView was attached.
                dataGridViewRooms.CellContentClick += DataGridViewRooms_CellContentClick;
            }
            else
            {
                MessageBox.Show("Error: DataGridView named 'dataGridViewRooms' not found. Please add it to the form or update the code to match your layout control.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method was added to load rooms into the DataGridView.
        public async Task LoadRoomsIntoDataGridView()
        {
            if (this.Controls.Find("dataGridViewRooms", true).FirstOrDefault() is DataGridView dataGridViewRooms)
            {
                var rooms = await _roomService.GetAllRoomsAsync();
                dataGridViewRooms.DataSource = rooms; // DataGridView was bound directly to the list of rooms.
                dataGridViewRooms.Refresh(); // Force refresh
                dataGridViewRooms.Invalidate(); // Force redraw
            }
            else
            {
                MessageBox.Show("Error: DataGridView named 'dataGridViewRooms' not found within LoadRoomsIntoDataGridView. Check designer.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method was added to update the total and available room counts.
        private async Task UpdateRoomCounts()
        {
            var allRooms = await _roomService.GetAllRoomsAsync();
            // Assuming you have TextBoxes named textBoxTotalRoomsCount and textBoxAvailableRoomsCount
            // These would display the counts.
            if (this.Controls.Find("textBoxTotalRoomsCount", true).FirstOrDefault() is TextBox totalRoomsCountTextBox)
            {
                totalRoomsCountTextBox.Text = allRooms.Count.ToString();
            }
            // For available rooms, you'd need a more complex query involving reservations.
            // For now, let's use the dummy logic (even ID) for the count in the UI.
            int availableRoomsCount = allRooms.Count(r => r.Id % 2 == 0); // DUMMY LOGIC
            if (this.Controls.Find("textBoxAvailableRoomsCount", true).FirstOrDefault() is TextBox availableRoomsCountTextBox)
            {
                availableRoomsCountTextBox.Text = availableRoomsCount.ToString();
            }
        }

        // This method was added to handle clicks on buttons within the DataGridView.
        private async void DataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignores header clicks.

            if (this.Controls.Find("dataGridViewRooms", true).FirstOrDefault() is DataGridView dataGridViewRooms)
            {
                // The clicked row was retrieved.
                var row = dataGridViewRooms.Rows[e.RowIndex];
                // The Room object associated with the row was retrieved from its DataBoundItem.
                var room = row.DataBoundItem as Room;

                if (room == null) return; // If for some reason the room object is null, exit.

                // If the "Edit" button column was clicked.
                if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    FormAddEditRoom editRoomForm = _serviceProvider.GetRequiredService<FormAddEditRoom>();
                    editRoomForm.SetRoom(room); // Pass the room object for editing
                    if (editRoomForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadRoomsIntoDataGridView(); // Reload after edit
                        await UpdateRoomCounts();
                    }
                }
                // If the "Delete" button column was clicked.
                else if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    // Confirmation before deleting was shown.
                    DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete room '{room.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        bool deleted = await _roomService.DeleteRoomAsync(room.Id);
                        if (deleted)
                        {
                            MessageBox.Show($"Room '{room.Name}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadRoomsIntoDataGridView(); // DataGridView was reloaded after deletion.
                            await UpdateRoomCounts(); // Counts were updated.
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete room '{room.Name}'. It might not exist or there was a database error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // The button for "Add New Room" was identified.
        // Assuming you have a button named 'buttonAddNewRoom'
        private async void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            FormAddEditRoom addRoomForm = _serviceProvider.GetRequiredService<FormAddEditRoom>();
            addRoomForm.SetRoom(null); // Indicate adding a new room
            if (addRoomForm.ShowDialog() == DialogResult.OK)
            {
                await LoadRoomsIntoDataGridView(); // Reload after add
                await UpdateRoomCounts();
            }
        }

        // --- Existing navigation and other methods from your Form13.cs ---
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic for tableLayoutPanel1_Paint is here.
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox11_TextChanged is here.
        }

        // The textBox1_Click event was configured to navigate to Form10 (Total Rooms).
        private void textBox1_Click(object sender, EventArgs e)
        {
            Form10 form10 = _serviceProvider.GetRequiredService<Form10>();
            form10.Show();
            this.Hide();
        }

        // The textBox2_Click event was configured to navigate to Available Rooms.
        private void textBox2_Click(object sender, EventArgs e)
        {
            Available_Rooms availableRoomsForm = _serviceProvider.GetRequiredService<Available_Rooms>();
            availableRoomsForm.Show();
            this.Hide();
        }

        // The button2_Click event was configured to navigate to admin bookings.
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (itself).
        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = _serviceProvider.GetRequiredService<Form13>();
            form13.Show();
            this.Hide();
        }

        // The button5_Click event was configured to navigate to Form9 (Dashboard).
        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9 = _serviceProvider.GetRequiredService<Form9>();
            form9.Show();
            this.Hide();
        }

        // The button3_Click event was configured to navigate to Form11 (Requests).
        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = _serviceProvider.GetRequiredService<Form11>();
            form11.Show();
            this.Hide();
        }

        // The button4_Click event was configured to navigate to Form18 (Accounts/Profile).
        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }
    }
}
