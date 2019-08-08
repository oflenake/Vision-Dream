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
    * File:         RepositoryWrapper.cs
    * Date:         2019-01-10
    * Description:  This file contains the RepositoryWrapper class. 
    *               Class execution code.
*/
#endregion

using Vision_Dream.ContractsService;
using Vision_Dream.EntitiesService;

namespace Vision_Dream.RepositoryService
{
    /// <summary>
    /// The <see cref="RepositoryWrapper"/> class that is used by entity models and 
    /// their related entity models to access the backend repository base.
    /// </summary>
    public class RepositoryWrapper : IRepositoryWrapper
    {
        #region Fields

        private ILoggerManager _logger;
        private string _component;
        private string _process;
        private string _message;

        private RepositoryContext _repoContext;
        private IEmployeeRepository _employeeRepo;
        private IBankAccountRepository _bankaccountRepo;
        #endregion

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                _process = "EmployeeRepository";

                if (_employeeRepo == null)
                {
                    _employeeRepo = new EmployeeRepository(_logger, _repoContext);

                    _message = string.Format($"[{_component}] {_process} is 'null'. A new repository created " +
                                             $"and initialized at: '{_component}.{_process}'");
                    _logger.LogWarn($"{_message}.");
                }

                _message = string.Format($"[{_component}] {_process} wraped for database operations " +
                                         $"at: '{_component}.{_process}'");
                _logger.LogInfo($"{_message}.");

                return _employeeRepo;
            }
        }

        public IBankAccountRepository BankAccountRepository
        {
            get
            {
                _process = "BankAccountRepository";

                if (_bankaccountRepo == null)
                {
                    _bankaccountRepo = new BankAccountRepository(_logger, _repoContext);

                    _message = string.Format($"[{_component}] {_process} is 'null'. A new repository created " +
                                             $"and initialized at: '{_component}.{_process}'");
                    _logger.LogWarn($"{_message}.");
                }

                _message = string.Format($"[{_component}] {_process} wraped for database operations " +
                                         $"at: '{_component}.{_process}'");
                _logger.LogInfo($"{_message}.");

                return _bankaccountRepo;
            }
        }

        public RepositoryWrapper(ILoggerManager logger, RepositoryContext repositoryContext)
        {
            _logger = logger;
            _repoContext = repositoryContext;

            _component = "RepositoryWrapper";
            _process = "RepositoryWrapper";
            _message = string.Format($"Initializing component: '{_component}', using its constructor: '{_component}.{_process}'");

            _logger.LogInfo($"{_message}.");
        }
    }
}
