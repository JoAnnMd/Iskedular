using Iskedular.Data;
using Iskedular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class admin_bookings : Form
    {
        private DataGridView dgvBookings;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private ApplicationDbContext db = new ApplicationDbContextFactory().CreateDbContext(null); // ✅


        public admin_bookings()
        {
            InitializeComponent();
            InitializeAdminControls();
            LoadBookings();
        }

        private void InitializeAdminControls()
        {
            dgvBookings = new DataGridView
            {
                Location = new Point(30, 350),
                Size = new Size(700, 250),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            Controls.Add(dgvBookings);

            cmbStatus = new ComboBox
            {
                Location = new Point(750, 350),
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbStatus.Items.AddRange(Enum.GetNames(typeof(ReservationStatus)));
            Controls.Add(cmbStatus);

            btnUpdateStatus = new Button
            {
                Text = "Update Status",
                Location = new Point(750, 390)
            };
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            Controls.Add(btnUpdateStatus);
        }

        private void LoadBookings()
        {
            var bookings = db.Reservations
                .Include(r => r.Room)
                .Include(r => r.User)
                .Select(r => new
                {
                    r.Id,
                    Room = r.Room != null ? r.Room.Name : "Unknown",
                    Date = r.StartTime.Date,
                    Time = $"{r.StartTime.ToShortTimeString()} - {r.EndTime.ToShortTimeString()}",
                    r.Purpose,
                    r.Status,
                    User = r.User != null ? r.User.Email : "Unknown"
                })
                .ToList();

            dgvBookings.DataSource = bookings;
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a new status to apply.", "No Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = (int)dgvBookings.CurrentRow.Cells["Id"].Value;
            var reservation = db.Reservations.FirstOrDefault(r => r.Id == reservationId);

            if (reservation != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to update the status?",
                                              "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                if (Enum.TryParse<ReservationStatus>(cmbStatus.SelectedItem.ToString(), out var newStatus))
                {
                    reservation.Status = newStatus;
                    db.SaveChanges();
                    MessageBox.Show("Reservation status updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                }
                else
                {
                    MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ Add missing event handlers from the Designer

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rooms button clicked.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bookings button clicked.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requests button clicked.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard button clicked.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View all bookings clicked.");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Room 103 label clicked.");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Room 201 label clicked.");
        }
    }
}
