using FolakeMSTestFramework.Configuration;
using FolakeMSTestFramework.CustomException;
using FolakeMSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace FolakeMSTestFramework.BaseClass
{
    [TestClass]
   public class Baseclass
    {
        private static FirefoxProfile GetFirefoxOptions()
        {
           var fProfile = new FirefoxProfile();
           var fXManager = new FirefoxProfileManager();
           fProfile = fXManager.GetProfile("default");
            return fProfile;
        }
        private static ChromeOptions GetChromeOptions()
        {
            var cOptions = new ChromeOptions();
            cOptions.AddArgument("start-maximized");
            return cOptions;
        }

        private static InternetExplorerOptions GetIeOption()
        {
            var iEoOptions = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true
            };
            return iEoOptions;

        }

       private static IWebDriver GetFirefoxBrowser()
       {
           IWebDriver driver = new FirefoxDriver();
           return driver;
       }

        private static IWebDriver GetChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static IWebDriver GetIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIeOption());
            return driver;
        }

        private static IWebDriver GetEdgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;
        }

        [AssemblyInitialize]
       public static void InitWebDriver(TestContext tc)
       {
           ObjectRepository.Config = new AppConfigReader();

           switch (ObjectRepository.Config.Getbrowser()) 
           {
                 case   BrowserType.Firefox:
                   ObjectRepository.Driver = GetFirefoxBrowser();
                    break;

                    case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeBrowser();
                    break;

                    case BrowserType.IExplorer:
                   ObjectRepository.Driver = GetIEBrowser();
                    break;
                default:
                    /**
                     * if none of the pre- defined browsers are refeenced
                     * we need an input to handle the error that will be
                     * displyed.
                     * We can create a custom error handler
                     */ 
                     throw  new UnknownBrowser("Browser is unknown:" +
                        ObjectRepository.Config.Getbrowser().ToString());

           }
       }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver == null) return;
            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Quit();
        }
    }
}
