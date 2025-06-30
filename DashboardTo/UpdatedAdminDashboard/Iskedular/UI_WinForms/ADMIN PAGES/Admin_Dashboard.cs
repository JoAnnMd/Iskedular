using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iskedular.Core.Services;
using Iskedular.Models;
using Microsoft.Extensions.DependencyInjection;

namespace UI_WinForms
{
    public partial class Admin_Dashboard : Form
    {
        // --------------------------------------------------------------------
        // DEPENDENCIES
        // --------------------------------------------------------------------
        private readonly IServiceProvider _serviceProvider;
        private readonly ReservationService _reservationService;
        private readonly RoomService _roomService;
        private readonly UserService _userService;

        public Admin_Dashboard(IServiceProvider serviceProvider,
                               ReservationService reservationService,
                               RoomService roomService,
                               UserService userService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _reservationService = reservationService;
            _roomService = roomService;
            _userService = userService;

            Load += Admin_Dashboard_Load;
            Activated += Admin_Dashboard_Activated;
        }

        // --------------------------------------------------------------------
        // FORM LIFECYCLE
        // --------------------------------------------------------------------
        private async void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // Full‑screen border‑less window
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            Bounds = Screen.PrimaryScreen!.Bounds;

            int screenWidth = ClientSize.Width;
            int screenHeight = ClientSize.Height;

            // ---------------- Top (red) bar -------------------------------------------------------
            pictureBox1.Size = new Size(screenWidth, 102);
            pictureBox1.Location = new Point(0, -1);

            pictureBox4.Location = new Point(16,
                                             (pictureBox1.Height - pictureBox4.Height) / 2);
            textBox4.Location = new Point(pictureBox4.Right + 6,
                                             (pictureBox1.Height - textBox4.Height) / 2);

            // Navigation buttons (right‑to‑left so they hug the right edge neatly)
            int btnSpacing = 15;
            int currentRight = screenWidth - button4.Width - 14;

            button4.Location = new Point(currentRight,
                                         (pictureBox1.Height - button4.Height) / 2);

            currentRight -= btnSpacing + button3.Width;
            button3.Location = new Point(currentRight,
                                         (pictureBox1.Height - button3.Height) / 2);

            currentRight -= btnSpacing + button5.Width;
            button5.Location = new Point(currentRight,
                                         (pictureBox1.Height - button5.Height) / 2);

            currentRight -= btnSpacing + button1.Width;
            button1.Location = new Point(currentRight,
                                         (pictureBox1.Height - button1.Height) / 2);

            currentRight -= btnSpacing + button2.Width;
            button2.Location = new Point(currentRight,
                                         (pictureBox1.Height - button2.Height) / 2);

            // ---------------- Dashboard header ----------------------------------------------------
            label1.Location = new Point((screenWidth - label1.Width) / 2,
                                        pictureBox1.Bottom + 25);

            // ---------------- Metric tiles --------------------------------------------------------
            int infoSpacing = 20;
            int infoY = label1.Bottom + 30;

            // Total width of the 4 picture‑box + text‑box pairs plus spacing
            int totalInfoWidth =
                (pictureBox2.Width + textBox2.Width) +
                (pictureBox3.Width + textBox1.Width) +
                (pictureBox5.Width + textBox3.Width) +
                (pictureBox6.Width + textBox6.Width) +
                infoSpacing * 3;

            int startX = (screenWidth - totalInfoWidth) / 2;

            // --- Available rooms (yellow) --------------------------------------------------------
            pictureBox2.Location = new Point(startX, infoY);
            textBox2.Location = new Point(pictureBox2.Right, infoY);
            textBox9.Location = new Point(textBox2.Left + (textBox2.Width - textBox9.Width) / 2,
                                             textBox2.Top + 21);
            textBox10.Location = new Point(textBox2.Left + (textBox2.Width - textBox10.Width) / 2,
                                             textBox2.Top + 58);

            // --- Pending requests (orange) -------------------------------------------------------
            pictureBox3.Location = new Point(textBox2.Right + infoSpacing, infoY);
            textBox1.Location = new Point(pictureBox3.Right, infoY);
            textBox11.Location = new Point(textBox1.Left + (textBox1.Width - textBox11.Width) / 2,
                                             textBox1.Top + 21);
            textBox12.Location = new Point(textBox1.Left + (textBox1.Width - textBox12.Width) / 2,
                                             textBox1.Top + 58);

            // --- Today’s bookings (green) --------------------------------------------------------
            pictureBox5.Location = new Point(textBox1.Right + infoSpacing, infoY);
            textBox3.Location = new Point(pictureBox5.Right, infoY);
            textBox15.Location = new Point(textBox3.Left + (textBox3.Width - textBox15.Width) / 2,
                                             textBox3.Top + 21);
            textBox13.Location = new Point(textBox3.Left + (textBox3.Width - textBox13.Width) / 2,
                                             textBox3.Top + 58);

            // --- Total users (blue) --------------------------------------------------------------
            pictureBox6.Location = new Point(textBox3.Right + infoSpacing, infoY);
            textBox6.Location = new Point(pictureBox6.Right, infoY);
            textBox16.Location = new Point(textBox6.Left + (textBox6.Width - textBox16.Width) / 2,
                                             textBox6.Top + 21);
            textBox14.Location = new Point(textBox6.Left + (textBox6.Width - textBox14.Width) / 2,
                                             textBox6.Top + 58);

