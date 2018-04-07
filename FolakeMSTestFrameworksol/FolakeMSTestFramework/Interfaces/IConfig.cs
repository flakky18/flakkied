using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolakeMSTestFramework.Configuration;

namespace FolakeMSTestFramework.Interfaces
{
   public  interface IConfig
   {
       BrowserType Getbrowser();
       string GetUsername();
       string GetPassword();
       string GetWebsite();

   }
}
