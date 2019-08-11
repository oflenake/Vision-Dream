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
    * File:         BankAccount.cs
    * Date:         2019-01-10
    * Description:  This file contains the BankAccount class. 
    *               Class execution code.
*/
#endregion

using System;
using System.ComponentModel.DataAnnotations;

namespace Vision_Dream.EntitiesService.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountNumber { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int ClientNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
