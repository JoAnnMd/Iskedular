using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace UI_WinForms
{
    public partial class AddEditUserForm : Form
    {
        private User currentUser;

        private TextBox txtFullName;
        private TextBox txtEmail;
        private ComboBox comboRole;
        private Button btnSave;
        private Button btnCancel;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblRole;

        public AddEditUserForm(User user = null)
        {
            InitializeComponent();
            currentUser = user;
            if (currentUser != null)
            {
                txtFullName.Text = currentUser.FullName;
                txtEmail.Text = currentUser.Email;
                comboRole.SelectedItem = currentUser.Role;
            }
        }

        private void InitializeComponent()
        {
            this.txtFullName = new TextBox();
            this.txtEmail = new TextBox();
            this.comboRole = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.lblFullName = new Label();
            this.lblEmail = new Label();
            this.lblRole = new Label();

            this.SuspendLayout();

            // lblFullName
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Location = new System.Drawing.Point(20, 20);
            this.lblFullName.Size = new System.Drawing.Size(80, 23);

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(120, 20);
            this.txtFullName.Size = new System.Drawing.Size(250, 23);

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 60);
            this.lblEmail.Size = new System.Drawing.Size(80, 23);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 60);
            this.txtEmail.Size = new System.Drawing.Size(250, 23);

            // lblRole
            this.lblRole.Text = "Role:";
            this.lblRole.Location = new System.Drawing.Point(20, 100);
            this.lblRole.Size = new System.Drawing.Size(80, 23);

            // comboRole
            this.comboRole.Items.AddRange(new object[] { "Admin", "User" });
            this.comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboRole.Location = new System.Drawing.Point(120, 100);
            this.comboRole.Size = new System.Drawing.Size(250, 23);

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(120, 150);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(230, 150);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // AddEditUserForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "AddEditUserForm";
            this.Text = "Add/Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || comboRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var user = new User
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Role = comboRole.SelectedItem.ToString()
            };

            if (currentUser != null)
            {
                user.Id = currentUser.Id;
                Database.UpdateUser(user);
            }
            else
            {
                Database.AddUser(user);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Stub User and Database class for compilation (remove if already defined elsewhere)
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    public static class Database
    {
        public static void AddUser(User user) { /* Add logic */ }
        public static void UpdateUser(User user) { /* Update logic */ }
    }
}
