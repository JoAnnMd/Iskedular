namespace UI_WinForms
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.comboBoxStartAmPm = new System.Windows.Forms.ComboBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.comboBoxEndAmPm = new System.Windows.Forms.ComboBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkRed;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 70;
            this.panelTop.Controls.Add(this.logo);
            this.panelTop.Controls.Add(this.labelAppName);
            this.panelTop.Controls.Add(this.button5);
            this.panelTop.Controls.Add(this.button6);
            this.panelTop.Controls.Add(this.button7);
            this.panelTop.Controls.Add(this.button4);
            // 
            // logo
            // 
            //this.logo.Image = Properties.Resources.logo;
            this.logo.Size = new System.Drawing.Size(48, 48);
            this.logo.Location = new System.Drawing.Point(20, 10);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // labelAppName
            // 
            this.labelAppName.Text = "Iskedular";
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(75, 18);
            this.labelAppName.AutoSize = true;
            // 
            // button5 (Home)
            // 
            this.button5.Text = "Home";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.Location = new System.Drawing.Point(750, 20);
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6 (Reserve)
            // 
            this.button6.Text = "Reserve";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.Location = new System.Drawing.Point(860, 20);
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7 (Rooms)
            // 
            this.button7.Text = "Rooms";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.Location = new System.Drawing.Point(970, 20);
            this.button7.BackColor = System.Drawing.Color.DarkRed;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4 (Profile)
            // 
            //this.button4.Image = Properties.Resources.profile_icon;
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.Location = new System.Drawing.Point(1080, 10);
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // Calendar
            //
            this.monthCalendar1.Location = new System.Drawing.Point(30, 100);
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            //
            // Start Time
            //
            this.labelStart.Text = "Start Time:";
            this.labelStart.Location = new System.Drawing.Point(30, 280);
            this.textBoxStartTime.Location = new System.Drawing.Point(30, 300);
            this.comboBoxStartAmPm.Location = new System.Drawing.Point(140, 300);
            this.comboBoxStartAmPm.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartAmPm_SelectedIndexChanged);
            this.textBoxStartTime.TextChanged += new System.EventHandler(this.textBoxStartTime_TextChanged);
            //
            // End Time
            //
            this.labelEnd.Text = "End Time:";
            this.labelEnd.Location = new System.Drawing.Point(30, 340);
            this.textBoxEndTime.Location = new System.Drawing.Point(30, 360);
            this.comboBoxEndAmPm.Location = new System.Drawing.Point(140, 360);
            this.comboBoxEndAmPm.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndAmPm_SelectedIndexChanged);
            this.textBoxEndTime.TextChanged += new System.EventHandler(this.textBoxEndTime_TextChanged);

            Label lblHint = new Label
            {
                Text = "Format: hh:mm (e.g., 6 or 6:30). Use AM/PM.",
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(textBoxStartTime.Left, textBoxStartTime.Bottom + 5)
            };
            this.Controls.Add(lblHint);

            //
            // FlowLayoutPanel
            //
            this.flowLayoutPanelRooms.AutoScroll = true;
            this.flowLayoutPanelRooms.Location = new System.Drawing.Point(250, 100);
            this.flowLayoutPanelRooms.Size = new System.Drawing.Size(1100, 600);
            //
            // Form2
            //
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.comboBoxStartAmPm);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.comboBoxEndAmPm);
            this.Controls.Add(this.flowLayoutPanelRooms);
            this.Text = "Available Rooms";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
