using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = new Form2(); // Create an instance of Form2
            roomsForm.Show();              // Show Form2
            this.Hide();                   // Hide Form1 (the current user dashboard)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Since Home goes to Form1 itself, we don't need to create a new instance
            // or hide the current form unless you want to refresh it.
            // For now, this effectively does nothing, keeping you on Form1.
            // If you wanted to, for example, refresh content on Form1, you might put:
            // this.Invalidate();
            // this.Refresh();
            // or reload specific data.
            MessageBox.Show("You are already on the Home screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = new Form3(); // Create an instance of Form3
            reserveForm.Show();              // Show Form3
            this.Hide();                     // Hide Form1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = new Form4(); // Create an instance of Form4
            profileForm.Show();              // Show Form4
            this.Hide();                     // Hide Form1
        }
    }
}
