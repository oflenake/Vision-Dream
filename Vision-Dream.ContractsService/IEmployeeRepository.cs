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
    * File:         IEmployeeRepository.cs
    * Date:         2019-01-10
    * Description:  This file contains the IEmployeeRepository class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Vision_Dream.EntitiesService.RelatedModels;
using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.ContractsService
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        Task<IEnumerable<Employee>> GetAllAsyncData();
        Task<Employee> GetByIDAsyncData(int employeeID);
        Task<EmployeeRelated> GetByIDRelatedAsyncData(int employeeID);
        Task PostCreateAsyncData(Employee employee);
        Task PutUpdateAsyncData(Employee dbEmployee, Employee employee);
        Task DeleteByIDAsyncData(Employee employee);
        bool GetByIDAsyncData(Func<object, bool> p);
    }
}
