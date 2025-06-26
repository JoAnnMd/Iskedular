namespace UI_WinForms
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            loginButton = new Button();
            button2 = new Button();
            textBox10 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox13 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 22);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 524);
            textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(259, 225);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(45, 28);
            textBox3.TabIndex = 12;
            textBox3.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(282, 261);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.InactiveCaption;
            textBox7.Location = new Point(282, 343);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.PasswordChar = '*';
            textBox7.Size = new Size(204, 27);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(259, 307);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(75, 28);
            textBox8.TabIndex = 19;
            textBox8.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Maroon;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(353, 412);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 29);
            loginButton.TabIndex = 21;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(411, 449);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 98;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Microsoft Sans Serif", 4.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(284, 457);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(121, 24);
            textBox10.TabIndex = 97;
            textBox10.Text = "Don't have an account yet?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jun_18__2025__05_06_57_PM_removebg_preview;
            pictureBox1.Location = new Point(325, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.Red;
            textBox13.Location = new Point(297, 165);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(189, 36);
            textBox13.TabIndex = 100;
            textBox13.Text = "Iskeduler";
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 562);
            Controls.Add(textBox13);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox10);
            Controls.Add(loginButton);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
       // private System.Windows.Forms.Button loginButton_Click;
        private Button button2;
        private TextBox textBox10;
        private PictureBox pictureBox1;
        private TextBox textBox13;
        private Button loginButton;
    }
}