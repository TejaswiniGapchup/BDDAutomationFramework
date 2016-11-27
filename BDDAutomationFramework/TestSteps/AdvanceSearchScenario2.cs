using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using BDDAutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BDDAutomationFramework.TestSteps
{
    [Binding]
    public class AdvanceSearchScenario2
    {
        [Given(@"I have navigated to Resources page")]
        public void GivenIHaveNavigatedToResourcesPage()
        {
            var CommonPageObject = new CommonPage(Browser.Current);
            CommonPageObject.NavigateToUrl();
            CommonPageObject.NavigateToPage("ResourcesPage", "");
        }

        [When(@"I enter (.*), selects (.*), selects (.*), selects (.*) and click on Search button")]
        public void WhenIEnterSelectsSelectsSelectsAndClickOnSearchButton(string p0, string p1, string p2, string p3)
        {
            var NewRoomPagePageObject = new NewsRoomPage(Browser.Current);
            NewRoomPagePageObject.EnterSearchCriteria(p0, p1, p2, p3);
            NewRoomPagePageObject.ClickSearchButton();
        }

        [Then(@"I should see the Search Results Page")]
        public void ThenIShouldSeeTheSearchResultsPage()
        {
            var ResourcePageObject = new NewsRoomPage(Browser.Current);
            Boolean isDiaplyed = ResourcePageObject.IsSearchResultPageDisplayed();
            Assert.IsTrue(isDiaplyed);
        }
    }
}
