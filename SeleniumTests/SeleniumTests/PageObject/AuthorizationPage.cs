using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class AuthorizationPage
    {
        private readonly IWebDriver _webDriver;

        private static By _emailField = By.CssSelector("input[name=email]");
        private static By _passwordField = By.CssSelector("input[type=password]");
        private static By _logInButton = By.CssSelector("button[type=submit]");
        private static By _exceptionInvalidPassword = By.XPath("//*[text()='Please enter a correct email and password.']");
        private static By _userIcon = By.CssSelector("[class^= AvatarClient__avatar]");
        private static By _logoutField = By.CssSelector("[class^= link_type_logout]");

        public AuthorizationPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AuthorizationPage GoToAuthorizationPage()
        {
            _webDriver.Navigate().GoToUrl("");
            return this;
        }

        public AuthorizationPage SetEmail(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public AuthorizationPage SetPassword(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public AuthorizationPage ClickSubmitbutton()
        {
            _webDriver.FindElement(_logInButton).Click();
            return this;
        }
    }
}
