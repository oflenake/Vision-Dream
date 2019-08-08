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

        protected ILoggerManager _logger;
        protected string _component;
        protected string _process;
        protected string _message;
        #endregion

        #region Properties

        protected RepositoryContext RepositoryContext { get; set; }
        #endregion

        #region Constructor

        public RepositoryBase(ILoggerManager logger, RepositoryContext repositoryContext)
        {
            this._logger = logger;
            this.RepositoryContext = repositoryContext;

            this._component = "RepositoryBase";
            this._process = "RepositoryBase";
            this._message = string.Format($"Initializing component: '{this._component}', using its " +
                                          $"constructor: '{this._component}.{this._process}'");
            this._logger.LogInfo($"{this._message}.");
        }
        #endregion

        #region Public Methods

        public IQueryable<T> GetAllBaseData()
        {
            this._process = "GetAllBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is retrieving all {this.RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            return this.RepositoryContext.Set<T>();
        }

        public IQueryable<T> GetByIDBaseData(Expression<Func<T, bool>> expression)
        {
            this._process = "GetByIDBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is retrieving by id {this.RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            return this.RepositoryContext.Set<T>()
                .Where(expression);
        }

        public void PostCreateBaseData(T entity)
        {
            this._process = "PostCreateBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is creating and adding new {this.RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void PutUpdateBaseData(T entity)
        {
            this._process = "PutUpdateBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is updating {this.RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void DeleteByIDBaseData(T entity)
        {
            this._process = "DeleteByIDBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is deleting by id {this.RepositoryContext.Set<T>()} entitiy data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task SaveAsyncBaseData()
        {
            this._process = "SaveAsyncBaseData";
            this._message = string.Format($"[{this._component}] queryable method '{this._component}.{this._process}' " +
                                          $"is asynchronously saving {this.RepositoryContext.Set<T>()} entity data, using " +
                                          $"the abstract {this._component}");
            this._logger.LogInfo($"{this._message}.");

            await this.RepositoryContext.SaveChangesAsync();
        }
        #endregion
    }
}
