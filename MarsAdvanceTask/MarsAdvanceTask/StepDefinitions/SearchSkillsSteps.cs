using MarsAdvanceTask.Pages;
using MarsAdvanceTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class SearchSkillsSteps : CommonDriver
    {
        SearchSkills searchskillsObj = new SearchSkills();

        [Given(@"the user is on Profile tab")]
        public void GivenTheUserIsOnProfileTab()
        {
            searchskillsObj.ProfileTab();
        }

        [When(@"the user input search key Refine search and click on searchicon")]
        public void WhenTheUserInputSearchKeyRefineSearchAndClickOnSearchicon()
        {
            searchskillsObj.Searchskills();
            searchskillsObj.RefineSearchSkills();
        }

        [When(@"the user input search user key search user and click on searchicon")]
        public void WhenTheUserInputSearchUserKeySearchUserAndClickOnSearchicon()
        {
            searchskillsObj.RefinesearchUser();
        }

        [Then(@"the refined search items should be Displayed")]
        public void ThenTheRefinedSearchItemsShouldBeDisplayed()
        {
            searchskillsObj.RefineFilterSearchSkills();
        }

        [When(@"the user inputs search key in search inputbox and click on searchicon")]
        public void WhenTheUserInputsSearchKeyInSearchInputboxAndClickOnSearchicon()
        {
            searchskillsObj.Searchskills();
        }

        [Then(@"the filtered search should be displayed")]
        public void ThenTheFilteredSearchShouldBeDisplayed()
        {
            searchskillsObj.RefineSearchVisible();
        }
    }
}
