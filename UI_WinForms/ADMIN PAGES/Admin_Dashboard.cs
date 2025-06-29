using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was added for DI navigation
using System.Drawing; // Added for Point and Size

namespace UI_WinForms
{
    public partial class Admin_Dashboard : Form
    {
        private readonly IServiceProvider _serviceProvider; // A field for IServiceProvider was added.

        // The constructor was updated to receive IServiceProvider from the DI container.
        public Admin_Dashboard(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form9_Load); // Ensure Load event is hooked up
            _serviceProvider = serviceProvider;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'

            // --- Dynamic Centering Logic ---
            int screenWidth = this.ClientSize.Width;
            int screenHeight = this.ClientSize.Height;

            // 1. Position and size the red header (pictureBox1) to span full width
            pictureBox1.Size = new Size(screenWidth, 89); // Maintain original height, span full width
            pictureBox1.Location = new Point(0, 0);

            // 2. Center elements within the red header (pictureBox1)
            // Logo (pictureBox4)
            pictureBox4.Location = new Point(20, (pictureBox1.Height - pictureBox4.Height) / 2); // Keep left aligned, center vertically

            // Iskedular Text (textBox4)
            textBox4.Location = new Point(pictureBox4.Right + 10, (pictureBox1.Height - textBox4.Height) / 2); // Right of logo, center vertically

            // Navigation Buttons (Bookings, Rooms, Dashboard, Requests, Accounts)
            // Calculate total width of buttons + spacing
            int buttonSpacing = 15; // Space between buttons
            int accountButtonWidth = button4.Width; // Account button is an image button
            int navButtonWidth = button2.Width; // Assuming all other nav buttons have similar width

            // Adjusted calculation for totalNavWidth to include all 5 buttons: Bookings, Rooms, Dashboard, Requests, Accounts
            // Assuming button5 (Dashboard) is 86 width, same as others based on designer.cs
            // Account button (button4) is 48 width based on designer.cs
            // Let's re-evaluate the button widths from designer:
            // button2 (Bookings): 86
            // button1 (Rooms): 86
            // button5 (Dashboard): 86
            // button3 (Requests): 86
            // button4 (Account): 48

            // Total width of text-based nav buttons
            int totalTextNavButtonsWidth = (button2.Width + button1.Width + button5.Width + button3.Width);
            // Total spacing for text-based nav buttons (3 spaces between 4 buttons)
            int totalTextNavButtonsSpacing = buttonSpacing * 3;

            // Total width of all nav elements to be right-aligned
            int totalRightNavElementsWidth = totalTextNavButtonsWidth + totalTextNavButtonsSpacing + button4.Width;

            // Starting X position for the right-aligned navigation group
            int currentRightPosition = screenWidth - 20; // 20 pixels from right edge for padding

            // Position button4 (Account) first, as it's the rightmost
            button4.Location = new Point(currentRightPosition - button4.Width, (pictureBox1.Height - button4.Height) / 2);
            currentRightPosition = button4.Left - buttonSpacing;

            // Position button3 (Requests)
            button3.Location = new Point(currentRightPosition - button3.Width, (pictureBox1.Height - button3.Height) / 2);
            currentRightPosition = button3.Left - buttonSpacing;

            // Position button5 (Dashboard)
            button5.Location = new Point(currentRightPosition - button5.Width, (pictureBox1.Height - button5.Height) / 2);
            currentRightPosition = button5.Left - buttonSpacing;

            // Position button1 (Rooms)
            button1.Location = new Point(currentRightPosition - button1.Width, (pictureBox1.Height - button1.Height) / 2);
            currentRightPosition = button1.Left - buttonSpacing;

            // Position button2 (Bookings) - this will be the leftmost of the nav group
            button2.Location = new Point(currentRightPosition - button2.Width, (pictureBox1.Height - button2.Height) / 2);


            // 3. Center "Dashboard" title (textBox5)
            // textBox5 is the Dashboard title based on your designer.cs and screenshot
            textBox5.Location = new Point((screenWidth - textBox5.Width) / 2, pictureBox1.Bottom + 20); // 20 pixels below header, centered

            // 4. Center the group of 4 info boxes (textBox1, textBox2, textBox3, textBox6)
            // Define infoBoxHeight
            int infoBoxHeight = textBox1.Height; // This will be 82 based on your designer.cs
            int infoBoxWidth = textBox1.Width; // This will be 162 based on your designer.cs

            int infoBoxSpacing = 20; // Adjust as needed
            int totalInfoBoxesWidth = (infoBoxWidth * 4) + (infoBoxSpacing * 3); // 4 boxes, 3 spaces between them

            int startXInfoBoxes = (screenWidth - totalInfoBoxesWidth) / 2;
            int infoBoxY = textBox5.Bottom + 30; // 30 pixels below dashboard title

            // Set locations for the info box containers
            textBox1.Location = new Point(startXInfoBoxes, infoBoxY); // Yellow box (Available Rooms)
            textBox2.Location = new Point(textBox1.Right + infoBoxSpacing, infoBoxY); // Orange box (Pending Request)
            textBox3.Location = new Point(textBox2.Right + infoBoxSpacing, infoBoxY); // Green box (Today's Bookings)
            textBox6.Location = new Point(textBox3.Right + infoBoxSpacing, infoBoxY); // Light blue/grey box (Total Users)

