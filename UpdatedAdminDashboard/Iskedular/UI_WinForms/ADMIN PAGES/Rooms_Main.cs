using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // For IServiceProvider and GetRequiredService
using Iskedular.Core.Services; // For RoomService and SessionService
using Iskedular.Models; // For Room and UserRole models

namespace UI_WinForms
{
    public partial class Rooms_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly RoomService _roomService;
        private readonly SessionService _sessionService;

        // Keep your constructor that takes DI services
        public Rooms_Main(IServiceProvider serviceProvider, RoomService roomService, SessionService sessionService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = roomService;
            _sessionService = sessionService;

            // Set parents for count textboxes so they render INSIDE the colored boxes
            // This MUST be done AFTER InitializeComponent()
            textBoxTotalRoomsCount.Parent = textBox1;
            textBoxTotalRoomsCount.BringToFront(); // Ensure it's on top of textBox1

            textBoxAvailableRoomsCount.Parent = textBox2;
            textBoxAvailableRoomsCount.BringToFront(); // Ensure it's on top of textBox2

            // Also set parents for the labels (textBox9, textBox11) if they are not already child controls
            // by default when created in the designer. This makes sure they are visually contained.
            textBox9.Parent = textBox1;
            textBox9.BringToFront();

            textBox11.Parent = textBox2;
            textBox11.BringToFront();

            // Initialize DataGridView columns programmatically
            InitializeDataGridViewColumns();
        }

        private async void Rooms_Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            AdjustLayoutForFullScreen(); // Adjust layout based on actual screen size

