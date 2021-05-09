using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumTests
{
    public class Registration
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;

        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
        }

        [Test]
        public void PositiveRegistration()
        {
            var phone = GenerateParameters.GetPhone();
            var email = GenerateParameters.GetEmail();
            _constMethods.RegistrationProcess(phone, email, Constant.password);

            //заменить на ожидание пока появится элемент
            Thread.Sleep(5000);

            Assert.AreEqual(Constant.companyLink, _webDriver.Url);
        }

        [Test]
        [TestCase("22222", "fhj@", "1234567")]
        public void RegistrationvithInvalidData(string invalidEmail, string invalidPhone, string invalidPassword)
        {
            _constMethods.RegistrationProcess(invalidPhone, invalidEmail, invalidPassword);
            Thread.Sleep(2000);
            var errors = _webDriver.FindElements(By.CssSelector("div.FormErrorText__error---nzyq > div"));

            Assert.AreEqual("Invalid Email", errors[0].Text);
            Assert.AreEqual("Invalid password format", errors[1].Text);
            Assert.AreEqual("Invalid phone format", errors[2].Text);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver(); 
        }
    }
}