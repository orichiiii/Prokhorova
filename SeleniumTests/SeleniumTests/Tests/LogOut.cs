using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTests.PageObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumTests
{
    public class LogOut
    {
        private WebDriverHelper _webDriverHelper;
        private IWebDriver _webDriver;
        private ConstMethods _constMethods;
        private WebDriverWait _webDriverWait;
        private string _email;
        private string _phone;

        [SetUp]
        public void Setup()
        {
            _webDriverHelper = new WebDriverHelper();
            _webDriver = _webDriverHelper.GetWebDriver();
            _constMethods = new ConstMethods(_webDriver);
            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(6));

            _email = Parameters.GenerateEmail();
            _phone = Parameters.GeneratePhone();
        }

        [Test]
        public void LogOutt()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            var updateProfilePage = new UpdateProfilePage(_webDriver);
            _webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class^='SignupCompanyForm__submitButton']")));
            updateProfilePage.GoToUpdateProfileLink();
            _webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class='link link_type_navigation']")));
            updateProfilePage.ClickLogOutButton();
            _webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[class^='SignInForm__signUpLink']")));

            var actualURL = _webDriver.Url;

            Assert.AreEqual(Constant.signInLink, actualURL);
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}
