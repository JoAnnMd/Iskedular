using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_WinForms
{
    public partial class Form4 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string _fullName;
        private readonly string _email;
        private readonly string _programSection;

        // Modified constructor with additional parameters
        public Form4(IServiceProvider serviceProvider, string fullName, string email, string programSection)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _fullName = fullName;
            _email = email;
            _programSection = programSection;

            // Hook up the Load event
            this.Load += Form4_Load;
        }

        // Overload for navigation from session (for backward compatibility)
        public Form4(IServiceProvider serviceProvider, Iskedular.Models.User user)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _fullName = user.FirstName;
            _email = user.Email;
            _programSection = user.ProgramSection;
            this.Load += Form4_Load;
        }

        // Set UI data when the form loads
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox9.ReadOnly = false;
            textBox11.ReadOnly = false;
            textBox3.ReadOnly = false;

            textBox9.Text = _fullName;
            textBox11.Text = _email;
            textBox3.Text = _programSection;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 homeForm = _serviceProvider.GetRequiredService<Form1>();
            homeForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 roomsForm = _serviceProvider.GetRequiredService<Form2>();
            roomsForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 reserveForm = _serviceProvider.GetRequiredService<Form3>();
            reserveForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Profile screen.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get SessionService from the service provider
            var sessionService = (Iskedular.Core.Services.SessionService)_serviceProvider.GetService(typeof(Iskedular.Core.Services.SessionService));
            sessionService?.ClearSession();

            // Show Form19 (main entry form)
            var form19 = _serviceProvider.GetRequiredService<Form19>();
            form19.Show();
            this.Hide();
        }

        // Add missing event handlers as empty methods if referenced in the designer
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
