#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.2.
    *               Library is generic to cater for multiple solutions.
    * Version:      v1.0.0
    * File:         ExceptionExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the ExceptionExtensions class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Vision_Dream.AppModels;
using Vision_Dream.ContractsService;
using Vision_Dream.Middlewares;

namespace Vision_Dream.Extensions
{
    public static class ExceptionExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder appExHandler, ILoggerManager logger)
        {
            // Extension method that registers the UseExceptionHandler middleware
            appExHandler.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Something went wrong.{Environment.NewLine}Details: {contextFeature.Error}");

                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }

        public static void ConfigureExceptionMiddleware(this IApplicationBuilder appExMiddleware)
        {
            appExMiddleware.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
