#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.2 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.2.
    * Version:      v1.0.0
    * File:         ExceptionMiddleware.cs
    * Date:         2019-01-10
    * Description:  This file contains the ExceptionMiddleware class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Vision_Dream.Models;
using Vision_Dream.ContractsService;

namespace Vision_Dream.Middlewares
{
    public class ExceptionMiddleware
    {
        #region Fields

        private readonly RequestDelegate _NextDelegate;
        private readonly ILoggerManagerUtility _LoggerUtility;
        #endregion

        #region Constructor

        public ExceptionMiddleware(RequestDelegate nextDelegate, ILoggerManagerUtility loggerUtility)
        {
            _LoggerUtility = loggerUtility;
            _NextDelegate = nextDelegate;
        }
        #endregion

        #region Public Methods
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _NextDelegate(httpContext);
            }
            catch (Exception ex)
            {
                _LoggerUtility.LogError($"Something went wrong.{Environment.NewLine}Details: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        #endregion

        #region Private Methods

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error from the exception middleware."
            }.ToString());
        }
        #endregion
    }
}
