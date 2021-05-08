using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumTests
{
    public class LogOut
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
        private WebDriverWait _webDriverWait;
        private string _email;
        private string _phone;

        [SetUp]
        public void Setup()
        {
            _phone = GenerateParameters.GetPhone();
            _email = GenerateParameters.GetEmail();

            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
            _constMethods.RegistrationProcess(_phone, _email);

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromMilliseconds(20000));
        }

        [Test]
        public void LogOutt()
        {
            _webDriverWait.Until((ExpectedConditions.ElementIsVisible(By.CssSelector("[class='SignupAvatar__avatar--IxJnV']"))));
            _webDriver.Navigate().GoToUrl(Constant.updateLink);
            _webDriverWait.Until((ExpectedConditions.ElementIsVisible(By.CssSelector("[class^='layout-fluid']"))));
            _webDriver.FindElement(By.CssSelector("[class='link link_type_logout link_active']")).Click();

            _webDriverWait.Until((ExpectedConditions.ElementIsVisible(By.CssSelector("[class='FormCard__header--36gOi']"))));
            var actualURL = _webDriver.Url;

            Assert.AreEqual(Constant.signInLink, actualURL);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}
