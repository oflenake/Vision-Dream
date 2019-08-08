#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.1.
    *               Library is generic to cater for multiple solutions.
    * Version:      v1.0.0
    * File:         AppSettings.cs
    * Date:         2019-01-10
    * Description:  This file contains the AppSettings class. 
    *               Class execution code.
*/
#endregion

namespace Vision_Dream.AppModels
{
    public class AppSettings
    {
        public string AppName { get; set; }
        public string ServerSecrete { get; set; }
        public string ServerApiUrl { get; set; }
    }
}
