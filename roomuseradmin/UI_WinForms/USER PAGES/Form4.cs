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
    public partial class Form4 : Form
    {
        // ADDED: Field to hold the injected service provider
        private readonly IServiceProvider _serviceProvider;

        // MODIFIED: Constructor now accepts IServiceProvider
        public Form4(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign the injected service provider
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your existing logic
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // MODIFIED: Get Form1 instance via DI
            Form1 homeForm = _serviceProvider.GetRequiredService<Form1>();
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // MODIFIED: Get Form2 instance via DI
            Form2 roomsForm = _serviceProvider.GetRequiredService<Form2>();
            roomsForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // MODIFIED: Get Form3 instance via DI
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Profile screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
