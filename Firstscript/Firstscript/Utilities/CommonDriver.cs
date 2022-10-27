using Firstscript.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstscript.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        LoginPage loginPageObj = new LoginPage();


        [OneTimeSetUp]
        public void LoginActions()
        {

            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        
        }
    }
}
