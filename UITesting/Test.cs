using NUnit.Framework;
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using UITesting.Framework.Core;

namespace UITesting
{
    [TestFixture()]
    public class Test
    {
        private String baseURL;
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            baseURL = Configuration.Get("BaseURL");
            ChromeOptions options = new ChromeOptions();
            DesiredCapabilities capabilities = new DesiredCapabilities();
            Driver.Add(Configuration.Get("Browser"), Path.GetFullPath("/home/wers4/Projects/UITesting/UITesting/chromedriver.exe"), capabilities);
            driver = Driver.Current();
            driver.Navigate().GoToUrl(baseURL);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Test()]
        public void Testcase()
        {
            driver.FindElement(By.Id("ss")).Click();
            driver.FindElement(By.Id("ss")).Clear();
            driver.FindElement(By.Id("ss")).SendKeys("London");
            driver.FindElement(By.XPath("//table[@class='c2-month-table']//td[contains(@class. 'c2-day-today')]")).Click();
            driver.FindElement(By.Id("group_adults")).Click();
            new SelectElement(driver.FindElement(By.Id("group_adults"))).SelectByText("1");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.Id("ss")).Click();
        }
    }
}