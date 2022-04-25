using Contractor;
using Entities;
using LoggerService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace CoreCourse.Extentions
{
    public static class ServiceExtentions
    {
        // 'static' to be able to use this class and  its methods as a service in StartUP.ConfigureServices

        /// <summary>
        /// using 'this' to add this method to the services of IServiceCollection
        /// "CorsPolicy" is the name of that Cors Service And may be more than one
        /// Allow Any Origin
        /// Allow Any HTTP Methods like Get, Put, Delete </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        /// <summary>
        /// services.AddSingleton Method : Create One Instance and will be Shared across the Apllication
        /// [Means One Instance for the whole App and the Whole Users]
        /// services.AddScoped Method: Create Instance per user
        /// [Means Each User Has its own Insance used across all this user requests]
        /// services.AddTransient Method : every Time You Ask for Instance It will Returns a New/Fresh One
        /// [Means new Instance for Every Request]
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }
        /// <summary>
        /// using IServiceCollection to make it as service 
        /// Using IConfiguration To use some Configs from Local File [Using CS from AppSettings.json]
        /// IConfiguration is Located in Startup File 
        /// UseSqlServer : You need Nuget For SqlServer [EntityFrameworkCore.SqlServer]
        /// GetConnectionString : To link Your Service with the DataBase      
        /// </summary>
        /// <param name="services">To Use it as Service</param>
        /// <param name="configuration">To Be able to load configrations from local file which is AppSettings</param>
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CS"),
                b => b.MigrationsAssembly("CoreCourse")
            ));
        }

        public static void ConfigureRepoManager(this IServiceCollection services) =>
            services.AddScoped<IRepoManager, RepoManager>();
    }





}
 