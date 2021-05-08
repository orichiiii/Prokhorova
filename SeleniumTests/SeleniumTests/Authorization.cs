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
    class Autorization
    {
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
        private Random random;
        private int randomPhoneFirst;
        private int randomPhoneSecond;
        private int randomPh;
        private string _email;
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

            _email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss");

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            _webDriver.FindElement(By.CssSelector("[name='first_name']")).SendKeys("Marina");
            _webDriver.FindElement(By.CssSelector("[name = last_name]")).SendKeys("Tropinkina");
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys($"{_email}@gmail.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = password_confirm]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = phone_number]")).SendKeys(phone);
            _webDriver.FindElement(By.CssSelector("[class^=SignupForm__submitButton]")).Click();
            Thread.Sleep(4000);
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
            Thread.Sleep(4000);
            _webDriver.FindElement(By.CssSelector("[class='link link_type_logout link_active']")).Click();
        }

        [Test]
        public void AuthorizationWithValidData()
        {
            Thread.Sleep(2000);

            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys($"{_email}@gmail.com");
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

            //Assert.That(_constMethods.existsElement("//*[text()='Please enter a correct email and password.']"));
        }
    }
}