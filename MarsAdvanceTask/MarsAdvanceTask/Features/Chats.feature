Feature: Chats


User chats with seller, the chats are recorded and user can view his chat history.

Scenario: View chat history 
Given The User login to mars and navigate to profile page
When The user Clicks on Chat tab, then Chat screen opens
And  The user inputs name in search input box
Then Chats between the input name and user should be visible 
And To send message type message in input box and click on send button
