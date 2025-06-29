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
            System.DirectoryServices.SortOption sortOption11 = new System.DirectoryServices.SortOption();
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
            directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            listBoxActivityLog = new ListBox();
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
            textBox5.Location = new Point(25, 121);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 21);
            textBox5.TabIndex = 95;
            textBox5.TabStop = false;
            textBox5.Text = "Dashboard\r\n";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Location = new Point(8, 148);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 100);
            textBox1.TabIndex = 104;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(190, 148);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 100);
            textBox2.TabIndex = 105;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 192, 0);
            textBox3.Location = new Point(362, 148);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 100);
            textBox3.TabIndex = 106;
            textBox3.Click += textBox3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.InactiveCaption;
            textBox6.Location = new Point(546, 148);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 100);
            textBox6.TabIndex = 107;
            textBox6.Click += textBox6_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(34, 262);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.ScrollBars = ScrollBars.Both;
            textBox7.Size = new Size(624, 148);
            textBox7.TabIndex = 108;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Yellow;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(28, 163);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(111, 37);
            textBox9.TabIndex = 109;
            textBox9.Text = "Available Rooms";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Yellow;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(65, 216);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(23, 23);
            textBox10.TabIndex = 110;
            textBox10.Text = "10";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(255, 128, 0);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(218, 163);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(95, 37);
            textBox11.TabIndex = 111;
            textBox11.Text = "Pending Request";
            textBox11.TextAlign = HorizontalAlignment.Center;
          
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(255, 128, 0);
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(251, 216);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(23, 23);
            textBox12.TabIndex = 112;
            textBox12.Text = "3";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(0, 192, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(427, 216);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(23, 23);
            textBox13.TabIndex = 113;
            textBox13.Text = "5";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.InactiveCaption;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(616, 216);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(23, 23);
            textBox14.TabIndex = 114;
            textBox14.Text = "50";
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.FromArgb(0, 192, 0);
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(379, 163);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(109, 37);
            textBox15.TabIndex = 115;
            textBox15.Text = "Today's Bookings";
            textBox15.TextAlign = HorizontalAlignment.Center;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // textBox16
            // 
            textBox16.BackColor = SystemColors.InactiveCaption;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox16.Location = new Point(600, 163);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(52, 37);
            textBox16.TabIndex = 116;
            textBox16.Text = "Total Users";
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.White;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox17.ForeColor = Color.Black;
            textBox17.Location = new Point(34, 268);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(197, 28);
            textBox17.TabIndex = 117;
            textBox17.Text = "Activity Log";
            textBox17.TextAlign = HorizontalAlignment.Center;
            // 
            // directorySearcher1
            // 
            directorySearcher1.ClientTimeout = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.Sort = sortOption11;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 230;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(616, 17);
            button4.Name = "button4";
            button4.Size = new Size(59, 65);
            button4.TabIndex = 229;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(524, 24);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
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
            button2.Location = new Point(284, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
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
            button1.Location = new Point(364, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
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
            button5.Location = new Point(444, 24);
            button5.Name = "button5";
            button5.Size = new Size(75, 39);
            button5.TabIndex = 225;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(89, 33);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 30);
            textBox4.TabIndex = 224;
            textBox4.Text = "Iskedular";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 98);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBoxActivityLog
            // 
            listBoxActivityLog.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxActivityLog.FormattingEnabled = true;
            listBoxActivityLog.ItemHeight = 23;
            listBoxActivityLog.Location = new Point(49, 302);
            listBoxActivityLog.Name = "listBoxActivityLog";
            listBoxActivityLog.Size = new Size(574, 96);
            listBoxActivityLog.TabIndex = 231;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(listBoxActivityLog);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
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
            Name = "Admin_Dashboard";
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
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private ListBox listBoxActivityLog;
    }
}