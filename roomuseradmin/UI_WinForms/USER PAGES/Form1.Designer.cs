namespace UI_WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            pictureBox3 = new PictureBox();
            txtAnnouncements = new TextBox();
            textBox7 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button4 = new Button();
            textBox13 = new TextBox();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            txtUpcomingBookings = new TextBox();
            label1 = new Label();
            lblWelcomeMessage = new Label();
            textBox8 = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.Location = new Point(1, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 358);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Maroon;
            monthCalendar1.ForeColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.Location = new Point(2, 64);
            monthCalendar1.Margin = new Padding(8, 8, 8, 8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.TitleBackColor = Color.DarkRed;
            monthCalendar1.TitleForeColor = Color.White;
            monthCalendar1.TrailingForeColor = Color.LightGray;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Maroon;
            pictureBox3.Location = new Point(312, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1, 1);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txtAnnouncements
            // 
            txtAnnouncements.BackColor = SystemColors.ScrollBar;
            txtAnnouncements.BorderStyle = BorderStyle.FixedSingle;
            txtAnnouncements.Location = new Point(297, 299);
            txtAnnouncements.Multiline = true;
            txtAnnouncements.Name = "txtAnnouncements";
            txtAnnouncements.ReadOnly = true;
            txtAnnouncements.ScrollBars = ScrollBars.Both;
            txtAnnouncements.Size = new Size(387, 112);
            txtAnnouncements.TabIndex = 15;
            txtAnnouncements.TextChanged += textBox10_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Maroon;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(324, 141);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(46, 14);
            textBox7.TabIndex = 85;
            textBox7.Text = "Status: ";
            textBox7.TextChanged += textBox7_TextChanged_1;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Maroon;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(324, 176);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(136, 21);
            textBox11.TabIndex = 87;
            textBox11.Text = "Laboratory Room";
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.Maroon;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(324, 210);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(226, 32);
            textBox12.TabIndex = 88;
            textBox12.Text = "June 15, 8:00am - 12:00pm";
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(641, 16);
            button4.Name = "button4";
            button4.Size = new Size(48, 38);
            button4.TabIndex = 90;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(192, 0, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(72, 22);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(128, 30);
            textBox13.TabIndex = 92;
            textBox13.Text = "Iskedular";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(385, 25);
            button5.Name = "button5";
            button5.Size = new Size(75, 22);
            button5.TabIndex = 94;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(466, 25);
            button7.Name = "button7";
            button7.Size = new Size(75, 22);
            button7.TabIndex = 95;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(546, 25);
            button6.Name = "button6";
            button6.Size = new Size(75, 22);
            button6.TabIndex = 96;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txtUpcomingBookings
            // 
            txtUpcomingBookings.BackColor = Color.Maroon;
            txtUpcomingBookings.BorderStyle = BorderStyle.FixedSingle;
            txtUpcomingBookings.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUpcomingBookings.Location = new Point(297, 124);
            txtUpcomingBookings.Multiline = true;
            txtUpcomingBookings.Name = "txtUpcomingBookings";
            txtUpcomingBookings.ReadOnly = true;
            txtUpcomingBookings.ScrollBars = ScrollBars.Both;
            txtUpcomingBookings.Size = new Size(307, 132);
            txtUpcomingBookings.TabIndex = 84;
            txtUpcomingBookings.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 272);
            label1.Name = "label1";
            label1.Size = new Size(123, 18);
            label1.TabIndex = 97;
            label1.Text = "Announcement";
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.BackColor = Color.Transparent;
            lblWelcomeMessage.Font = new Font("Elephant", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcomeMessage.Location = new Point(304, 87);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(128, 21);
            lblWelcomeMessage.TabIndex = 98;
            lblWelcomeMessage.Text = "Hi, Isko/Iska";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Maroon;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.FromArgb(255, 192, 128);
            textBox8.Location = new Point(375, 141);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(65, 21);
            textBox8.TabIndex = 86;
            textBox8.Text = "Pending";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 99;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 422);
            Controls.Add(pictureBox4);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(textBox13);
            Controls.Add(button4);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(txtUpcomingBookings);
            Controls.Add(txtAnnouncements);
            Controls.Add(pictureBox3);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtAnnouncements;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtUpcomingBookings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

