using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // Added for IServiceProvider

namespace UI_WinForms
{
    public partial class Form2 : Form
    {
        private readonly IServiceProvider _serviceProvider; // Added for dependency injection

        public Form2(IServiceProvider serviceProvider) // Modified constructor
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign injected service provider
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
            Form1 homeForm = _serviceProvider.GetRequiredService<Form1>(); // Get Form1 from DI
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Rooms screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>(); // Get Form3 from DI
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 profileForm = _serviceProvider.GetRequiredService<Form4>(); // Get Form4 from DI
            profileForm.Show();
            this.Hide();
        }
    }
}