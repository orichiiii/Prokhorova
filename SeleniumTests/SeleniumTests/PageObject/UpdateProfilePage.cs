using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumTests.PageObject
{
    public class UpdateProfilePage
    {
        private IWebDriver _webDriver;

        private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        private static By _changeGeneralDataButton = By.CssSelector("nb-account-info-general-information>form>div:nth-child(1)>div>nb-edit-switcher>div>div");
        private static By _changeEmailButton = By.CssSelector("nb-account-info-email-address>form>div:nth-child(1)>div>nb-edit-switcher>div>div");
        private static By _changePasswordButton = By.CssSelector("nb-account-info-password div:nth-child(1)>div>nb-edit-switcher>div>div");
        private static By _changeNumberButton = By.CssSelector("nb-account-info-phone>div:nth-child(1)>div>nb-edit-switcher>div>div");
        private static By _companyLocationfield = By.CssSelector("[class='input__self input__self_type_text-underline ng-untouched ng-pristine ng-valid pac-target-input']");
        private static By _industryField = By.CssSelector("input[placeholder='Enter Industry']");
        private static By _nameField = By.CssSelector("common-input:nth-child(3) input");
        private static By _lastNameField = By.CssSelector("common-input:nth-child(4) input");
        private static By _saveGeneralButton = By.CssSelector("div:nth-child(2) > div > common-button-deprecated > button");
        private static By _newName = By.CssSelector("nb-paragraph:nth-child(3)>div");
        private static By _newLocation = By.CssSelector("nb-paragraph:nth-child(5)>div");
        private static By _newIndustry = By.CssSelector("nb-paragraph:nth-child(7)>div");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");
        //private static By _logOutButton = By.CssSelector("[class='link link_type_logout link_active']");


        public UpdateProfilePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public UpdateProfilePage GoToUpdateProfileLink()
        {
            _webDriver.Navigate().GoToUrl(Constant.updateProfileLink);
            return this;
        }

        public UpdateProfilePage ClickGeneralChange()
        {
            _webDriver.FindElement(_changeGeneralDataButton).Click();
            return this;
        }

        public UpdateProfilePage SetNewName(string name)
        {
            var nameField = _webDriver.FindElement(_nameField);
            nameField.Clear();
            nameField.SendKeys(name);
            return this;
        }

        public UpdateProfilePage SetNewLastName(string lastName)
        {
            var lastNameField = _webDriver.FindElement(_lastNameField);
            lastNameField.Clear();
            lastNameField.SendKeys(lastName);
            return this;
        }

        public UpdateProfilePage SetLocation(string location)
        {
            var locationField = _webDriver.FindElement(_companyLocationfield);
            locationField.SendKeys("hhh");
            Thread.Sleep(500);
            locationField.SendKeys(Keys.Down);
            locationField.SendKeys(Keys.Enter);
            return this;
        }

        public UpdateProfilePage SetIndustry(string industry)
        {
            _webDriver.FindElement(_industryField).SendKeys(industry);
            return this;
        }

        public UpdateProfilePage ClickSaveGeneralChanges()
        {
            _webDriver.FindElement(_saveGeneralButton).Click();
            Thread.Sleep(1000);
            return this;
        }

        public UpdateProfilePage ClickLogOutButton()
        {
            _webDriver.FindElement(_logOutButton).Click();
            return this;
        }

        public string GetNewName() => _webDriver.FindElement(_newName).Text;

        public string GetNewIndustry() => _webDriver.FindElement(_newIndustry).Text;

        public string GetNewLocation() => _webDriver.FindElement(_newLocation).Text;

    }
}
