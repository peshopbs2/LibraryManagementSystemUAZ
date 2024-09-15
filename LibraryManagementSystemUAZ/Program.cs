using LibraryManagementSystemUAZ.Core.Constants;
using LibraryManagementSystemUAZ.Data.Data;
using LibraryManagementSystemUAZ.Data.Interfaces;
using LibraryManagementSystemUAZ.Services;
using LibraryManagementSystemUAZ.Services.Interfaces;
using LibraryManagementSystemUAZ.UI;
using LibraryManagementSystemUAZ.UI.Authors;
using LibraryManagementSystemUAZ.UI.Books;
using LibraryManagementSystemUAZ.UI.Categories;
using LibraryManagementSystemUAZ.UI.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace LibraryManagementSystemUAZ
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; set; }
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
            ServiceProvider = serviceCollection
                .BuildServiceProvider();

            ApplicationConfiguration.Initialize();

        //    Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlServer(AppConfiguration.ConnectionString);
                options.UseLazyLoadingProxies();
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<MainForm>();
            services.AddTransient<LoginForm>();
            
            services.AddTransient<CategoryListForm>();
            services.AddTransient<CategoryAddForm>();
            services.AddTransient<CategoryEditForm>();
            services.AddTransient<CategoryDeleteForm>();

            services.AddTransient<BookListForm>();
            services.AddTransient<BookAddForm>();
            
            services.AddTransient<AuthorsListForm>();
            services.AddTransient<AuthorsAddForm>();
            services.AddTransient<AuthorsEditForm>();
            services.AddTransient<AuthorsDeleteForm>();

            services.AddTransient<MembersListForm>();
        }
    }
}