            // Position labels and counts relative to their parent textboxes (the info boxes)
            // textBox9 (Available Rooms label) and textBox10 (Available Rooms count)
            textBox9.Location = new Point(textBox1.Left + (textBox1.Width - textBox9.Width) / 2, textBox1.Top + 15);
            textBox10.Location = new Point(textBox1.Left + (textBox1.Width - textBox10.Width) / 2, textBox1.Top + 50);

            // textBox11 (Pending Request label) and textBox12 (Pending Request count)
            textBox11.Location = new Point(textBox2.Left + (textBox2.Width - textBox11.Width) / 2, textBox2.Top + 15);
            textBox12.Location = new Point(textBox2.Left + (textBox2.Width - textBox12.Width) / 2, textBox2.Top + 50);

            // textBox15 (Today's Bookings label) and textBox13 (Today's Bookings count)
            textBox15.Location = new Point(textBox3.Left + (textBox3.Width - textBox15.Width) / 2, textBox3.Top + 15);
            textBox13.Location = new Point(textBox3.Left + (textBox3.Width - textBox13.Width) / 2, textBox3.Top + 50);

            // textBox16 (Total Users label) and textBox14 (Total Users count)
            textBox16.Location = new Point(textBox6.Left + (textBox6.Width - textBox16.Width) / 2, textBox6.Top + 15);
            textBox14.Location = new Point(textBox6.Left + (textBox6.Width - textBox14.Width) / 2, textBox6.Top + 50);


            // 5. Center and expand the Activity box (textBox7)
            // It appears to be a large box spanning most of the remaining width.
            // textBox7 is the large activity box container based on your designer.cs and screenshot.
            // textBox17 is "Activity" label, textBox18 is activity content
            int activityBoxY = infoBoxY + infoBoxHeight + 50; // 50 pixels below info boxes
            int activityBoxCalculatedHeight = screenHeight - activityBoxY - 20; // 20 pixels from bottom edge for padding
            int finalActivityBoxHeight = (activityBoxCalculatedHeight > 130) ? activityBoxCalculatedHeight : 130; // Min height 130, or fill remaining space

            textBox7.Size = new Size(screenWidth - 100, finalActivityBoxHeight); // 50 pixels margin on each side
            textBox7.Location = new Point((screenWidth - textBox7.Width) / 2, activityBoxY);

            // Position elements inside the activity box relative to its new position
            textBox17.Location = new Point(textBox7.Left + 17, textBox7.Top + 18); // "Activity" label
            textBox18.Location = new Point(textBox7.Left + 46, textBox7.Top + 52); // Activity content
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox8_TextChanged is here.
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox5_TextChanged is here.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox2_TextChanged is here.
        }

        // The textBox3_Click event was configured to navigate to admin_bookings.
        private void textBox3_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox13_TextChanged is here.
        }

        // The button2_Click event was configured to navigate to admin bookings.
        private void button2_Click(object sender, EventArgs e)
        {
            admin_bookings adminBookingsForm = _serviceProvider.GetRequiredService<admin_bookings>(); // The form was retrieved from DI.
            adminBookingsForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1_TextChanged is here.
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox9_TextChanged is here.
        }

        // The textBox1_Click event was configured to navigate to Available Rooms.
        private void textBox1_Click(object sender, EventArgs e)
        {
            Available_Rooms availableRoomsForm = _serviceProvider.GetRequiredService<Available_Rooms>(); // The form was retrieved from DI.
            availableRoomsForm.Show();
            this.Hide();
        }

        // The textBox2_Click event was configured to navigate to Form11 (Requests).
        private void textBox2_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>(); // The form was retrieved from DI.
            form11.Show();
            this.Hide();
        }

        // The button1_Click event was configured to navigate to Form13 (Rooms).
        private void button1_Click(object sender, EventArgs e)
        {
            Rooms_Main form = _serviceProvider.GetRequiredService<Rooms_Main>();
            form.Show();
            this.Hide();
        }

        // The button3_Click event was configured to navigate to Form11 (Requests).
        private void button3_Click(object sender, EventArgs e)
        {
            PendingRequest form11 = _serviceProvider.GetRequiredService<PendingRequest>(); // The form was retrieved from DI.
            form11.Show();
            this.Hide();
        }

        // The button4_Click event was configured to navigate to Form18 (Accounts/Profile).
        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form18 = _serviceProvider.GetRequiredService<Form18>(); // The form was retrieved from DI.
            form18.Show();
            this.Hide();
        }

        // The button5_Click event was configured to navigate to Dashboard. (Self-referential, typically not needed if on dashboard)
        // Kept as per instruction to not remove any component/logic.
        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboardForm = _serviceProvider.GetRequiredService<Admin_Dashboard>();
            dashboardForm.Show();
            this.Hide();
        }
    }
}