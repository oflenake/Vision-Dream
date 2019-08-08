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
    * File:         IRepositoryBase.cs
    * Date:         2019-01-10
    * Description:  This file contains the IRepositoryBase Generic Type class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Vision_Dream.ContractsService
{
    /// <summary>
    /// The main <see cref="IRepositoryBase"/> interface class that is implemented 
    /// and used by the main <see cref="RepositoryBase"/> class. Entities and their 
    /// web api backend access, to process their database manipulations is done 
    /// through this generic class and its implementation.
    /// </summary>
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAllBaseData();
        IQueryable<T> GetByIDBaseData(Expression<Func<T, bool>> expression);
        void PostCreateBaseData(T entity);
        void PutUpdateBaseData(T entity);
        void DeleteByIDBaseData(T entity);
        Task SaveAsyncBaseData();
    }
}
