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
    * File:         BankAccountRepository.cs
    * Date:         2019-01-10
    * Description:  This file contains the BankAccountRepository class. 
    *               Class execution code.
*/
#endregion

using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Vision_Dream.ContractsService;
using Vision_Dream.EntitiesService;
using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.RepositoryService
{
    /// <summary>
    /// The <see cref="BankAccountRepository"/> class that access the base repository backend through 
    /// the <see cref="RepositoryWrapper"/> class, to manipulate the <see cref="BankAccount"/> 
    /// entity data and its related data.
    /// </summary>
    public class BankAccountRepository : RepositoryBase<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(ILoggerManagerUtility loggerUtility, RepositoryContext repositoryContext)
            : base(loggerUtility, repositoryContext)
        {
        }

        // Get all BankAccounts
        public async Task<IEnumerable<BankAccount>> GetAllAsyncData()
        {
            return await GetAllBaseData()
                .OrderBy(b => b.AccountName)
                .ToListAsync();
        }

        //public async Task<BankAccount> GetByIDAsyncData(int bankaccountNO)
        //{
        //    return await GetByIDBaseData(a => a.BankAccountNumber.Equals(bankaccountNO))
        //        .Select(employee => new Employee()
        //        {
        //            BankAccounts = RepositoryContext.BankAccountEntity
        //            .Where(ba => ba.BankAccountNumber.Equals(employee.BankAccountNumber))
        //            .ToList()
        //        })
        //        .SingleOrDefaultAsync();
        //}

        //// Get all related BankAccounts for a particular Employee
        //public async Task<BankAccount> GetByIDRelatedAsyncData(int employeeID)
        //{
        //    return await GetByIDBaseData(o => o.BankAccountNumber.Equals(employeeID))
        //        .Select(employee => new EmployeeRelated(employee)
        //        {
        //            BankAccounts = RepositoryContext.BankAccountEntity
        //            .Where(a => a.ClientNumber.Equals(employee.BankAccountNumber))
        //            .ToList()
        //        })
        //        .SingleOrDefaultAsync();
        //}
    }
}
