Feature: SearchSkills

User should be able to SearchSkills

@mytag

Scenario: Check if result has location as Online
	Given I login to the Mars website
	When I select select category and subcategory
	And I refine filters by online
	Then Only results matching with online location are displayed

	Scenario: Check if result has location as onsite
    When  I click on onsite filter 
	Then Only results matching with onsite location are displayed

Scenario: Check if user is able to click on Show All Filter
	When  I click on show all filter
	Then The results with both onsite and online locations are displayed

