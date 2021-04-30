using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestProject1
{
    class UnitTest2
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _webDriver.Navigate().GoToUrl("https://rozetka.com.ua/");

            Thread.Sleep(5000);
            _webDriver.FindElement(By.CssSelector(
            "body > app-root > div > div:nth-child(3) > app-rz-main-page > div > aside > main-page-sidebar > sidebar-fat-menu > div > ul > li:nth-child(1) > a")).Click();

            Thread.Sleep(5000);
            _webDriver.FindElement(By.CssSelector(
            "body > app-root > div > div:nth-child(3) > rz-super-portal > div > main > section > div:nth-child(3) > rz-dynamic-widgets > rz-widget-list:nth-child(2) > section > ul > li:nth-child(2) > rz-list-tile > div > a.tile-cats__heading.tile-cats__heading_type_center.ng-star-inserted")).Click();

            var actual = _webDriver.Url;

            Assert.AreEqual("https://hard.rozetka.com.ua/computers/c80095/", actual);
        }

        [TearDown]
        public void quit()
        {
            _webDriver.Quit();
        }
    }
}
