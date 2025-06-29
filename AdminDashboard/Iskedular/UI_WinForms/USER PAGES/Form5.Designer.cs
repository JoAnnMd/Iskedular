namespace UI_WinForms
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panelWrapper = new Panel();
            textBox5 = new TextBox();
            textBox10 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            panelTopNav = new Panel();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            textBox13 = new TextBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelWrapper.SuspendLayout();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelWrapper
            // 
            panelWrapper.Anchor = AnchorStyles.None;
            panelWrapper.BackColor = Color.White;
            panelWrapper.Controls.Add(textBox5);
            panelWrapper.Controls.Add(textBox10);
            panelWrapper.Controls.Add(button2);
            panelWrapper.Controls.Add(button4);
            panelWrapper.Location = new Point(0, 90);
            panelWrapper.Name = "panelWrapper";
            panelWrapper.Size = new Size(1024, 610);
            panelWrapper.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 18F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(362, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 39);
            textBox5.TabIndex = 0;
            textBox5.Text = "BOOKING INFO";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.WhiteSmoke;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Font = new Font("Segoe UI", 11F);
            textBox10.Location = new Point(200, 70);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ScrollBars = ScrollBars.Horizontal;
            textBox10.Size = new Size(620, 360);
            textBox10.TabIndex = 1;
            textBox10.Text = "Your Reservation Info";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            button2.ForeColor = Color.LimeGreen;
            button2.Location = new Point(552, 450);
            button2.Name = "button2";
            button2.Size = new Size(100, 80);
            button2.TabIndex = 2;
            button2.Text = "✅";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(372, 450);
            button4.Name = "button4";
            button4.Size = new Size(100, 80);
            button4.TabIndex = 3;
            button4.Text = "❎";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.FromArgb(192, 0, 0);
            panelTopNav.Controls.Add(button6);
            panelTopNav.Controls.Add(button7);
            panelTopNav.Controls.Add(button5);
            panelTopNav.Controls.Add(textBox13);
            panelTopNav.Controls.Add(pictureBox4);
            panelTopNav.Controls.Add(button1);
            panelTopNav.Controls.Add(pictureBox1);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1024, 89);
            panelTopNav.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(860, 30);
            button6.Name = "button6";
            button6.Size = new Size(86, 29);
            button6.TabIndex = 0;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(768, 30);
            button7.Name = "button7";
            button7.Size = new Size(86, 29);
            button7.TabIndex = 1;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(676, 30);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 2;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(192, 0, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(82, 28);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(160, 40);
            textBox13.TabIndex = 3;
            textBox13.Text = "Iskedular";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(960, 20);
            button1.Name = "button1";
            button1.Size = new Size(55, 51);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 89);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 700);
            Controls.Add(panelWrapper);
            Controls.Add(panelTopNav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            panelWrapper.ResumeLayout(false);
            panelWrapper.PerformLayout();
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel panelWrapper;
        private TextBox textBox5;
        private TextBox textBox10;
        private Button button2;
        private Button button4;
        private Panel panelTopNav;
        private Button button6;
        private Button button7;
        private Button button5;
        private TextBox textBox13;
        private PictureBox pictureBox4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}