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
    * File:         ExceptionFilterMiddleware.cs
    * Date:         2019-01-10
    * Description:  This file contains the ExceptionFilterMiddleware class. 
    *               Class execution code.
*/
#endregion

using System;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Vision_Dream.Middlewares
{
    /// <summary>
    /// Exception Filter Middleware Class.
    /// </summary>
    /// <value>
    /// Utility for writing log streams to file(s) using <see cref="ExceptionFilterMiddleware"/>.
    /// </value>
    /// <remarks>
    /// <para>
    /// Writes formatted string log stream data to a specified log file(s).
    /// </para>
    /// </remarks>
    public class ExceptionFilterMiddleware : ExceptionFilterAttribute
    {
        /// <summary> Field Properties
        /// </summary>
        private readonly IHostingEnvironment _HostingEnvironment;
        public StreamWriter _StreamLogger;

        public Exception _Exception { get; set; }
        public string _LogText { get; set; }
        public string _TimeStamp { get; set; }
        public string _ErrorFolder { get; set; }

        /// <summary> Constructors
        /// </summary>
        public ExceptionFilterMiddleware(IHostingEnvironment hostingEnvironment)
        {
            _HostingEnvironment = hostingEnvironment;
            _LogText = string.Empty;
        }

        public override void OnException(ExceptionContext exceptionContext)
        {
            _Exception = exceptionContext.Exception;
            exceptionContext.ExceptionHandled = true;
            var objClass = exceptionContext;
            _LogText += "Message ---\n{0}" + _Exception.Message;


            if (exceptionContext.HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {
                _LogText += Environment.NewLine + ".Net Error ---\n{0}" + "Check MVC Ajax Code For Error";
            }

            _LogText += Environment.NewLine + "Source ---\n{0}" + _Exception.Source;
            _LogText += Environment.NewLine + "StackTrace ---\n{0}" + _Exception.StackTrace;
            _LogText += Environment.NewLine + "TargetSite ---\n{0}" + _Exception.TargetSite;

            if (_Exception.InnerException != null)
            {
                _LogText += Environment.NewLine + "Inner Exception is {0}" + _Exception.InnerException;   // error prone
            }

            if (_Exception.HelpLink != null)
            {
                _LogText += Environment.NewLine + "HelpLink ---\n{0}" + _Exception.HelpLink;  // error prone
            }

            _TimeStamp = DateTime.Now.ToString("d-MMMM-yyyy", new CultureInfo("en-ZA"));

            _ErrorFolder = Path.Combine(_HostingEnvironment.WebRootPath, "ErrorLog");

            if (!Directory.Exists(_ErrorFolder))
            {
                Directory.CreateDirectory(_ErrorFolder);
            }

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (!File.Exists($@"{_ErrorFolder}\{_TimeStamp}_Log.txt"))
            {
                _StreamLogger = new StreamWriter($@"{_ErrorFolder}\{_TimeStamp}_Log.txt");
            }
            else
            {
                _StreamLogger = File.AppendText($@"{_ErrorFolder}\{_TimeStamp}_Log.txt");
            }

            var controllerName = (string)exceptionContext.RouteData.Values["controller"];
            var actionName = (string)exceptionContext.RouteData.Values["action"];

            // Write log stream to file
            _StreamLogger.WriteLine(Environment.NewLine + DateTime.Now);
            _StreamLogger.WriteLine("--------------------------------------------------------------------------------------");
            _StreamLogger.WriteLine("Controller Name :- " + controllerName);
            _StreamLogger.WriteLine("Action Method Name :- " + actionName);
            _StreamLogger.WriteLine("--------------------------------------------------------------------------------------");
            _StreamLogger.WriteLine(objClass);
            _StreamLogger.WriteLine(_LogText);
            _StreamLogger.WriteLine();

            // Close log stream:
            _StreamLogger.Close();

            if (!_HostingEnvironment.IsDevelopment())
            {
                // do nothing
                return;
            }

            var routingResult = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Error"}, {"action", "Error"}
                });

            // TODO: Pass additional detailed data via ViewData
            exceptionContext.Result = routingResult;
        }
    }
}
