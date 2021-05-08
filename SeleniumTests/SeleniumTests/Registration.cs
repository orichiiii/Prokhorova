using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace LoginTests
{
    public class Registration
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;

        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
        }

        [Test]
        public void PositiveRegistration()
        {
            var phone = GenerateParameters.GetPhone();
            var email = GenerateParameters.GetEmail();
            _constMethods.RegistrationProcess(phone, email);

            //заменить на ожидание пока появится элемент
            Thread.Sleep(5000);

            Assert.AreEqual(Constant.companyLink, _webDriver.Url);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver(); 
        }
    }
}