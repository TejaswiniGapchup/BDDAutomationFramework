using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BDDAutomationFramework.Pages
{
    class NewsRoomPage
    {
        private IWebDriver driver;

        //Constructor 
        public NewsRoomPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Method to click on search button at advance search section
        public void ClickSearchButton()
        {
            IWebElement searchButton = null;
            try
            {
                searchButton = Browser.Current.FindElement(By.XPath("//input[contains(@id,'searchsubmit') and contains(@value,'search now')]"));
                searchButton.Click();
            } catch(WebDriverException wd)
            {
                Console.Write("Failed to click on Search Button"+wd);
            } catch (Exception e)
            {
                Console.Write("Failed to click on Search Button"+e);
            }
        }

        //Method to verify if search result page is displayed
        public Boolean IsSearchResultPageDisplayed()
        {
            Boolean isDisplayed = false;
            IWebElement title = null;
            try
            {
                title = Browser.Current.FindElement(By.XPath("//h1[contains(text(),'Search results')]"));
                if (title != null)
                    isDisplayed = true;
            } catch(Exception e)
            {
                Console.Write("Failed verify search results page"+e);
            }
            return isDisplayed;
        }

        //Method to enter the search criteria
        public void EnterSearchCriteria(string searchTerm, string relevantIndustry, string resourceType, string year)
        {
            IWebElement searchTermElement = null;
            IWebElement selectElement = null;
            
            try
            {
                searchTermElement = Browser.Current.FindElement(By.XPath("//input[contains(@id,'searchbox')]"));
                searchTermElement.SendKeys(searchTerm);

                selectElement = Browser.Current.FindElement(By.XPath("//select[@id='cat']"));
                var relevantIndustryElement = new SelectElement(selectElement);
                relevantIndustryElement.SelectByText(relevantIndustry);

                selectElement = Browser.Current.FindElement(By.XPath("//select[contains(@id,'post_type')]"));
                var resourceTypeElement = new SelectElement(selectElement);
                resourceTypeElement.SelectByText(relevantIndustry);

                selectElement = Browser.Current.FindElement(By.XPath("//select[contains(@id,'year')]"));
                var yearElement = new SelectElement(selectElement);
                yearElement.SelectByText(relevantIndustry);
            }
            catch (WebDriverException wd)
            {
                Console.Write("Failed to enter search criteria " + wd);
            }
            catch (Exception e)
            {
                Console.Write("Failed to enter search criteria" + e);
            }
        }
    }
}
