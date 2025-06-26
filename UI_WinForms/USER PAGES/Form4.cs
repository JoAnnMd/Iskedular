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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of Form1 (User Dashboard/Home)
            homeForm.Show();              // Show Form1
            this.Hide();                  // Hide Form4
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = new Form2(); // Create an instance of Form2
            roomsForm.Show();              // Show Form2
            this.Hide();                  // Hide Form4
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = new Form3(); // Create an instance of Form3
            reserveForm.Show();              // Show Form3
            this.Hide();                     // Hide Form4
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // You are already on the Profile screen (Form4).
            // Similar to Form1's Home button, this keeps you on the current form.
            MessageBox.Show("You are already on the Profile screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
