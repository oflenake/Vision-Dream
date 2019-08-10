#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.2.
    *               Library is generic to cater for multiple solutions.
    * Version:      v1.0.0
    * File:         ErrorDetails.cs
    * Date:         2019-01-10
    * Description:  This file contains the ErrorDetails class. 
    *               Class execution code.
*/
#endregion

using Newtonsoft.Json;

namespace Vision_Dream.Models
{
    /// <summary>
    /// The <see cref="ErrorDetails"/> class is used in the <see cref="ExceptionMiddleware"/> 
    /// class and in the <see cref="ExceptionExtensions"/> class as a custom exception 
    /// middleware that logs async messages, using a Status Code and a Message.
    /// </summary>
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
