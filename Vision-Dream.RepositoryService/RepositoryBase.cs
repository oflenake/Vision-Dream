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
    * File:         RepositoryBase.cs
    * Date:         2019-01-10
    * Description:  This file contains the RepositoryBase class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Vision_Dream.ContractsService;
using Vision_Dream.EntitiesService;

namespace Vision_Dream.RepositoryService
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Fields

        protected ILoggerManagerUtility _LoggerUtility;
        protected string _Component;
        protected string _Process;
        protected string _Message;
        #endregion

        #region Properties

        protected RepositoryContext _RepositoryContext { get; set; }
        #endregion

        #region Constructor

        public RepositoryBase(ILoggerManagerUtility loggerUtility, RepositoryContext repositoryContext)
        {
            this._LoggerUtility = loggerUtility;
            this._RepositoryContext = repositoryContext;

            this._Component = "RepositoryBase";
            this._Process = "RepositoryBase";
            this._Message = string.Format($"Initializing component: '{this._Component}', using its " +
                                          $"constructor: '{this._Component}.{this._Process}'");
            this._LoggerUtility.LogInfo($"{this._Message}.");
        }
        #endregion

        #region Public Methods

        public IQueryable<T> GetAllBaseData()
        {
            this._Process = "GetAllBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is retrieving all {this._RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            return this._RepositoryContext.Set<T>();
        }

        public IQueryable<T> GetByIDBaseData(Expression<Func<T, bool>> expression)
        {
            this._Process = "GetByIDBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is retrieving by id {this._RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            return this._RepositoryContext.Set<T>()
                .Where(expression);
        }

        public void PostCreateBaseData(T entity)
        {
            this._Process = "PostCreateBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is creating and adding new {this._RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            this._RepositoryContext.Set<T>().Add(entity);
        }

        public void PutUpdateBaseData(T entity)
        {
            this._Process = "PutUpdateBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is updating {this._RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            this._RepositoryContext.Set<T>().Update(entity);
        }

        public void DeleteByIDBaseData(T entity)
        {
            this._Process = "DeleteByIDBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is deleting by id {this._RepositoryContext.Set<T>()} entitiy data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            this._RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsyncBaseData()
        {
            this._Process = "SaveAsyncBaseData";
            this._Message = string.Format($"[{this._Component}] queryable method '{this._Component}.{this._Process}' " +
                                          $"is asynchronously saving {this._RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._Component}");
            this._LoggerUtility.LogInfo($"{this._Message}.");

            await this._RepositoryContext.SaveChangesAsync();
        }
        #endregion
    }
}
