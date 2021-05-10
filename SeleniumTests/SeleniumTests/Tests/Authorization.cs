using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestProject
{
    class AutorizationTests
    {
        private IWebDriver _webDriver;
        private WebDriverHelper _webDriverHelper;
        private ConstMethods _constMethods;
        private string _email;
        private string _phone;

        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
            _webDriver.Navigate().GoToUrl(Constant.registrationLink);

            _email = Parameters.GenerateEmail();
            _phone = Parameters.GeneratePhone();
        }

        [Test]
        public void AuthorizationWithValidData()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            var authorization = new AuthorizationPage(_webDriver);
            authorization.GoToAuthorizationPage()
            .SetEmail(_email)
            .SetPassword(Constant.password)
            .ClickSubmitbutton();

            Thread.Sleep(3000);
            var actual = _webDriver.Url;

            Assert.That(actual == "https://newbookmodels.com/join/company?goBackUrl=%2Fexplore");
        }

        [Test]
        public void AuthorizationWithInValidData()
        {
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("uijjthkc@emlpro.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Assert.That(existsElement("//*[text()='Please enter a correct email and password.']"));
        }

        private bool existsElement(String id)
        {
            try
            {
                _webDriver.FindElement(By.XPath(id));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}