using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Firstscript.Utilities;
using Firstscript.Pages;

namespace Firstscript.StepDefinitions
{
    [Binding]
    public class TM_FeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();


        [Given(@"I logged into Turnup portal successfully")]


        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            //login page obj initialization and defininition

            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()

        {
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new Time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {

            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {

            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Thread.Sleep(10000);
            Assert.That(newCode == "firstscript", "New code and expected code do not match.");
            Assert.That(newDescription == "description", "New description and expected description do not match.");
            Assert.That(newPrice == "$15.00", "New price and expected price do not match.");

        }

        [When(@"I update '([^']*)' , '([^']*)' and '([^']*)' on an existing Time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            tmPageObj.EditTM(driver, description, code, price);
        }

        [Then(@"The record should have updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveUpdatedAnd(string description, string code, string price)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            Assert.That(editedDescription == "Actual and Expected description not matched");
            Assert.That(editedCode == "Actual and expected code not matched");
            Assert.That(editedPrice == "Acutal and expected price not matched");
        }

    }

}

