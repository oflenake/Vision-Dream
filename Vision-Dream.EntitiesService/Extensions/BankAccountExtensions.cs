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
    * File:         BankAccountExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the BankAccountExtensions class. 
    *               Class execution code.
*/
#endregion

using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.EntitiesService.Extensions
{
    /// <summary>
    /// Static <see cref="BankAccountExtensions"/> class helps to map <see cref="Map"/> 
    /// the same two <see cref="BankAccount"/> entities for further processing.
    /// </summary>
    public static class BankAccountExtensions
    {
        public static void Map(this BankAccount destBankAccount, BankAccount srcBankAccount)
        {
            destBankAccount.BankAccountNumber = srcBankAccount.BankAccountNumber;
            destBankAccount.UserID = srcBankAccount.UserID;
            destBankAccount.CreatedDateTime = srcBankAccount.CreatedDateTime;
            destBankAccount.ClientNumber = srcBankAccount.ClientNumber;
            destBankAccount.AccountName = srcBankAccount.AccountName;
            destBankAccount.AccountBalance = srcBankAccount.AccountBalance;
        }
    }
}
