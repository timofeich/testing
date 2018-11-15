﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Page_Object
{
    public class ChoosingCity
    {
        private IWebDriver driver;

        private By departureCity = By.XPath("//input[@placeholder='From']");
        private By arrivalCity = By.XPath("//input[@placeholder='To']");
        private By searchResults = By.XPath("//div[@class ='airport']");

        public ChoosingCity(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void InputDepartureCity(string city)
        {
            driver.FindElement(departureCity).Clear();
            driver.FindElement(departureCity).SendKeys(city);
        }

        public void Enter_acity(string city)
        {
            driver.FindElement(arrivalCity).Clear();
            driver.FindElement(arrivalCity).SendKeys(city);
        }

        public void Enter_result_click()
        {
            driver.FindElement(searchResults).Click();
        }
    }
}
