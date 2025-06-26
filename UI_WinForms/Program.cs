using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection; // Dependency Injection was added
using Microsoft.EntityFrameworkCore;           // EF Core was added for database context options
using Microsoft.Extensions.Configuration;      // Configuration was added for appsettings.json

using Iskedular.Data;        // ApplicationDbContext was referenced
using Iskedular.Core.Services;   // UserService and RoomService were referenced
using Iskedular.Models; // User, Room, and Reservation models were referenced

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

            // Configuration was set up from appsettings.json.
            // It was configured to ensure appsettings.json exists and reloads on change.
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Dependency Injection (DI) container was set up.
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            // The DI Configuration was completed.

            // The application was configured to run with Form19 as the initial screen,
            // retrieving it from the service provider to ensure its dependencies are met.
            Application.Run(serviceProvider.GetRequiredService<Form19>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configuration was added to the services.
            services.AddSingleton<IConfiguration>(_configuration);

            // ApplicationDbContext was added to the DI container,
            // using the connection string from configuration.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            // UserService was added as a transient service to the DI container.
            services.AddTransient<UserService>();
            // RoomService was added as a transient service to the DI container.
            services.AddTransient<RoomService>();

            // The new SessionService was added as a Singleton.
            // A singleton ensures the same instance of SessionService is used throughout the application,
            // maintaining the logged-in user's state.
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
            services.AddTransient<Form12>(); // Admin User Management (assuming Form12 exists)
            services.AddTransient<AdminLogin>(); // Admin Login
            services.AddTransient<Form9>(); // Admin Dashboard
            services.AddTransient<Form10>(); // Admin Rooms/Booking Management
            services.AddTransient<Form11>(); // Admin Requests
            // Form13 was registered with explicit dependency resolution for RoomService and SessionService.
            services.AddTransient<Form13>(provider => new Form13(
                provider,
                provider.GetRequiredService<RoomService>(),
                provider.GetRequiredService<SessionService>()
            ));
            // ADDED: FormAddEditRoom was registered as a transient service.
            // Since FormAddEditRoom's constructor takes only RoomService, it can be registered simply.
            services.AddTransient<FormAddEditRoom>();
            services.AddTransient<Form15>(); // Admin Other Page (Placeholder)
            services.AddTransient<Form16>(); // Admin Other Page (Placeholder)
            services.AddTransient<Form17>(); // Admin Other Page (Placeholder)
            services.AddTransient<Form18>(); // Admin Accounts/Profile
            services.AddTransient<Available_Rooms>(); // Admin Available Rooms
            services.AddTransient<admin_bookings>(); // Admin Bookings

            // Other forms can be added here as needed.
        }
    }
}
