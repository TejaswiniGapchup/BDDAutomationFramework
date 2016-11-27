using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BDDAutomationFramework.Pages;
using TechTalk.SpecFlow;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDDAutomationFramework.TestSteps
{
    [Binding]
    class AdvanceSearchScenario1
    {

        [Given(@"I have navigated to Resources page")]
        public void GivenIHaveNavigatedToResourcesPage()
        {
            var CommonPageObject = new CommonPage(Browser.Current);
            CommonPageObject.NavigateToUrl();
            CommonPageObject.NavigateToPage("ResourcesPage","");
        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            var NewRoomPagePageObject = new NewsRoomPage(Browser.Current);
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
