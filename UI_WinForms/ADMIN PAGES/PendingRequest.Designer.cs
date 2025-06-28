namespace UI_WinForms
{
    partial class PendingRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingRequest));
            panelTopNav = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            panelMainContentWrapper = new Panel();
            panelContentToCenter = new Panel();
            textBox5 = new TextBox();
            pendingRequestsPanel = new FlowLayoutPanel();

            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(button3);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(button1);
            panelTopNav.Controls.Add(button2);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(textBox4);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1024, 89);
            panelTopNav.TabIndex = 0;

            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(960, 10);
            button4.Name = "button4";
            button4.Size = new Size(48, 64);
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;

            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(870, 30);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(778, 30);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;

            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(686, 30);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(594, 30);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabStop = false;

            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(82, 28);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 40);
            textBox4.Text = "Iskedular";

            panelMainContentWrapper.Dock = DockStyle.Fill;
            panelMainContentWrapper.BackColor = SystemColors.ControlLight;
            panelMainContentWrapper.Controls.Add(panelContentToCenter);
            panelMainContentWrapper.Location = new Point(0, 89);
            panelMainContentWrapper.Name = "panelMainContentWrapper";
            panelMainContentWrapper.Size = new Size(1024, 639);
            panelMainContentWrapper.TabIndex = 1;

            panelContentToCenter.Dock = DockStyle.Fill;
            panelContentToCenter.BackColor = Color.Transparent;
            panelContentToCenter.Controls.Add(pendingRequestsPanel);
            panelContentToCenter.Controls.Add(textBox5);
            panelContentToCenter.Name = "panelContentToCenter";

            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(20, 10);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(300, 30);
            textBox5.Text = "Pending Requests";

            pendingRequestsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pendingRequestsPanel.AutoScroll = true;
            pendingRequestsPanel.WrapContents = true;
            pendingRequestsPanel.FlowDirection = FlowDirection.LeftToRight;
            pendingRequestsPanel.Location = new Point(20, 50);
            pendingRequestsPanel.Name = "pendingRequestsPanel";
            pendingRequestsPanel.Size = new Size(980, 560);
            pendingRequestsPanel.TabIndex = 123;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 728);
            Controls.Add(panelMainContentWrapper);
            Controls.Add(panelTopNav);
            Name = "PendingRequest";
            Text = "PendingRequest";
            Load += PendingRequest_Load;
            Resize += PendingRequest_Resize;
        }

        private Panel panelTopNav;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Panel panelMainContentWrapper;
        private Panel panelContentToCenter;
        private TextBox textBox5;
        private FlowLayoutPanel pendingRequestsPanel;
    }
}
