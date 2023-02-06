using MarsAdvanceTask.Pages;
using MarsAdvanceTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class ChatsStepDefinitions : CommonDriver
    {
        ChatsPage chatpageObj = new ChatsPage();
        LoginPage loginpageObj = new LoginPage();
        ProfilePage profilepageObj = new ProfilePage();

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
            chatpageObj.ChatSearch();
        }

        [Then(@"Chats between the input name and user should be visible")]
        public void ThenChatsBetweenTheInputNameAndUserShouldBeVisible()
        {
            chatpageObj.ChatHistory();
        }

        [Then(@"To send message type message in input box and click on send button")]
        public void ThenToSendMessageTypeMessageInInputBoxAndClickOnSendButton()
        {
            chatpageObj.ChatMessage();
            chatpageObj.ChatSendbutton();
        }
    }
}
