using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Iskedular.Models;
using Iskedular.Core.Services;

namespace UI_WinForms
{
    public partial class FormManageRooms : Form
    {
        private readonly RoomService _roomService;
        private readonly IServiceProvider _serviceProvider;

        public FormManageRooms(IServiceProvider serviceProvider, RoomService roomService)
        {
            InitializeComponent();
            _roomService = roomService;
            _serviceProvider = serviceProvider;
            Load += FormManageRooms_Load;
        }

        private async void FormManageRooms_Load(object sender, EventArgs e)
        {
            await LoadRoomsIntoDataGridView();
        }

        private async Task LoadRoomsIntoDataGridView()
        {
            var rooms = await _roomService.GetAllRoomsAsync();
            dataGridViewRooms.DataSource = rooms;

            // Add columns only once
            if (dataGridViewRooms.Columns["EditButton"] == null)
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Edit",
                    Width = 60
                };
                dataGridViewRooms.Columns.Add(editBtn);
            }

            if (dataGridViewRooms.Columns["DeleteButton"] == null)
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Delete",
                    Width = 70
                };
                dataGridViewRooms.Columns.Add(deleteBtn);
            }

            dataGridViewRooms.AutoResizeColumns();
        }

        private async void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewRooms.Rows[e.RowIndex];
            var room = row.DataBoundItem as Room;

            if (room == null) return;

            if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "EditButton")
            {
                var form = _serviceProvider.GetRequiredService<FormAddEditRoom>();
                form.SetRoom(room);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await LoadRoomsIntoDataGridView();
                }
            }
            else if (dataGridViewRooms.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var confirm = MessageBox.Show($"Delete room '{room.Name}'?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    await _roomService.DeleteRoomAsync(room.Id);
                    await LoadRoomsIntoDataGridView();
                }
            }
        }

        private async void buttonAddRoom_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormAddEditRoom>();
            form.SetRoom(null); // New room
            if (form.ShowDialog() == DialogResult.OK)
            {
                await LoadRoomsIntoDataGridView();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Rooms_Main>();
            form.Show();
            this.Close(); // Closes current window only (not app)
        }
    }
}