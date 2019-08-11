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
    * File:         CorsMiddleware.cs
    * Date:         2019-01-10
    * Description:  This file contains the CorsMiddleware class. 
    *               Class execution code.
*/
#endregion

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Vision_Dream.Middlewares
{
    // Package that may need to be installed into the project: Microsoft.AspNetCore.Http.Abstractions
    public class CorsMiddleware
    {
        private readonly RequestDelegate _NextDelegate;

        public CorsMiddleware(RequestDelegate nextDelegate)
        {
            _NextDelegate = nextDelegate;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            httpContext.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            httpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Accept");
            httpContext.Response.Headers.Add("Access-Control-Allow-Methods", "POST,GET,PUT,PATCH,DELETE,OPTIONS");
            return _NextDelegate(httpContext);
        }
    }
}
