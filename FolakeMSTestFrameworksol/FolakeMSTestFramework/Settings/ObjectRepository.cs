using FolakeMSTestFramework.Interfaces;
using OpenQA.Selenium;

namespace FolakeMSTestFramework.Settings
{
    public  class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

    }

}
