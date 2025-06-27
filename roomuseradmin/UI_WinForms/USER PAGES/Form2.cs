// In UI_WinForms/Form2.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // For .Any(), .FirstOrDefault(), .AsQueryable()
using System.Text;
using System.Threading.Tasks; // For async/await
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // Required for IServiceProvider
using Iskedular.Core.Services; // Required for IRoomService
using Iskedular.Models; // Required for Room model

namespace UI_WinForms
{
    public partial class Form2 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IRoomService _roomService;
        private List<Room> _allRooms = new List<Room>(); // Cache all rooms for filtering

        // MODIFIED: Constructor now accepts IRoomService and IServiceProvider
        public Form2(IRoomService roomService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _roomService = roomService;
            _serviceProvider = serviceProvider;

            // Form_Load is already subscribed in designer.cs: Load += Form2_Load;

            // Hook up filter checkboxes by finding them dynamically (safer if names vary slightly)
            // IMPORTANT: Verify these CheckBox names in your Form2.Designer.cs
            // If the names are like checkBox1, checkBox2, etc., update these strings.
            if (this.Controls.Find("chkProjector", true).FirstOrDefault() is CheckBox chkProjectorControl)
                chkProjectorControl.CheckedChanged += FilterCheckbox_CheckedChanged;
            else if (this.Controls.Find("checkBox1", true).FirstOrDefault() is CheckBox genericChk1) // Fallback for generic name
                genericChk1.CheckedChanged += FilterCheckbox_CheckedChanged;


            if (this.Controls.Find("chkWhiteboard", true).FirstOrDefault() is CheckBox chkWhiteboardControl)
                chkWhiteboardControl.CheckedChanged += FilterCheckbox_CheckedChanged;
            else if (this.Controls.Find("checkBox2", true).FirstOrDefault() is CheckBox genericChk2) // Fallback for generic name
                genericChk2.CheckedChanged += FilterCheckbox_CheckedChanged;


            if (this.Controls.Find("chkComputerLab", true).FirstOrDefault() is CheckBox chkComputerLabControl)
                chkComputerLabControl.CheckedChanged += FilterCheckbox_CheckedChanged;
            else if (this.Controls.Find("checkBox3", true).FirstOrDefault() is CheckBox genericChk3) // This might be the source of "checkBox3_CheckedChanged" error
                genericChk3.CheckedChanged += FilterCheckbox_CheckedChanged;


            if (this.Controls.Find("chkTV", true).FirstOrDefault() is CheckBox chkTVControl)
                chkTVControl.CheckedChanged += FilterCheckbox_CheckedChanged;
            if (this.Controls.Find("chkAirConditioning", true).FirstOrDefault() is CheckBox chkAirConditioningControl)
                chkAirConditioningControl.CheckedChanged += FilterCheckbox_CheckedChanged;

            // Hook up "Apply Filters" and "Clear Filters" buttons if they exist
            if (this.Controls.Find("btnApplyFilters", true).FirstOrDefault() is Button btnApplyFiltersControl)
                btnApplyFiltersControl.Click += btnApplyFilters_Click;
            if (this.Controls.Find("btnClearFilters", true).FirstOrDefault() is Button btnClearFiltersControl)
                btnClearFiltersControl.Click += btnClearFilters_Click;

            // Setup room panel click handlers will be called in Form2_Load
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await LoadAllRoomsInitially();
            SetupRoomPanelClickHandlers(); // Setup click handlers after rooms are loaded
            await ApplyFilters(); // Apply any default filters or load all rooms initially
        }

        /// <summary>
        /// Loads all rooms from the database once and caches them.
        /// </summary>
        private async Task LoadAllRoomsInitially()
        {
            try
            {
                _allRooms = await _roomService.GetAllRoomsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the full exception details in a real application
            }
        }

