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

        private ILoggerManagerUtility _LoggerUtility;
        private string _Component;
        private string _Process;
        private string _Message;

        private RepositoryContext _RepositoryContext;
        private IEmployeeRepository _EmployeeRepository;
        private IBankAccountRepository _BankAccountRepository;
        #endregion

        public RepositoryWrapper(ILoggerManagerUtility loggerUtility, RepositoryContext repositoryContext)
        {
            _LoggerUtility = loggerUtility;
            _RepositoryContext = repositoryContext;

            _Component = "RepositoryWrapper";
            _Process = "RepositoryWrapper";
            _Message = string.Format($"Initializing component: '{_Component}', using its constructor: '{_Component}.{_Process}'");

            _LoggerUtility.LogInfo($"{_Message}.");
        }

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                _Process = "EmployeeRepository";

                if (_EmployeeRepository == null)
                {
                    _EmployeeRepository = new EmployeeRepository(_LoggerUtility, _RepositoryContext);

                    _Message = string.Format($"[{_Component}] {_Process} is 'null'. A new repository created " +
                                             $"and initialized at: '{_Component}.{_Process}'");
                    _LoggerUtility.LogWarn($"{_Message}.");
                }

                _Message = string.Format($"[{_Component}] {_Process} wraped for database operations " +
                                         $"at: '{_Component}.{_Process}'");
                _LoggerUtility.LogInfo($"{_Message}.");

                return _EmployeeRepository;
            }
        }

        public IBankAccountRepository BankAccountRepository
        {
            get
            {
                _Process = "BankAccountRepository";

                if (_BankAccountRepository == null)
                {
                    _BankAccountRepository = new BankAccountRepository(_LoggerUtility, _RepositoryContext);

                    _Message = string.Format($"[{_Component}] {_Process} is 'null'. A new repository created " +
                                             $"and initialized at: '{_Component}.{_Process}'");
                    _LoggerUtility.LogWarn($"{_Message}.");
                }

                _Message = string.Format($"[{_Component}] {_Process} wraped for database operations " +
                                         $"at: '{_Component}.{_Process}'");
                _LoggerUtility.LogInfo($"{_Message}.");

                return _BankAccountRepository;
            }
        }
    }
}
