namespace UI_WinForms
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            textBox1 = new TextBox();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridViewRooms = new DataGridView();
            buttonAddNewRoom = new Button();
            textBoxTotalRoomsCount = new TextBox();
            textBoxAvailableRoomsCount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Location = new Point(8, 158);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 120);
            textBox1.TabIndex = 131;
            textBox1.Click += textBox1_Click;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Yellow;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(102, 182);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(55, 38);
            textBox9.TabIndex = 132;
            textBox9.Text = "Total Rooms";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(255, 128, 0);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(285, 182);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(74, 49);
            textBox11.TabIndex = 135;
            textBox11.Text = "Available Rooms";
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(207, 158);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 120);
            textBox2.TabIndex = 134;
            textBox2.Click += textBox2_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(24, 118);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 26);
            textBox5.TabIndex = 143;
            textBox5.Text = "Manage Rooms";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 17);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 230;
            pictureBox4.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(91, 34);
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
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 89);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(749, 16);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 240;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(645, 34);
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
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(551, 34);
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
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(459, 34);
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
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(368, 34);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 236;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(47, 315);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.RowHeadersWidth = 51;
            dataGridViewRooms.Size = new Size(939, 557);
            dataGridViewRooms.TabIndex = 241;
            // 
            // buttonAddNewRoom
            // 
            buttonAddNewRoom.Location = new Point(446, 249);
            buttonAddNewRoom.Name = "buttonAddNewRoom";
            buttonAddNewRoom.Size = new Size(136, 29);
            buttonAddNewRoom.TabIndex = 242;
            buttonAddNewRoom.Text = "Add New Room";
            buttonAddNewRoom.UseVisualStyleBackColor = true;
            buttonAddNewRoom.Click += buttonAddNewRoom_Click;
            // 
            // textBoxTotalRoomsCount
            // 
            textBoxTotalRoomsCount.Location = new Point(32, 227);
            textBoxTotalRoomsCount.Name = "textBoxTotalRoomsCount";
            textBoxTotalRoomsCount.ReadOnly = true;
            textBoxTotalRoomsCount.Size = new Size(125, 27);
            textBoxTotalRoomsCount.TabIndex = 244;
            // 
            // textBoxAvailableRoomsCount
            // 
            textBoxAvailableRoomsCount.Location = new Point(234, 227);
            textBoxAvailableRoomsCount.Name = "textBoxAvailableRoomsCount";
            textBoxAvailableRoomsCount.ReadOnly = true;
            textBoxAvailableRoomsCount.Size = new Size(125, 27);
            textBoxAvailableRoomsCount.TabIndex = 245;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(textBoxAvailableRoomsCount);
            Controls.Add(textBoxTotalRoomsCount);
            Controls.Add(buttonAddNewRoom);
            Controls.Add(dataGridViewRooms);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox11);
            Controls.Add(textBox2);
            Controls.Add(textBox9);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private DataGridView dataGridViewRooms;
        private Button buttonAddNewRoom;
        private TextBox textBoxTotalRoomsCount;
        private TextBox textBoxAvailableRoomsCount;
    }
}