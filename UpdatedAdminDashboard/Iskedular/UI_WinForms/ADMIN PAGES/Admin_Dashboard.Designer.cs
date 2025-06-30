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
            System.DirectoryServices.SortOption sortOption1 = new System.DirectoryServices.SortOption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            dataGridViewActivityLog = new DataGridView();
            StatusColumn = new DataGridViewTextBoxColumn();
            RoomColumn = new DataGridViewTextBoxColumn();
            BookedByColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivityLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Cursor = Cursors.No;
            textBox1.Location = new Point(400, 185);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(144, 100);
            textBox1.TabIndex = 104;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(150, 185);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(144, 100);
            textBox2.TabIndex = 105;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Cursor = Cursors.No;
            textBox3.Location = new Point(646, 185);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(156, 100);
            textBox3.TabIndex = 106;
            textBox3.Click += textBox3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Cursor = Cursors.No;
            textBox6.Location = new Point(911, 182);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(144, 100);
            textBox6.TabIndex = 107;
            textBox6.Click += textBox6_Click;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(125, 333);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.ScrollBars = ScrollBars.Both;
            textBox7.Size = new Size(864, 211);
            textBox7.TabIndex = 108;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(150, 206);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(130, 31);
            textBox9.TabIndex = 109;
            textBox9.Text = "Available Rooms";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(159, 243);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(121, 39);
            textBox10.TabIndex = 110;
            textBox10.Text = "10";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(400, 206);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(130, 31);
            textBox11.TabIndex = 111;
            textBox11.Text = "Pending Request";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.White;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(417, 243);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(113, 30);
            textBox12.TabIndex = 112;
            textBox12.Text = "3";
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(662, 243);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(128, 30);
            textBox13.TabIndex = 113;
            textBox13.Text = "5";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.White;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(920, 243);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(125, 30);
            textBox14.TabIndex = 114;
            textBox14.Text = "50";
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.White;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(658, 201);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(132, 36);
            textBox15.TabIndex = 115;
            textBox15.Text = "Today's Bookings";
            textBox15.TextAlign = HorizontalAlignment.Center;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.White;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox16.Location = new Point(911, 201);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(134, 28);
            textBox16.TabIndex = 116;
            textBox16.Text = "Total Users";
            textBox16.TextAlign = HorizontalAlignment.Center;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // textBox17
            // 
            textBox17.BackColor = SystemColors.Control;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox17.ForeColor = Color.Black;
            textBox17.Location = new Point(159, 352);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(197, 31);
            textBox17.TabIndex = 117;
            textBox17.Text = "Activity Log";
            textBox17.TextChanged += textBox17_TextChanged;
            // 
            // directorySearcher1
            // 
            directorySearcher1.ClientTimeout = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
            directorySearcher1.Sort = sortOption1;
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
            button4.Location = new Point(1047, 14);
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
            button3.Location = new Point(955, 21);
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
            button2.Location = new Point(715, 21);
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
            button1.Location = new Point(795, 21);
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
            button5.Location = new Point(875, 21);
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
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1129, 95);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 232;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(308, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 233;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(128, 255, 128);
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(561, 185);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(95, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 234;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(819, 182);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(95, 100);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 235;
            pictureBox6.TabStop = false;
            // 
            // dataGridViewActivityLog
            // 
            dataGridViewActivityLog.AllowUserToAddRows = false;
            dataGridViewActivityLog.AllowUserToDeleteRows = false;
            dataGridViewActivityLog.AllowUserToResizeRows = false;
            dataGridViewActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewActivityLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewActivityLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActivityLog.Columns.AddRange(new DataGridViewColumn[] { StatusColumn, RoomColumn, BookedByColumn, DateColumn, TimeColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewActivityLog.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewActivityLog.Location = new Point(159, 400);
            dataGridViewActivityLog.Name = "dataGridViewActivityLog";
            dataGridViewActivityLog.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewActivityLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewActivityLog.RowHeadersVisible = false;
            dataGridViewActivityLog.RowTemplate.Height = 35;
            dataGridViewActivityLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActivityLog.Size = new Size(791, 119);
            dataGridViewActivityLog.TabIndex = 231;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            // 
            // RoomColumn
            // 
            RoomColumn.HeaderText = "Room";
            RoomColumn.MinimumWidth = 6;
            RoomColumn.Name = "RoomColumn";
            RoomColumn.ReadOnly = true;
            // 
            // BookedByColumn
            // 
            BookedByColumn.HeaderText = "Booked By";
            BookedByColumn.MinimumWidth = 6;
            BookedByColumn.Name = "BookedByColumn";
            BookedByColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 6;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Time";
            TimeColumn.MinimumWidth = 6;
            TimeColumn.Name = "TimeColumn";
            TimeColumn.ReadOnly = true;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(0, 88);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1129, 468);
            pictureBox7.TabIndex = 236;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(473, 119);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 237;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 556);
            Controls.Add(label1);
            Controls.Add(dataGridViewActivityLog);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            Controls.Add(pictureBox7);
            Name = "Admin_Dashboard";
            Text = "Form9";
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivityLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        // Removed ListBox, added DataGridView
        private DataGridView dataGridViewActivityLog;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn RoomColumn;
        private DataGridViewTextBoxColumn BookedByColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label1;
    }
}