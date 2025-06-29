using System.Drawing;
using System.Windows.Forms;

namespace UI_WinForms
{
    partial class PendingRequest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingRequest));
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
            pendingRequestsPanel = new FlowLayoutPanel();
            textBox5 = new TextBox();

            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            panelMainContentWrapper.SuspendLayout();
            panelContentToCenter.SuspendLayout();
            SuspendLayout();

            // panelTopNav
            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button4);
            panelTopNav.Controls.Add(button3);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(button1);
            panelTopNav.Controls.Add(button2);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(textBox4);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Size = new Size(1024, 89);

            // button4 (Logout)
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(944, 10);
            button4.Size = new Size(48, 64);
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;

            // button3 (Requests)
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(854, 30);
            button3.Size = new Size(86, 29);
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            // button5 (Dashboard)
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(762, 30);
            button5.Size = new Size(86, 29);
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;

            // button1 (Rooms)
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(670, 30);
            button1.Size = new Size(86, 29);
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // button2 (Bookings)
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(578, 30);
            button2.Size = new Size(86, 29);
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // pictureBox4 (Logo)
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            // textBox4 (App Name)
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(82, 28);
            textBox4.Multiline = true;
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 40);
            textBox4.Text = "Iskedular";

            // panelMainContentWrapper
            panelMainContentWrapper.BackColor = SystemColors.ControlLight;
            panelMainContentWrapper.Controls.Add(panelContentToCenter);
            panelMainContentWrapper.Dock = DockStyle.Fill;

            // panelContentToCenter
            panelContentToCenter.Controls.Add(pendingRequestsPanel);
            panelContentToCenter.Controls.Add(textBox5);
            panelContentToCenter.Dock = DockStyle.Fill;

            // textBox5 (Header)
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(20, 10);
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(300, 26);
            textBox5.Text = "Pending Requests";

            // pendingRequestsPanel
            pendingRequestsPanel.Dock = DockStyle.Fill;
            pendingRequestsPanel.AutoScroll = true;

            // PendingRequest Form
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

            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            panelMainContentWrapper.ResumeLayout(false);
            panelContentToCenter.ResumeLayout(false);
            panelContentToCenter.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelTopNav;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private Panel panelMainContentWrapper;
        private Panel panelContentToCenter;
        private TextBox textBox5;
        private FlowLayoutPanel pendingRequestsPanel;
    }
}