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
using SeleniumTests;


namespace SeleniumTests
{
    class UpdateProfileData
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
        private string _email;
        private string _phone;

        [SetUp]
        public void Setup()
        {
            _phone = GenerateParameters.GetPhone();
            _email = GenerateParameters.GetEmail();

            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
            _constMethods.RegistrationProcess(_phone, _email);

            Thread.Sleep(3000);

            _webDriver.Navigate().GoToUrl(Constant.updateLink);
        }

        [Test]
        public void UpdateGeneralInformation()
        {
            _webDriver.FindElement(By.CssSelector("nb-account-info-general-information > form > div:nth-child(1) > div > nb-edit-switcher > div > div")).Click();
            Thread.Sleep(500);
            var nameField = _webDriver.FindElement(By.CssSelector("common-input:nth-child(3) input"));
            nameField.Clear();
            nameField.SendKeys("Liza");
            var lastNameField = _webDriver.FindElement(By.CssSelector("common-input:nth-child(4) input"));
            lastNameField.Clear();
            lastNameField.SendKeys("Olive"); ;
            var locationField = _webDriver.FindElement(By.CssSelector("[class^='input__self input__self_type_text-underline ng-untouched ng-pristine ng-valid ']"));
            locationField.SendKeys("hhh");
            Thread.Sleep(500);
            locationField.SendKeys(Keys.Down);
            locationField.SendKeys(Keys.Enter);           
            _webDriver.FindElement(By.CssSelector("input[placeholder='Enter Industry']")).SendKeys("fashion");
            Thread.Sleep(500);
            _webDriver.FindElement(By.CssSelector("div:nth-child(2) > div > common-button-deprecated > button")).Click();

            var industryText = _webDriver.FindElement(By.CssSelector("nb-paragraph:nth-child(7)>div")).Text;
            var locationText = _webDriver.FindElement(By.CssSelector("nb-paragraph:nth-child(5)>div")).Text;
            var nameText = _webDriver.FindElement(By.CssSelector("nb-paragraph:nth-child(3)>div")).Text;

            Assert.AreEqual("Liza Olive", nameText);
            Assert.AreEqual("fashion", industryText);
            Assert.AreEqual("Half Hollow Hills Central School District, NY, USA", locationText);
        }

        [Test]
        public void UpdatePassword()
        {
            _webDriver.FindElement(By.XPath("//div[3]/div[1]/nb-account-info-password[1]/form[1]/div[1]/div[1]/nb-edit-switcher[1]/div[1]/div[1]")).Click();
            var elements =_webDriver.FindElements(By.CssSelector("[type = password]"));
            elements[0].SendKeys(Constant.password);
            elements[1].SendKeys("Oly12345678$$");
            elements[2].SendKeys("Oly12345678$$");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();
            _webDriver.FindElement(By.CssSelector("[class='link link_type_logout link_active']")).Click();

            Thread.Sleep(9000);
            _webDriver.FindElement(By.CssSelector("[type=email]")).SendKeys(_email);
            _webDriver.FindElement(By.CssSelector("input[name = password]")).SendKeys("Oly12345678$$");
            _webDriver.FindElement(By.CssSelector("[class^=SignInForm__submitButton]")).Click();

            Thread.Sleep(3000);
            var actual = _webDriver.Url;

            Assert.AreEqual(Constant.companyLink + "?goBackUrl=%2Fexplore", actual);
        }

        [Test]
        public void UpdateEmail()
        {
            var email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss") + "@gmail.com";

            _webDriver.FindElement(By.CssSelector("nb-account-info-email-address>form>div:nth-child(1)>div>nb-edit-switcher>div>div")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("[type = text]")).SendKeys(email);
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            Thread.Sleep(4000);
            var newEmail = _webDriver.FindElement(By.CssSelector("div>div:nth-child(1)>span")).Text;

            Assert.AreEqual(email, newEmail);
        }

        [Test]
        public void UpdatePhoneNumber()
        {
            _webDriver.FindElement(By.CssSelector("nb-account-info-phone>div:nth-child(1)>div>nb-edit-switcher>div>div")).Click();
            _webDriver.FindElement(By.CssSelector("[type = password]")).SendKeys("Aa@12345678");
            _webDriver.FindElement(By.CssSelector("common-input-phone>label>input")).SendKeys("1111111111");
            _webDriver.FindElement(By.CssSelector("common-button-deprecated:nth-child(5)>button")).Click();

            Thread.Sleep(4000);
            var newPhone = _webDriver.FindElement(By.CssSelector("nb-paragraph.mt-2>div>span")).Text;

            Assert.AreEqual("111.111.1111", newPhone);
        }

        [Test]
        public void AddCard()
        {
            _webDriver.FindElement(By.CssSelector("input[placeholder ='Full name']")).SendKeys("Marina Tropinkina");
            _webDriver.FindElement(By.CssSelector("div.CardNumberField-input-wrapper>span>input")).SendKeys("4683 9759 3739 473");
            _webDriver.FindElement(By.CssSelector("[name = exp-date]")).SendKeys("9999");
            _webDriver.FindElement(By.CssSelector("[name = cvc]")).SendKeys("999");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            var expectedException = _webDriver.FindElement(By.CssSelector("[class='header-notification__text ml-1']")).Text;

            Thread.Sleep(1000);

            Assert.AreEqual("Update card info unexpected error", expectedException);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}
