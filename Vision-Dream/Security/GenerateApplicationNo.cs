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
    * File:         GenerateApplicationNo.cs
    * Date:         2019-01-10
    * Description:  This file contains the GenerateApplicationNo class. 
    *               Class execution code.
*/
#endregion

using System;

namespace Vision_Dream.Security
{
    public class GenerateApplicationNo
    {
        public string ApplicationNo(string districtId, string divisionId, string serviceId)
        {
            var expirationDate = DateTime.Now;
            var lastTwoDigitsOfYear = expirationDate.ToString("yy");
            var day = DateTime.Now.Day;

            var random = EncryptionLibrary.EncryptText(KeyGenerator.GetUniqueKey()).Substring(0, 6);
            return string.Concat(lastTwoDigitsOfYear, day, districtId, divisionId, serviceId, random);
        }
    }
}
