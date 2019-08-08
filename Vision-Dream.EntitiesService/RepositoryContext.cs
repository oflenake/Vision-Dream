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
    * File:         RepositoryContext.cs
    * Date:         2019-01-10
    * Description:  This file contains the RepositoryContext class. 
    *               Class execution code.
*/
#endregion

using Microsoft.EntityFrameworkCore;
using Vision_Dream.EntitiesService.Models;

namespace Vision_Dream.EntitiesService
{
    /// <summary>
    /// The <see cref="RepositoryContext"/> class is the main generic <see cref="DbContext"/> 
    /// (EmployeeContext) class, that facilitates the <see cref="Employee"/> entity's 
    /// data and it's related data manipulations. It also facilitates the 
    /// <see cref="BankAccount"/> entity's data and it's related data manipulations.
    /// </summary>
    public class RepositoryContext : DbContext
    {
        #region Constructor
        /// <summary>
        /// Inject the logger and repository parameter services inside the constructor.
        /// </summary>
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }
        #endregion

        public DbSet<Employee> EmployeeEntity { get; set; }
        public DbSet<BankAccount> BankAccountEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { FirstName = "Onkgopotse", LastName = "Lenake", Email = "gupilenake@gmail.com", Gender = "1" },
                new Employee() { FirstName = "Sandy", LastName = "Khoza", Email = "Sandy.Khoza@outlook.com", Gender = "2" },
                new Employee() { FirstName = "Jafta", LastName = "Dladla", Email = "jafta.dladla@gmail.com", Gender = "1" },
                new Employee() { FirstName = "Sebi", LastName = "Rapoo", Email = "Sebi.Rapoo@vision-dream.local", Gender = "2" }
                );
        }
    }
}
