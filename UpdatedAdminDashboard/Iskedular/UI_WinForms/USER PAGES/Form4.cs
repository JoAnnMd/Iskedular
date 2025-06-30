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
    public partial class Form4 : Form
    {
        private readonly IServiceProvider _serviceProvider; // Added for dependency injection

        public Form4(IServiceProvider serviceProvider) // Modified constructor
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign injected service provider
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            Form2 roomsForm = _serviceProvider.GetRequiredService<Form2>(); // Get Form2 from DI
            roomsForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>(); // Get Form3 from DI
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Profile screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}