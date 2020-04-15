Feature: ResetPassword
	In order to be able to log in to my account
	As a user that forgot the account password
	I want to reset the password

@invalidTest_EmptyInputEmail
Scenario: Enter blank email address
	Given I am on the reset password page
	And I have enetered nothing for the email
	When I press reset password
	Then error 请输入邮箱地址 should be shown on screen


@invalidTest_InvalidEmail
Scenario Outline: Enter invalid email address
	Given I am on the reset password page
	And I have enetered "<Email input>" invalid email
	When I press reset password
	Then error 请输入有效的电子邮件地址 should be shown on screen

Examples: 
	| Email input    |
	| a              |
	| a bc@yahoo.com |
	| asdasd@yahoo.  |

@invalidTest_EmailNotFound
Scenario Outline: Enter email address that has not been registered
	Given I am on the reset password page
	And I have enetered "<Email input>" not registered email
	When I press reset password
	Then error 该邮箱地址没有注册过帐号 should be shown on screen

Examples: 
	| Email input    |
	| sdofinsdojgn@yahoo.com              |
	| 000000000000000@yahoo.com |
	| JBJ$##B$B@gmail.com  |
