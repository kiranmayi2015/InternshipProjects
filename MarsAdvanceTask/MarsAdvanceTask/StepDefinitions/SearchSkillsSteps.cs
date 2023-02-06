using MarsAdvanceTask.Pages;
using MarsAdvanceTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class SearchSkillsSteps : CommonDriver
    {
        LoginPage loginpageObj = new LoginPage();
        ProfilePage profilepageObj = new ProfilePage();
        SearchSkillPage searchskillpageObj = new SearchSkillPage();

        [Given(@"I login to the Mars website")]
        public void GivenILoginToTheMarsWebsite()
        {
            loginpageObj.LoginSteps();
            profilepageObj.GoToSearchSkillsPage();
        }

        [When(@"I select select category and subcategory")]
        public void WhenISelectSelectCategoryAndSubcategory()
        {
            searchskillpageObj.Category();
            searchskillpageObj.SubCategory();
        }

        [When(@"I refine filters by online")]
        public void WhenIRefineFiltersByOnline()
        {
            searchskillpageObj.ClickOnlineBtn();
        }

        [Then(@"Only results matching with online location are displayed")]
        public void ThenOnlyResultsMatchingWithOnlineLocationAreDisplayed()
        {
            searchskillpageObj.ClickResultBtn();
        }

        [When(@"I click on onsite filter")]
        public void WhenIClickOnOnsiteFilter()
        {
            searchskillpageObj.ClickOnSiteBtn();
        }

        [Then(@"Only results matching with onsite location are displayed")]
        public void ThenOnlyResultsMatchingWithOnsiteLocationAreDisplayed()
        {
            searchskillpageObj.ClickResultBtn();
        }

        [When(@"I click on show all filter")]
        public void WhenIClickOnShowAllFilter()
        {
            searchskillpageObj.ClickShowAllBtn();
        }

        [Then(@"The results with both onsite and online locations are displayed")]
        public void ThenTheResultsWithBothOnsiteAndOnlineLocationsAreDisplayed()
        {
            searchskillpageObj.ClickResultBtn();
        }
    }
}
