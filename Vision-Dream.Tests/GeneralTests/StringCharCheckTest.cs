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
    * File:         StringCharCheckTest.cs
    * Date:         2019-01-10
    * Description:  This file contains the StringCharCheckTest class. 
    *               Class execution code.
*/
#endregion

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vision_Dream.General;

namespace Vision_Dream.Tests.GeneralTests
{
    [TestClass]
    public class StringCharCheckTest
    {
        [TestMethod]
        public void IsFirstUpperTestTrue()
        {
            // Test expected to return true.
            string[] words = { "Onkgopotse", "Kgupi", "Alphabet", "Zebra", "ABC" };
            foreach (var word in words)
            {
                bool result = StringCharCheck.IsFirstUpper(word);
                Assert.IsTrue(result, string.Format("Expected for '{0}': true; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void IsFirstUpperTestFalse()
        {
            // Test expected to return false.
            string[] words = { "onkgopotse", "kgupi", "alphabet", "zebra", "abc", "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = StringCharCheck.IsFirstUpper(word);
                Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void IsFirstUpperTestNullOrEmpty()
        {
            // Test expected to return false.
            string[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringCharCheck.IsFirstUpper(word);
                Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}",
                                                     word == null ? "<null>" : word, result));
            }
        }
    }
}
