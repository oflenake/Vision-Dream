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
        public static void ConfigureIIS(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        // Custom Logger configuration
        public static void ConfigureLogger(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManagerUtility, LoggerManagerUtility>();
        }

        // SQL DBContext Connection Configuration
        // With the help of the IConfiguration config parameter, we can access the 
        // appsettings.json file and take all the settings data that we need from it.
        public static void ConfigureSQLDefaultDEV(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringDefaultDEV:DBConnDefaultDEV"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLDefaultPRD(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringDefaultPRD:DBConnDefaultPRD"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLReportingDEV(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringReportingDEV:DBConnReportingDEV"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLReportingPRD(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringReportingPRD:DBConnReportingPRD"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLTransactionalDEV(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringTransactionalDEV:DBConnTransactionalDEV"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        public static void ConfigureSQLTransactionalPRD(this IServiceCollection services, IConfiguration config)
        {
            var sqlConnString = config["SQLStringTransactionalPRD:DBConnTransactionalPRD"];
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(sqlConnString));
        }

        // Repository Wrapper configuration
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
