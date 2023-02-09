Feature: SentRequests

	Verifying the Status of SentRequest


@tag1
Scenario:Check Sent Request Pending Status
	When I click on Manage Requests tab and select SentRequests
	And  If the seller has not accepted the request
	Then The status should be displayed as Pending

	Scenario:Check Sent Request Withdrawn Status
	When  The user click on withdraw for the request sent
	Then The status should be displayed as Withdrawn

	Scenario:Check Sent Request Declined Status
	When  The request send is declined by the seller
	Then The status should be displayed as Declined
	
	Scenario:Check Sent Request Accepted Status
	When  The request sent is accepted by the Seller
	Then The status should be displayed as Accepted

	Scenario:Check Sent Request Complete Status
	When  The request is accepted by both buyer and seller
	Then Mark As Complete button should be displayed

	Scenario:Check Sent Request Review Status
	When The Status is Completed 
	And  Click on Review Button 
	Then Review and Ratings can be given and save review and ratings
	

	