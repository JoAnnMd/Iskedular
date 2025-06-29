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
            tabControlRequests = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pendingRequestsPanel = new FlowLayoutPanel();
            rejectedRequestsPanel = new FlowLayoutPanel();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelMainContentWrapper.SuspendLayout();
            panelContentToCenter.SuspendLayout();
            tabControlRequests.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopNav
            // 
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
            panelTopNav.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(944, 10);
            button4.Name = "button4";
            button4.Size = new Size(48, 64);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(854, 30);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 1;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(762, 30);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 2;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(670, 30);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 3;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(578, 30);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 4;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(82, 28);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 40);
            textBox4.TabIndex = 6;
            textBox4.Text = "Iskedular";
            // 
            // panelMainContentWrapper
            // 
            panelMainContentWrapper.BackColor = SystemColors.ControlLight;
            panelMainContentWrapper.Controls.Add(panelContentToCenter);
            panelMainContentWrapper.Dock = DockStyle.Fill;
            panelMainContentWrapper.Location = new Point(0, 89);
            panelMainContentWrapper.Name = "panelMainContentWrapper";
            panelMainContentWrapper.Size = new Size(1024, 639);
            panelMainContentWrapper.TabIndex = 0;
            // 
            // panelContentToCenter
            // 
            panelContentToCenter.Controls.Add(tabControlRequests);
            panelContentToCenter.Dock = DockStyle.Fill;
            panelContentToCenter.Location = new Point(0, 0);
            panelContentToCenter.Name = "panelContentToCenter";
            panelContentToCenter.Size = new Size(1024, 639);
            panelContentToCenter.TabIndex = 0;
            // 
            // tabControlRequests
            // 
            tabControlRequests.Controls.Add(tabPage1);
            tabControlRequests.Controls.Add(tabPage2);
            tabControlRequests.Location = new Point(12, 6);
            tabControlRequests.Name = "tabControlRequests";
            tabControlRequests.SelectedIndex = 0;
            tabControlRequests.Size = new Size(1000, 630);
            tabControlRequests.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pendingRequestsPanel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(882, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPagePending";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rejectedRequestsPanel);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(992, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPageRejected";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pendingRequestsPanel
            // 
            pendingRequestsPanel.AutoScroll = true;
            pendingRequestsPanel.Dock = DockStyle.Fill;
            pendingRequestsPanel.Location = new Point(3, 3);
            pendingRequestsPanel.Name = "pendingRequestsPanel";
            pendingRequestsPanel.Size = new Size(876, 549);
            pendingRequestsPanel.TabIndex = 1;
            // 
            // rejectedRequestsPanel
            // 
            rejectedRequestsPanel.Dock = DockStyle.Fill;
            rejectedRequestsPanel.Location = new Point(3, 3);
            rejectedRequestsPanel.Name = "rejectedRequestsPanel";
            rejectedRequestsPanel.Size = new Size(986, 591);
            rejectedRequestsPanel.TabIndex = 0;
            // 
            // PendingRequest
            // 
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelMainContentWrapper.ResumeLayout(false);
            panelContentToCenter.ResumeLayout(false);
            tabControlRequests.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
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
        private TabControl tabControlRequests;
        private TabPage tabPage1;
        private FlowLayoutPanel pendingRequestsPanel;
        private TabPage tabPage2;
        private FlowLayoutPanel rejectedRequestsPanel;
    }
}