namespace UI_WinForms
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.ComboBox comboBoxStartAmPm;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.ComboBox comboBoxEndAmPm;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            monthCalendar1 = new MonthCalendar();
            textBoxStartTime = new TextBox();
            comboBoxStartAmPm = new ComboBox();
            textBoxEndTime = new TextBox();
            comboBoxEndAmPm = new ComboBox();
            labelStart = new Label();
            labelEnd = new Label();
            flowLayoutPanelRooms = new FlowLayoutPanel();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            panelTop = new Panel();
            button4 = new Button();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar1.Location = new Point(25, 100);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBoxStartTime
            // 
            textBoxStartTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxStartTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxStartTime.Location = new Point(32, 358);
            textBoxStartTime.Name = "textBoxStartTime";
            textBoxStartTime.Size = new Size(95, 27);
            textBoxStartTime.TabIndex = 4;
            textBoxStartTime.TextChanged += textBoxStartTime_TextChanged;
            // 
            // comboBoxStartAmPm
            // 
            comboBoxStartAmPm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxStartAmPm.Location = new Point(162, 358);
            comboBoxStartAmPm.Name = "comboBoxStartAmPm";
            comboBoxStartAmPm.Size = new Size(96, 28);
            comboBoxStartAmPm.TabIndex = 5;
            comboBoxStartAmPm.SelectedIndexChanged += comboBoxStartAmPm_SelectedIndexChanged;
            // 
            // textBoxEndTime
            // 
            textBoxEndTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxEndTime.Location = new Point(32, 418);
            textBoxEndTime.Name = "textBoxEndTime";
            textBoxEndTime.Size = new Size(95, 27);
            textBoxEndTime.TabIndex = 7;
            textBoxEndTime.TextChanged += textBoxEndTime_TextChanged;
            // 
            // comboBoxEndAmPm
            // 
            comboBoxEndAmPm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxEndAmPm.Location = new Point(162, 418);
            comboBoxEndAmPm.Name = "comboBoxEndAmPm";
            comboBoxEndAmPm.Size = new Size(96, 28);
            comboBoxEndAmPm.TabIndex = 8;
            comboBoxEndAmPm.SelectedIndexChanged += comboBoxEndAmPm_SelectedIndexChanged;
            // 
            // labelStart
            // 
            labelStart.Location = new Point(32, 338);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(100, 23);
            labelStart.TabIndex = 3;
            labelStart.Text = "Start Time:";
            // 
            // labelEnd
            // 
            labelEnd.Location = new Point(32, 398);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(100, 23);
            labelEnd.TabIndex = 6;
            labelEnd.Text = "End Time:";
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanelRooms.AutoScroll = true;
            flowLayoutPanelRooms.Location = new Point(318, 100);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(830, 600);
            flowLayoutPanelRooms.TabIndex = 9;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(856, 23);
            button7.Name = "button7";
            button7.Size = new Size(100, 35);
            button7.TabIndex = 4;
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
            button5.Location = new Point(750, 22);
            button5.Name = "button5";
            button5.Size = new Size(100, 36);
            button5.TabIndex = 2;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(962, 23);
            button6.Name = "button6";
            button6.Size = new Size(92, 35);
            button6.TabIndex = 3;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(192, 0, 0);
            panelTop.Controls.Add(button4);
            panelTop.Controls.Add(textBox2);
            panelTop.Controls.Add(pictureBox4);
            panelTop.Controls.Add(button6);
            panelTop.Controls.Add(button5);
            panelTop.Controls.Add(button7);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1166, 77);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1103, 10);
            button4.Name = "button4";
            button4.Size = new Size(51, 52);
            button4.TabIndex = 110;
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 0, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(105, 18);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(200, 40);
            textBox2.TabIndex = 108;
            textBox2.TabStop = false;
            textBox2.Text = "Iskedular";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 107;
            pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            ClientSize = new Size(1166, 693);
            Controls.Add(panelTop);
            Controls.Add(monthCalendar1);
            Controls.Add(labelStart);
            Controls.Add(textBoxStartTime);
            Controls.Add(comboBoxStartAmPm);
            Controls.Add(labelEnd);
            Controls.Add(textBoxEndTime);
            Controls.Add(comboBoxEndAmPm);
            Controls.Add(flowLayoutPanelRooms);
            Name = "Form2";
            Text = "Available Rooms";
            Load += Form2_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button7;
        private Button button5;
        private Button button6;
        private Panel panelTop;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private Button button4;
    }
}
