using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.PageObject
{
    public class UpdateProfilePage
    {
        private IWebDriver _webDriver;

        private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");

        public UpdateProfilePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public UpdateProfilePage GoToUpdateProfileLink()
        {
            _webDriver.Navigate().GoToUrl(Constant.updateProfileLink);
            return this;
        }

        public UpdateProfilePage ClickLogOutButton()
        {
            _webDriver.FindElement(_logOutButton).Click();
            return this;
        }
    }
}
