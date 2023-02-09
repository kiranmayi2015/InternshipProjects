using System;
using TechTalk.SpecFlow;
using MarsAdvanceTask.Utilities;
using MarsAdvanceTask.Pages;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class ChatsStepDefinitions : CommonDriver
    {
        LoginPage loginpageObj;
        ProfilePage profilepageObj;
        ChatsPage chatspageObj;

        public ChatsStepDefinitions()
        {
            loginpageObj = new LoginPage();
            profilepageObj = new ProfilePage();
            chatspageObj = new ChatsPage();
            
        }


        [Given(@"The User login to mars and navigate to profile page")]
        public void GivenTheUserLoginToMarsAndNavigateToProfilePage()
        {
            loginpageObj.LoginSteps();
            
        }

        [When(@"The user Clicks on Chat tab, then Chat screen opens")]
        public void WhenTheUserClicksOnChatTabThenChatScreenOpens()
        {
            profilepageObj.GoToChatsPage();
        }

        [When(@"The user inputs name in search input box")]
        public void WhenTheUserInputsNameInSearchInputBox()
        {
            chatspageObj.ChatSearch();
        }

        [Then(@"Chats between the input name and user should be visible")]
        public void ThenChatsBetweenTheInputNameAndUserShouldBeVisible()
        {
            chatspageObj.ChatHistory();
          
        }

        [Then(@"To send message type message in input box and click on send button")]
        public void ThenToSendMessageTypeMessageInInputBoxAndClickOnSendButton()
        {
            chatspageObj.ChatMessage();
        }
    }
}
