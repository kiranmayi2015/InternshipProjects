using MarsAdvanceTask.Pages;
using MarsAdvanceTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvanceTask.StepDefinitions
{
    [Binding]
    public class SentRequestsSteps : CommonDriver
    {
        ProfilePage profilepageObj = new ProfilePage();
        SentRequests sentrequestsObj = new SentRequests();

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

        [Then(@"The status should be displayed as Pending")]
        public void ThenTheStatusShouldBeDisplayedAsPending()
        {
            sentrequestsObj.PendingStatus();
        }

        [When(@"If the user click on withdraw for the request sent")]
        public void WhenIfTheUserClickOnWithdrawForTheRequestSent()
        {
            sentrequestsObj.WithdrawSentRequest();
        }

        [Then(@"The status should be displayed as Withdrawn")]
        public void ThenTheStatusShouldBeDisplayedAsWithdrawn()
        {
            sentrequestsObj.WithdrawStatus();
        }

        [When(@"If the request send is declined by the seller")]
        public void WhenIfTheRequestSendIsDeclinedByTheSeller()
        {
            sentrequestsObj.DeclineStatus();
        }

        [Then(@"The status should be displayed as Declined")]
        public void ThenTheStatusShouldBeDisplayedAsDeclined()
        {
               sentrequestsObj.DeclineStatus();
        }

        [When(@"If the request sent is accepted by the Seller")]
        public void WhenIfTheRequestSentIsAcceptedByTheSeller()
        {
            sentrequestsObj.AcceptedStatus();
        }

        [Then(@"The status should be displayed as Accepted")]
        public void ThenTheStatusShouldBeDisplayedAsAccepted()
        {
            sentrequestsObj.AcceptedStatus();
        }

        [When(@"If the request is accepted by both buyer and seller")]
        public void WhenIfTheRequestIsAcceptedByBothBuyerAndSeller()
        {
            sentrequestsObj.CompleteButton();
        }

        [Then(@"Mark As Complete button should be displayed")]
        public void ThenMarkAsCompleteButtonShouldBeDisplayed()
        {
            sentrequestsObj.Completed();
        }

        [When(@"If the Status is Completed")]
        public void WhenIfTheStatusIsCompleted()
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
