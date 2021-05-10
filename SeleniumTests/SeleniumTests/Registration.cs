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


        [SetUp]
        public void Setup()
        {
            _webDriverHelper.GetWebDriver();

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss");
        }

        [Test]
        public void Test1()
        {
            var registration = new RegistrationPage(_webDriver);

            registration.GoToRegistrationPage()
                .SetFirstName("Carolina")
                .SetLastName("Doul")
                .SetEmail($"{email}@gmail.com")
                .SetPassword("Aa@12345678")
                .SetPasswordConfirm("Aa@12345678")
                .SetPhoneNumber($"{phone}")
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