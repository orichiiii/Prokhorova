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
    public class RegistrationTests
    {
        private WebDriverHelper _webDriverHelper;

        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
        }

        [Test]
        public void Registration()
        {
            var phone =  GenerateParameters.GetPhone();
            var email = GenerateParameters.GetEmail();
            var webDriver = _webDriverHelper.GetWebDriver();
            webDriver.Navigate().GoToUrl(Constant.loginLink);

            webDriver.FindElement(By.CssSelector("[name='first_name']")).SendKeys(Constant.name);
            webDriver.FindElement(By.CssSelector("[name = last_name]")).SendKeys(Constant.lastName);
            webDriver.FindElement(By.CssSelector("[name = email]")).SendKeys(email);
            webDriver.FindElement(By.CssSelector("[name = password]")).SendKeys(Constant.password);
            webDriver.FindElement(By.CssSelector("[name = password_confirm]")).SendKeys(Constant.password);
            webDriver.FindElement(By.CssSelector("[name = phone_number]")).SendKeys(phone);
            webDriver.FindElement(By.CssSelector("[class^=SignupForm__submitButton]")).Click();

            //заменить на ожидание пока появится элемент
            Thread.Sleep(5000);

            Assert.AreEqual(Constant.companyLink, webDriver.Url);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver(); 
        }
    }
}