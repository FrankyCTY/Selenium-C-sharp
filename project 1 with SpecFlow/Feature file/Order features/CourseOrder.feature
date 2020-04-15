Feature: CourseOrder
	In order to check the order of the course
	As an admin
	I want to see the course users have ordered

@Valid_CourseOrder
Scenario: Search the courses I have ordered using the default filter
	Given I have logged in to the admin account
	| Username | Password |
	| admin  | 5EstafeyEtre |
	And I am on the course order page
	When I press the search button
	Then the courses should be shown

@Valid_CourseOrder
Scenario Outline: Search the courses I have ordered using the filter
	Given I have logged in to the admin account
	| Username | Password |
	| admin  | 5EstafeyEtre |
	And I am on the course order page
	And I have set up the filter "<start date>" "<order status>" "<payment way>" "<keyword type>" "<keyword>"
	When I press the search button
	Then the courses with "<order number>" the order number that have been filtered should be shown

Examples: 
	| start date         | order status | payment way | keyword type   | keyword                | order number      |
	| 2018-9-15 04:52:48 | paid         | none        | courseSetTitle | 购买课程《学员在网校》 | C2018091504524821 |


