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
        private int randomPhoneFirst;
        private int randomPhoneSecond;
        private int randomPh;
        private string email;
        private string phone;


        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

            random = new Random();

            randomPhoneFirst = random.Next(100, 999);
            randomPhoneSecond = random.Next(100, 999);
            randomPh = random.Next(1000, 9999);

            phone = $"{randomPhoneFirst}{randomPhoneSecond}{randomPh}";

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
    }
}