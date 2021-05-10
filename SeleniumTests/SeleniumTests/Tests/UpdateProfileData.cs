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
        private Random random;
        private int randomPhoneFirst;
        private int randomPhoneSecond;
        private int randomPh;
        private string email;

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

            string phoneNumber = $"{randomPhoneFirst}{randomPhoneSecond}{randomPh}";

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss");

            _webDriver.FindElement(By.CssSelector("[name='first_name']")).SendKeys("Marina");
            _webDriver.FindElement(By.CssSelector("[name = last_name]")).SendKeys("Tropinkina");
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys($"dori{email}@gmail.com.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = password_confirm]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = phone_number]")).SendKeys(phoneNumber);
            _webDriver.FindElement(By.CssSelector("[class^=SignupForm__submitButton]")).Click();

            Thread.Sleep(3000);
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
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
            var email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss");
            var emailField = _webDriver.FindElement(By.CssSelector("body > nb-app > ng-component > nb-internal-layout > common-layout > section > div > ng-component > nb-account-info-edit > common-border > div:nth-child(5) > div > nb-account-info-password > form > div:nth-child(1) > div"));
            emailField.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            var elements =_webDriver.FindElements(By.CssSelector("[type = password]"));
            elements[0].SendKeys("Oly12345678$");
            elements[1].SendKeys("Oly12345678$$");
            elements[2].SendKeys("Oly12345678$$");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();
            _webDriver.FindElement(By.CssSelector("[class^= HamburgerButton__container--3QXFq]")).Click();
            _webDriver.FindElements(By.CssSelector("[type = button]"));

            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys("cassssb0@gmail.com");
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Oly12345678$");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Thread.Sleep(20000);
            var actual = _webDriver.Url;

            Thread.Sleep(4000);

            Assert.That(actual == "https://newbookmodels.com/join/company?goBackUrl=%2Fexplore");
        }

        [Test]
        public void UpdateEmail()
        {
            var emailField =_webDriver.FindElement(By.CssSelector("body > nb-app > ng-component > nb-internal-layout > common-layout > section > div > ng-component > nb-account-info-edit > common-border > div:nth-child(3) > div > nb-account-info-email-address > form > div:nth-child(1) > div"));
            emailField.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[type = text]")).SendKeys($"dori{email}@gmail.com.com");
            Thread.Sleep(2000);
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(4000);

            Assert.That(existsElement($"//*[text()='cassssb{email}@gmail.com']"));
        }

        [Test]
        public void UpdatePhoneNumber()
        {
            var emailField = _webDriver.FindElement(By.CssSelector("body > nb-app > ng-component > nb-internal-layout > common-layout > section > div > ng-component > nb-account-info-edit > common-border > div:nth-child(9) > div > nb-account-info-phone > div:nth-child(1) > div"));
            emailField.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Oly12345678$");
            _webDriver.FindElement(By.CssSelector("[type = text]")).SendKeys("");
            Thread.Sleep(2000);
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(4000);

            Assert.That(existsElement($"//*[text()='cassssb{email}@gmail.com']"));
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
