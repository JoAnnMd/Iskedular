namespace UI_WinForms
{
    partial class admin_bookings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_bookings));

            this.panelTopNav = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button(); // Profile icon
            this.button3 = new System.Windows.Forms.Button(); // Requests
            this.button5 = new System.Windows.Forms.Button(); // Dashboard
            this.button1 = new System.Windows.Forms.Button(); // Rooms
            this.button2 = new System.Windows.Forms.Button(); // Bookings
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Logo
            this.textBox4 = new System.Windows.Forms.TextBox(); // "Iskedular" text
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Nav bar background

            this.panelMainContent = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button(); // View All Bookings
            this.label1 = new System.Windows.Forms.Label(); // Title: Today's Booking
            this.flowLayoutPanelBookings = new System.Windows.Forms.FlowLayoutPanel(); // Flow panel for bookings

            this.panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();

            // panelTopNav
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.panelTopNav.Controls.Add(this.button4);
            this.panelTopNav.Controls.Add(this.button3);
            this.panelTopNav.Controls.Add(this.button5);
            this.panelTopNav.Controls.Add(this.button1);
            this.panelTopNav.Controls.Add(this.button2);
            this.panelTopNav.Controls.Add(this.pictureBox4);
            this.panelTopNav.Controls.Add(this.textBox4);
            this.panelTopNav.Controls.Add(this.pictureBox1);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(1000, 89);
            this.panelTopNav.TabIndex = 0;

            // button4 (Profile)
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            this.button4.Location = new System.Drawing.Point(944, 10);
            this.button4.Size = new System.Drawing.Size(48, 69);
            this.button4.TabIndex = 240;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // button3 (Requests)
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(850, 30);
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // button5 (Dashboard)
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button5.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(754, 30);
            this.button5.Size = new System.Drawing.Size(86, 29);
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // button1 (Rooms)
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 30);
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.Text = "Rooms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // button2 (Bookings)
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(562, 30);
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.Text = "Bookings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // pictureBox4 (Logo)
            this.pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Size = new System.Drawing.Size(72, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // textBox4 (Iskedular text)
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(90, 27);
            this.textBox4.Multiline = true;
            this.textBox4.Text = "Iskedular";

            // pictureBox1 (Background)
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;

            // panelMainContent
            this.panelMainContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainContent.Controls.Add(this.button6);
            this.panelMainContent.Controls.Add(this.label1);
            this.panelMainContent.Controls.Add(this.flowLayoutPanelBookings);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 89);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1000, 600);  // Adjust this as needed
            this.panelMainContent.TabIndex = 1;

            // button6 (View All Bookings)
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(750, 20);
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.Text = "View All Bookings";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // label1 (Today's Booking Title)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Text = "Today's Bookings";

            // flowLayoutPanelBookings
            this.flowLayoutPanelBookings.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.flowLayoutPanelBookings.AutoScroll = true;
            this.flowLayoutPanelBookings.Location = new System.Drawing.Point(20, 80);
            this.flowLayoutPanelBookings.Size = new System.Drawing.Size(960, 500); // Fill most of the area
            this.flowLayoutPanelBookings.Name = "flowLayoutPanelBookings";

            // admin_bookings (Form settings)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTopNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "admin_bookings";
            this.Text = "Admin Bookings";

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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBookings;
    }
}
