using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestProject1
{
    public class Tests
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
            var searchField = _webDriver.FindElement(By.CssSelector(
            "body > app-root > div > div:nth-child(3) > rz-header > header > div > div > div > form > div > div > input"));
            searchField.SendKeys("Пасхальный набор");
            
            _webDriver.FindElement(By.CssSelector(
            "body > app-root > div > div:nth-child(3) > rz-header > header > div > div > div > form > button")).Click();

            var actual = _webDriver.FindElement(By.CssSelector("body > app-root > div > div:nth-child(3) > rz-search > rz-catalog > div > div.layout.layout_with_sidebar > section > rz-grid > ul > li:nth-child(1) > app-goods-tile-default > div > div.goods-tile__inner > a.goods-tile__heading.ng-star-inserted > span"));

            Assert.AreEqual("Набор Spell Семейная пасхальная корзина 8 позиций (7500000311111)", actual.Text);
        }

        [TearDown]
        public void quit()
        {
            _webDriver.Quit();
        }
    }
}