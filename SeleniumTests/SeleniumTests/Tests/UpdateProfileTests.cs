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
    public class UpdateProfileTests
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
                .ClickSaveGeneralChanges()
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
        public void UpdatePassword()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);

            _updateProfile.GoToUpdateProfileLink()
                .ClickPasswordChange()
                .SetCurrentPassword(Constant.password)
                .SetNewPasswordFirst("Aa12345678$$")
                .SetNewPasswordSecond("Aa12345678$$")
                .ClickSavePasswords()
                .ClickLogOutButton();
            var authorization = new AuthorizationPage(_webDriver);
            authorization.SetEmail(_email)
            .SetPassword("Aa12345678$$")
            .ClickSubmitbutton();

            Thread.Sleep(3000);
            var actual = _webDriver.Url;

            Assert.AreEqual(Constant.secondStepLink, actual);
        }

        [Test]
        public void UpdateEmail()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);
            var email = DateTime.Now.ToString("dd.yyyy.HH.mm.ss") + "@gmail.com";

            _updateProfile.GoToUpdateProfileLink()
                .ClickEmailChange()
                .SetPasswordEmail(Constant.password)
                .SetNewEmail(email)
                .ClickSaveEmail();

            Assert.AreEqual(email, _updateProfile.GetNewEmail());
        }

        [Test]
        public void UpdatePhoneNumber()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);

            _updateProfile.GoToUpdateProfileLink()
                .ClickPhoneChange()
                .SetPhonePassword(Constant.password)
                .SetNewPhone("1111111111")
                .ClickSavePhone();

            Assert.AreEqual("111.111.1111", _updateProfile.GetNewPhone());
        }

        [Test]
        public void AddCard()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);

            _updateProfile.GoToUpdateProfileLink()
                .SetFullNameToCardField(Constant.name + Constant.lastName)
                .SetCardNumber("4111111111111111")
                .SetCardExpDate("1025")
                .SetCardCVC("493")
                .ClickSaveCard();
            Thread.Sleep(500);

            Assert.AreEqual("Update card info unexpected error", _updateProfile.GetExceprionCardInfoError());
        }

        [Test]
        public void AddPhoto()
        {
            _constMethods.RegistrationProcess(_phone, _email, Constant.password, Constant.name, Constant.lastName);
            _updateProfile = new UpdateProfilePage(_webDriver);
            Thread.Sleep(3000);
            _updateProfile.GoToUpdateProfileLink();
            _updateProfile.ClickProfileChanges();
            _constMethods.FindPhotoElement();

            Thread.Sleep(3000);

            Assert.AreEqual(true, _constMethods.existsElement());
        }

        [TearDown]
        public void Quit()
        {
            _webDriverHelper.CloseDriver();
        }
    }
}
