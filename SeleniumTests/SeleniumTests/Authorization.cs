using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
        }

        [Test]
        public void AuthorizationWithValidData()
        {
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("cassssb0@gmail.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Oly12345678$");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Thread.Sleep(20000);
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