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
    * File:         EmployeeExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the EmployeeExtensions class. 
    *               Class execution code.
*/
#endregion

using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.EntitiesService.Extensions
{
    /// <summary>
    /// Static <see cref="EmployeeExtensions"/> class helps to map <see cref="Map"/> 
    /// the same two <see cref="Employee"/> entities for further processing.
    /// </summary>
    public static class EmployeeExtensions
    {
        public static void Map(this Employee destEmployee, Employee srcEmployee)
        {
            destEmployee.EmployeeID = srcEmployee.EmployeeID;
            destEmployee.FirstName = srcEmployee.FirstName;
            destEmployee.LastName = srcEmployee.LastName;
            destEmployee.Email = srcEmployee.Email;
            destEmployee.Gender = srcEmployee.Gender;
        }
    }
}
