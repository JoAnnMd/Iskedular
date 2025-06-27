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

            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            // The application was configured to run with Form19 as the initial screen,
            // retrieving it from the service provider to ensure its dependencies are met.
            Application.Run(serviceProvider.GetRequiredService<Form19>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(_configuration);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<UserService>();
            services.AddTransient<RoomService>();
            services.AddSingleton<SessionService>();

            // All forms were registered as transient services to allow them to be created by DI.
            // This ensures all forms can receive IServiceProvider or other services via their constructors.
            services.AddTransient<Form19>();
            services.AddTransient<Form7>(); // User Login
            services.AddTransient<Form8>(); // User Sign Up
            services.AddTransient<Form1>(); // User Dashboard (assuming Form1 exists for user)
            services.AddTransient<Form2>(); // Rooms (User) (assuming Form2 exists for user)
            services.AddTransient<Form3>(); // Reserve (User) (assuming Form3 exists for user)
            services.AddTransient<Form4>(); // Profile (User) (assuming Form4 exists for user)
            services.AddTransient<Form5>(); // Reserve Confirmation (User) (assuming Form5 exists for user)
            services.AddTransient<Form6>(); // Password Change (User/Admin)
            // services.AddTransient<Bookings_Total>(); // Removed duplicate registration

            services.AddTransient<AdminLogin>(); // Admin Login

            // Updated registrations with new names
            services.AddTransient<Admin_Dashboard>();    // Renamed from Form9
            services.AddTransient<Total_Rooms>();        // Renamed from Form10
            services.AddTransient<PendingRequest>();     // Renamed from Form11

            // Rooms_Main was registered with explicit dependency resolution for RoomService and SessionService.
            services.AddTransient<Rooms_Main>(provider => new Rooms_Main(
                provider,
                provider.GetRequiredService<RoomService>(),
                provider.GetRequiredService<SessionService>()
            ));

            // ADDED: FormAddEditRoom was registered as a transient service.
            services.AddTransient<FormAddEditRoom>();

            services.AddTransient<Bookings_Total>(); // Admin User Management (assuming Bookings_Total is the correct form for this)
            services.AddTransient<Form16>(); // Admin Other Page (Placeholder)
            services.AddTransient<Form17>(); // Admin Other Page (Placeholder)
            services.AddTransient<Form18>(); // Admin Accounts/Profile
            services.AddTransient<Available_Rooms>(); // Admin Available Rooms
            services.AddTransient<admin_bookings>(); // Admin Bookings

            // Other forms can be added here as needed.
        }
    }
}