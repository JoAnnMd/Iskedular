namespace UI_WinForms
{
    partial class Form6
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            textBox13 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button4, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox13, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox6, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox8, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox7, 1, 3);
            tableLayoutPanel1.Location = new Point(164, 104);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(567, 236);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.ForeColor = Color.White;
            button4.Location = new Point(246, 188);
            button4.Margin = new Padding(20, 30, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 29);
            button4.TabIndex = 122;
            button4.Text = "Change Password";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Elephant", 11.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox13.ForeColor = Color.Red;
            textBox13.Location = new Point(3, 4);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(220, 30);
            textBox13.TabIndex = 115;
            textBox13.Text = "Change Password";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(80, 129);
            textBox6.Margin = new Padding(80, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 120;
            textBox6.Text = "Confirm Password";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(90, 97);
            textBox8.Margin = new Padding(90, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(106, 24);
            textBox8.TabIndex = 118;
            textBox8.Text = "New Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(90, 64);
            textBox1.Margin = new Padding(90, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 25);
            textBox1.TabIndex = 116;
            textBox1.Text = "Old Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InactiveCaption;
            textBox5.Location = new Point(229, 64);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 27);
            textBox5.TabIndex = 121;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(229, 97);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 117;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.InactiveCaption;
            textBox7.Location = new Point(229, 129);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(232, 27);
            textBox7.TabIndex = 119;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private TextBox textBox13;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox2;
        private TextBox textBox5;
    }
}