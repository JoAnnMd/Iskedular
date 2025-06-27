namespace UI_WinForms
{
    partial class Available_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available_Rooms));
            this.panelTopNav = new System.Windows.Forms.Panel(); // New panel for top navigation
            this.button4 = new System.Windows.Forms.Button(); // Profile Icon
            this.button3 = new System.Windows.Forms.Button(); // Requests
            this.button5 = new System.Windows.Forms.Button(); // Dashboard
            this.button1 = new System.Windows.Forms.Button(); // Rooms
            this.button2 = new System.Windows.Forms.Button(); // Bookings
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Iskedular Logo icon
            this.textBox4 = new System.Windows.Forms.TextBox(); // Iskedular Text
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Background for top nav
            this.panelMainContent = new System.Windows.Forms.Panel(); // New panel for main content
            this.button6 = new System.Windows.Forms.Button(); // View Total Rooms
            this.textBox5 = new System.Windows.Forms.TextBox(); // Available Rooms Label
            this.flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();

            this.panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTopNav
            //
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTopNav.Controls.Add(this.button4);
            this.panelTopNav.Controls.Add(this.button3);
            this.panelTopNav.Controls.Add(this.button5);
            this.panelTopNav.Controls.Add(this.button1);
            this.panelTopNav.Controls.Add(this.button2);
            this.panelTopNav.Controls.Add(this.pictureBox4);
            this.panelTopNav.Controls.Add(this.textBox4);
            this.panelTopNav.Controls.Add(this.pictureBox1); // This pictureBox can act as a background element
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top; // Dock to top
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(800, 89); // Fixed height for nav bar
            this.panelTopNav.TabIndex = 0;
            //
            // button4 (Profile Icon)
            //
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))); // Anchor to top-right
            this.button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            this.button4.Location = new System.Drawing.Point(742, 9); // Adjusted X position (800 - 48 - 10 = 742)
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 69);
            this.button4.TabIndex = 240;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button3 (Requests)
            //
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(646, 27); // Adjusted X position
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29); // Consistent size
            this.button3.TabIndex = 239;
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // button5 (Dashboard)
            //
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(550, 27); // Adjusted X position
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 29); // Consistent size
            this.button5.TabIndex = 238;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // button1 (Rooms)
            //
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(454, 27); // Adjusted X position
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29); // Consistent size
            this.button1.TabIndex = 237;
            this.button1.Text = "Rooms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2 (Bookings)
            //
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(358, 27); // Adjusted X position
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29); // Consistent size
            this.button2.TabIndex = 236;
            this.button2.Text = "Bookings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // pictureBox4 (Iskedular Logo icon)
            //
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 220;
            this.pictureBox4.TabStop = false;
            //
            // textBox4 (Iskedular Text)
            //
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(90, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 40);
            this.textBox4.TabIndex = 224;
            this.textBox4.Text = "Iskedular";
            //
            // pictureBox1 (Background for top nav)
            //
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill; // Fill the entire top panel
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 89);
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            //
            // panelMainContent
            //
            this.panelMainContent.BackColor = System.Drawing.SystemColors.Control; // Use default control background
            this.panelMainContent.Controls.Add(this.button6);
            this.panelMainContent.Controls.Add(this.textBox5);
            this.panelMainContent.Controls.Add(this.flowLayoutPanelRooms);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill; // Fill remaining space below top nav
            this.panelMainContent.Location = new System.Drawing.Point(0, 89); // Start below the nav bar
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(800, 473); // Remaining height
            this.panelMainContent.TabIndex = 1;
            //
            // button6 (View Total Rooms)
            //
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(563, 15); // Position relative to panelMainContent
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 44);
            this.button6.TabIndex = 225;
            this.button6.Text = "View Total Rooms";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            //
            // textBox5 (Available Rooms Label)
            //
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(12, 27); // Position relative to panelMainContent
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 26);
            this.textBox5.TabIndex = 151;
            this.textBox5.Text = "Available Rooms";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            //
            // flowLayoutPanelRooms
            //
            this.flowLayoutPanelRooms.AutoScroll = true;
            this.flowLayoutPanelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Anchor to all sides within its parent
            this.flowLayoutPanelRooms.Location = new System.Drawing.Point(22, 70); // Adjust Y to be below textBox5/button6
            this.flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            this.flowLayoutPanelRooms.Size = new System.Drawing.Size(756, 390); // Adjusted size to fill content area
            this.flowLayoutPanelRooms.TabIndex = 242;
            //
            // Available_Rooms
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panelMainContent); // Add main content panel first
            this.Controls.Add(this.panelTopNav); // Add top navigation panel
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Available_Rooms";
            this.Text = "Available_Rooms";
            this.Load += new System.EventHandler(this.Available_Rooms_Load);
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        // Removed unused labels (label1, label13, label11, label15, label17) if they are not used in the .cs logic
    }
}
