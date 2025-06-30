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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms_Main));
            panelTopNav = new Panel();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            labelTitle = new Label();
            buttonAvailableRooms = new Button();
            buttonTotalRooms = new Button();
            buttonRoomsManage = new Button();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.Maroon;
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(button3);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(button1);
            panelTopNav.Controls.Add(button2);
            panelTopNav.Controls.Add(textBox4);
            panelTopNav.Controls.Add(pictureBox1);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1190, 89);
            panelTopNav.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1028, 32);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 1;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(728, 31);
            button5.Name = "button5";
            button5.Size = new Size(96, 29);
            button5.TabIndex = 2;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(835, 31);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 3;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(931, 32);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 4;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(90, 27);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 43);
            textBox4.TabIndex = 6;
            textBox4.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1190, 89);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.rooms_image;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(buttonAvailableRooms);
            panel1.Controls.Add(buttonTotalRooms);
            panel1.Controls.Add(buttonRoomsManage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 611);
            panel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(40, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(129, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Rooms";
            // 
            // buttonAvailableRooms
            // 
            buttonAvailableRooms.Location = new Point(0, 0);
            buttonAvailableRooms.Name = "buttonAvailableRooms";
            buttonAvailableRooms.Size = new Size(150, 40);
            buttonAvailableRooms.TabIndex = 1;
            buttonAvailableRooms.Text = "Available Rooms";
            buttonAvailableRooms.UseVisualStyleBackColor = true;
            buttonAvailableRooms.Click += buttonAvailableRooms_Click;
            // 
            // buttonTotalRooms
            // 
            buttonTotalRooms.Location = new Point(0, 0);
            buttonTotalRooms.Name = "buttonTotalRooms";
            buttonTotalRooms.Size = new Size(150, 40);
            buttonTotalRooms.TabIndex = 2;
            buttonTotalRooms.Text = "Total Rooms";
            buttonTotalRooms.UseVisualStyleBackColor = true;
            buttonTotalRooms.Click += buttonTotalRooms_Click;
            // 
            // buttonRoomsManage
            // 
            buttonRoomsManage.Location = new Point(0, 0);
            buttonRoomsManage.Name = "buttonRoomsManage";
            buttonRoomsManage.Size = new Size(150, 40);
            buttonRoomsManage.TabIndex = 3;
            buttonRoomsManage.Text = "Manage Rooms";
            buttonRoomsManage.UseVisualStyleBackColor = true;
            buttonRoomsManage.Click += buttonRoomsManage_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1130, 15);
            button4.Name = "button4";
            button4.Size = new Size(48, 64);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            // 
            // Rooms_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 700);
            Controls.Add(panel1);
            Controls.Add(panelTopNav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rooms_Main";
            Text = "Rooms_Main";
            Load += Rooms_Main_Load;
            Resize += Rooms_Main_Resize;
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAvailableRooms;
        private System.Windows.Forms.Button buttonTotalRooms;
        private System.Windows.Forms.Button buttonRoomsManage;
        private System.Windows.Forms.Label labelTitle;
        private PictureBox pictureBox4;
        private Button button4;
    }
}

