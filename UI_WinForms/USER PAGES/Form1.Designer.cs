namespace UI_WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox13 = new TextBox();
            button5 = new Button();
            button7 = new Button();
            pictureBox4 = new PictureBox();
            button6 = new Button();
            button4 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            monthCalendar1 = new MonthCalendar();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox7 = new TextBox();
            textBox10 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 0, 0);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 315F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 5, 0);
            tableLayoutPanel1.Controls.Add(button7, 3, 0);
            tableLayoutPanel1.Controls.Add(button6, 4, 0);
            tableLayoutPanel1.Controls.Add(textBox13, 1, 0);
            tableLayoutPanel1.Location = new Point(1, -1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(809, 95);
            tableLayoutPanel1.TabIndex = 99;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(192, 0, 0);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.White;
            textBox13.Location = new Point(120, 30);
            textBox13.Margin = new Padding(30, 30, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(282, 55);
            textBox13.TabIndex = 103;
            textBox13.Text = "Iskedular";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(475, 30);
            button5.Margin = new Padding(70, 30, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(83, 33);
            button5.TabIndex = 104;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(564, 30);
            button7.Margin = new Padding(3, 30, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(77, 33);
            button7.TabIndex = 105;
            button7.Text = "Rooms";
            button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Enabled = false;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 107;
            pictureBox4.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(647, 30);
            button6.Margin = new Padding(3, 30, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(72, 33);
            button6.TabIndex = 106;
            button6.Text = "Reserve";
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(725, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(70, 87);
            button4.TabIndex = 102;
            button4.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Maroon;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(monthCalendar1, 0, 0);
            tableLayoutPanel2.Location = new Point(-2, 96);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(279, 470);
            tableLayoutPanel2.TabIndex = 100;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(textBox10, 0, 5);
            tableLayoutPanel3.Controls.Add(textBox7, 0, 3);
            tableLayoutPanel3.Controls.Add(textBox11, 0, 2);
            tableLayoutPanel3.Controls.Add(textBox12, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 4);
            tableLayoutPanel3.Location = new Point(323, 148);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(450, 402);
            tableLayoutPanel3.TabIndex = 101;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 10);
            label2.Margin = new Padding(10, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 117;
            label2.Text = "Hi, Isko/Iska";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 189);
            label1.Margin = new Padding(10, 25, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 116;
            label1.Text = "Announcement";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.Maroon;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(10, 67);
            textBox12.Margin = new Padding(10, 10, 3, 4);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(208, 23);
            textBox12.TabIndex = 115;
            textBox12.Text = "June 15, 8:00am - 12:00pm";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.Maroon;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(10, 104);
            textBox11.Margin = new Padding(10, 10, 3, 4);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(156, 23);
            textBox11.TabIndex = 114;
            textBox11.Text = "Laboratory Room";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Maroon;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(10, 141);
            textBox7.Margin = new Padding(10, 10, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(129, 17);
            textBox7.TabIndex = 112;
            textBox7.Text = "Status: Pending";
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.ScrollBar;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(3, 243);
            textBox10.Margin = new Padding(3, 30, 3, 4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(444, 155);
            textBox10.TabIndex = 111;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(812, 562);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button5;
        private TextBox textBox13;
        private PictureBox pictureBox4;
        private Button button6;
        private Button button4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MonthCalendar monthCalendar1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox10;
        private TextBox textBox7;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label1;
        private Label label2;
    }
}

