using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // ADDED: Required for IServiceProvider

namespace UI_WinForms
{
    public partial class Form5 : Form
    {
        // ADDED: Field to hold the injected service provider
        private readonly IServiceProvider _serviceProvider;

        // MODIFIED: Constructor now accepts IServiceProvider
        public Form5(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign the injected service provider
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // --- Placeholder for final database saving logic ---
            MessageBox.Show("Information saved! (Simulated)", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // MODIFIED: Get Form1 instance via DI
            Form1 dashboardForm = _serviceProvider.GetRequiredService<Form1>();
            dashboardForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // MODIFIED: Get Form3 instance via DI
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide();
        }
    }
}
