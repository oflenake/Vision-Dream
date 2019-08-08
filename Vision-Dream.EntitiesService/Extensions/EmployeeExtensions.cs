#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.1.
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
    /// The static <see cref="EmployeeExtensions"/>, extension class helps to map <see cref="Map"/> 
    /// the same two <see cref="Employee"/> object entities to each other, for further processing.
    /// </summary>
    public static class EmployeeExtensions
    {
        public static void Map(this Employee dbEmployee, Employee employee)
        {
            dbEmployee.FirstName = employee.FirstName;
            dbEmployee.LastName = employee.LastName;
            dbEmployee.Email = employee.Email;
            dbEmployee.Gender = employee.Gender;
        }
    }
}
