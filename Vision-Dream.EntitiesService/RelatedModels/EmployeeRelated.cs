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
    * File:         EmployeeRelated.cs
    * Date:         2019-01-10
    * Description:  This file contains the EmployeeRelated class. 
    *               Class execution code.
*/
#endregion

using Vision_Dream.EntitiesService.Models;
using System.Collections.Generic;

namespace Vision_Dream.EntitiesService.RelatedModels
{
    public class EmployeeRelated : IEntity
    {
        public int EntityIDRel { get; set; }
        public string FirstNameRel { get; set; }
        public string LastNameRel { get; set; }
        public string EmailRel { get; set; }
        public string GenderRel { get; set; }

        public virtual IEnumerable<BankAccount> BankAccounts { get; set; }

        /// <see cref="EmployeeRelated"/> constructor enabled/disabled to configure lazy-loading.
        public EmployeeRelated(Employee employee)
        {
            EntityIDRel = employee.EmployeeID;
            FirstNameRel = employee.FirstName;
            LastNameRel = employee.LastName;
            EmailRel = employee.Email;
            GenderRel = employee.Gender;
        }
    }
}
