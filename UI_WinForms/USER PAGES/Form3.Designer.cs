namespace UI_WinForms
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panelTopNav = new Panel();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            panelMainContentWrapper = new Panel();
            panelContentToCenter = new Panel();
            comboBoxEndAmPm = new ComboBox();
            comboBoxStartAmPm = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            labelHint = new Label();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContentWrapper.SuspendLayout();
            panelContentToCenter.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(button6);
            panelTopNav.Controls.Add(button7);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(textBox2);
            panelTopNav.Controls.Add(pictureBox1);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1024, 89);
            panelTopNav.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(952, 18);
            button4.Name = "button4";
            button4.Size = new Size(51, 52);
            button4.TabIndex = 110;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(850, 30);
            button6.Name = "button6";
            button6.Size = new Size(86, 40);
            button6.TabIndex = 105;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(758, 30);
            button7.Name = "button7";
            button7.Size = new Size(86, 40);
            button7.TabIndex = 104;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(666, 30);
            button5.Name = "button5";
            button5.Size = new Size(86, 40);
            button5.TabIndex = 103;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 106;
            pictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 0, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(90, 27);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(200, 40);
            textBox2.TabIndex = 107;
            textBox2.TabStop = false;
            textBox2.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 89);
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // panelMainContentWrapper
            // 
            panelMainContentWrapper.BackColor = SystemColors.ControlLight;
            panelMainContentWrapper.Controls.Add(panelContentToCenter);
            panelMainContentWrapper.Dock = DockStyle.Fill;
            panelMainContentWrapper.Location = new Point(0, 89);
            panelMainContentWrapper.Name = "panelMainContentWrapper";
            panelMainContentWrapper.Size = new Size(1024, 611);
            panelMainContentWrapper.TabIndex = 1;
            // 
            // panelContentToCenter
            // 
            panelContentToCenter.Anchor = AnchorStyles.None;
            panelContentToCenter.BackColor = Color.WhiteSmoke;
            panelContentToCenter.Controls.Add(labelHint);
            panelContentToCenter.Controls.Add(comboBoxEndAmPm);
            panelContentToCenter.Controls.Add(comboBoxStartAmPm);
            panelContentToCenter.Controls.Add(textBox7);
            panelContentToCenter.Controls.Add(textBox6);
            panelContentToCenter.Controls.Add(textBox4);
            panelContentToCenter.Controls.Add(button2);
            panelContentToCenter.Controls.Add(textBox13);
            panelContentToCenter.Controls.Add(textBox12);
            panelContentToCenter.Controls.Add(textBox11);
            panelContentToCenter.Controls.Add(textBox10);
            panelContentToCenter.Controls.Add(textBox9);
            panelContentToCenter.Controls.Add(textBox1);
            panelContentToCenter.Controls.Add(comboBox1);
            panelContentToCenter.Controls.Add(textBox3);
            panelContentToCenter.Controls.Add(textBox5);
            panelContentToCenter.Controls.Add(monthCalendar1);
            panelContentToCenter.Location = new Point(70, 20);
            panelContentToCenter.Name = "panelContentToCenter";
            panelContentToCenter.Size = new Size(880, 560);
            panelContentToCenter.TabIndex = 0;
            // 
            // comboBoxEndAmPm
            // 
            comboBoxEndAmPm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEndAmPm.Items.AddRange(new object[] { "AM", "PM" });
            comboBoxEndAmPm.Location = new Point(649, 185);
            comboBoxEndAmPm.Name = "comboBoxEndAmPm";
            comboBoxEndAmPm.Size = new Size(60, 28);
            comboBoxEndAmPm.TabIndex = 0;
            // 
            // comboBoxStartAmPm
            // 
            comboBoxStartAmPm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStartAmPm.Items.AddRange(new object[] { "AM", "PM" });
            comboBoxStartAmPm.Location = new Point(649, 133);
            comboBoxStartAmPm.Name = "comboBoxStartAmPm";
            comboBoxStartAmPm.Size = new Size(60, 28);
            comboBoxStartAmPm.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(539, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 27);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(539, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(429, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 20);
            textBox4.TabIndex = 8;
            textBox4.Text = "End Time";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(353, 446);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 9;
            button2.Text = "BOOK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(429, 381);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(390, 27);
            textBox13.TabIndex = 10;
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Location = new Point(429, 351);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 20);
            textBox12.TabIndex = 11;
            textBox12.Text = "Professor";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(429, 299);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(390, 27);
            textBox11.TabIndex = 12;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(429, 261);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 20);
            textBox10.TabIndex = 13;
            textBox10.Text = "Purpose";
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(429, 133);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 20);
            textBox9.TabIndex = 14;
            textBox9.Text = "Start Time";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Bold);
            textBox1.Location = new Point(38, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 20);
            textBox1.TabIndex = 15;
            textBox1.Text = "Choose Date";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.Location = new Point(178, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 31);
            comboBox1.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 10F, FontStyle.Bold);
            textBox3.Location = new Point(38, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 20);
            textBox3.TabIndex = 17;
            textBox3.Text = "Select Room";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.Location = new Point(251, 21);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(400, 26);
            textBox5.TabIndex = 18;
            textBox5.Text = "ROOM RESERVATION FORM";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(38, 203);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 19;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            labelHint.ForeColor = Color.Gray;
            labelHint.Location = new Point(429, 216);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(282, 19);
            labelHint.TabIndex = 20;
            labelHint.Text = "Format: hh:mm (e.g., 6 or 6:30). Use AM/PM.";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1024, 700);
            Controls.Add(panelMainContentWrapper);
            Controls.Add(panelTopNav);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            Resize += Form3_Resize;
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainContentWrapper.ResumeLayout(false);
            panelContentToCenter.ResumeLayout(false);
            panelContentToCenter.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelTopNav;
        private PictureBox pictureBox4;
        private Button button6;
        private Button button7;
        private Button button5;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel panelMainContentWrapper;
        private Panel panelContentToCenter;
        private MonthCalendar monthCalendar1;
        private TextBox textBox5;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBoxEndAmPm;
        private ComboBox comboBoxStartAmPm;
        private Button button4;
        private Label labelHint;
    }
}