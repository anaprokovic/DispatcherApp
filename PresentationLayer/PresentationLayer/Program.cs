using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainMenu>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IDriverRepository, DriverRepository>();
            services.AddScoped<IDriverBusiness, DriverBusiness>();
            services.AddScoped<MainMenu>();

            services.AddSingleton<IDrivingRepository, DrivingRepository>();
            services.AddScoped<IDrivingBusiness, DrivingBusiness>();
            services.AddScoped<MainMenu>();

            services.AddSingleton<IDispatcherRepository, DispatcherRepository>();
            services.AddScoped<IDispatcherBusiness, DispatcherBusiness>();
            services.AddScoped<MainMenu>();
        }
    }
}
