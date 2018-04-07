using System;
using System.Threading;
using FolakeMSTestFramework.Configuration;
using FolakeMSTestFramework.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FolakeMSTestFramework.BrowserLaunchTest
{
    [TestClass]
   public  class LaunchBrowser
    {
        [TestMethod]
        [TestCategory("Selenium tests")]
        public void BrowserLaunch()
        {
            var baseURL = "https://www.asda.com";
            

           IWebDriver driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
           driver.Navigate().GoToUrl(baseURL);
           //driver.Close();
           Thread.Sleep(5000);
           driver.Quit();
        }

        [TestMethod]
        [TestCategory("CONFIG")]
        public void Sample()
        {
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));

            IConfig config = new AppConfigReader();
            //AppConfigReader appConfigReader = new AppConfigReader();
            Console.WriteLine("The browser is : {0}" ,config.Getbrowser());
            Console.WriteLine("The username is : {0}", config.GetUsername());
            Console.WriteLine("The password is : {0}", config.GetPassword());

        }

    }
}
