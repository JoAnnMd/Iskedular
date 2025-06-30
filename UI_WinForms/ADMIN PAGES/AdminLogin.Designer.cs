namespace UI_WinForms
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            mainContentPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox13 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            button4 = new Button();
            mainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainContentPanel
            // 
            mainContentPanel.BackColor = Color.White;
            mainContentPanel.Controls.Add(pictureBox1);
            mainContentPanel.Controls.Add(pictureBox2);
            mainContentPanel.Controls.Add(textBox13);
            mainContentPanel.Controls.Add(textBox3);
            mainContentPanel.Controls.Add(textBox1);
            mainContentPanel.Controls.Add(textBox2);
            mainContentPanel.Controls.Add(textBox8);
            mainContentPanel.Controls.Add(textBox7);
            mainContentPanel.Controls.Add(button4);
            mainContentPanel.Location = new Point(282, 253);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(325, 524);
            mainContentPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.IskedularLogo;
            pictureBox1.Location = new Point(101, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 100;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic);
            textBox13.ForeColor = Color.Red;
            textBox13.Location = new Point(73, 143);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(189, 36);
            textBox13.TabIndex = 101;
            textBox13.Text = "Iskedular";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(110, 185);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(120, 24);
            textBox3.TabIndex = 102;
            textBox3.Text = "Admin Login";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(45, 28);
            textBox1.TabIndex = 103;
            textBox1.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(58, 266);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 104;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(35, 305);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(75, 28);
            textBox8.TabIndex = 105;
            textBox8.Text = "Password";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.InactiveCaption;
            textBox7.Location = new Point(58, 341);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '*';
            textBox7.Size = new Size(204, 27);
            textBox7.TabIndex = 106;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.ForeColor = Color.White;
            button4.Location = new Point(129, 390);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 107;
            button4.Text = "Log In";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.Screenshot_2025_06_15_224250;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 562);
            Controls.Add(mainContentPanel);
            Name = "AdminLogin";
            Load += AdminLogin_Load;
            mainContentPanel.ResumeLayout(false);
            mainContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
    }
}
