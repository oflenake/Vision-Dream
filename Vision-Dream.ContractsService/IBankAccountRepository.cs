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
    * File:         IBankAccountRepository.cs
    * Date:         2019-01-10
    * Description:  This file contains the IBankAccountRepository class. 
    *               Class execution code.
*/
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.ContractsService
{
    public interface IBankAccountRepository : IRepositoryBase<BankAccount>
    {
        Task<IEnumerable<BankAccount>> GetAllAsyncData();
        //Task<BankAccount> GetByIDAsyncData(int bankaccountNO);
        //Task<BankAccount> GetByIDRelatedAsyncData(int employeeID);      // Get Employee's related BankAccounts
    }
}
