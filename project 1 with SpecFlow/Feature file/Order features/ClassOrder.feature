Feature: ClassOrder
	In order to check the my order of the class
	As an admin
	I want to see the class I have ordered

@Valid_ClassOrder
Scenario: Search the classes I have ordered using the default filter
	Given I have logged in to the admin account
	| Username | Password |
	| admin  | 5EstafeyEtre |
	And I am on the class order page
	When I press the search button in the class order page
	Then the class I have ordered should be shown

@Valid_CourseOrder
Scenario Outline: Search the classes I have joined using the filter
	Given I have logged in to the admin account
	| Username | Password |
	| admin  | 5EstafeyEtre |
	And I am on the class order page
	And I have set up the filters for class "<start date>" "<order status>" "<payment way>" "<keyword type>" "<keyword>"
	When I press the search button in the class order page
	Then the classes with "<order number>" the order number that have been filtered should be shown
	
Examples: 
	| start date         | order status | payment way | keyword type | keyword | order number      |
	| 2018-6-11 11:15:48 | paid         | none        | buyer        | t22222  | CR201806111115485 |
	| 2015-6-30 16:59:20 | paid         | outside     | buyer        | River   | CR2015063016591966296 |