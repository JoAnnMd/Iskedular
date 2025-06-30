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
            comboBox3 = new ComboBox();
            textBox14 = new TextBox();
            textBox8 = new TextBox();
            comboBox2 = new ComboBox();
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
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContentWrapper.SuspendLayout();
            panelContentToCenter.SuspendLayout();
            SuspendLayout();

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

            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(968, 10);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 101;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;

            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(850, 30);
            button6.Name = "button6";
            button6.Size = new Size(86, 29);
            button6.TabIndex = 105;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;

            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(758, 30);
            button7.Name = "button7";
            button7.Size = new Size(86, 29);
            button7.TabIndex = 104;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;

            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(666, 30);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 103;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;

            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabStop = false;

            textBox2.BackColor = Color.FromArgb(192, 0, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(90, 27);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(200, 40);
            textBox2.TabStop = false;
            textBox2.Text = "Iskedular";

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 89);
            pictureBox1.TabStop = false;

            panelMainContentWrapper.BackColor = SystemColors.ControlLight;
            panelMainContentWrapper.Controls.Add(panelContentToCenter);
            panelMainContentWrapper.Dock = DockStyle.Fill;
            panelMainContentWrapper.Location = new Point(0, 89);
            panelMainContentWrapper.Name = "panelMainContentWrapper";
            panelMainContentWrapper.Size = new Size(1024, 611);
            panelMainContentWrapper.TabIndex = 1;

            panelContentToCenter.Anchor = AnchorStyles.None;
            panelContentToCenter.BackColor = Color.WhiteSmoke;
            panelContentToCenter.Controls.Add(comboBoxEndAmPm);
            panelContentToCenter.Controls.Add(comboBoxStartAmPm);
            panelContentToCenter.Controls.Add(comboBox3);
            panelContentToCenter.Controls.Add(textBox14);
            panelContentToCenter.Controls.Add(textBox8);
            panelContentToCenter.Controls.Add(comboBox2);
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

            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.Location = new Point(20, 20);
            textBox5.Size = new Size(400, 30);
            textBox5.ReadOnly = true;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Text = "ROOM RESERVATION FORM";

            textBox3.Text = "Select Room";
            textBox3.Location = new Point(30, 70);
            textBox3.Size = new Size(130, 30);
            textBox3.Font = new Font("Arial", 10, FontStyle.Bold);
            textBox3.BorderStyle = BorderStyle.None;

            comboBox1.Location = new Point(170, 70);
            comboBox1.Size = new Size(200, 30);
            comboBox1.Font = new Font("Segoe UI", 10F);

            textBox1.Text = "Choose Date";
            textBox1.Location = new Point(30, 120);
            textBox1.Size = new Size(130, 30);
            textBox1.Font = new Font("Arial", 10, FontStyle.Bold);
            textBox1.BorderStyle = BorderStyle.None;

            monthCalendar1.Location = new Point(30, 160);
            monthCalendar1.MaxSelectionCount = 1;

            textBox9.Text = "Start Time";
            textBox9.Location = new Point(430, 30);
            textBox9.Size = new Size(100, 30);
            textBox9.BorderStyle = BorderStyle.None;

            textBox6.Location = new Point(540, 30);
            textBox6.Size = new Size(100, 30);

            comboBoxStartAmPm.Location = new Point(650, 30);
            comboBoxStartAmPm.Size = new Size(60, 30);
            comboBoxStartAmPm.Items.AddRange(new object[] { "AM", "PM" });
            comboBoxStartAmPm.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox4.Text = "End Time";
            textBox4.Location = new Point(430, 70);
            textBox4.Size = new Size(100, 30);
            textBox4.BorderStyle = BorderStyle.None;

            textBox7.Location = new Point(540, 70);
            textBox7.Size = new Size(100, 30);

            comboBoxEndAmPm.Location = new Point(650, 70);
            comboBoxEndAmPm.Size = new Size(60, 30);
            comboBoxEndAmPm.Items.AddRange(new object[] { "AM", "PM" });
            comboBoxEndAmPm.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox8.Text = "Program";
            textBox8.Location = new Point(430, 110);
            textBox8.BorderStyle = BorderStyle.None;

            comboBox2.Location = new Point(540, 110);
            comboBox2.Size = new Size(280, 30);

            textBox14.Text = "Year and Section";
            textBox14.Location = new Point(430, 150);
            textBox14.BorderStyle = BorderStyle.None;

            comboBox3.Location = new Point(540, 150);
            comboBox3.Size = new Size(200, 30);

            textBox10.Text = "Purpose";
            textBox10.Location = new Point(430, 200);
            textBox10.BorderStyle = BorderStyle.None;

            textBox11.Location = new Point(430, 230);
            textBox11.Size = new Size(390, 70);

            textBox12.Text = "Professor";
            textBox12.Location = new Point(430, 310);
            textBox12.BorderStyle = BorderStyle.None;

            textBox13.Location = new Point(430, 340);
            textBox13.Size = new Size(390, 50);

            button2.Text = "BOOK";
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.ForeColor = Color.White;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(430, 410);
            button2.Size = new Size(120, 40);
            button2.Click += button2_Click;

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
        private Button button4;
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
        private TextBox textBox8;
        private TextBox textBox14;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBoxEndAmPm;
        private ComboBox comboBoxStartAmPm;
    }
}