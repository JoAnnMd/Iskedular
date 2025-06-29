// File: UI_WinForms/Program.cs
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Iskedular.Data;
using Iskedular.Core.Services;
using Iskedular.Models;

namespace UI_WinForms
{
    static class Program
    {
        private static IConfigurationRoot _configuration = default!;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure appsettings.json
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                // IMPORTANT: Apply database migrations at startup
                try
                {
                    using (var scope = serviceProvider.CreateScope())
                    {
                        var dbContextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();
                        using (var dbContext = dbContextFactory.CreateDbContext())
                        {
                            dbContext.Database.Migrate();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error applying database migrations: {ex.Message}\n" +
                                    "Please check your 'appsettings.json' connection string and ensure SQL Server is running.",
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }

                Application.Run(serviceProvider.GetRequiredService<Form19>());
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(_configuration);

            services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            // Register Services
            services.AddTransient<RoomService>();
            services.AddTransient<ReservationService>();
            services.AddTransient<UserService>();
            services.AddTransient<ActivityLogService>();
            services.AddSingleton<SessionService>(); // SessionService must be a singleton

            // Register Forms for DI (Add all your forms here)
            // Each form that uses DI should be registered as Transient
            services.AddTransient<Form19>();            // Your main login/entry point
            services.AddTransient<Form1>();
            services.AddTransient<Form2>();
            services.AddTransient<Form3>();
            services.AddTransient<Form4>();
            services.AddTransient<Form5>();
            services.AddTransient<Form7>();             // Student Login
            services.AddTransient<Form8>();

            services.AddTransient<AdminLogin>();        // Admin Login form

            services.AddTransient<Admin_Dashboard>();
            services.AddTransient<Total_Rooms>();
            services.AddTransient<PendingRequest>();

            // Ensure Rooms_Main constructor accepts direct injection: (IServiceProvider, RoomService, SessionService)
            services.AddTransient<Rooms_Main>();

            services.AddTransient<FormAddEditRoom>();

            services.AddTransient<Bookings_Total>();
            services.AddTransient<Form16>();
            services.AddTransient<Form17>();
            services.AddTransient<Form18>();
            services.AddTransient<Available_Rooms>();
            services.AddTransient<admin_bookings>();
            services.AddTransient<Form6>();
        }
    }
}