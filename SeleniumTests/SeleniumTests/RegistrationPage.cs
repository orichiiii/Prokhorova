using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumTests
{
    public class RegistrationPage
    {
        private readonly IWebDriver _webDriver;

        private static By _firstNameField = By.CssSelector("input[name=first_name]");
        private static By _lastNameField = By.CssSelector("input[name=last_name]");
        private static By _emailField = By.CssSelector("input[name=email]");
        private static By _passwordField = By.CssSelector("input[name=password]");
        private static By _passwordConfirmField = By.CssSelector("input[name=password_confirm]");
        private static By _phoneNumberlField = By.CssSelector("input[name=phone_number]");
        private static By _nextButton = By.CssSelector("[class^=SignupForm__submitButton]");
        private static By _companyNameField = By.CssSelector("input[name=company_name]");
        private static By _companyWebsiteField = By.CssSelector("input[name=company_website]");
        private static By _industryField = By.CssSelector("input[name=industry]");
        private static By _optionTextField = By.CssSelector("[class^=Select__optionText]");
        private static By _locationField = By.CssSelector("input[name=location]");
        private static By _pacMatchedField = By.CssSelector("[class=pac-matched]");
        private static By _signupCompanyFormButton = By.CssSelector("[class^=SignupCompanyForm__submitButton]");
        private static By _ExceptionMessageForNullLastName = By.XPath("//*[contains(@name,'last_name')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForNullEmail = By.XPath("//*[contains(@name,'email')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForInvalidPassword = By.XPath("//*[contains(@name,'password')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForInvalidPhoneNumber = By.XPath("//*[contains(@name,'phone_number')]/../div[contains(@class,'FormErrorText')]");

        public RegistrationPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RegistrationPage GoToRegistrationPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");
            return this;
        }

        public RegistrationPage GoToNextRegistrationInPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join/company");
            return this;
        }

        public RegistrationPage SetFirstName(string firstName)
        {
            _webDriver.FindElement(_firstNameField).SendKeys(firstName);
            return this;
        }

        public RegistrationPage SetLastName(string lastName)
        {
            _webDriver.FindElement(_lastNameField).SendKeys(lastName);
            return this;
        }

        public RegistrationPage SetEmail(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public RegistrationPage SetPassword(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public RegistrationPage SetPasswordConfirm(string passwordConfirm)
        {
            _webDriver.FindElement(_passwordConfirmField).SendKeys(passwordConfirm);
            return this;
        }

        public RegistrationPage SetPhoneNumber(string phoneNumber)
        {
            _webDriver.FindElement(_phoneNumberlField).SendKeys(phoneNumber);
            return this;
        }

        public void ClickNextButton() =>
            _webDriver.FindElement(_nextButton).Click();

        public RegistrationPage SetCompanyName(string companyName)
        {
            _webDriver.FindElement(_companyNameField).SendKeys(companyName);
            return this;
        }

        public RegistrationPage SetCompanyWebsite(string companyWebsite)
        {
            _webDriver.FindElement(_companyWebsiteField).SendKeys(companyWebsite);
            return this;
        }

        public RegistrationPage SetLocation(string location)
        {
            _webDriver.FindElement(_locationField).SendKeys(location);
            return this;
        }

        public void ClickIndustry() =>
            _webDriver.FindElement(_companyWebsiteField).Click();

        public void ClickOptionText() =>
            _webDriver.FindElement(_optionTextField).Click();

        public void ClickPacMatched() =>
            _webDriver.FindElement(_pacMatchedField).Click();

        public void ClickSignupCompanyFormButton() =>
           _webDriver.FindElement(_signupCompanyFormButton).Click();

        public string GetExceptionMessageRequiredLastName() =>
            _webDriver.FindElement(_ExceptionMessageForNullLastName).Text;

        public string GetExceptionMessageRequiredEmail() =>
            _webDriver.FindElement(_ExceptionMessageForNullEmail).GetProperty("innerText");

        public string GetExceptionMessageInvalidPassword() =>
                    _webDriver.FindElement(_ExceptionMessageForInvalidPassword).Text;

        public string GetExceptionMessageInvalidPhoneFormat() =>
                    _webDriver.FindElement(_ExceptionMessageForInvalidPhoneNumber).Text;

    }
}
   
