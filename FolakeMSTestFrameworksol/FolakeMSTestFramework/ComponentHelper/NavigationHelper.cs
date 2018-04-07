using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolakeMSTestFramework.Settings;

namespace FolakeMSTestFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string URL)
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Navigate().GoToUrl(URL);
        }
    }
}
