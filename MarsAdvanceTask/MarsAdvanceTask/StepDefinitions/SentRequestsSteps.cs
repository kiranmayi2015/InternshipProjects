using MarsAdvanceTask.Pages;
using MarsAdvanceTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class SentRequestsSteps : CommonDriver
    {

        SentRequests sentrequestsObj = new SentRequests();
        ProfilePage profilepageObj = new ProfilePage();
        
        [When(@"I click on Manage Requests tab and select SentRequests")]
        public void WhenIClickOnManageRequestsTabAndSelectSentRequests()
        {
            profilepageObj.ManageRequestsTab();
            sentrequestsObj.SentRequest();
        }

        [When(@"If the seller has not accepted the request")]
        public void WhenIfTheSellerHasNotAcceptedTheRequest()
        {
            sentrequestsObj.PendingStatus();
        }

        [When(@"The user click on withdraw for the request sent")]
        public void WhenTheUserClickOnWithdrawForTheRequestSent()
        {
            sentrequestsObj.WithdrawSentRequest();
        }

        [Then(@"The status should be displayed as Withdrawn")]
        public void ThenTheStatusShouldBeDisplayedAsWithdrawn()
        {
            sentrequestsObj.WithdrawStatus();
        }

        [When(@"The request send is declined by the seller")]
        public void WhenTheRequestSendIsDeclinedByTheSeller()
        {
            sentrequestsObj.DeclineStatus();
        }

       
        [When(@"The request sent is accepted by the Seller")]
        public void WhenTheRequestSentIsAcceptedByTheSeller()
        {
            sentrequestsObj.AcceptedStatus();
        }

        [When(@"The request is accepted by both buyer and seller")]
        public void WhenTheRequestIsAcceptedByBothBuyerAndSeller()
        {
            sentrequestsObj.CompleteButton();
        }

        [Then(@"Mark As Complete button should be displayed")]
        public void ThenMarkAsCompleteButtonShouldBeDisplayed()
        {
            sentrequestsObj.Completed();
        }

        [When(@"The Status is Completed")]
        public void WhenTheStatusIsCompleted()
        {
            sentrequestsObj.CompleteStatus();
        }

        [When(@"Click on Review Button")]
        public void WhenClickOnReviewButton()
        {
            sentrequestsObj.ReviewButton();
        }

        [Then(@"Review and Ratings can be given and save review and ratings")]
        public void ThenReviewAndRatingsCanBeGivenAndSaveReviewAndRatings()
        {
            sentrequestsObj.Review();
        }
    }
}
