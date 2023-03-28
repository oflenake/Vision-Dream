using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;
using TestStack.White.Factory;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.Finders;

namespace VisionDream.TestWhite.Calculator
{
    class CalculatorTest
    {
        /// <summary>
        /// Automation of calculator using White Framework
        /// </summary>

        // Launch calculator exe through white
        private const string ExeSourceFile = @"C:\Windows\system32\calc.exe";
        // Global variable for application launch
        private static TestStack.White.Application _application;
        // Global variable to get the Main window of calculator from application
        private static TestStack.White.UIItems.WindowItems.Window _mainWindow;

        /// <summary>
        /// Find difference between dates through calculator
        /// </summary>
        private static void DateDifferenceCalculation()
        {
            Keyboard.Instance.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
            Keyboard.Instance.Enter("E");
            Keyboard.Instance.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);

            // On Date window find the difference between dates.
            // Set the value into combobox
            var comboBox = _mainWindow.Get<TestStack.White.UIItems.ListBoxItems.ComboBox>
            (SearchCriteria.ByAutomationId("4003"));
            comboBox.Select("Calculate the difference between two dates");

            // Click on Calculate button
            TestStack.White.UIItems.Button caclButton =
            _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("4009"));
            caclButton.Click();
        }

        /// <summary>
        /// Change and return the calculator mode back to basic using the Key Board Hot Key
        /// </summary>
        private static void ReturnToBasicCalculatorUsingHotKey()
        {
            Keyboard.Instance.HoldKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
            Keyboard.Instance.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.F4);
            Keyboard.Instance.LeaveKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
        }

        /// <summary>
        /// Change and return the calculator mode back to basic using the Key Board View Menu
        /// </summary>
        private static void ReturnToBasicCalculatorUsingViewMenu()
        {
            // Click on View Menu
            var menuView = _mainWindow.Get<TestStack.White.UIItems.MenuItems.Menu>(SearchCriteria.ByText("View"));
            menuView.Click();

            // Select and click on Basic, on the Drop Down Menu
            var menuViewBasic = _mainWindow.Get<TestStack.White.UIItems.MenuItems.Menu>(SearchCriteria.ByText("Basic"));
            menuViewBasic.Click();
        }

        /// <summary>
        /// Open Help Menu file 
        /// </summary>
        private static void OpenHelpOptionInCalculator()
        {
            // Click on Help Menu item
            var help = _mainWindow.Get<TestStack.White.UIItems.MenuItems.Menu>(SearchCriteria.ByText("Help"));
            help.Click();
            // Click on View Help guide to open new window from menu bar
            var viewHelp = _mainWindow.Get<TestStack.White.UIItems.MenuItems.Menu>(SearchCriteria.ByText("View Help"));
            viewHelp.Click();
        }

        /// <summary>
        /// Perform summation on calculator through White.
        /// Add two numbers (1234 + 5678 = 6912) and get the result.
        /// Compare the result to check whether the calculator is working perfectly fine or not.
        /// Read all the keys of the calculator to press the desired key through white, using text instead of Automation Id.
        /// </summary>
        private static void PerformSummationInCalculator()
        {
            // Button with Numerical value 1
            TestStack.White.UIItems.Button btn1 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("1"));
            // Button with Numerical value 2
            TestStack.White.UIItems.Button btn2 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("2"));
            // Button with Numerical value 3
            TestStack.White.UIItems.Button btn3 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("3"));
            // Button with Numerical value 4
            TestStack.White.UIItems.Button btn4 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("4"));
            // Button with Numerical value 5
            TestStack.White.UIItems.Button btn5 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("5"));
            // Button with Numerical value 6
            TestStack.White.UIItems.Button btn6 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("6"));
            // Button with Numerical value 7
            TestStack.White.UIItems.Button btn7 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("7"));
            // Button with Numerical value 8
            TestStack.White.UIItems.Button btn8 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("8"));
            // Button with Numerical value 9
            TestStack.White.UIItems.Button btn9 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("9"));
            // Button with Numerical value 0
            TestStack.White.UIItems.Button btn0 = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("0"));
            // Button with text as +(for sum)
            TestStack.White.UIItems.Button btnSum = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("Add"));
            // Read button to get the result
            TestStack.White.UIItems.Button btnResult = _mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("Equals"));

            // Type first set of numbers: 1234
            btn1.Click();
            btn2.Click();
            btn3.Click();
            btn4.Click();
            // Press Add(+) button to add the second number
            btnSum.Click();
            // Type second set of numbers: 5678 
            btn5.Click();
            btn6.Click();
            btn7.Click();
            btn8.Click();
            // Press Result(=) button to get the result
            btnResult.Click();

            // Read the result from the calculator display into a label
            TestStack.White.UIItems.Label resultLabel = _mainWindow.Get<TestStack.White.UIItems.Label>
            (SearchCriteria.ByAutomationId("150"));

            // Compare the result computed to see if it is correct or not
            string result = resultLabel.Text;
            Assert.AreEqual("6912", result, "Sorry Summation is wrong!!");
        }

        static void Main(string[] args)
        {
            // Start process for the above exe file location
            var psi = new ProcessStartInfo(ExeSourceFile);
            // Launch the process through white application
            _application = TestStack.White.Application.AttachOrLaunch(psi);
            // Get the window of calculator from white application 
            _mainWindow = _application.GetWindow(SearchCriteria.ByText("Calculator"), InitializeOption.NoCache);
            // _mainWindow = _application.GetWindow(SearchCriteria.ByText("Standard"), InitializeOption.NoCache);
        }
    }
}
