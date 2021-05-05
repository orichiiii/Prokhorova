using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumTests
{
    class UpdateProfileData
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

            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("cassssb0@gmail.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Oly12345678$");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();
            _webDriver.FindElement(By.CssSelector("[class^= AvatarClient__avatar]")).Click();
            //_webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
        }

        [Test]
        public void UpdateGeneralInformation()
        {
            _webDriver.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[class= input__self input__self_type_text - underline ng - untouched ng - pristine ng - valid]")).SendKeys("da");
            Thread.Sleep(2000);
            _webDriver.FindElement(By.CssSelector("[class=pac-matched]")).Click();

            Thread.Sleep(20000);
            var actual = _webDriver.Url;//_webDriver.FindElement(By.CssSelector("[class^='paragraph_type_gray']));

            Assert.That(actual == "https://newbookmodels.com/join/company");
        }

        [Test]
        public void UpdatePassword()
        {
            _webDriver.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[class= input__self input__self_type_text - underline ng - untouched ng - pristine ng - valid]")).SendKeys("da");
            Thread.Sleep(2000);
            _webDriver.FindElement(By.CssSelector("[class=pac-matched]")).Click();

            Thread.Sleep(20000);
            var actual = _webDriver.Url;//_webDriver.FindElement(By.CssSelector("[class^='paragraph_type_gray']));

            Assert.That(actual == "https://newbookmodels.com/join/company");
        }
    }
}
