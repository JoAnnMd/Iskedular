namespace UI_WinForms
{
    partial class PendingRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingRequest));
            this.panelTopNav = new System.Windows.Forms.Panel(); // Top navigation panel
            this.button4 = new System.Windows.Forms.Button(); // Profile Icon button
            this.button3 = new System.Windows.Forms.Button(); // Requests button
            this.button5 = new System.Windows.Forms.Button(); // Dashboard button
            this.button1 = new System.Windows.Forms.Button(); // Rooms button
            this.button2 = new System.Windows.Forms.Button(); // Bookings button
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Iskedular Logo icon
            this.textBox4 = new System.Windows.Forms.TextBox(); // Iskedular Text label
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Background for top navigation
            this.panelMainContentWrapper = new System.Windows.Forms.Panel(); // Wrapper panel for main content, fills remaining space
            this.panelContentToCenter = new System.Windows.Forms.Panel(); // This panel holds content to be centered
            this.dataGridView1 = new System.Windows.Forms.DataGridView(); // DataGridView for pending requests
            this.textBox5 = new System.Windows.Forms.TextBox(); // "Pending Request" label

            this.panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainContentWrapper.SuspendLayout();
            this.panelContentToCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelTopNav.Controls.Add(this.pictureBox1);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(800, 89);
            this.panelTopNav.TabIndex = 0;
            //
            // button4 (Profile Icon)
            //
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            this.button4.Location = new System.Drawing.Point(742, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 69);
            this.button4.TabIndex = 229;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button3 (Requests)
            //
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(646, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 228;
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
            this.button5.Location = new System.Drawing.Point(550, 27);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 29);
            this.button5.TabIndex = 225;
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
            this.button1.Location = new System.Drawing.Point(454, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 226;
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
            this.button2.Location = new System.Drawing.Point(358, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 227;
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
            this.pictureBox4.TabIndex = 230;
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
            this.textBox4.ReadOnly = true; // Make read-only
            this.textBox4.TabStop = false; // Remove from tab order
            //
            // pictureBox1 (Background for top nav)
            //
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 89);
            this.pictureBox1.TabIndex = 223;
            this.pictureBox1.TabStop = false;
            //
            // panelMainContentWrapper
            //
            this.panelMainContentWrapper.BackColor = System.Drawing.SystemColors.ControlLight; // Light background for content area
            this.panelMainContentWrapper.Controls.Add(this.panelContentToCenter); // Add the content panel here
            this.panelMainContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContentWrapper.Location = new System.Drawing.Point(0, 89); // Below the top navigation
            this.panelMainContentWrapper.Name = "panelMainContentWrapper";
            this.panelMainContentWrapper.Size = new System.Drawing.Size(800, 473);
            this.panelMainContentWrapper.TabIndex = 1;
            //
            // panelContentToCenter
            //
            // This panel will contain the "Pending Request" label and the DataGridView, and will be centered dynamically.
            this.panelContentToCenter.Controls.Add(this.dataGridView1);
            this.panelContentToCenter.Controls.Add(this.textBox5);
            this.panelContentToCenter.Location = new System.Drawing.Point(0, 0); // Temporary position, will be centered in code
            this.panelContentToCenter.Name = "panelContentToCenter";
            this.panelContentToCenter.Size = new System.Drawing.Size(770, 400); // Set a size for the content area
            this.panelContentToCenter.TabIndex = 0;
            this.panelContentToCenter.Anchor = System.Windows.Forms.AnchorStyles.None; // Set anchor to None for manual centering
            this.panelContentToCenter.BackColor = System.Drawing.Color.Transparent; // Make background transparent to show parent's color
            //
            // dataGridView1
            //
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 50); // Adjusted relative to panelContentToCenter
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(720, 340); // Adjusted size within the panel
            this.dataGridView1.TabIndex = 241;
            //
            // textBox5 ("Pending Request" Label)
            //
            this.textBox5.BackColor = System.Drawing.SystemColors.Control; // This will now contrast with panelMainContentWrapper.BackColor
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(23, 10); // Adjusted relative to panelContentToCenter
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 26);
            this.textBox5.TabIndex = 122;
            this.textBox5.Text = "Pending Request";
            this.textBox5.ReadOnly = true; // Make read-only
            this.textBox5.TabStop = false; // Remove from tab order
            //
            // PendingRequest
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); // Form background for areas not covered by panels
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panelMainContentWrapper);
            this.Controls.Add(this.panelTopNav); // Add the top nav panel
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PendingRequest";
            this.Text = "Form11"; // Keep this as it might be used internally by VS
            this.Load += new System.EventHandler(this.PendingRequest_Load); // Renamed Load event
            this.Resize += new System.EventHandler(this.PendingRequest_Resize); // Added Resize event for centering
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainContentWrapper.ResumeLayout(false);
            this.panelContentToCenter.ResumeLayout(false);
            this.panelContentToCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav; // New top navigation panel
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMainContentWrapper; // Wrapper for centering
        private System.Windows.Forms.Panel panelContentToCenter; // Panel that contains main content to be centered
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
