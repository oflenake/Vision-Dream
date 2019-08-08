#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.1 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.1.
    * Version:      v1.0.0
    * File:         VDEventLog.cs
    * Date:         2019-01-10
    * Description:  This file contains the VDEventLog class. 
    *               Class execution code.
*/
#endregion

using System;
using System.IO;

namespace Vision_Dream.General
{
    /// <summary>
    /// Custom Logging Class.
    /// </summary>
    /// <value>
    /// Utility for writing custom logs to a file(s) using <see cref="VDEventLog"/>.
    /// Returning formated output data to be used.
    /// </value>
    /// <remarks>
    /// <para>
    /// Writes formatted string data to a specified log file(s).
    /// Returns formatted output string data to be streamed or written to standard output.
    /// </para>
    /// </remarks>

    public class VDEventLog
    {
        #region Fields
        /// <summary> Input
        /// </summary>

        private static string _LogFile;
        private static string _Process;
        private static string _Message;
        /// <summary> Internal
        /// </summary>

        private static string _DateTime;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor.
        /// </summary>

        public VDEventLog()
        {
        }

        /// <summary>
        /// Parameterized Constructor requiring a log file name parameter.
        /// </summary>

        public VDEventLog(string logfile)
        {
            _LogFile = logfile;
            _Process = string.Empty;
            _Message = string.Empty;
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// <see cref="ReturnLog"/> Method.
        /// </summary>
        /// <value>
        /// Return a formatted string to write.
        /// </value>

        public static string ReturnLog(string process)
        {
            _Process = process;
            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return string.Format("{0} {1}", _DateTime, _Process);
        }

        public static string ReturnLog(string process, string message)
        {
            _Process = process;
            _Message = message;
            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return string.Format("{0} [{1}] - {2}", _DateTime, _Process, _Message);
        }

        /// <summary>
        /// <see cref="WriteLog"/> Method.
        /// </summary>
        /// <value>
        /// FileStream processing event log.
        /// Write an empty line to a log file.
        /// </value>

        public static void WriteLog(string logfile = null)
        {
            if (!string.IsNullOrEmpty(logfile))
                _LogFile = logfile;

            using (FileStream stream = File.Open(_LogFile, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream))
                    writer.WriteLine();
            }
        }

        /// <summary>
        /// <see cref="WriteLog"/> Method.
        /// </summary>
        /// <value>
        /// FileStream processing event log overloading method.
        /// Write log data to a log file.
        /// </value>

        public static void WriteLog(string message, string logfile = null)
        {
            if (!string.IsNullOrEmpty(logfile))
                _LogFile = logfile;

            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (FileStream stream = File.Open(_LogFile, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream))
                    writer.WriteLine("{0} {1}", _DateTime, message);
            }
        }

        public static void WriteLog(string process, string message, string logfile = null)
        {
            if (!string.IsNullOrEmpty(logfile))
                _LogFile = logfile;

            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (FileStream stream = File.Open(_LogFile, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream))
                    writer.WriteLine("{0} [{1}] - {2}", _DateTime, process, message);
            }
        }

        public static void WriteLog(string process, string message, string status, string logfile = null)
        {
            if (!string.IsNullOrEmpty(logfile))
                _LogFile = logfile;

            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (FileStream stream = File.Open(_LogFile, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream))
                    writer.WriteLine("{0} [{1}] - {2} | Status: {3}", _DateTime, process, message, status);
            }
        }
        #endregion
    }
}
