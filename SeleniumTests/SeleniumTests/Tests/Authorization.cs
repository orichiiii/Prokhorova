using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumTests
{
    class Autorization
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
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
            _constMethods.RegistrationProcess(_phone, _email, Constant.password);

            Thread.Sleep(3000);
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
            Thread.Sleep(4000);
            _webDriver.FindElement(By.CssSelector("[class='link link_type_logout link_active']")).Click();
        }

        [Test]
        public void AuthorizationWithValidData()
        {
            Thread.Sleep(2000);

            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys(_email);
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Thread.Sleep(2000);
            var actual = _webDriver.Url;

            Assert.That(actual == "https://newbookmodels.com/join/company?goBackUrl=%2Fexplore");
        }

        [Test]
        public void AuthorizationWithInValidData()
        {
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("uijjthkc@emlpro.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Assert.That(_constMethods.existsElement(By.CssSelector("div.PageFormLayout__errors--3dFcq > div > div")));
        }
    }
}