namespace UI_WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTopNav = new Panel();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBoxTitle = new TextBox();
            monthCalendar1 = new MonthCalendar();
            flowLayoutPanelReservations = new FlowLayoutPanel();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(button6);
            panelTopNav.Controls.Add(button7);
            panelTopNav.Controls.Add(textBoxTitle);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1208, 80);
            panelTopNav.TabIndex = 0;
            panelTopNav.Paint += panelTopNav_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1145, 13);
            button4.Name = "button4";
            button4.Size = new Size(51, 52);
            button4.TabIndex = 109;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(814, 23);
            button5.Name = "button5";
            button5.Size = new Size(100, 35);
            button5.TabIndex = 0;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1026, 23);
            button6.Name = "button6";
            button6.Size = new Size(100, 35);
            button6.TabIndex = 1;
            button6.Text = "Room";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(920, 23);
            button7.Name = "button7";
            button7.Size = new Size(100, 35);
            button7.TabIndex = 2;
            button7.Text = "Reserve";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.FromArgb(192, 0, 0);
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxTitle.Font = new Font("Elephant", 14F, FontStyle.Bold | FontStyle.Italic);
            textBoxTitle.ForeColor = Color.White;
            textBoxTitle.Location = new Point(85, 25);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(200, 40);
            textBoxTitle.TabIndex = 4;
            textBoxTitle.Text = "Iskedular";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Segoe UI", 10F);
            monthCalendar1.Location = new Point(17, 101);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // flowLayoutPanelReservations
            // 
            flowLayoutPanelReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelReservations.AutoScroll = true;
            flowLayoutPanelReservations.Location = new Point(300, 101);
            flowLayoutPanelReservations.Name = "flowLayoutPanelReservations";
            flowLayoutPanelReservations.Size = new Size(878, 619);
            flowLayoutPanelReservations.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1208, 750);
            Controls.Add(flowLayoutPanelReservations);
            Controls.Add(monthCalendar1);
            Controls.Add(panelTopNav);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReservations;
        private TextBox textBoxTitle;
        private PictureBox pictureBox4;
        private Button button4;
    }
}