            // ---------------- Activity log panel --------------------------------------------------
            int activityY = infoY + textBox2.Height + 50;
            int calcActivityHeight = screenHeight - activityY - 20;
            int activityHeight = Math.Max(calcActivityHeight, 130);

            textBox7.Size = new Size(screenWidth - 100, activityHeight);
            textBox7.Location = new Point((screenWidth - textBox7.Width) / 2, activityY);

            textBox17.Location = new Point(textBox7.Left + 31, textBox7.Top + 21);

            dataGridViewActivityLog.Location = new Point(textBox7.Left + 31,
                                                         textBox17.Bottom + 10);
            dataGridViewActivityLog.Size = new Size(textBox7.Width - 62,
                                                    textBox7.Height -
                                                    (textBox17.Bottom - textBox7.Top + 10 + 20));
            dataGridViewActivityLog.Anchor = AnchorStyles.Top |
                                             AnchorStyles.Bottom |
                                             AnchorStyles.Left |
                                             AnchorStyles.Right;

            await LoadDashboardData();
        }

        private async void Admin_Dashboard_Activated(object sender, EventArgs e)
        {
            await LoadDashboardData();
        }

        // --------------------------------------------------------------------
        // DASHBOARD DATA (Fetch & bind)
        // --------------------------------------------------------------------
        private async Task LoadDashboardData()
        {
            try
            {
                // --- Metric tiles ---------------------------------------------------------------
                textBox10.Text = (await _roomService.GetAllRoomsAsync())
                                 .Count
                                 .ToString();

                textBox12.Text = (await _reservationService
                                            .GetReservationsAsync(status: ReservationStatus.Pending))
                                 .Count
                                 .ToString();

                textBox13.Text = (await _reservationService
                                            .GetReservationsAsync(date: DateTime.Today,
                                                                  status: ReservationStatus.Approved))
                                 .Count
                                 .ToString();

                textBox14.Text = (await _userService.GetAllUsersAsync())
                                 .Count
                                 .ToString();

                // --- Recent activity grid -------------------------------------------------------
                dataGridViewActivityLog.Rows.Clear();

                var recent = (await _reservationService
                                    .GetReservationsAsync(includePast: false))
                             .OrderByDescending(r => r.StartTime)
                             .Take(5)
                             .ToList();

                if (recent.Any())
                {
                    foreach (var res in recent)
                    {
                        string roomName = (await _roomService.GetRoomByIdAsync(res.RoomId))?.Name
                                          ?? "Unknown Room";
                        string userName = (await _userService.GetUserByIdAsync(res.UserId))?.Username
                                          ?? "Unknown User";

                        bool hasStart = res.StartTime.HasValue && res.StartTime.Value != DateTime.MinValue;
                        string formattedDate = hasStart
                                               ? res.StartTime.Value.ToString("yyyy-MM-dd")
                                               : "N/A";
                        string formattedTime = hasStart
                                               ? res.StartTime.Value.ToString("hh:mm tt")
                                               : "N/A";

                        dataGridViewActivityLog.Rows.Add(
                            res.Status,       // Status
                            roomName,         // Room
                            userName,         // Booked by
                            formattedDate,    // Date
                            formattedTime     // Time
                        );
                    }
                }
                else
                {
                    dataGridViewActivityLog.Rows.Add("No recent activity.", "", "", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data:\n{ex.Message}",
                                "Dashboard Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // NOP EVENT HANDLERS (needed only so VS designer keeps them intact)
        // --------------------------------------------------------------------
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox15_TextChanged(object sender, EventArgs e) { }
        private void textBox16_TextChanged(object sender, EventArgs e) { }
        private void textBox14_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox12_TextChanged(object sender, EventArgs e) { }
        private void textBox17_TextChanged(object sender, EventArgs e) { }

        // --------------------------------------------------------------------
        // NAVIGATION ACTIONS
        // --------------------------------------------------------------------
        private void textBox1_Click(object sender, EventArgs e) // Pending requests tile
        {
            _serviceProvider.GetRequiredService<PendingRequest>().Show();
            Hide();
        }

        private void textBox2_Click(object sender, EventArgs e) // Available rooms tile
        {
            _serviceProvider.GetRequiredService<Available_Rooms>().Show();
            Hide();
        }

        private void textBox3_Click(object sender, EventArgs e) // Today’s bookings tile
        {
            _serviceProvider.GetRequiredService<admin_bookings>().Show();
            Hide();
        }

        private void textBox6_Click(object sender, EventArgs e) // Total users tile
        {
            _serviceProvider.GetRequiredService<Form18>().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)  // Bookings nav
        {
            _serviceProvider.GetRequiredService<admin_bookings>().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)  // Rooms nav
        {
            _serviceProvider.GetRequiredService<Rooms_Main>().Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)  // Requests nav
        {
            _serviceProvider.GetRequiredService<PendingRequest>().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)  // Users nav
        {
            _serviceProvider.GetRequiredService<Form18>().Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)  // Dashboard nav
        {
            _serviceProvider.GetRequiredService<Admin_Dashboard>().Show();
            Hide();
        }

        // --------------------------------------------------------------------
        // UNUSED CLICK HANDLERS (logo & decorative elements)
        // --------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
