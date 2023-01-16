using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompetitionTask1.Utilities;
using System.IO;
using AventStack.ExtentReports;
using CompetitionTask1.Input;
using CompetitionTask1.Pages;
using NUnit.Framework;
using CompetitionTask1.Screenshots;
using SeleniumExtras.PageObjects;
using ExcelDataReader;
using OpenQA.Selenium;
using NuGet.Frameworks;

namespace CompetitionTask1.Tests
{
    [TestFixture]
    public class ShareSkill_Tests : CommonDriver
    {
       
        ProfilePage profilepageObj = new ProfilePage();
        ShareSkillPage shareskillpageObj = new ShareSkillPage();
        ManageListingsPage managelistingspageObj = new ManageListingsPage();
        


        [Test, Order(1)]


        public void CreateShareSkillTest()
        {
            try
            {


                test = extentreportObj.CreateTest("CreateSkills", "Testing Create Skills");
                profilepageObj.GoToShareSkillPage();
                shareskillpageObj.CreateShareSkill();
                PageFactory.InitElements(driver, this);
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch(Exception ex)
            {
                
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Create Skills Test Failed", ex.Message);
                throw;
            }
        }


        [Test, Order(2)]

        public void ViewShareSkillsTest()
        {
            try
            {

                test = extentreportObj.CreateTest("ViewSkills", "Testing Creted Skills");
                profilepageObj.GoToManageListingsPage();
                PageFactory.InitElements(driver, this);
                managelistingspageObj.ViewListings();
                Thread.Sleep(2000);
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "View Shareskills page opened successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch(Exception ex)
            {
                
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("View skills test failed", ex.Message);
                throw;
            }
        }

        [Test, Order(3)]
        public void EditShareSkillTest()
        {
        try
        {

             test = extentreportObj.CreateTest("EditSkills", "Testing Created Skills");
            profilepageObj.GoToManageListingsPage();
            managelistingspageObj.GoToShareSkillPage();
            shareskillpageObj.EditShareSkill();
            CommonDriver.UseWait();
            TakeScreenShot.SSMethod(driver);
            test.Log(Status.Info, "Skills edited successfully");
            test.Log(Status.Pass, "Test passed");
        }
        catch(Exception ex)
        {
            
            test.Log(Status.Fail, "Test Failed");
            Assert.Fail("Edit Skills Test failed", ex.Message);
            throw;
        }


    }
           

        [Test, Order(4)]

        public void DeleteShareSkillTest()
        {
            try
            {
                test = extentreportObj.CreateTest("DeleteSkills", "Deleting skills created");
                profilepageObj.GoToManageListingsPage();
                managelistingspageObj.DeleteShareSkill();
                Thread.Sleep(2000);
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skill listing deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch(Exception ex)
            {
                
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Delete Skills Test failed", ex.Message);
                throw;
            }

        }

    }

} 
    



    

