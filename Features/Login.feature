Feature: Type of Partner selection
Test  partner selection feature of liberis website(https://www.liberis.com/become-a-partner)

using, Type of partner section, user can register as partner with Liberis

@Test1
Scenario:Verify landed on  Partner selection page
	#Steps
	Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	Then [ I navigated to Website ]
	And [I see Three types of partners]
	And [Close the Driver]

@Test3 
Scenario: Verify Type of Partner selection feature if I select first option
	Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And   [I click on I'm a Broker  option]
	And   [I click on get a demo button]
	Then  [I  should navigated to broker-form page]
	And [Close the Driver]

@Test4
Scenario: Verify Type of Partner selection feature if I select Second option
	Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And  [I click  I'm an ISO  option]
	And [I click on get a demo button]
	Then [I  should navigated to "broker-iso-form page" page]
	And [Close the Driver]

@Test5
Scenario: Verify Type of Partner selection feature if I select Third option
	Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And [I click on I'm a Strategic Partner  option]
	And [I click on get a demo button]
	Then [I sould navigated to "strategic-partner-form" page]
	And [Close the Driver]
	

@Test2
Scenario: Verify if I Don't Select any option
   Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	 And [I click on get a demo button]
	Then [I see message Please select a type of partner]
	And [Close the Driver]
	
	
@Test6
Scenario: Verify if I want to change my option
   Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And [I click on I'm a Broker  option]
	And [I click on I'm a Strategic Partner  option]
	Then [It select  I'm a strategic Partner option only]
	And [Close the Driver]

@Test7
Scenario: Verify if I select Multiple option using ctrl key
	Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And [I click on I'm a Broker  option]
	And [I click on I'm a Strategic Partner  option]
	Then [It select  I'm a strategic Partner option only] 
	And [Close the Driver]

@Test8
Scenario: Verify if I right click given option
Given [ I Log  into website]
	And  [ I Open  Get a Demo page]
	And [I right click on I'm a Broker  option]
	And [I click on get a demo button]
	Then [I see message Please select a type of partner]
	And [Close the Driver]