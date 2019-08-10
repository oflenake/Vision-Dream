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
    * File:         CorsExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the CorsExtensions class. 
    *               Class execution code.
*/
#endregion

using Microsoft.AspNetCore.Builder;
using Vision_Dream.Middlewares;

namespace Vision_Dream.Extensions
{
    public static class CorsExtensions
    {
        // Cors extensions method used to add the Cors middleware to the HTTP request pipeline.
        public static void ConfigureCorsMiddleware(this IApplicationBuilder corsBuilder)
        {
            corsBuilder.UseMiddleware<CorsMiddleware>();
        }
    }
}
