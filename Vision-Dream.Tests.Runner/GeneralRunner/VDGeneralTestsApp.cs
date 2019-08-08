#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _____________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.1 (Vision-Dream) Library Tests
    *               Runner App. Project Targeting .Net Core 2.1.
    * Version:      v1.0.0
    * File:         VDGeneralTestsApp.cs
    * Date:         2019-01-10
    * Description:  This file contains the VDGeneralTestsApp class. 
    *               Class execution code.
*/
#endregion

using System;
using Vision_Dream.General;

namespace Vision_Dream.Tests.Runner.GeneralRunner
{
    class VDGeneralTestsApp
    {
        private static string _AppName;
        static void Main(string[] args)
        {
            _AppName = "VDGeneralTestsApp";
            Console.WriteLine($"Vision-Dream tests runner '{_AppName}' started...\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            int row = 0;

            do
            {
                if (row == 0 || row >= 15)
                    ResetConsole();

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;

                Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                                  $"{(StringCharCheck.IsFirstUpper(input) ? "Yes" : "No")}\n");
                Console.WriteLine($"Input: {input} {"Formatted returned data is ",30}: " +
                                  $"{VDEventLog.ReturnLog(input)}\n");
                row += 3;
            } while (true);
            return;

            // Declare a ResetConsole local method
            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
                row = 3;
            }
        }
    }
}
