namespace UI_WinForms
{
    partial class Bookings_Total
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings_Total));
            panelTopNav = new Panel();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panelTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panelTopNav.Controls.Add(pictureBox1);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1000, 89);
            panelTopNav.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(850, 30);
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
            button5.Location = new Point(754, 30);
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
            button1.Location = new Point(658, 30);
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
            button2.Location = new Point(562, 30);
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
            pictureBox4.Size = new Size(72, 57);
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
            textBox4.Location = new Point(90, 27);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 27);
            textBox4.TabIndex = 6;
            textBox4.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 89);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = SystemColors.Control;
            panelMainContent.Controls.Add(textBox5);
            panelMainContent.Controls.Add(dataGridView1);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 89);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1000, 611);
            panelMainContent.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Elephant", 12F, FontStyle.Bold);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(20, 30);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 27);
            textBox5.TabIndex = 0;
            textBox5.Text = "Total Bookings";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(960, 500);
            dataGridView1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(942, 13);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 241;
            button4.UseVisualStyleBackColor = true;
            // 
            // Bookings_Total
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelMainContent);
            Controls.Add(panelTopNav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bookings_Total";
            Text = "Total Bookings";
            WindowState = FormWindowState.Maximized;
            panelTopNav.ResumeLayout(false);
            panelTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button4;
    }
}
