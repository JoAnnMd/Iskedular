namespace UI_WinForms
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox3 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            panel23 = new Panel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            panel24 = new Panel();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            textBox13 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            monthCalendar1 = new MonthCalendar();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(289, 170);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 16);
            textBox3.TabIndex = 19;
            textBox3.Text = "LEGEND:";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Location = new Point(360, 161);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(28, 29);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 168);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 21;
            label1.Text = "Available";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(594, 161);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 29);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Location = new Point(479, 161);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(28, 29);
            panel3.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(513, 166);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 23;
            label2.Text = "Occupied";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(628, 170);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 24;
            label3.Text = "Faculty";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(289, 214);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 333);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(516, 228);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(67, 24);
            panel4.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(589, 232);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 27;
            label4.Text = "Guard House";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.Location = new Point(463, 261);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(28, 24);
            panel5.TabIndex = 22;
            panel5.Paint += panel5_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(497, 266);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 28;
            label5.Text = "Gymnasium";
            label5.Click += label5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLight;
            panel6.Location = new Point(314, 314);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(22, 184);
            panel6.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 320);
            label6.Name = "label6";
            label6.Size = new Size(37, 14);
            label6.TabIndex = 29;
            label6.Text = "A 206";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Lime;
            panel7.Location = new Point(342, 349);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(28, 24);
            panel7.TabIndex = 23;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Lime;
            panel8.Location = new Point(342, 318);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(28, 24);
            panel8.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Lime;
            panel9.Location = new Point(342, 380);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(28, 24);
            panel9.TabIndex = 24;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Lime;
            panel10.Location = new Point(342, 411);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(28, 24);
            panel10.TabIndex = 25;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Lime;
            panel11.Location = new Point(342, 442);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(28, 24);
            panel11.TabIndex = 26;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Lime;
            panel12.Location = new Point(342, 476);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(28, 24);
            panel12.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(376, 354);
            label7.Name = "label7";
            label7.Size = new Size(37, 14);
            label7.TabIndex = 30;
            label7.Text = "A 205";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(376, 382);
            label8.Name = "label8";
            label8.Size = new Size(37, 14);
            label8.TabIndex = 31;
            label8.Text = "A 204";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(376, 414);
            label9.Name = "label9";
            label9.Size = new Size(37, 14);
            label9.TabIndex = 32;
            label9.Text = "A 203";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(376, 445);
            label10.Name = "label10";
            label10.Size = new Size(37, 14);
            label10.TabIndex = 33;
            label10.Text = "A 202";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(376, 476);
            label11.Name = "label11";
            label11.Size = new Size(37, 14);
            label11.TabIndex = 34;
            label11.Text = "A 201";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Lime;
            panel13.Location = new Point(433, 318);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(28, 24);
            panel13.TabIndex = 28;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Lime;
            panel14.Location = new Point(433, 351);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(28, 24);
            panel14.TabIndex = 29;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Lime;
            panel15.Location = new Point(433, 382);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(28, 24);
            panel15.TabIndex = 29;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Lime;
            panel16.Location = new Point(433, 414);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(28, 24);
            panel16.TabIndex = 29;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Lime;
            panel17.Location = new Point(433, 445);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(28, 24);
            panel17.TabIndex = 29;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Lime;
            panel18.Location = new Point(433, 476);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(28, 24);
            panel18.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(467, 318);
            label12.Name = "label12";
            label12.Size = new Size(37, 14);
            label12.TabIndex = 35;
            label12.Text = "A 106";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(467, 351);
            label13.Name = "label13";
            label13.Size = new Size(37, 14);
            label13.TabIndex = 36;
            label13.Text = "A 105";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(467, 382);
            label14.Name = "label14";
            label14.Size = new Size(37, 14);
            label14.TabIndex = 37;
            label14.Text = "A 104";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(466, 414);
            label15.Name = "label15";
            label15.Size = new Size(37, 14);
            label15.TabIndex = 38;
            label15.Text = "A 103";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(467, 448);
            label16.Name = "label16";
            label16.Size = new Size(37, 14);
            label16.TabIndex = 39;
            label16.Text = "A 102";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bell MT", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(467, 479);
            label17.Name = "label17";
            label17.Size = new Size(37, 14);
            label17.TabIndex = 40;
            label17.Text = "A 101";
            // 
            // panel19
            // 
            panel19.BackColor = Color.Lime;
            panel19.Location = new Point(722, 278);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(28, 24);
            panel19.TabIndex = 24;
            // 
            // panel20
            // 
            panel20.BackColor = Color.Lime;
            panel20.Location = new Point(722, 335);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(28, 24);
            panel20.TabIndex = 25;
            // 
            // panel21
            // 
            panel21.BackColor = Color.Yellow;
            panel21.Location = new Point(658, 399);
            panel21.Margin = new Padding(3, 4, 3, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(58, 29);
            panel21.TabIndex = 23;
            // 
            // panel22
            // 
            panel22.BackColor = Color.Lime;
            panel22.Location = new Point(580, 500);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(58, 30);
            panel22.TabIndex = 25;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Lime;
            panel23.Location = new Point(644, 500);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(58, 30);
            panel23.TabIndex = 25;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(641, 278);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 41;
            label18.Text = "Roth Room #1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(641, 335);
            label19.Name = "label19";
            label19.Size = new Size(80, 15);
            label19.TabIndex = 42;
            label19.Text = "Roth Room #2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(612, 404);
            label20.Name = "label20";
            label20.Size = new Size(40, 15);
            label20.TabIndex = 43;
            label20.Text = "Chapel";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(591, 479);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 44;
            label21.Text = "AVR";
            label21.Click += label21_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Bell MT", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(641, 478);
            label23.Name = "label23";
            label23.Size = new Size(57, 15);
            label23.TabIndex = 46;
            label23.Text = "COMLAB";
            label23.Click += label23_Click;
            // 
            // panel24
            // 
            panel24.BackColor = SystemColors.ControlLight;
            panel24.Location = new Point(342, 521);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(149, 26);
            panel24.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 0, 0);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 315F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 5, 0);
            tableLayoutPanel1.Controls.Add(button7, 3, 0);
            tableLayoutPanel1.Controls.Add(button6, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox13, 1, 0);
            tableLayoutPanel1.Location = new Point(2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(798, 93);
            tableLayoutPanel1.TabIndex = 100;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 107;
            pictureBox4.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(475, 30);
            button5.Margin = new Padding(70, 30, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(83, 33);
            button5.TabIndex = 104;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(725, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(70, 85);
            button4.TabIndex = 102;
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(564, 30);
            button7.Margin = new Padding(3, 30, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(77, 33);
            button7.TabIndex = 105;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(647, 30);
            button6.Margin = new Padding(3, 30, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(72, 33);
            button6.TabIndex = 106;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(192, 0, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(120, 30);
            textBox13.Margin = new Padding(30, 30, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(282, 55);
            textBox13.TabIndex = 103;
            textBox13.Text = "Iskedular";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Maroon;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthCalendar1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(279, 470);
            tableLayoutPanel2.TabIndex = 102;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.FromArgb(192, 0, 0);
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 315F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 2, 0);
            tableLayoutPanel3.Controls.Add(button2, 5, 0);
            tableLayoutPanel3.Controls.Add(button3, 3, 0);
            tableLayoutPanel3.Controls.Add(button8, 4, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel3.Location = new Point(3, -2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(796, 95);
            tableLayoutPanel3.TabIndex = 101;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(475, 30);
            button1.Margin = new Padding(70, 30, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(83, 33);
            button1.TabIndex = 104;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(725, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(68, 87);
            button2.TabIndex = 102;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(564, 30);
            button3.Margin = new Padding(3, 30, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(77, 33);
            button3.TabIndex = 105;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 0, 0);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(647, 30);
            button8.Margin = new Padding(3, 30, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(72, 33);
            button8.TabIndex = 106;
            button8.Text = "Reserve";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 0, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(120, 30);
            textBox2.Margin = new Padding(30, 30, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 55);
            textBox2.TabIndex = 103;
            textBox2.Text = "Iskedular";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 562);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel24);
            Controls.Add(panel22);
            Controls.Add(label23);
            Controls.Add(panel23);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(panel21);
            Controls.Add(panel20);
            Controls.Add(panel19);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(panel18);
            Controls.Add(panel17);
            Controls.Add(panel16);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "x";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel24;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox4;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button6;
        private TextBox textBox13;
        private TableLayoutPanel tableLayoutPanel2;
        private MonthCalendar monthCalendar1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button8;
        private TextBox textBox2;
    }
}