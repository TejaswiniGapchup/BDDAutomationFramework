using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomationFramework.Pages
{
    class CommonPage
    {
        private IWebDriver driver;

        //Constructor 
        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Method to navigate to specific page
        public Object NavigateToPage(String page, String subPage)
        {
            Object pageObject = null;
            IWebElement mainmenu = null;
            IWebElement submenu = null;
            try
            {
                Actions action = new Actions(Browser.Current);   

                switch (page)
                {
                    case "ResourcesPage" :
                        mainmenu = Browser.Current.FindElement(By.XPath("//a[contains(text(),'Resources')]"));
                        break;
                }
                action.MoveToElement(mainmenu).Build().Perform();

                switch (subPage)
                {
                    case "NewsRoom":
                        submenu = Browser.Current.FindElement(By.XPath("//ul[contains(@class,'sub - menu')]//li//a[contains(text(),'News Room')]"));
                        pageObject = new NewsRoomPage(Browser.Current);
                        break;
                }
                submenu.Click();

            } catch(Exception e)
            {
                Console.Write("Failed to navigate to the page"+e);
            }
            return pageObject;
        }

        //Method to navigate to the URL
        public void NavigateToUrl()
        {
            try
            {
                Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            } catch(Exception e)
            {
                Console.Write("Failed to navigate to the URL"+e);
            }
        }
    }
}