            await LoadRoomsIntoDataGridView();
            await UpdateRoomCounts();
        }

        private void AdjustLayoutForFullScreen()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // --- 1. Top Navigation Bar ---
            pictureBox1.Width = formWidth + 2; // Stretch red bar to full width

            int buttonSpacing = 15; // Space between buttons
            int rightMargin = 30; // Margin from the right edge of the form

            // Calculate X positions for buttons starting from the rightmost
            button4.Location = new Point(formWidth - button4.Width - rightMargin, button4.Location.Y); // Profile/Accounts
            button3.Location = new Point(button4.Location.X - button3.Width - buttonSpacing, button3.Location.Y); // Requests
            button5.Location = new Point(button3.Location.X - button5.Width - buttonSpacing, button5.Location.Y); // Dashboard
            button1.Location = new Point(button5.Location.X - button1.Width - buttonSpacing, button1.Location.Y); // Rooms
            button2.Location = new Point(button1.Location.X - button2.Width - buttonSpacing, button2.Location.Y); // Bookings

            // --- 2. Main Content Area ---

            // textBox5 (Manage Rooms title) - Center horizontally
            textBox5.Location = new Point((formWidth - textBox5.Width) / 2, 118); // Fixed Y, dynamically centered X

            // Total Rooms and Available Rooms boxes (textBox1 and textBox2)
            int boxWidth = textBox1.Width;
            int boxHeight = textBox1.Height;
            int gapBetweenBoxes = 50; // Space between the yellow and orange boxes

            int totalBoxesGroupWidth = (boxWidth * 2) + gapBetweenBoxes;
            int startXForBoxesGroup = (formWidth - totalBoxesGroupWidth) / 2;

            textBox1.Location = new Point(startXForBoxesGroup, 158); // Yellow box (Total Rooms)
            textBox2.Location = new Point(startXForBoxesGroup + boxWidth + gapBetweenBoxes, 158); // Orange box (Available Rooms)

            // Adjust positions of child controls within their parent boxes
            // The coordinates here are RELATIVE to the PARENT control's top-left corner
            textBox9.Location = new Point((textBox1.Width - textBox9.Width) / 2, 24); // Centered label in yellow box
            textBoxTotalRoomsCount.Location = new Point((textBox1.Width - textBoxTotalRoomsCount.Width) / 2, 70); // Centered count in yellow box

            textBox11.Location = new Point((textBox2.Width - textBox11.Width) / 2, 24); // Centered label in orange box
            textBoxAvailableRoomsCount.Location = new Point((textBox2.Width - textBoxAvailableRoomsCount.Width) / 2, 70); // Centered count in orange box


            // buttonAddNewRoom - Position to the right, above DataGridView
            int buttonAddNewRoomY = Math.Max(textBox1.Bottom, textBox2.Bottom) + 20; // 20px below the lowest count box
            int buttonAddNewRoomX = formWidth - buttonAddNewRoom.Width - (int)(formWidth * 0.05); // 5% margin from right edge
            buttonAddNewRoom.Location = new Point(buttonAddNewRoomX, buttonAddNewRoomY);


            // dataGridViewRooms
            int dataGridViewTopY = buttonAddNewRoomY + buttonAddNewRoom.Height + 20; // 20px below the Add New Room button
            int dataGridViewLeftRightPadding = (int)(formWidth * 0.05); // 5% padding on left and right
            int dataGridViewBottomPadding = 30; // 30px padding at the bottom

            dataGridViewRooms.Location = new Point(dataGridViewLeftRightPadding, dataGridViewTopY);
            dataGridViewRooms.Size = new Size(formWidth - (2 * dataGridViewLeftRightPadding),
                                             formHeight - dataGridViewTopY - dataGridViewBottomPadding);

            // Ensure minimum height for DataGridView
            if (dataGridViewRooms.Height < 150) // Adjust minimum height as needed
            {
                dataGridViewRooms.Height = 150;
            }
        }

        // Optional: If you want the layout to readjust if the user resizes the form after it's shown
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState != FormWindowState.Minimized)
            {
                AdjustLayoutForFullScreen();
            }
        }

        private void InitializeDataGridViewColumns()
        {
            dataGridViewRooms.AutoGenerateColumns = false; // Important: We are manually defining columns
            dataGridViewRooms.Columns.Clear(); // Clear existing columns if any from designer

            // Add columns as per your original request and current setup
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "RoomId", // Added for internal use, can be hidden
                HeaderText = "ID",
                DataPropertyName = "Id", // Assuming your Room model has an 'Id' property
                ReadOnly = true,
                Visible = false // Hide the ID column
            });
            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "RoomName",
                HeaderText = "Room Name",
                DataPropertyName = "Name", // Assuming Room model has 'Name' property
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Capacity",
                HeaderText = "Capacity",
                DataPropertyName = "Capacity",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Floor",
                HeaderText = "Floor",
                DataPropertyName = "Floor",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "HasProjector",
                HeaderText = "Projector",
                DataPropertyName = "HasProjector",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "HasWhiteboard",
                HeaderText = "Whiteboard",
                DataPropertyName = "HasWhiteboard",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "HasTV",
                HeaderText = "TV",
                DataPropertyName = "HasTV",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "HasAirConditioning",
                HeaderText = "A/C",
                DataPropertyName = "HasAirConditioning",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "HasSoundSystem",
                HeaderText = "Sound Sys.",
                DataPropertyName = "HasSoundSystem",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewRooms.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NumberOfComputers",
                HeaderText = "Computers",
                DataPropertyName = "NumberOfComputers",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Add Edit and Delete buttons
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Width = 70;
            // Retaining this line assuming SessionService and UserRole are correctly defined in your models/services
            // If this line causes errors, you might need to comment it out or ensure these types are available.
            editButtonColumn.Visible = _sessionService.LoggedInUser?.Role == UserRole.Admin;
            dataGridViewRooms.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 70;
            // Retaining this line assuming SessionService and UserRole are correctly defined in your models/services
            // If this line causes errors, you might need to comment it out or ensure these types are available.
            deleteButtonColumn.Visible = _sessionService.LoggedInUser?.Role == UserRole.Admin;
            dataGridViewRooms.Columns.Add(deleteButtonColumn);

            // Wire up the CellContentClick event
            dataGridViewRooms.CellContentClick += DataGridViewRooms_CellContentClick;

            // Auto-size columns to fit content and allow user resizing
            dataGridViewRooms.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewRooms.AllowUserToResizeColumns = true;
        }


        public async Task LoadRoomsIntoDataGridView()
        {
            try
            {
                var rooms = await _roomService.GetAllRoomsAsync();
                dataGridViewRooms.DataSource = rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateRoomCounts()
        {
            try
            {
                var allRooms = await _roomService.GetAllRoomsAsync();
                textBoxTotalRoomsCount.Text = allRooms.Count.ToString();

                // DUMMY LOGIC FOR AVAILABLE ROOMS TO AVOID CS1061 ERROR on 'IsAvailable'
                // This will count 0 for available rooms or you can change it to a fixed number.
                // You need to implement the actual logic for 'available rooms' in your RoomService or Room model.
                int availableRoomsCount = 0; // Placeholder: No assumption on 'IsAvailable' property
                // If you want to temporarily show the total count for available too, uncomment the line below:
                // int availableRoomsCount = allRooms.Count;

                textBoxAvailableRoomsCount.Text = availableRoomsCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridViewRooms.Rows[e.RowIndex];
            var room = row.DataBoundItem as Room; // Cast to your Room model

            if (room == null) return; // Should not happen if data binding is correct

            if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "EditButton")
            {
                FormAddEditRoom editRoomForm = _serviceProvider.GetRequiredService<FormAddEditRoom>();
                // This is the crucial line: now calling your existing SetRoom method!
                editRoomForm.SetRoom(room);

                if (editRoomForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadRoomsIntoDataGridView();
                    await UpdateRoomCounts();
                }
            }
            else if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete room '{room.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        bool deleted = await _roomService.DeleteRoomAsync(room.Id); // Assuming Room has an 'Id' property
                        if (deleted)
                        {
                            MessageBox.Show($"Room '{room.Name}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadRoomsIntoDataGridView();
                            await UpdateRoomCounts();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete room '{room.Name}'. It might not exist or there was a database error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            FormAddEditRoom addRoomForm = _serviceProvider.GetRequiredService<FormAddEditRoom>();
            // This is the crucial line: calling your existing SetRoom method with null for new room!
            addRoomForm.SetRoom(null);

            if (addRoomForm.ShowDialog() == DialogResult.OK)
            {
                await LoadRoomsIntoDataGridView();
                await UpdateRoomCounts();
            }
        }

        // --- Navigation Buttons (using DI) ---

        private void textBox1_Click(object sender, EventArgs e)
        {
            Total_Rooms totalRoomsForm = _serviceProvider.GetRequiredService<Total_Rooms>();
            totalRoomsForm.Show();
            this.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Available_Rooms availableRoomsForm = _serviceProvider.GetRequiredService<Available_Rooms>();
            availableRoomsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // Bookings button
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>();
            adminBookingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // Rooms button (current page)
        {
            // If already on Rooms page, maybe just refresh
            MessageBox.Show("Rooms button clicked! (Already on this page, refreshing...)");
            LoadRoomsIntoDataGridView();
            UpdateRoomCounts();
        }

        private void button5_Click(object sender, EventArgs e) // Dashboard button
        {
            Admin_Dashboard adminDashboardForm = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            adminDashboardForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // Requests button
        {
            PendingRequest pendingRequestForm = _serviceProvider.GetRequiredService<PendingRequest>();
            pendingRequestForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) // Profile/Accounts button (assuming Form18)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>();
            form18.Show();
            this.Hide();
        }

        // Other event handlers you might have
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic for tableLayoutPanel1_Paint is here.
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox11_TextChanged is here.
        }
    }
}