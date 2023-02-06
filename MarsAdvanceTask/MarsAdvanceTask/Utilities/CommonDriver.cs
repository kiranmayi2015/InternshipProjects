using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using MarsAdvanceTask.Input;
using MarsAdvanceTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvanceTask.Utilities
{
    public class CommonDriver
    {

        public static IWebDriver driver;
        public static ExtentReports extentreportObj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        public static FileStream stream;

        [OneTimeSetUp]

        public void LoginFunctions()
        {

            var htmlreporter = new ExtentHtmlReporter(@"C:\Testing\sampletest\MarsAdvanceTask\MarsAdvanceTask\ExtentReports\");
            extentreportObj = new ExtentReports();
            extentreportObj.AttachReporter(htmlreporter);


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            if (LoginCredentials.String1 == "kiranmayi.bodireddy@gmail.com")
            {
                LoginPage loginpageObj = new LoginPage();
                loginpageObj.LoginSteps();
            }
            else
            {
                SignUpPage signuppageObj = new SignUpPage();
                signuppageObj.SignUpSteps();
            }

            string fileName = @"C:\Testing\sampletest\MarsAdvanceTask\MarsAdvanceTask\ExternalFiles\AdvanceMars_TestData.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //ExcelReader.ReadDataTable(stream, "Profile");

        }
        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [OneTimeTearDown]

        public void CloseTestRun()
        {
            extentreportObj.Flush();
            driver.Quit();
        }
    }
}
    