        /// <summary>
        /// Applies filters to the cached list of all rooms and updates txtRoomDetails.
        /// It also visually highlights matching rooms on the map (if implemented).
        /// </summary>
        private async Task ApplyFilters()
        {
            // Get filter states - use Find to get the actual checkbox control and its checked state
            bool? projectorFilter = (this.Controls.Find("chkProjector", true).FirstOrDefault() as CheckBox)?.Checked ?? false;
            bool? whiteboardFilter = (this.Controls.Find("chkWhiteboard", true).FirstOrDefault() as CheckBox)?.Checked ?? false;
            bool? computerLabFilter = (this.Controls.Find("chkComputerLab", true).FirstOrDefault() as CheckBox)?.Checked ?? false;
            // Fallback to generic names if specific ones aren't found, based on error 'checkBox3_CheckedChanged'
            if (!(this.Controls.Find("chkProjector", true).FirstOrDefault() is CheckBox) && (this.Controls.Find("checkBox1", true).FirstOrDefault() is CheckBox genericChk1)) projectorFilter = genericChk1.Checked;
            if (!(this.Controls.Find("chkWhiteboard", true).FirstOrDefault() is CheckBox) && (this.Controls.Find("checkBox2", true).FirstOrDefault() is CheckBox genericChk2)) whiteboardFilter = genericChk2.Checked;
            if (!(this.Controls.Find("chkComputerLab", true).FirstOrDefault() is CheckBox) && (this.Controls.Find("checkBox3", true).FirstOrDefault() is CheckBox genericChk3)) computerLabFilter = genericChk3.Checked;


            bool? tvFilter = (this.Controls.Find("chkTV", true).FirstOrDefault() as CheckBox)?.Checked ?? false;
            bool? acFilter = (this.Controls.Find("chkAirConditioning", true).FirstOrDefault() as CheckBox)?.Checked ?? false;

            // Filter the cached list of rooms
            // Only apply filter if checkbox is checked (i.e., Value is true)
            var filteredRooms = _allRooms.AsQueryable();

            if (projectorFilter.Value)
            {
                filteredRooms = filteredRooms.Where(r => r.HasProjector);
            }
            if (whiteboardFilter.Value)
            {
                filteredRooms = filteredRooms.Where(r => r.HasWhiteboard);
            }
            if (computerLabFilter.Value)
            {
                filteredRooms = filteredRooms.Where(r => r.IsComputerLab);
            }
            if (tvFilter.Value)
            {
                filteredRooms = filteredRooms.Where(r => r.HasTV);
            }
            if (acFilter.Value)
            {
                filteredRooms = filteredRooms.Where(r => r.HasAirConditioning);
            }

            // --- Update txtRoomDetails with a list of matching rooms ---
            // IMPORTANT: Ensure you have a TextBox named txtRoomDetails in your Form2 designer!
            if (this.Controls.Find("txtRoomDetails", true).FirstOrDefault() is TextBox txtRoomDetails)
            {
                txtRoomDetails.Text = ""; // Clear previous details

                if (filteredRooms.Any())
                {
                    txtRoomDetails.Text = "Matching Rooms (filtered):\r\n";
                    foreach (var room in filteredRooms)
                    {
                        txtRoomDetails.Text += $"- {room.Name} (Capacity: {room.Capacity}, Projector: {room.HasProjector}, Whiteboard: {room.HasWhiteboard}, TV: {room.HasTV}, ComLab: {room.IsComputerLab}, A/C: {room.HasAirConditioning}){Environment.NewLine}";
                    }
                }
                else
                {
                    txtRoomDetails.Text = "No rooms match the selected filters.";
                }
            }
            else
            {
                MessageBox.Show("txtRoomDetails TextBox control not found on Form2. Please add it in the designer.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Common handler for all filter checkboxes
        private async void FilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        // Handler for "Apply Filters" button (if you use one instead of immediate filtering)
        private async void btnApplyFilters_Click(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        // Handler for "Clear Filters" button
        private async void btnClearFilters_Click(object sender, EventArgs e)
        {
            // IMPORTANT: Ensure these CheckBox controls exist in your designer!
            // Using Find for robustness
            if (this.Controls.Find("chkProjector", true).FirstOrDefault() is CheckBox chkProjectorControl) chkProjectorControl.Checked = false;
            else if (this.Controls.Find("checkBox1", true).FirstOrDefault() is CheckBox genericChk1) genericChk1.Checked = false;

            if (this.Controls.Find("chkWhiteboard", true).FirstOrDefault() is CheckBox chkWhiteboardControl) chkWhiteboardControl.Checked = false;
            else if (this.Controls.Find("checkBox2", true).FirstOrDefault() is CheckBox genericChk2) genericChk2.Checked = false;

            if (this.Controls.Find("chkComputerLab", true).FirstOrDefault() is CheckBox chkComputerLabControl) chkComputerLabControl.Checked = false;
            else if (this.Controls.Find("checkBox3", true).FirstOrDefault() is CheckBox genericChk3) genericChk3.Checked = false;


            if (this.Controls.Find("chkTV", true).FirstOrDefault() is CheckBox chkTVControl) chkTVControl.Checked = false;
            if (this.Controls.Find("chkAirConditioning", true).FirstOrDefault() is CheckBox chkAirConditioningControl) chkAirConditioningControl.Checked = false;

            await ApplyFilters(); // Reload without filters (which means all rooms)
        }

        /// <summary>
        /// Sets up click handlers for the room panels on the map.
        /// This method needs to be populated with the EXACT NAMES of your Panel controls.
        /// </summary>
        private void SetupRoomPanelClickHandlers()
        {
            List<Control> roomPanels = new List<Control>();

            // --- FIRST FLOOR ROOMS (Rooms 101-106) ---
            // Based on your screenshot, these are the "A 101" to "A 106" rooms.
            // Assuming their panel names are like 'panelA101', 'panelA102', etc.
            // IMPORTANT: Verify these names in Form2.Designer.cs and update them if different!
            for (int i = 1; i <= 6; i++)
            {
                Control? panel100 = this.Controls.Find($"panelA10{i}", true).FirstOrDefault(); // Guess: panelA101, panelA102...
                if (panel100 == null) panel100 = this.Controls.Find($"pnlA10{i}", true).FirstOrDefault(); // Alternative guess
                if (panel100 != null) roomPanels.Add(panel100);
            }

            // --- SECOND FLOOR ROOMS (Rooms 201-206) ---
            // Based on your screenshot, these are the "A 201" to "A 206" rooms.
            // Assuming their panel names are like 'panelA201', 'panelA202', etc.
            // IMPORTANT: Verify these names in Form2.Designer.cs and update them if different!
            for (int i = 1; i <= 6; i++)
            {
                Control? panel200 = this.Controls.Find($"panelA20{i}", true).FirstOrDefault(); // Guess: panelA201, panelA202...
                if (panel200 == null) panel200 = this.Controls.Find($"pnlA20{i}", true).FirstOrDefault(); // Alternative guess
                if (panel200 != null) roomPanels.Add(panel200);
            }

            // --- SPECIAL ROOMS ---
            // GUESSING THE NAMES - YOU MUST VERIFY THESE IN Form2.Designer.cs
            // The names used in the switch statement in RoomPanel_Click must match these.
            Control? pnlComLab = this.Controls.Find("pnlComLab", true).FirstOrDefault(); // Guess for "COMLAB"
            if (pnlComLab != null) roomPanels.Add(pnlComLab);

            Control? pnlAVR = this.Controls.Find("pnlAVR", true).FirstOrDefault(); // Guess for "AVR"
            if (pnlAVR != null) roomPanels.Add(pnlAVR);

            Control? pnlGymnasium = this.Controls.Find("pnlGymnasium", true).FirstOrDefault(); // Guess for "Gymnasium"
            if (pnlGymnasium != null) roomPanels.Add(pnlGymnasium);

            Control? pnlGuardHouse = this.Controls.Find("pnlGuardHouse", true).FirstOrDefault(); // Guess for "Guard House"
            if (pnlGuardHouse != null) roomPanels.Add(pnlGuardHouse);

            Control? pnlRothRoom1 = this.Controls.Find("pnlRothRoom1", true).FirstOrDefault(); // Guess for "Roth Room #1"
            if (pnlRothRoom1 != null) roomPanels.Add(pnlRothRoom1);

            Control? pnlRothRoom2 = this.Controls.Find("pnlRothRoom2", true).FirstOrDefault(); // Guess for "Roth Room #2"
            if (pnlRothRoom2 != null) roomPanels.Add(pnlRothRoom2);


            // Attach the click handler to each identified room panel and its nested controls
            foreach (Control panel in roomPanels)
            {
                panel.Click += RoomPanel_Click;
                // If panels contain labels or other controls, their clicks might not bubble up to the panel.
                // To ensure clicks on nested controls also trigger the panel's logic:
                foreach (Control nestedControl in panel.Controls)
                {
                    nestedControl.Click += RoomPanel_Click;
                }
            }
        }


        /// <summary>
        /// Handles clicks on room panels to display details of the clicked room.
        /// </summary>
        private void RoomPanel_Click(object? sender, EventArgs e)
        {
            Control? clickedControl = sender as Control;
            Panel? clickedPanel = clickedControl as Panel;

            // If the clicked control is not a panel, try to find its parent panel that represents a room
            if (clickedPanel == null && clickedControl != null)
            {
                clickedPanel = clickedControl.Parent as Panel;
            }

            if (clickedPanel != null)
            {
                string displayRoomName = "";
                // Map the Panel's Name (from designer) to the Room.Name (from seeded data)
                // IMPORTANT: Ensure these case strings match your actual Panel names in Designer.cs
                // and the 'displayRoomName' matches the 'Name' property you seeded in ApplicationDbContext.cs
                switch (clickedPanel.Name)
                {
                    // First Floor Rooms
                    case "panelA101": displayRoomName = "Room 101"; break;
                    case "panelA102": displayRoomName = "Room 102"; break;
                    case "panelA103": displayRoomName = "Room 103"; break;
                    case "panelA104": displayRoomName = "Room 104"; break;
                    case "panelA105": displayRoomName = "Room 105"; break;
                    case "panelA106": displayRoomName = "Room 106"; break;

                    // Second Floor Rooms
                    case "panelA201": displayRoomName = "Room 201"; break;
                    case "panelA202": displayRoomName = "Room 202"; break;
                    case "panelA203": displayRoomName = "Room 203"; break;
                    case "panelA204": displayRoomName = "Room 204"; break;
                    case "panelA205": displayRoomName = "Room 205"; break;
                    case "panelA206": displayRoomName = "Room 206"; break;

                    // Special Rooms - IMPORTANT: Verify these panel names match your designer
                    // and the displayRoomName matches your seeded room names.
                    case "pnlComLab": displayRoomName = "Computer Laboratory"; break;
                    case "pnlAVR": displayRoomName = "Audio Visual Room"; break;
                    case "pnlGymnasium": displayRoomName = "Gymnasium"; break; // From your image/seeded data
                    case "pnlGuardHouse": displayRoomName = "Guard House"; break; // From your image/seeded data
                    case "pnlRothRoom1": displayRoomName = "Roth Room #1"; break; // From your image/seeded data
                    case "pnlRothRoom2": displayRoomName = "Roth Room #2"; break; // From your image/seeded data

                    default:
                        // Fallback: This case should ideally not be hit if all panels are covered.
                        // You might log a warning here if an unexpected panel name is clicked.
                        txtRoomDetails.Text = $"Clicked on an unrecognized room panel: {clickedPanel.Name}.";
                        return; // Exit as we can't find details for this panel
                }

                Room? selectedRoom = _allRooms.FirstOrDefault(r => r.Name == displayRoomName);

                if (this.Controls.Find("txtRoomDetails", true).FirstOrDefault() is TextBox txtRoomDetailsControl)
                {
                    if (selectedRoom != null)
                    {
                        txtRoomDetailsControl.Text = $"Selected Room: {selectedRoom.Name}{Environment.NewLine}";
                        txtRoomDetailsControl.Text += $"Capacity: {selectedRoom.Capacity}{Environment.NewLine}";
                        txtRoomDetailsControl.Text += $"Features: ";
                        List<string> features = new List<string>();
                        if (selectedRoom.HasProjector) features.Add("Projector");
                        if (selectedRoom.HasWhiteboard) features.Add("Whiteboard");
                        if (selectedRoom.HasTV) features.Add("TV");
                        if (selectedRoom.IsComputerLab) features.Add("Computer Lab");
                        if (selectedRoom.HasAirConditioning) features.Add("Air Conditioning");
                        txtRoomDetailsControl.Text += (features.Any() ? string.Join(", ", features) : "None") + Environment.NewLine;
                        // Add more details as needed
                    }
                    else
                    {
                        txtRoomDetailsControl.Text = $"Room details not found in database for '{displayRoomName}'. Verify seeded data.";
                    }
                }
                else
                {
                    MessageBox.Show("txtRoomDetails TextBox control not found on Form2. Please add it in the designer.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // --- Navigation Button Click Handlers (from your existing Form2.cs) ---

        private void button5_Click(object sender, EventArgs e) // Home button
        {
            Form1 homeForm = _serviceProvider.GetRequiredService<Form1>();
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e) // Rooms button (stay on this form)
        {
            MessageBox.Show("You are already on the Rooms screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e) // Reserve button
        {
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) // Profile button
        {
            Form4 profileForm = _serviceProvider.GetRequiredService<Form4>();
            profileForm.Show();
            this.Hide();
        }

        // --- ADDED: EMPTY STUBS FOR MISSING EVENT HANDLERS ---
        // IMPORTANT: If you had any logic inside these methods previously,
        // you MUST copy it back into these stubs from an older version of your Form2.cs!

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            // Original logic for panel13_Paint, if any, goes here.
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            // Original logic for panel14_Paint, if any, goes here.
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            // Original logic for panel22_Paint, if any, goes here.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Original logic for button3_Click, if any, goes here.
            // This might be your "Apply Filters" button if not btnApplyFilters.
            // Consider renaming button3 to btnApplyFilters in designer for clarity.
            // If it's your Apply Filters button: await ApplyFilters();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            // Original logic for textBox4_TextChanged_1, if any, goes here.
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Original logic for checkBox3_CheckedChanged, if any, goes here.
            // This is likely one of your filter checkboxes.
            // Consider renaming checkBox3 to chkComputerLab (or similar) in designer for clarity.
            // If it's a filter checkbox: await FilterCheckbox_CheckedChanged(sender, e);
        }

        // --- Other Existing Event Handlers from your Form2.cs (kept as-is) ---
        // These were already in your previous code.

        private void textBox5_TextChanged(object sender, EventArgs e) { /* Your existing logic */ }
        private void textBox3_TextChanged(object sender, EventArgs e) { /* Your existing logic */ }
        private void label1_Click_1(object sender, EventArgs e) { /* Your existing logic */ }
        private void label2_Click(object sender, EventArgs e) { /* Your existing logic */ }
        private void groupBox1_Enter(object sender, EventArgs e) { /* Your existing logic */ }
        private void label5_Click(object sender, EventArgs e) { /* Your existing logic */ }
        private void panel5_Paint(object sender, PaintEventArgs e) { /* Your existing logic */ }
        private void textBox1_TextChanged(object sender, EventArgs e) { /* Your existing logic */ }
        private void label23_Click(object sender, EventArgs e) { /* Your existing logic */ }
        private void label21_Click(object sender, EventArgs e) { /* Your existing logic */ }
        private void textBox4_TextChanged(object sender, EventArgs e) { /* Your existing logic */ } // Note: you had this and textBox4_TextChanged_1
        private void textBox8_TextChanged(object sender, EventArgs e) { /* Your existing logic */ }
        private void label1_Click(object sender, EventArgs e) { /* Original label1 click, not label1_Click_1 */ }

        private void pnlRoomA206_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA205_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA204_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA203_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRoomA203_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA202_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA201_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA106_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA105_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA104_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA103_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA102_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA101_Click(object sender, EventArgs e)
        {

        }

        private void pnlAVR_Click(object sender, EventArgs e)
        {

        }

        private void pnlComLab_Click(object sender, EventArgs e)
        {

        }

        private void pnlRoomA202_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRoomA201_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkProjector_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Add any other specific event handlers from your designer here if they exist and are not listed.
    }
}
