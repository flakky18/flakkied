using System;
using FolakeMSTestFramework.ComponentHelper;
using FolakeMSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolakeMSTestFramework.TestScipts.PageNavigation
{
    [TestClass]
   public  class TestNavigationPage
    {
        [TestMethod]
        [TestCategory("NEW BROWSER LAUNCH")]
        public void OpenPage()
        {
           NavigationHelper.
                NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(WindowHelper.GetPageTitle());

           
        }
      
    }
}
