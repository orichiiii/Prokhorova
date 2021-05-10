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
    public class AutorizationTests
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

            _email = Parameters.GenerateEmail();
            _phone = Parameters.GeneratePhone();
        }

        [Test]
        public void AuthorizationWith_ValidData()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            var authorization = new AuthorizationPage(_webDriver);
            Thread.Sleep(3000);
            authorization.GoToAuthorizationPage()
            .SetEmail(_email)
            .SetPassword(Constant.password)
            .ClickSubmitbutton();

            Thread.Sleep(3000);
            var actualLink = _webDriver.Url;

            Assert.AreEqual(Constant.signInLink, actualLink);
        }

        [Test]
        public void AuthorizationWith_InValidData()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            var authorization = new AuthorizationPage(_webDriver);
            Thread.Sleep(3000);
            authorization.GoToAuthorizationPage()
            .SetEmail(_email)
            .SetPassword("1")
            .ClickSubmitbutton();

            Assert.AreEqual("Please enter a correct email and password.", authorization.GetExceptionInvalidData());
        }

        [TearDown]
        public void TearDown()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}