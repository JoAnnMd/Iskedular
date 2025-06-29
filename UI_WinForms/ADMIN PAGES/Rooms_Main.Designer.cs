namespace UI_WinForms
{
    partial class Rooms_Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTopNav = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRoomsManage = new System.Windows.Forms.Button();
            this.buttonTotalRooms = new System.Windows.Forms.Button();
            this.buttonAvailableRooms = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopNav
            // 
            this.panelTopNav.BackColor = System.Drawing.Color.Maroon;
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
            // 
            // button4 (Profile)
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(944, 10);
            this.button4.Size = new System.Drawing.Size(48, 69);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3 (Requests)
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(850, 30);
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5 (Dashboard)
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(754, 30);
            this.button5.Size = new System.Drawing.Size(86, 29);
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1 (Rooms)
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 30);
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.Text = "Rooms";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2 (Bookings)
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(562, 30);
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.Text = "Bookings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4 (Logo)
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Size = new System.Drawing.Size(72, 57);
            // 
            // textBox4 (Iskedular)
            // 
            this.textBox4.BackColor = System.Drawing.Color.Maroon;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(90, 27);
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.Text = "Iskedular";
            // 
            // pictureBox1 (Top bar fill)
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Size = new System.Drawing.Size(1000, 89);
            // 
            // panel1 (Main background with image)
            // 
            this.panel1.BackgroundImage = global::UI_WinForms.Properties.Resources.rooms_image;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.buttonAvailableRooms);
            this.panel1.Controls.Add(this.buttonTotalRooms);
            this.panel1.Controls.Add(this.buttonRoomsManage);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Size = new System.Drawing.Size(1000, 611);
            this.panel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Text = "Rooms";
            this.labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.labelTitle.ForeColor = Color.White;
            this.labelTitle.BackColor = Color.Transparent;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new Point(40, 40);
            // 
            // buttonAvailableRooms
            // 
            this.buttonAvailableRooms.Name = "buttonAvailableRooms";
            this.buttonAvailableRooms.Size = new System.Drawing.Size(150, 40);
            this.buttonAvailableRooms.Text = "Available Rooms";
            this.buttonAvailableRooms.UseVisualStyleBackColor = true;
            this.buttonAvailableRooms.Click += new System.EventHandler(this.buttonAvailableRooms_Click);
            // 
            // buttonTotalRooms
            // 
            this.buttonTotalRooms.Name = "buttonTotalRooms";
            this.buttonTotalRooms.Size = new System.Drawing.Size(150, 40);
            this.buttonTotalRooms.Text = "Total Rooms";
            this.buttonTotalRooms.UseVisualStyleBackColor = true;
            this.buttonTotalRooms.Click += new System.EventHandler(this.buttonTotalRooms_Click);
            // 
            // buttonRoomsManage
            // 
            this.buttonRoomsManage.Name = "buttonRoomsManage";
            this.buttonRoomsManage.Size = new System.Drawing.Size(150, 40);
            this.buttonRoomsManage.Text = "Manage Rooms";
            this.buttonRoomsManage.UseVisualStyleBackColor = true;
            this.buttonRoomsManage.Click += new System.EventHandler(this.buttonRoomsManage_Click);
            // 
            // Rooms_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms_Main";
            this.Text = "Rooms_Main";
            this.Load += new System.EventHandler(this.Rooms_Main_Load);
            this.Resize += new System.EventHandler(this.Rooms_Main_Resize);
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAvailableRooms;
        private System.Windows.Forms.Button buttonTotalRooms;
        private System.Windows.Forms.Button buttonRoomsManage;
        private System.Windows.Forms.Label labelTitle;
    }
}

