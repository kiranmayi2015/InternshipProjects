Feature: SearchSkills

User should be able to SearchSkills

@mytag

Scenario: RefineSearch Skills in Profile Page
Given the user is on Profile tab
When the user input search key Refine search and click on searchicon
And the user input search user key search user and click on searchicon
Then the refined search items should be Displayed

Scenario: Search Skills by Filter 
Given the user is on Profile tab
When the user inputs search key in search inputbox and click on searchicon
And the user input search key Refine search and click on searchicon
Then  the filtered search should be displayed
