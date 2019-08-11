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
    * File:         EmployeeRepository.cs
    * Date:         2019-01-10
    * Description:  This file contains the EmployeeRepository class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vision_Dream.ContractsService;
using Vision_Dream.EntitiesService;
using Vision_Dream.EntitiesService.RelatedModels;
using Vision_Dream.EntitiesService.Extensions;
using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.RepositoryService
{
    /// <summary>
    /// The <see cref="EmployeeRepository"/> class that access the base repository backend through 
    /// the <see cref="RepositoryWrapper"/> class, to manipulate the <see cref="Employee"/> 
    /// entity data and its related data.
    /// </summary>
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ILoggerManagerUtility loggerUtility, RepositoryContext repositoryContext)
            : base(loggerUtility, repositoryContext)
        {
        }

        // Get all Employees
        public async Task<IEnumerable<Employee>> GetAllAsyncData()
        {
            return await GetAllBaseData()
                .OrderBy(e => e.LastName)
                .ToListAsync();
        }

        // Get Employee by Id
        public async Task<Employee> GetByIDAsyncData(int employeeID)
        {
            return await GetByIDBaseData(o => o.EmployeeID.Equals(employeeID))
                    .DefaultIfEmpty(new Employee())
                    .SingleAsync();
        }

        // Get all related BankAccounts for a particular Employee
        public async Task<EmployeeRelated> GetByIDRelatedAsyncData(int entityID)
        {
            return await GetByIDBaseData(o => o.EmployeeID.Equals(entityID))
                .Select(employeeEntity => new EmployeeRelated(employeeEntity)
                {
                    RelBankAccounts = RepositoryContext.BankAccountEntity
                    .Where(a => a.UserID.Equals(employeeEntity.EmployeeID))
                    .ToList()
                })
                .SingleOrDefaultAsync();
        }

        // Create new Employee
        public async Task PostCreateAsyncData(Employee employee)
        {
            int newID = 10;
            //employee.ID = Guid.NewGuid();
            employee.EmployeeID = newID;
            PostCreateBaseData(employee);
            await SaveAsyncBaseData();
        }

        // Update Employee
        public async Task PutUpdateAsyncData(Employee dbEmployee, Employee employee)
        {
            dbEmployee.Map(employee);
            PutUpdateBaseData(dbEmployee);
            await SaveAsyncBaseData();
        }

        // Delete Employee
        public async Task DeleteByIDAsyncData(Employee employee)
        {
            DeleteByIDBaseData(employee);
            await SaveAsyncBaseData();
        }

        public bool GetByIDAsyncData(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
