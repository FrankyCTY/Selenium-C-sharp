Feature: UserRegistration
	In order to use the website's services
	As a visitor
	I want to be able to register an account 

@invalidTest_Blankinfo
Scenario: Enter blank registration information
	Given I am on the registration page
	And I have entered blank information
	When I press register
	Then the error message caused by blank input should be shown on the screen

@invalidTest_Email
Scenario Outline: Enter invalid email
	Given I am on the registration page
	And I have entered "<invalid email>" invalid email
	When I press register
	Then the error message caused by invalid email should be shown on the screen

Examples:
	| invalid email          |
	| 信123sd@yahoo.com      |
	| 1                      |
	| aasdasd  asd@yahoo.com |

@invalidTest_Username
Scenario Outline: Enter invalid text input username
	Given I am on the registration page
	And I have entered "<invalid username>" invalid text input username
	When I press register
	Then the error message caused by invalid text input username should be shown on the screen

Examples:
	| invalid username |
	|    @@@@@@@@@@@   |
	| %%%%%%%%%        |
	|0       1         |

@invalidTest_Username
Scenario Outline: Enter too short username
	Given I am on the registration page
	And I have entered "<invalid username>" too short username
	When I press register
	Then the error message caused by too short username should be shown on the screen

Examples:
	| invalid username |
	| 111              |
	| 信                |
	| 、                |
	| _                |

@invalidTest_Username
Scenario Outline: Enter too long username
	Given I am on the registration page
	And I have entered "<invalid username>" too long username
	When I press register
	Then the error message caused by too long username should be shown on the screen

Examples:
	| invalid username |
	| 1234567891234567891             |
	| 信信信信信信信信信信                |
	| 、、、、、、、、、、              |
	| ___________________               |

@invalidTest_Password
Scenario Outline: Enter too short password
	Given I am on the registration page
	And I have entered "<invalid password>" too short password
	When I press register
	Then 最少需要输入 5 个字符 should be shown on the screen

Examples:
	| invalid password |
	| 1234             |
	| 信信信信             |
	| 、、、、             |
	| ____             |
	| 1  1             |

@invalidTest_Password
Scenario Outline: Enter too long password
	Given I am on the registration page
	And I have entered "<invalid password>" too long password
	When I press register
	Then 最多只能输入 20 个字符 should be shown on the screen

Examples:
	| invalid password |
	| 123456789123456789123            |
	| 信信信信信信信信信信信信信信信信信信信信信            |
	| 、、、、、、、、、、、、、、、、、、、、、            |
	| _____________________             |
	| 1                   1             |

@invalidTest_Captcha
Scenario Outline: Enter invalid text type captcha
	Given I am on the registration page
	And I have entered "<invalid captcha>" invalid text type capcha
	When I press register
	Then 必须是英文字母、数字及下划线组成 should be shown on the screen

Examples:
	| invalid captcha |
	| 信信信信            |
	| 、、、、           |
	| 1   1       |

@invalidTest_Captcha
Scenario Outline: Enter incorrect captcha
	Given I am on the registration page
	And I have entered "<invalid captcha>" incorrect capcha
	When I press register
	Then 验证码错误 should be shown on the screen

Examples:
	| invalid captcha |
	| 12345            |
	| abcde          |



