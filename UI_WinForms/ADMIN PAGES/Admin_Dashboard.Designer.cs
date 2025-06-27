namespace UI_WinForms
{
    partial class Admin_Dashboard
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
            System.DirectoryServices.SortOption sortOption3 = new System.DirectoryServices.SortOption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(29, 112);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 26);
            textBox5.TabIndex = 95;
            textBox5.Text = "Dashboard\r\n";
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.TabStop = false; // <<< --- THIS IS THE ADDED LINE
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Location = new Point(12, 178);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 82);
            textBox1.TabIndex = 104;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(219, 178);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 82);
            textBox2.TabIndex = 105;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 192, 0);
            textBox3.Location = new Point(416, 178);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 82);
            textBox3.TabIndex = 106;
            textBox3.Click += textBox3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.InactiveCaption;
            textBox6.Location = new Point(626, 178);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 82);
            textBox6.TabIndex = 107;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(40, 360);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(712, 130);
            textBox7.TabIndex = 108;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Yellow;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(29, 202);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(79, 49);
            textBox9.TabIndex = 109;
            textBox9.Text = "Available Rooms";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Yellow;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(114, 202);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(26, 31);
            textBox10.TabIndex = 110;
            textBox10.Text = "10";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(255, 128, 0);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(228, 202);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(59, 49);
            textBox11.TabIndex = 111;
            textBox11.Text = "Pending Request";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(255, 128, 0);
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(311, 202);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(26, 31);
            textBox12.TabIndex = 112;
            textBox12.Text = "3";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(0, 192, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(528, 202);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(26, 31);
            textBox13.TabIndex = 113;
            textBox13.Text = "5";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.InactiveCaption;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(726, 202);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(26, 31);
            textBox14.TabIndex = 114;
            textBox14.Text = "50";
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.FromArgb(0, 192, 0);
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(440, 202);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(68, 49);
            textBox15.TabIndex = 115;
            textBox15.Text = "Today's Bookings";
            // 
            // textBox16
            // 
            textBox16.BackColor = SystemColors.InactiveCaption;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox16.Location = new Point(638, 202);
            textBox16.Margin = new Padding(3, 4, 3, 4);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(59, 49);
            textBox16.TabIndex = 116;
            textBox16.Text = "Total  Users";
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.White;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Elephant", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox17.ForeColor = Color.Black;
            textBox17.Location = new Point(57, 378);
            textBox17.Margin = new Padding(3, 4, 3, 4);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(72, 22);
            textBox17.TabIndex = 117;
            textBox17.Text = "Activity";
            // 
            // textBox18
            // 
            textBox18.BorderStyle = BorderStyle.None;
            textBox18.Location = new Point(86, 412);
            textBox18.Margin = new Padding(3, 4, 3, 4);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(349, 49);
            textBox18.TabIndex = 118;
            textBox18.Text = "Room A101 approved for 9 AM by Admin";
            // 
            // directorySearcher1
            // 
            directorySearcher1.ClientTimeout = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.Sort = sortOption3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 19);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 230;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(746, 15);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 229;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(638, 32);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 228;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(363, 32);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 227;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(455, 32);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 226;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(546, 32);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 225;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(92, 36);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 40);
            textBox4.TabIndex = 224;
            textBox4.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 89);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox18);
            Controls.Add(textBox17);
            Controls.Add(textBox16);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private TextBox textBox4;
        private PictureBox pictureBox1;
    }
}