#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.2 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.2.
    * Version:      v1.0.0
    * File:         LoggerManagerUtility.cs
    * Date:         2019-01-10
    * Description:  This file contains the LoggerManagerUtility class. 
    *               Class execution code.
*/
#endregion

using Vision_Dream.ContractsService;
using NLog;

namespace Vision_Dream.LoggerService
{
    public class LoggerManagerUtility : ILoggerManagerUtility
    {
        private static ILogger _LoggerUtility = LogManager.GetCurrentClassLogger();

        public LoggerManagerUtility()
        {
        }

        public void LogDebug(string message)
        {
            _LoggerUtility.Debug(message);
        }

        public void LogError(string message)
        {
            _LoggerUtility.Error(message);
        }

        public void LogInfo(string message)
        {
            _LoggerUtility.Info(message);
        }

        public void LogWarn(string message)
        {
            _LoggerUtility.Warn(message);
        }
    }
}
