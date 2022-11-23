using ProjectMars.Utilities;
using System;
using ProjectMars.Pages;
using TechTalk.SpecFlow;


namespace ProjectMars.StepDefinitions
{
    
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        Login loginPageObj = new Login();
        Profile profilePageObj = new Profile();

        [Given(@"I logged in to the mars application successfully")]
        public void GivenILoggedInToTheMarsApplicationSuccessfully()
        {
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I add firstname, lastname and save to profile page")]
        public void WhenIAddFirstnameLastnameAndSaveToProfilePage()
        {
            profilePageObj.AddName(driver);
        }

        [Then(@"The Profile page should display both firstname and lastname")]
        public void ThenTheProfilePageShouldDisplayBothFirstnameAndLastname()
        {
            profilePageObj.GetName(driver);
        }

        [When(@"I select particular option for availability")]
        public void WhenISelectParticularOptionForAvailability()
        {
            profilePageObj.SelectAvailabilityType(driver);
        }

        [Then(@"The profile page should display added availability type")]
        public void ThenTheProfilePageShouldDisplayAddedAvailabilityType()
        {
            profilePageObj.GetAvailabilityType(driver);
        }

        [When(@"I select particular option for hours")]
        public void WhenISelectParticularOptionForHours()
        {
            profilePageObj.SelectHours(driver);
        }

        [Then(@"The profile page should display the selected hours option")]
        public void ThenTheProfilePageShouldDisplayTheSelectedHoursOption()
        {
            profilePageObj.GetHours(driver);    
        }

        [When(@"I select particular option for Earn Target")]
        public void WhenISelectParticularOptionForEarnTarget()
        {
            profilePageObj.SelectEarnTarget(driver);
        }

        [Then(@"The profile page should display the selected Earn Target Option")]
        public void ThenTheProfilePageShouldDisplayTheSelectedEarnTargetOption()
        {
            profilePageObj.GetEarnTarget(driver);
        }

        [When(@"I add and save the details in Description")]
        public void WhenIAddAndSaveTheDetailsInDescription()
        {
            profilePageObj.AddDescription(driver);
        }

        [Then(@"The profile page should display the added Description")]
        public void ThenTheProfilePageShouldDisplayTheAddedDescription()
        {
            profilePageObj.GetDescription(driver);
        }

        [When(@"I add skills and choose skill level in the profile page")]
        public void WhenIAddSkillsAndChooseSkillLevelInTheProfilePage()
        {
            profilePageObj.AddSkills(driver);
        }

        [Then(@"The profile page should display added skill and chosen skill level")]
        public void ThenTheProfilePageShouldDisplayAddedSkillAndChosenSkillLevel()
        {
            profilePageObj.GetSkills(driver);
        }

        [When(@"I add Education name,country,Title,degree and year to the profile page")]
        public void WhenIAddEducationNameCountryTitleDegreeAndYearToTheProfilePage()
        {
            profilePageObj.AddEducation(driver);
        }

        [Then(@"The profile page should display added education details")]
        public void ThenTheProfilePageShouldDisplayAddedEducationDetails()
        {
            profilePageObj.GetEducation(driver);
        }

        [When(@"I add multiple '([^']*)' and '([^']*)' to the profile page")]
        public void WhenIAddMultipleAndToTheProfilePage(string language, string level)
        {
            profilePageObj.AddLanguage(driver, language, level);
        }

        [Then(@"The profile page should display added '([^']*)' and '([^']*)'")]
        public void ThenTheProfilePageShouldDisplayAddedAnd(string language, string level)
        {
            profilePageObj.GetLanguage(driver, language, level);
        }
    }
}
