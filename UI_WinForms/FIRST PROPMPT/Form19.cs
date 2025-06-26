using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // IServiceProvider was used

// Specific using directives for sub-namespaces were not needed here,
// as Form7, AdminLogin, and Form19 were all confirmed to be within the 'namespace UI_WinForms'.

namespace UI_WinForms // Form19's namespace was confirmed as UI_WinForms
{
    public partial class Form19 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        // The constructor was set up for Dependency Injection: IServiceProvider was injected.
        public Form19(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // Setup code for Form19 when it loaded was added here.
            // Fullscreen setup was applied, and the null-forgiving operator was used for Screen.PrimaryScreen.
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen!.Bounds; // Warning CS8602 was addressed with '!'
        }

        // The button1_Click event was configured to direct to student login (Form7).
        private void button1_Click(object sender, EventArgs e)
        {
            // Form7 instance was retrieved from the DI container.
            Form7 studentLoginForm = _serviceProvider.GetRequiredService<Form7>();

            // Form7 was shown.
            studentLoginForm.Show();

            // The current form (Form19) was hidden.
            this.Hide();
        }

        // The button2_Click event was configured to direct to admin login (AdminLogin).
        private void button2_Click(object sender, EventArgs e)
        {
            // AdminLogin instance was retrieved from the DI container.
            AdminLogin adminLoginForm = _serviceProvider.GetRequiredService<AdminLogin>();

            // AdminLogin was shown.
            adminLoginForm.Show();

            // The current form (Form19) was hidden.
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form19_Load_1(object sender, EventArgs e)
        {

        }
    }
}
