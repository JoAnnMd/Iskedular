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
    public partial class Form3 : Form
    {
        // ADDED: Field to hold the injected service provider
        private readonly IServiceProvider _serviceProvider;

        // MODIFIED: Constructor now accepts IServiceProvider
        public Form3(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign the injected service provider
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
            MessageBox.Show("You are already on the Reserve screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // MODIFIED: Get Form4 instance via DI
            Form4 profileForm = _serviceProvider.GetRequiredService<Form4>();
            profileForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // --- Placeholder for collecting reservation data ---
            // --- Placeholder for input validation ---
            // --- Placeholder for Database Saving Logic (Future Implementation with EF Core) ---

            MessageBox.Show("Reservation request submitted! (Simulated)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // MODIFIED: Get Form5 instance via DI
            Form5 confirmationForm = _serviceProvider.GetRequiredService<Form5>();
            confirmationForm.Show();
            this.Hide();
        }
    }
}
