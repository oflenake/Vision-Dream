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
    * File:         ErrorModel.cs
    * Date:         2019-01-10
    * Description:  This file contains the ErrorModel class. 
    *               Class execution code.
*/
#endregion

namespace Vision_Dream.Models
{
    public class ErrorModel
    {
        public string RequestID { get; set; }
        public bool ShowRequestID => !string.IsNullOrEmpty(RequestID);
    }
}
