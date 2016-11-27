Feature: Scenario2
	Test the advance search functionality of application
	Will verify user is navigated to Search Results page when user enters search criteria and clicks on Search button

@Regressiontest
@Browser:Chrome
Scenario Outline: Verify the advance search functionality is working fine
	Given I have navigated to Resources page
	When I enter <Search Term>, selects <Relevant Industry>, selects <Resource Type>, selects <Year> and click on Search button
	Then I should see the Search Results Page
Examples: 
| Search Term    | Relevant Industry   | Resource Type  | Year |
| VEHICLE HEALTH | Transport & Haulage | Press Releases | 2016 |

