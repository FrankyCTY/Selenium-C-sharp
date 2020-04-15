Feature: FundamentalInformation
	In order to get people to know my basic information
	As a user
	I want to be able to set up my fundamental information

@Invalid_TooShortName
Scenario Outline: Enter too short name
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<name>" less than 2 characters for the name
	When I press save
	Then error msg 最少需要输入 2 个字符 should be shown under the name input

Examples:
	| name |
	| a    |
	| #    |
	| 嚴    |
	| 1    |

@Invalid_TooLongName
Scenario Outline: Enter too long name
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<name>" more than 18 characters for the name
	When I press save
	Then error msg 最多只能输入 18 个字符 should be shown under the name input

Examples:
	| name |
	| aaaaaaaaaaaaaaaaaaa    |
	| ###################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111    |

@Invalid_IdNumber
Scenario Outline: Enter invalid ID number
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<ID number>" invalid ID number
	When I press save
	Then error msg 请正确输入您的身份证号码 should be shown under the ID number input

Examples:
	| ID number |
	| aaaaaaaaaaaaaaaaaaa    |
	| ###################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111    |

@Invalid_PhoneNumber
Scenario Outline: Enter invalid Phone Number
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<Phone Number>" invalid phone number
	When I press save
	Then error msg 请输入正确的手机号 should be shown under the phone number input

Examples:
	| Phone Number |
	| aaaaaaaaaaaaaaaaaaa    |
	| ###################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111    |

@Invalid_TooLongTitle
Scenario Outline: Enter too long title
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<title>" too long title
	When I press save
	Then error msg 最多只能输入 24 个字符 should be shown under the title input

Examples:
	| title |
	| aaaaaaaaaaaaaaaaaaaaaaaaa    |
	| #########################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111111111    |

@Invalid_InvalidSite
Scenario Outline: Enter invalid site
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<site>" invalid site
	When I press save
	Then error msg 地址不正确，须以http://或者https://开头。 should be shown under the site input

Examples:
	| site |
	|  htt://aaaaaaaaaaaaaaaaaaaaaaaaa    |
	| #########################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111111111    |

@Invalid_InvalidWeibo
Scenario Outline: Enter invalid weibo
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<weibo>" invalid weibo
	When I press save
	Then error msg 地址不正确，须以http://或者https://开头。 should be shown under the weibo input

Examples:
	| weibo |
	| htt://aaaaaaaaaaaaaaaaaaaaaaaaa    |
	| #########################    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
	| 1111111111111111111111111    |

@Invalid_InvalidQQ
Scenario Outline: Enter invalid QQ
	Given I am logged into my account
	| Username | Password |
	| test001  | Test1234 |
	Given I am on the fundamental information page
	And I entered "<QQ>" invalid QQ
	When I press save
	Then error msg 请输入正确的QQ号 should be shown under the QQ input

Examples:
	| QQ |
	| htt://aaaaaaaaaaaaaaaaaaaaaaaaa    |
	| astdgherheh#    |
	| 嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴    |
