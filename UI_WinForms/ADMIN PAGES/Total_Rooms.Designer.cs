namespace UI_WinForms
{
    partial class Total_Rooms
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
        /// the contents of this method with the code code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_Rooms));
            panelTopNav = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            button6 = new Button();
            textBox5 = new TextBox();
            flowLayoutPanelRooms = new FlowLayoutPanel();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(button3);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(button1);
            panelTopNav.Controls.Add(button2);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(textBox4);
            panelTopNav.Controls.Add(pictureBox1);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(800, 89);
            panelTopNav.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(742, 9);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 240;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(646, 29);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 239;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 7.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(356, 30);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 238;
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
            button1.Location = new Point(455, 30);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 237;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(550, 28);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 236;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 221;
            pictureBox4.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(90, 27);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 40);
            textBox4.TabIndex = 105;
            textBox4.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 89);
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = SystemColors.Control;
            panelMainContent.Controls.Add(button6);
            panelMainContent.Controls.Add(textBox5);
            panelMainContent.Controls.Add(flowLayoutPanelRooms);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 89);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(800, 473);
            panelMainContent.TabIndex = 1;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(563, 15);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(213, 44);
            button6.TabIndex = 138;
            button6.Text = "View Available Rooms";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(12, 27);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 26);
            textBox5.TabIndex = 113;
            textBox5.Text = "Total Rooms";
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.Location = new Point(22, 70);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(756, 390);
            flowLayoutPanelRooms.TabIndex = 241;
            // 
            // Total_Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 562);
            Controls.Add(panelMainContent);
            Controls.Add(panelTopNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Total_Rooms";
            Text = "Form10";
            Load += Form10_Load;
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            ResumeLayout(false);

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
    }
}
