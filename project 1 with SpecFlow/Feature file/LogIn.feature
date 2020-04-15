Feature: LogInFeature
	In order to explore the website
	As a user
	I want to log in to my account

@validTest
Scenario: Log In Successfully and avatar is visible
	Given I am in the Log In Page
	When I enter the correct user name and correct password
		| Username | Password |
		| test001   | Test1234  |
	When I press the log in button
	Then I can log in to my account and see my avatar on the web page

 @validTest
Scenario: Log In Successfully with the log in details being remembered and avatar is visible
	Given I am in the Log In Page
	When I enter the correct user name and correct password
		| Username | Password |
		| test001   | Test1234  |
	When I ticked the remember me radio box
	When I press the log in button
	Then I can log in to my account and see my avatar on the web page

 @validTest
Scenario: Log In Successfully and Log out successfully
	Given I am in the Log In Page
	When I enter the correct user name and correct password
		| Username | Password |
		| test001   | Test1234  |
	When I ticked the remember me radio box
	When I press the log in button
	Then I can log out my account


 @invalidTest
Scenario: Log In unsuccessfully and error message is visible
	Given I am in the Log In Page
	When I enter the incorrect user name and correct password
		| Username | Password |
		| testas   | afaggag  |
	When I press the log in button
	Then I can see the error message