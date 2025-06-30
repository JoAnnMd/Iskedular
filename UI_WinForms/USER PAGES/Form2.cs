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
using Iskedular.Core.Services; // Added for SessionService

namespace UI_WinForms
{
    public partial class Form2 : Form
    {
        private readonly IServiceProvider _serviceProvider; // Added for dependency injection
        private readonly SessionService _sessionService; // Added for session management

        public Form2(IServiceProvider serviceProvider, SessionService sessionService) // Modified constructor
        {
            InitializeComponent();
            _serviceProvider = serviceProvider; // Assign injected service provider
            _sessionService = sessionService; // Assign injected session service
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
            // Get current user from session service
            var currentUser = _sessionService.LoggedInUser;
            if (currentUser != null)
            {
                // Create Form4 with user information
                Form4 profileForm = new Form4(_serviceProvider, currentUser);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not logged in. Please log in first.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}