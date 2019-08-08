#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.1 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.1.
    * Version:      v1.0.0
    * File:         StringCharCheck.cs
    * Date:         2019-01-10
    * Description:  This file contains the StringCharCheck class. 
    *               Class execution code.
*/
#endregion

namespace Vision_Dream.General
{
    public class StringCharCheck
    {
        public static bool IsFirstUpper(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}
