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
        private Random random;
        private WebDriverHelper _webDriverHelper;
        private string email;
        private string phone;


        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            email = Parameters.GenerateEmail();
            phone = Parameters.GeneratePhone();
        }

        [Test]
        public void PositiveRegistration()
        {
            var registration = new RegistrationPage(_webDriver);

            registration.GoToRegistrationPage()
                .SetFirstName(Constant.name)
                .SetLastName(Constant.lastName)
                .SetEmail(email)
                .SetPassword(Constant.password)
                .SetPasswordConfirm(Constant.password)
                .SetPhoneNumber(phone)
                .ClickNextButton();

            Thread.Sleep(5000);
            var actualResult = _webDriver.Url;
            Assert.AreEqual("https://newbookmodels.com/join/company", actualResult);
        }

        [Test]
        public void NegativeRegistration()
        {
            var registration = new RegistrationPage(_webDriver);

            registration.GoToRegistrationPage()
                .SetFirstName(Constant.name)
                .SetLastName(Constant.lastName)
                .SetEmail(email)
                .SetPassword(Constant.password)
                .SetPasswordConfirm(Constant.password)
                .SetPhoneNumber(phone)
                .ClickNextButton();

            Thread.Sleep(5000);
            var actualResult = _webDriver.Url;
            Assert.AreEqual("https://newbookmodels.com/join/company", actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}