using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace UI_WinForms
{
    public partial class Form19 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Form19(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Hook up the Resize event to re-center the tableLayoutPanel when the form size changes
            this.Resize += new System.EventHandler(this.Form19_Resize);
        }

        private void Form19_Load(object? sender, EventArgs e)
        {
            // Fullscreen setup (from previous discussions, ensures borderless and covers taskbar)
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal; // Set to Normal first, then Bounds, which makes it fullscreen
            this.Bounds = Screen.PrimaryScreen!.Bounds;

            // Center the tableLayoutPanel AFTER the form has been sized to fullscreen
            CenterTableLayoutPanel();
        }

        private void Form19_Resize(object? sender, EventArgs e)
        {
            // Re-center the tableLayoutPanel when the form is resized (e.g., if it's not fullscreen or user resizes)
            CenterTableLayoutPanel();
        }

        private void CenterTableLayoutPanel()
        {
            // Calculate the new location to center tableLayoutPanel1
            int x = (this.ClientSize.Width - tableLayoutPanel1.Width) / 2;
            int y = (this.ClientSize.Height - tableLayoutPanel1.Height) / 2;

            // Set the new location
            tableLayoutPanel1.Location = new System.Drawing.Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 studentLoginForm = _serviceProvider.GetRequiredService<Form7>();
            studentLoginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginForm = _serviceProvider.GetRequiredService<AdminLogin>();
            adminLoginForm.Show();
            this.Hide();
        }
    }
}