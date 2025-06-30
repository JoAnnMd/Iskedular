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
            this.panelTopNav = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button(); // Home
            this.button6 = new System.Windows.Forms.Button(); // Reserve
            this.button7 = new System.Windows.Forms.Button(); // Rooms
            this.button4 = new System.Windows.Forms.Button(); // Profile
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanelReservations = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTopNav
            // 
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.panelTopNav.Controls.Add(this.button5);
            this.panelTopNav.Controls.Add(this.button6);
            this.panelTopNav.Controls.Add(this.button7);
            this.panelTopNav.Controls.Add(this.button4);
            this.panelTopNav.Controls.Add(this.textBoxTitle);
            this.panelTopNav.Controls.Add(this.pictureBoxLogo);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(1200, 80);
            this.panelTopNav.TabIndex = 0;

            // 
            // button5 (Home)
            // 
            this.button5.Text = "Home";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.Location = new System.Drawing.Point(850, 25);
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button5.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Click += new System.EventHandler(this.button5_Click);

            // 
            // button6 (Reserve)
            // 
            this.button6.Text = "Reserve";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.Location = new System.Drawing.Point(960, 25);
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // 
            // button7 (Rooms)
            // 
            this.button7.Text = "Rooms";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.Location = new System.Drawing.Point(1070, 25);
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button7.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Click += new System.EventHandler(this.button7_Click);

            // 
            // button4 (Profile)
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1180, 20);
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Text = "Iskedular";
            this.textBoxTitle.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Location = new System.Drawing.Point(85, 25);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Size = new System.Drawing.Size(200, 40);
            this.textBoxTitle.ReadOnly = true;

            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 8);
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 120);
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);

            // 
            // flowLayoutPanelReservations
            // 
            this.flowLayoutPanelReservations.AutoScroll = true;
            this.flowLayoutPanelReservations.Location = new System.Drawing.Point(300, 120);
            this.flowLayoutPanelReservations.Size = new System.Drawing.Size(850, 600);
            this.flowLayoutPanelReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.flowLayoutPanelReservations.WrapContents = true;

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.flowLayoutPanelReservations);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelTopNav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReservations;
    }
}

