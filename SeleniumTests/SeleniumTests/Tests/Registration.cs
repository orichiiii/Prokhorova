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
        public void PositiveRegistration()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);

            Thread.Sleep(3000);
            var actualResult = _webDriver.Url;
            Assert.AreEqual("https://newbookmodels.com/join/company", actualResult);
        }

        [Test]
        [TestCase("2334", "aaaaa@", "12345", "", "")]
        public void NegativeRegistration(string phone, string email, string password, string name, string lastName)
        {
            var registrationPage = new RegistrationPage(_webDriver);

            _constMethods.RegistrationProcess(phone, email, password, name, lastName);
            Thread.Sleep(3000);

            Assert.AreEqual("Required", registrationPage.GetExceptionMessageRequiredLastName());
            Assert.AreEqual("Required", registrationPage.GetExceptionMessageRequiredName());
            Assert.AreEqual("Invalid Email", registrationPage.GetExceptionMessageRequiredEmail());
            Assert.AreEqual("Invalid password format", registrationPage.GetExceptionMessageInvalidPassword());
            Assert.AreEqual("Invalid phone format", registrationPage.GetExceptionMessageInvalidPhoneFormat());
        }

        [TearDown]
        public void TearDown()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}