﻿using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.airbaltic.com/en-BY/index";

        [FindsBy(How = How.XPath, Using = "//div[@class='btn btn-blue btn-search']")]
        private IWebElement buttonSearchTicket;

        [FindsBy(How = How.XPath, Using = "//summary[@aria-label='Create new…']")]
        private IWebElement buttonOneWay;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='From']")]
        private IWebElement cityOfArrival;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='To']")]
        private IWebElement cityOfDeparture;

        [FindsBy(How = How.XPath, Using = "//input[@name='flt_leaving_on']")]
        private IWebElement departureDate;

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickOnOneWayTicket()
        {
            buttonOneWay.Click();
        }

        public void EnterCityOfDeparture(string departureCity)
        {
            cityOfDeparture.SendKeys(departureCity);
        }

        public void EnterCityOfArrival(string arrivalCity)
        {
            cityOfArrival.SendKeys(arrivalCity);
        }

        public void EnterDepartureDate(string yesterdayDate)//закодить дату
        {
            departureDate.SendKeys(yesterdayDate);
        }

        public void ClickSearchTicket()
        {
            buttonSearchTicket.Click(); 
        }


    }
}
