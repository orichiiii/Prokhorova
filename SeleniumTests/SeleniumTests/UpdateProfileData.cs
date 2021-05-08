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
        private ConstMethods _constMethods;
        private string _email;

        [SetUp]
        public void Setup()
        {
            _webDriver = new WebDriverHelper().GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);

            var phone = GenerateParameters.GetPhone();
            _email = GenerateParameters.GetEmail();

            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");

            _webDriver.FindElement(By.CssSelector("[name='first_name']")).SendKeys("Marina");
            _webDriver.FindElement(By.CssSelector("[name = last_name]")).SendKeys("Tropinkina");
            _webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys(_email);
            _webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = password_confirm]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[name = phone_number]")).SendKeys(phone);
            _webDriver.FindElement(By.CssSelector("[class^=SignupForm__submitButton]")).Click();
            Thread.Sleep(3000);
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
        }

        [Test]
        public void UpdateGeneralInformation()
        {
            _webDriver.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            var location = _webDriver.FindElement(By.CssSelector("[class='input__self input__self_type_text-underline ng-untouched ng-pristine ng-valid pac-target-input']"));
            location.SendKeys("hhh");
            Thread.Sleep(500);
            location.SendKeys(Keys.Down);
            location.SendKeys(Keys.Enter);           
            _webDriver.FindElement(By.CssSelector("input[placeholder='Enter Industry']")).SendKeys("fashion");
            Thread.Sleep(500);
            _webDriver.FindElement(By.CssSelector("div:nth-child(2) > div > common-button-deprecated > button")).Click();

            var industryText = _webDriver.FindElement(By.CssSelector("nb-paragraph:nth-child(7)>div")).Text;
            var locationText = _webDriver.FindElement(By.CssSelector("nb-paragraph:nth-child(5)>div")).Text;

            Assert.AreEqual("fashion", industryText);
            Assert.AreEqual("Half Hollow Hills Central School District, NY, USA", locationText);
        }

        [Test]
        public void UpdatePassword()
        {
            _webDriver.FindElement(By.XPath("//div[3]/div[1]/nb-account-info-password[1]/form[1]/div[1]/div[1]/nb-edit-switcher[1]/div[1]/div[1]")).Click();
            var elements =_webDriver.FindElements(By.CssSelector("[type = password]"));
            elements[0].SendKeys("Aa@12345678");
            elements[1].SendKeys("Oly12345678$$");
            elements[2].SendKeys("Oly12345678$$");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();
            _webDriver.FindElement(By.CssSelector("[class='link link_type_logout link_active']")).Click();

            Thread.Sleep(4000);
            _webDriver.FindElement(By.CssSelector("input[type = email]")).SendKeys(_email);
            _webDriver.FindElement(By.CssSelector("input[type = password]")).SendKeys("Oly12345678$");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Thread.Sleep(20000);
            var actual = _webDriver.Url;

            Thread.Sleep(4000);

            Assert.That(actual == "https://newbookmodels.com/account-settings/account-info/edit");
        }

        [Test]
        public void UpdateEmail()
        {
            _email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss");
            var emailField =_webDriver.FindElement(By.CssSelector("body > nb-app > ng-component > nb-internal-layout > common-layout > section > div > ng-component > nb-account-info-edit > common-border > div:nth-child(3) > div > nb-account-info-email-address > form > div:nth-child(1) > div"));
            emailField.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[type = text]")).SendKeys(_email);
            Thread.Sleep(2000);
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(4000);

            //Assert.That(_constMethods.existsElement($"//*[text()='{_email}']"));
        }

        [Test]
        public void UpdatePhoneNumber()
        {
            var emailField = _webDriver.FindElement(By.CssSelector("body > nb-app > ng-component > nb-internal-layout > common-layout > section > div > ng-component > nb-account-info-edit > common-border > div:nth-child(9) > div > nb-account-info-phone > div:nth-child(1) > div"));
            emailField.FindElement(By.CssSelector("[class^= edit-switcher__icon_type_edit]")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[type = text]")).SendKeys("1111111111");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(4000);

            //Assert.That(_constMethods.existsElement($"//*[text()='1111111111']"));
        }

        [Test]
        public void AddCard()
        {
            _webDriver.FindElement(By.CssSelector("input[placeholder ='Full name']")).SendKeys("Marina Tropinkina");
            _webDriver.FindElement(By.CssSelector("[class^= 'InputElement']")).SendKeys("4683 9759 3739 473");
            _webDriver.FindElement(By.CssSelector("[name = exp-date]")).SendKeys("9999");
            _webDriver.FindElement(By.CssSelector("[name = cvc]")).SendKeys("999");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(1000);

            //Assert.That(_constMethods.existsElement($"//*[text()='Update card info unexpected error']"));
        }

        [TearDown]
        public void Quit()
        {
            _webDriver.Quit();
        }
    }
}
