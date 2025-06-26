namespace UI_WinForms
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            button6 = new Button();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanelRooms = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
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
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 89);
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(12, 124);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 26);
            textBox5.TabIndex = 113;
            textBox5.Text = "Total Rooms";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(563, 124);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(213, 44);
            button6.TabIndex = 138;
            button6.Text = "View Available Rooms";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
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
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(748, 9);
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
            button3.Location = new Point(644, 27);
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
            button5.Location = new Point(550, 27);
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
            button1.Location = new Point(458, 27);
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
            button2.Location = new Point(367, 27);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 236;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.Location = new Point(22, 197);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(900, 500);
            flowLayoutPanelRooms.TabIndex = 241;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(flowLayoutPanelRooms);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button6;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanelRooms;
    }
}