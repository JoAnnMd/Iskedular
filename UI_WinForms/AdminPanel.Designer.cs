using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Iskedular
{
    public partial class AdminPanelForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControlMain;
        private TabPage tabDashboard;
        private TabPage tabUsers;
        private TabPage tabSettings;
        private Label lblWelcome;
        private DataGridView dataGridViewUsers;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Button btnLogout;

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new TabControl();
            this.tabDashboard = new TabPage();
            this.lblWelcome = new Label();
            this.tabUsers = new TabPage();
            this.dataGridViewUsers = new DataGridView();
            this.btnAddUser = new Button();
            this.btnEditUser = new Button();
            this.btnDeleteUser = new Button();
            this.tabSettings = new TabPage();
            this.btnLogout = new Button();

            // TabControl
            this.tabControlMain.Controls.Add(this.tabDashboard);
            this.tabControlMain.Controls.Add(this.tabUsers);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Dock = DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);

            // Dashboard Tab
            this.tabDashboard.Controls.Add(this.lblWelcome);
            this.tabDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(792, 422);
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;

            // Welcome Label
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 30);
            this.lblWelcome.Text = "Welcome, Admin!";

            // Users Tab
            this.tabUsers.Controls.Add(this.dataGridViewUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.btnEditUser);
            this.tabUsers.Controls.Add(this.btnDeleteUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 24);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(792, 422);
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;

            // DataGridView
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(750, 300);

            // Add User Button
            this.btnAddUser.Location = new System.Drawing.Point(20, 340);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 30);
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new EventHandler(this.btnAddUser_Click);

            // Edit User Button
            this.btnEditUser.Location = new System.Drawing.Point(130, 340);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 30);
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new EventHandler(this.btnEditUser_Click);

            // Delete User Button
            this.btnDeleteUser.Location = new System.Drawing.Point(240, 340);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new EventHandler(this.btnDeleteUser_Click);

            // Settings Tab
            this.tabSettings.Controls.Add(this.btnLogout);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(792, 422);
            this.tabSettings.Text = "Admin Settings";
            this.tabSettings.UseVisualStyleBackColor = true;

            // Logout Button
            this.btnLogout.Location = new System.Drawing.Point(20, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // AdminPanelForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.Load += new EventHandler(this.AdminPanelForm_Load);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Placeholder - implement as needed
            MessageBox.Show("Add User Clicked");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Placeholder - implement as needed
            MessageBox.Show("Edit User Clicked");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Placeholder - implement as needed
            MessageBox.Show("Delete User Clicked");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Placeholder - implement as needed
            MessageBox.Show("Logout Clicked");
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // Placeholder - implement as needed
            lblWelcome.Text = "Welcome, Admin!";
        }
    }
}


