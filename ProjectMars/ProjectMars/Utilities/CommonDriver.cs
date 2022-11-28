using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using ProjectMars.Utilities;

namespace ProjectMars.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {

            //Defining the browser
            driver = new ChromeDriver();

            //Maximise the window
           // driver.Manage().Window.Maximize();
        }

        //Implicit Wait
        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        //Close the browser
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}