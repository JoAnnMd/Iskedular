namespace UI_WinForms
{
    partial class Form16
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            textBox1 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(26, 110);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(743, 413);
            textBox1.TabIndex = 142;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(228, 238);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(295, 56);
            button6.TabIndex = 143;
            button6.Text = "✅ Approve Request";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(228, 332);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(292, 56);
            button7.TabIndex = 144;
            button7.Text = "❎ Delete Request";
            button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 16);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 230;
            pictureBox4.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(192, 0, 0);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(91, 33);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 40);
            textBox4.TabIndex = 224;
            textBox4.Text = "Iskedular";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 89);
            pictureBox1.TabIndex = 223;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(745, 15);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(48, 69);
            button4.TabIndex = 240;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(641, 33);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 239;
            button3.Text = "Requests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(547, 33);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 238;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(455, 33);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 237;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(364, 33);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 236;
            button2.Text = "Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form16";
            Text = "Form16";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
    }
}