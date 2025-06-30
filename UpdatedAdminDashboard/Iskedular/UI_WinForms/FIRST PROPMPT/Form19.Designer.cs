namespace UI_WinForms
{
    partial class Form19
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            textBox13 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox13, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 1, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.Size = new Size(504, 422);
            tableLayoutPanel1.TabIndex = 97;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.IskedularLogo;
            pictureBox1.Location = new Point(138, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.Black;
            textBox13.Location = new Point(162, 148);
            textBox13.Margin = new Padding(27, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(199, 40);
            textBox13.TabIndex = 100;
            textBox13.Text = "Iskedular";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(138, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 16);
            textBox2.TabIndex = 101;
            textBox2.Text = " A real-time room reservation of PUPQC";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(190, 278);
            button1.Margin = new Padding(55, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(132, 45);
            button1.TabIndex = 98;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(190, 345);
            button2.Margin = new Padding(55, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(132, 45);
            button2.TabIndex = 99;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 562);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form19";
            Text = "Form19";
            Load += Form19_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox13;
    }
}
