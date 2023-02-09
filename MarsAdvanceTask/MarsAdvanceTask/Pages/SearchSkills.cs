using AventStack.ExtentReports;
using MarsAdvanceTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsAdvanceTask.Input;

namespace MarsAdvanceTask.Pages
{
    public class SearchSkills : CommonDriver
    {
        //profile tab
        public IWebElement profileTab => driver.FindElement(By.LinkText("Profile"));

        //Click on SearchTextBox
        public IWebElement searchTextbox => driver.FindElement(By.XPath("//div[@class='ui secondary menu']//input[@placeholder='Search skills']"));

        //Click on refine search skills
        public IWebElement refineSearchskills => driver.FindElement(By.XPath("/html//div[@id='service-search-section']/div[2]//section[@class='search-results']/div/div[1]/div[2]/input[@type='text']"));

        //click on refine search user textbox
        public IWebElement refineSearchUser => driver.FindElement(By.XPath("/html//div[@id='service-search-section']/div[2]//section[@class='search-results']/div/div[1]/div[3]/div[1]/div//input"));


        public void ProfileTab()
        {
            UseWait();
            profileTab.Click();
        }
        public void Searchskills()
        {
            
            // Populate Login page test data collection
            ExcelReader.ReadDataTable(stream, "SearchSkills");
            //Click on Searchskills textbox
            Thread.Sleep(3000);
            searchTextbox.Click();
            searchTextbox.SendKeys(ExcelReader.ReadData(1, "Searchskills"));
            UseWait();
            searchTextbox.SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            //Validate Search Skills
            
            string actualPageTitle = driver.Title;
            string expectedPageTitle = "Search";

            try
            {

                Thread.Sleep(3000);
                test = extentreportObj.CreateTest("SearchSkills");
                if (expectedPageTitle == actualPageTitle)
                {
                    test.Log(Status.Pass, "Test Passed, SearchSkills Page Visible");
                    test.Log(Status.Info, "Validating the Searchskills Page");
                    TakeScreenShot.SSMethod(driver);
                    Assert.Pass("Test Passed, SearchSkills Page Visible");
                }
                else
                {
                    test.Log(Status.Fail, "Test Failed");
                    Assert.Fail("Test Failed, SearchSkills Page doesn't Exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        public void RefineSearchSkills()
        {
            
            // Populate Login page test data collection
            ExcelReader.ReadDataTable(stream, "SearchSkills");
            //Click on Searchskills textbox
            UseWait();
            searchTextbox.Click();
            searchTextbox.SendKeys(ExcelReader.ReadData(1, "Searchskills"));
            UseWait();
            searchTextbox.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            //Click on Refine Search Skills
            refineSearchskills.Click();
            Thread.Sleep(2000);
            refineSearchskills.SendKeys(ExcelReader.ReadData(1, "Refineskills"));
            Thread.Sleep(2000);
            searchTextbox.SendKeys(Keys.Enter);
            UseWait();
        }
        public void RefinesearchUser()
        {
            //Click on Refine User
            refineSearchUser.Click();
            UseWait();
            refineSearchUser.SendKeys(ExcelReader.ReadData(1, "RefineSearchUser"));
            Thread.Sleep(2000);
            refineSearchUser.SendKeys(Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(3000);

        }
        public void RefineSearchVisible()
        {
            //Validate RefineSearchSkills

            ExcelReader.ReadDataTable(stream, "SearchSkills");
            Thread.Sleep(4000);
            String ActualUser = driver.FindElement(By.LinkText("Kiranmayi")).Text;
            String ActualSkill = driver.FindElement(By.LinkText("Automation")).Text;
            Thread.Sleep(3000);
            String ExpectedUser = ExcelReader.ReadData(1, "RefineSearchUser");
            String ExpectedSkill = ExcelReader.ReadData(1, "Searchskills");
            Thread.Sleep(5000);

            try
            {
                Thread.Sleep(3000);
                test = extentreportObj.CreateTest("SearchSkills");

                if (ActualUser == ExpectedUser && ActualSkill == ExpectedSkill)
                {
                    Thread.Sleep(3000);
                    test.Log(Status.Info, "Validating the SearchSkills");
                    TakeScreenShot.SSMethod(driver);
                    test.Log(Status.Pass, "Test Passed, SearchSkills Visible");
                    Assert.Pass("Test Passed, SearchSkills Visible");
                }
                else
                {
                    Thread.Sleep(3000);
                    test.Log(Status.Fail, "Test Failed, SearchSkills doesn't Exists ");
                    Assert.Fail("Test Fail, SearchSkills doesn't Exists");
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void RefineFilterSearchSkills()
        {
            
            // Populate Profile page test data collection
            ExcelReader.ReadDataTable(stream, "SearchSkills");
            // Search skills using filter
            string value1 = ExcelReader.ReadData(1, "FilterButtons");
            string value2 = ExcelReader.ReadData(2, "FilterButtons");
            string value3 = ExcelReader.ReadData(3, "FilterButtons");
            // Click on button
            string Button = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]")).Text;


            Thread.Sleep(3000);

            for (int i = 1; i <= 3; i++)
            {
                // Click on ith button
                string actualvalue = driver.FindElement(By.XPath("//div/section/div/div[1]/div[5]/button[" + i + "]")).Text;
                if (actualvalue == value1)
                {
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//button[normalize-space()='Online']")).Click();
                    Console.WriteLine("Test Passed for Online Filter");
                    Thread.Sleep(2000);
                }
                else if (actualvalue == value2)
                {
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//button[normalize-space()='Onsite']")).Click();
                    Console.WriteLine("Test Passed for Onsite Filter");
                    Thread.Sleep(2000);
                }
                else if (actualvalue == value3)
                {
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//button[normalize-space()='ShowAll']")).Click();
                    Console.WriteLine("Test Passed for ShowAll Filter");
                    Thread.Sleep(2000);
                }
            }

            
        }


    }
}

 