Feature: TM_Feature

As a Turnup Portal admin
I would like to Create, Edit and Delete Time and Materials records
so that i can manage employees Time and materials details successfully
@tag1
Scenario: Create Time and material record with valid details
	Given I logged into Turnup portal successfully
	When I navigate to Time and material page
	And I create a new Time and material record
	Then The record should be created successfully

Scenario Outline: Edit Time and material record with valid details
	Given I logged into Turnup portal successfully
	When I navigate to Time and material page
	And I update '<Description>' , '<Code>' and '<Price>' on an existing Time and material record
	Then The record should have updated '<Description>', '<Code>' and '<Price>'

Examples: 
| Description  | Code     | Price |
| Time         | Kiran    | $15    |
| Material     | Keyboard | $500   |
| Editedrecord | Mouse    | $100  |