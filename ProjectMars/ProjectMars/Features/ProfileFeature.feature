Feature: Profile

As a Seller of Mars Application
I would like to add details to the profile page
So that i can manage my profile successfully


@tag1
Scenario: Add first and last names to the profile page
	Given I logged in to the mars application successfully
	When  I add firstname, lastname and save to profile page
	Then The Profile page should display both firstname and lastname

Scenario: Add availability type to the profile page
   	Given I logged in to the mars application successfully
	When  I select particular option for availability
	Then The profile page should display added availability type

Scenario: Add number of hours to the profile page
	Given I logged in to the mars application successfully
	When I select particular option for hours
	Then The profile page should display the selected hours option

Scenario: Add Earn Target to the profile page
	Given I logged in to the mars application successfully
	When I select particular option for Earn Target
	Then The profile page should display the selected Earn Target Option

Scenario: Add and save Description to the profile page
	Given I logged in to the mars application successfully
	When I add and save the details in Description
	Then The profile page should display the added Description

Scenario:Add skills and save it to the profile page
	Given I logged in to the mars application successfully
    When I add skills and choose skill level in the profile page
	Then The profile page should display added skill and chosen skill level

Scenario: Add Education and save it to the profile page
	Given I logged in to the mars application successfully
	When I add Education name,country,Title,degree and year to the profile page
	Then The profile page should display added education details

Scenario Outline: Add multiple languages and save it to the profile page
    Given I logged in to the mars application successfully
	When I add multiple '<Language>' and '<Level>' to the profile page
	Then The profile page should display added '<Language>' and '<Level>'

Examples: 
    | Language | Level  |
    | English  | Fluent |
    | Telugu   | Fluent |
    | Hindi    | Basic  |




	


