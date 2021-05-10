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
using SeleniumTests.PageObject;

namespace SeleniumTests
{
    class UpdateProfileTests
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
        private UpdateProfilePage _updateProfile;
        private string _email;
        private string _phone;

        [SetUp]
        public void Setup()
        {
            _phone = Parameters.GeneratePhone();
            _email = Parameters.GenerateEmail();

            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
        }

        [Test]
        public void UpdateGeneralInformation()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);

            _updateProfile.GoToUpdateProfileLink()
                .ClickGeneralChange()
                .SetNewName("Liza")
                .SetNewLastName("Olive")
                .SetLocation("hhh")
                .SetIndustry("fashion")
                .ClickSaveGeneralChanges();

            Assert.AreEqual("Liza Olive", _updateProfile.GetNewName());
            Assert.AreEqual("fashion", _updateProfile.GetNewIndustry());
            Assert.AreEqual("Half Hollow Hills Central School District, NY, USA", _updateProfile.GetNewLocation());
        }

        [Test]
        [TestCase("Oly12345678$$")]
        public void UpdatePassword(string password)
        {
            _webDriver.FindElement(By.XPath("//div[3]/div[1]/nb-account-info-password[1]/form[1]/div[1]/div[1]/nb-edit-switcher[1]/div[1]/div[1]")).Click();
            var elements = _webDriver.FindElements(By.CssSelector("[type = password]"));
            elements[0].SendKeys(Constant.password);
            elements[1].SendKeys(password);
            elements[2].SendKeys(password);
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();
            Thread.Sleep(3000);
            _webDriver.FindElement(By.CssSelector("div.row.mt-4>div>nb-link>div")).Click();
            Thread.Sleep(3000);
            _webDriver.FindElement(By.CssSelector("[type=email]")).SendKeys(_email);
            _webDriver.FindElement(By.CssSelector("input[name = password]")).SendKeys(password);
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
            _webDriver.FindElement(By.CssSelector("div.CardNumberField-input-wrapper input")).SendKeys("468397593739473");
            _webDriver.FindElement(By.CssSelector("[name = exp-date]")).SendKeys("9999");
            _webDriver.FindElement(By.CssSelector("[name = cvc]")).SendKeys("999");
            _webDriver.FindElement(By.CssSelector("[type = submit]")).Click();

            var expectedException = _webDriver.FindElement(By.CssSelector("[class='header-notification__text ml-1']")).Text;
            Thread.Sleep(1000);

            Assert.AreEqual("Update card info unexpected error", expectedException);
        }

        [Test]
        public void AddPhoto()
        {
            _webDriver.FindElement(By.CssSelector("[class='link link_type_navigation']")).Click();
            _constMethods.FindPhotoElement();

            Thread.Sleep(3000);
            var actualPhoto = _webDriver.FindElement(By.CssSelector("div.avatar__image"));

            Assert.AreEqual(@"C:\Users\proho\Desktop\image_2021-04-29_14-00-03.png", actualPhoto);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}
