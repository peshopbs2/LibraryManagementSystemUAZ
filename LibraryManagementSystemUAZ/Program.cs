using LibraryManagementSystemUAZ.Core.Constants;
using LibraryManagementSystemUAZ.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementSystemUAZ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection
                .BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlServer(AppConfiguration.ConnectionString);
            });

        }
    }
}