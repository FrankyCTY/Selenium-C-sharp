Feature: Avatar Setting
	In order to let other user to identify me
	As a user
	I want to be able to change my avatar

@mytag
Scenario: Change profile picture
	Given I have logged in to the account
		| Username | Password |
		| test001   | Test1234  |
	And I am on the personal setting page
	When I press Avatar setting
	Then I choose a picture from my desktop and press save
