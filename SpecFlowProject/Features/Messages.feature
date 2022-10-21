Feature: Messages

In order to contact the author
As a website visitor
I want to write a message

@tag1
Scenario: Successfully entered everything
	Given I have opened a browser
	And I have opened a website
	And I have clicked on Messages
	When I have entered a correct name
	And I have entered a correct email
	And I have entered some message
	And I have clicked the Submit button
	Then I should see that there is a message
	And I should see the green confirmation message
	And I close the Browser

Scenario: Forgot to enter the name
	Given I have opened a browser
	Given I have opened a website
	Given I have clicked on Messages
	When I haven't entered a correct name
	When I have entered a correct email
	When I have entered some message
	When I have clicked the Submit button
	Then I should see that the name is required
	Then I close the Browser


