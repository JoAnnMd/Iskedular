namespace UI_WinForms
{
    partial class Rooms_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms_Main));
            textBox1 = new TextBox(); // Yellow box (Total Rooms container)
            textBox9 = new TextBox(); // "Total Rooms" label
            textBox11 = new TextBox(); // "Available Rooms" label
            textBox2 = new TextBox(); // Orange box (Available Rooms container)
            textBox5 = new TextBox(); // "Manage Rooms" title
            pictureBox4 = new PictureBox(); // Logo
            textBox4 = new TextBox(); // "Iskedular" text
            pictureBox1 = new PictureBox(); // Red top bar
            button4 = new Button(); // Profile/Accounts button
            button3 = new Button(); // Requests button
            button5 = new Button(); // Dashboard button
            button1 = new Button(); // Rooms button
            button2 = new Button(); // Bookings button
            dataGridViewRooms = new DataGridView();
            buttonAddNewRoom = new Button();
            textBoxTotalRoomsCount = new TextBox(); // Numerical count for Total Rooms
            textBoxAvailableRoomsCount = new TextBox(); // Numerical count for Available Rooms
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            //
            // textBox1 (Yellow box - Total Rooms container)
            //
            textBox1.BackColor = Color.Yellow;
            textBox1.Location = new Point(200, 158); // Initial placement, will be dynamically centered
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 120);
            textBox1.TabIndex = 131;
            textBox1.Click += textBox1_Click; // Keep the click event
            //
            // textBox9 ("Total Rooms" label)
            //
            textBox9.BackColor = Color.Yellow; // Match parent box color
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(8, 24); // Position RELATIVE to textBox1 (inside)
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(140, 38); // Increased size to fit text better
            textBox9.TabIndex = 132;
            textBox9.Text = "Total Rooms";
            textBox9.TextAlign = HorizontalAlignment.Center; // Center text within its own bounds
            //
            // textBox11 ("Available Rooms" label)
            //
            textBox11.BackColor = Color.FromArgb(255, 128, 0); // Match parent box color
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(8, 24); // Position RELATIVE to textBox2 (inside)
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(140, 49); // Increased size to fit text better
            textBox11.TabIndex = 135;
            textBox11.Text = "Available Rooms";
            textBox11.TextAlign = HorizontalAlignment.Center; // Center text within its own bounds
            textBox11.TextChanged += textBox11_TextChanged; // Keep the text changed event
            //
            // textBox2 (Orange box - Available Rooms container)
            //
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(407, 158); // Initial placement, will be dynamically centered
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 120);
            textBox2.TabIndex = 134;
            textBox2.Click += textBox2_Click; // Keep the click event
            //
            // textBox5 ("Manage Rooms" title)
            //
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(290, 118); // This will be dynamically centered
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 26);
            textBox5.TabIndex = 143;
            textBox5.Text = "Manage Rooms";
            textBox5.TextAlign = HorizontalAlignment.Center;
            //
            // pictureBox4 (Logo)
            //
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 17);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 230;
            pictureBox4.TabStop = false;
            //
            // textBox4 ("Iskedular" Text)
            //
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(91, 34);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 40);
            textBox4.TabIndex = 224;
            textBox4.Text = "Iskedular";
            //
            // pictureBox1 (Red Top Bar)
            //
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 89);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            //
            // button4 (Profile/Accounts - Rightmost)
            //
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(749, 16); // Will be dynamically positioned
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 240;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            //
            // button3 (Requests)
            //
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(645, 34); // Will be dynamically positioned
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 239;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            //
            // button5 (Dashboard)
            //
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(551, 34); // Will be dynamically positioned
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 238;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            //
            // button1 (Rooms - Current Page)
            //
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(459, 34); // Will be dynamically positioned
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 237;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            //
            // button2 (Bookings)
            //
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(368, 34); // Will be dynamically positioned
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 236;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            //
            // dataGridViewRooms
            //
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(50, 315); // Will be dynamically positioned and sized
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.RowHeadersWidth = 51;
            dataGridViewRooms.Size = new Size(939, 557); // Will be dynamically positioned and sized
            dataGridViewRooms.TabIndex = 241;
            dataGridViewRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Stretch
            // The CellContentClick event will be wired up in Rooms_Main.cs
            //
            // buttonAddNewRoom
            //
            buttonAddNewRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Anchor to top-right
            buttonAddNewRoom.Location = new Point(600, 249); // Initial placement, will be dynamically positioned
            buttonAddNewRoom.Name = "buttonAddNewRoom";
            buttonAddNewRoom.Size = new Size(136, 29);
            buttonAddNewRoom.TabIndex = 242;
            buttonAddNewRoom.Text = "Add New Room";
            buttonAddNewRoom.UseVisualStyleBackColor = true;
            buttonAddNewRoom.Click += buttonAddNewRoom_Click;
            //
            // textBoxTotalRoomsCount (Numerical count for Total Rooms)
            //
            textBoxTotalRoomsCount.Location = new Point(8, 70); // Position RELATIVE to its parent (textBox1)
            textBoxTotalRoomsCount.Name = "textBoxTotalRoomsCount";
            textBoxTotalRoomsCount.ReadOnly = true;
            textBoxTotalRoomsCount.Size = new Size(140, 27); // Make it fill the width of the label above it
            textBoxTotalRoomsCount.TabIndex = 244;
            textBoxTotalRoomsCount.TextAlign = HorizontalAlignment.Center; // Center the number
            textBoxTotalRoomsCount.BackColor = Color.Yellow; // Match parent box color
            textBoxTotalRoomsCount.BorderStyle = BorderStyle.None; // Remove border
            textBoxTotalRoomsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); // Make it stand out
            //
            // textBoxAvailableRoomsCount (Numerical count for Available Rooms)
            //
            textBoxAvailableRoomsCount.Location = new Point(8, 70); // Position RELATIVE to its parent (textBox2)
            textBoxAvailableRoomsCount.Name = "textBoxAvailableRoomsCount";
            textBoxAvailableRoomsCount.ReadOnly = true;
            textBoxAvailableRoomsCount.Size = new Size(140, 27); // Make it fill the width of the label above it
            textBoxAvailableRoomsCount.TabIndex = 245;
            textBoxAvailableRoomsCount.TextAlign = HorizontalAlignment.Center; // Center the number
            textBoxAvailableRoomsCount.BackColor = Color.FromArgb(255, 128, 0); // Match parent box color
            textBoxAvailableRoomsCount.BorderStyle = BorderStyle.None; // Remove border
            textBoxAvailableRoomsCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); // Make it stand out
            //
            // Rooms_Main
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562); // This will be overridden by Bounds = Screen.PrimaryScreen!.Bounds;
            Controls.Add(buttonAddNewRoom);
            Controls.Add(dataGridViewRooms);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            // Ensure child controls are added to their parent FIRST, then their parent to the form.
            // The Designer.cs typically adds all controls to the form, then we set parents programmatically.
            // So the order here within Controls.Add() isn't as critical as the Parent = X assignment in constructor.
            Controls.Add(textBoxAvailableRoomsCount); // These will become children in constructor
            Controls.Add(textBoxTotalRoomsCount);     // when Parent property is set.
            Controls.Add(textBox11); // The label for available rooms
            Controls.Add(textBox2);  // The orange box
            Controls.Add(textBox9);  // The label for total rooms
            Controls.Add(textBox1);  // The yellow box
            Margin = new Padding(3, 4, 3, 4);
            Name = "Rooms_Main";
            Text = "Rooms_Main";
            Load += Rooms_Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private DataGridView dataGridViewRooms;
        private Button buttonAddNewRoom;
        private TextBox textBoxTotalRoomsCount;
        private TextBox textBoxAvailableRoomsCount;
    }
}