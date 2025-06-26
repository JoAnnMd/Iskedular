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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of Form1 (User Dashboard/Home)
            homeForm.Show();              // Show Form1
            this.Hide();                  // Hide Form2
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // You are already on the Rooms screen (Form2).
            // Similar to Form1's Home button, this keeps you on the current form.
            MessageBox.Show("You are already on the Rooms screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = new Form3(); // Create an instance of Form3
            reserveForm.Show();              // Show Form3
            this.Hide();                     // Hide Form2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = new Form4(); // Create an instance of Form4
            profileForm.Show();              // Show Form4
            this.Hide();                     // Hide Form2
        }
    }
}
