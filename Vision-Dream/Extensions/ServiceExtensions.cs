#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.2 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.2.
    * Version:      v1.0.0
    * File:         ServiceExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the ServiceExtensions class. 
    *               Class execution code.
*/
#endregion

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vision_Dream.ContractsService;
using Vision_Dream.EntitiesService;
using Vision_Dream.LoggerService;
using Vision_Dream.RepositoryService;

namespace Vision_Dream.Extensions
{
    public static class ServiceExtensions
    {
        // CORS configuration
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithExposedHeaders("X-Pagination"));
            });
        }

        // IIS configuration
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        // Custom Logger configuration
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        // SQL DBContext Connection Configuration
        // With the help of the IConfiguration config parameter, we can access the 
        // appsettings.json file and take all the settings data that we need from it.
        public static void ConfigureSQLDBContextDefaultDev(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringDefaultDev:DBConnDefaultDev"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDBContextDefaultPrd(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringDefaultPrd:DBConnDefaultPrd"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDBContextReportingDev(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringReportingDev:DBConnReportingDev"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDBContextReportingPrd(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringReportingPrd:DBConnReportingPrd"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDBContextTransactionalDev(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringTransactionalDev:DBConnTransactionalDev"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDBContextTransactionalPrd(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringTransactionalPrd:DBConnTransactionalPrd"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        // Repository Wrapper configuration
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
