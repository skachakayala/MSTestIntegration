using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AzureDemo
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            launchBrowser();
            Console.WriteLine("chrome browser lunched successfully");

        }
        public void launchBrowser()
        {
            driver = new ChromeDriver(@"D:\selenium jars");
            //driver.Manage().Timeouts().ImplicitWait = 20;
            driver.Manage().Window.Maximize();
            driver.Url = "https://docs.microsoft.com/en-us/azure/devops/test/run-automated-tests-from-test-hub?view=vsts";
        }
    }
}

