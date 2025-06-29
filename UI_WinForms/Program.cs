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

            Application.Run(serviceProvider.GetRequiredService<Form19>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(_configuration);

            
            services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            
            services.AddScoped<RoomService>();
            services.AddScoped<ReservationService>();
            services.AddScoped<SessionService>();
            services.AddScoped<UserService>();

            
            services.AddTransient<Form19>();
            services.AddTransient<Form1>(provider => new Form1(
                provider.GetRequiredService<IServiceProvider>(),
                provider.GetRequiredService<SessionService>()
            ));
            services.AddTransient<Form2>(provider => new Form2(
                provider.GetRequiredService<IServiceProvider>(),
                provider.GetRequiredService<SessionService>()
            ));
            services.AddTransient<Form3>();
            services.AddTransient<Form5>();
            services.AddTransient<Form7>(provider => new Form7(
                provider.GetRequiredService<UserService>(),
                provider.GetRequiredService<IServiceProvider>(),
                provider.GetRequiredService<SessionService>()
            ));
            services.AddTransient<Form8>(provider => new Form8(
                provider.GetRequiredService<UserService>(),
                provider.GetRequiredService<IServiceProvider>(),
                provider.GetRequiredService<SessionService>()
            ));

            services.AddTransient<AdminLogin>();

            
            services.AddTransient<Admin_Dashboard>();
            services.AddTransient<Total_Rooms>();
            services.AddTransient<PendingRequest>();

            
            services.AddTransient<Rooms_Main>(provider => new Rooms_Main(
                provider,
                provider.GetRequiredService<RoomService>(),
                provider.GetRequiredService<SessionService>()
            ));

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
