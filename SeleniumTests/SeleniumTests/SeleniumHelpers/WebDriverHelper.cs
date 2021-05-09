using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumTests
{
    public class WebDriverHelper
    {
        private IWebDriver _webDriver;

        private void CreateDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        public void CloseDriver()
        {
            _webDriver.Quit();
        }

        public IWebDriver GetWebDriver()
        {
            if (_webDriver == null)
                CreateDriver();
            return _webDriver;
        }
    }
}
