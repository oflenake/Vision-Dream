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
        public int EntityID { get; set; }
        public string RelFirstName { get; set; }
        public string RelLastName { get; set; }
        public string RelEmail { get; set; }
        public string RelGender { get; set; }

        public virtual IEnumerable<BankAccount> RelBankAccounts { get; set; }

        /// <see cref="EmployeeRelated"/> constructor enabled/disabled to configure lazy-loading.
        public EmployeeRelated(Employee employeeEntity)
        {
            EntityID = employeeEntity.EmployeeID;
            RelFirstName = employeeEntity.FirstName;
            RelLastName = employeeEntity.LastName;
            RelEmail = employeeEntity.Email;
            RelGender = employeeEntity.Gender;
            //RelBankAccounts = BankAccount;
        }
    }
}
