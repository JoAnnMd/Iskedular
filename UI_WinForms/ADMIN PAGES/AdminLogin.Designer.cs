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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));

            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // IskedularLogo
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Admin Icon (if used)
            this.textBox13 = new System.Windows.Forms.TextBox(); // Iskedular title
            this.textBox3 = new System.Windows.Forms.TextBox(); // Admin Login title
            this.textBox1 = new System.Windows.Forms.TextBox(); // Email Label
            this.textBox2 = new System.Windows.Forms.TextBox(); // Email Input
            this.textBox8 = new System.Windows.Forms.TextBox(); // Password Label
            this.textBox7 = new System.Windows.Forms.TextBox(); // Password Input
            this.button4 = new System.Windows.Forms.Button(); // Login Button

            this.mainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            //
            // mainContentPanel
            //
            // Changed BackColor to White to make the panel visible
            this.mainContentPanel.BackColor = System.Drawing.Color.White;
            this.mainContentPanel.Controls.Add(this.pictureBox1);
            this.mainContentPanel.Controls.Add(this.pictureBox2);
            this.mainContentPanel.Controls.Add(this.textBox13);
            this.mainContentPanel.Controls.Add(this.textBox3);
            this.mainContentPanel.Controls.Add(this.textBox1);
            this.mainContentPanel.Controls.Add(this.textBox2);
            this.mainContentPanel.Controls.Add(this.textBox8);
            this.mainContentPanel.Controls.Add(this.textBox7);
            this.mainContentPanel.Controls.Add(this.button4);
            this.mainContentPanel.Size = new System.Drawing.Size(325, 524); // Size based on Form7's main content panel
            // The Location for mainContentPanel will be set dynamically in AdminLogin.cs Load event
            this.mainContentPanel.Location = new System.Drawing.Point(
                (this.ClientSize.Width - this.mainContentPanel.Width) / 2,
                (this.ClientSize.Height - this.mainContentPanel.Height) / 2
            );
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.TabIndex = 0; // Set appropriate tab index for the panel
            //
            // pictureBox1 (Iskedular Logo - assuming this is the main logo like in Form7)
            //
            this.pictureBox1.BackColor = System.Drawing.Color.White; // Inherit from panel or set explicitly
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // Assuming this is the main Iskedular logo from your resources, same as Form7
            this.pictureBox1.Image = Properties.Resources.IskedularLogo;
            // Adjusted location relative to mainContentPanel (similar to Form7's PictureBox1)
            this.pictureBox1.Location = new System.Drawing.Point(101, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            //
            // pictureBox2 (Optional: Admin Icon if it's different from IskedularLogo, or remove if not needed)
            // If this is meant to be a separate admin icon, ensure its resource is correct.
            // If it's not needed, remove it from mainContentPanel.Controls.Add() and here.
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // You might need to change "pictureBox2.Image" to your specific admin icon resource
            // Example: this.pictureBox2.Image = Properties.Resources.AdminIcon;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(134, 10); // Example relative position within the panel
            this.pictureBox2.Size = new System.Drawing.Size(57, 49); // Keep existing size
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100; // Adjusted for new control order if needed
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false; // Hide if not strictly needed or conflicting with pictureBox1
            //
            // textBox13 (App Name: Iskedular)
            //
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.textBox13.ForeColor = System.Drawing.Color.Red;
            // Adjusted location relative to mainContentPanel (similar to Form7's textBox13)
            this.textBox13.Location = new System.Drawing.Point(73, 143);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(189, 36);
            this.textBox13.TabIndex = 101; // Adjusted tab index
            this.textBox13.Text = "Iskedular";
            //
            // textBox3 (Admin Login Title)
            //
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            // Adjusted location relative to mainContentPanel, centered below Iskedular title
            this.textBox3.Location = new System.Drawing.Point(110, 185); // Adjusted to be below the Iskedular title
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 24);
            this.textBox3.TabIndex = 102; // Adjusted tab index
            this.textBox3.Text = "Admin Login";
            //
            // textBox1 (Email Label)
            //
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0); // Changed font size to match Form7
            // Adjusted location relative to mainContentPanel (similar to Form7's textBox3)
            this.textBox1.Location = new System.Drawing.Point(35, 230); // Adjusted for better spacing
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 28); // Adjusted size to match Form7
            this.textBox1.TabIndex = 103; // Adjusted tab index
            this.textBox1.Text = "Email";
            //
            // textBox2 (Email Input)
            //
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            // Adjusted location relative to mainContentPanel (similar to Form7's textBox2)
            this.textBox2.Location = new System.Drawing.Point(58, 266); // Adjusted for better spacing
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 27); // Standard size from Form7
            this.textBox2.TabIndex = 104; // Adjusted tab index
            //
            // textBox8 (Password Label)
            //
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0); // Changed font size to match Form7
            // Adjusted location relative to mainContentPanel (similar to Form7's textBox8)
            this.textBox8.Location = new System.Drawing.Point(35, 305); // Adjusted for better spacing
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 28); // Standard size from Form7
            this.textBox8.TabIndex = 105; // Adjusted tab index
            this.textBox8.Text = "Password";
            //
            // textBox7 (Password Input)
            //
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            // Adjusted location relative to mainContentPanel (similar to Form7's textBox7)
            this.textBox7.Location = new System.Drawing.Point(58, 341); // Adjusted for better spacing
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*'; // Set in Designer for security
            this.textBox7.Size = new System.Drawing.Size(204, 27); // Standard size from Form7
            this.textBox7.TabIndex = 106; // Adjusted tab index
            //
            // button4 (Login Button)
            //
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.ForeColor = System.Drawing.Color.White;
            // Adjusted location relative to mainContentPanel (similar to Form7's loginButton)
            this.button4.Location = new System.Drawing.Point(129, 390);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29); // Standard size from Form7
            this.button4.TabIndex = 107; // Adjusted tab index
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            //
            // AdminLogin (the form)
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow; // Still kept as a fallback for the main form
            this.BackgroundImage = UI_WinForms.Properties.Resources.Screenshot_2025_06_15_224250;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 562); // Set initial client size, will be overridden by Bounds in AdminLogin.cs
            this.Controls.Add(this.mainContentPanel);
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
