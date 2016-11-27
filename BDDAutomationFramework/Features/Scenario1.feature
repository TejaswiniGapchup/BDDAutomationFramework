Feature: Scenario1
	Test the advance search functionality of application
	Will verify user is navigated to Search Results page when user clicks on Search button without entering any criteria

@Regressiontest
@Browser:Chrome
Scenario: Verify the advance search functionality is working fine
	Given I have navigated to Resources page
	When I click on Search button
	Then I should see the Search Results Page