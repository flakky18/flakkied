using FolakeMSTestFramework.Settings;

namespace FolakeMSTestFramework.ComponentHelper
{
   public  class WindowHelper
    {
       public static string GetPageTitle()
       {
           return ObjectRepository.Driver.Title;
       }
    }
}
