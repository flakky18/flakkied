using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolakeMSTestFramework
{
    [TestClass]
    public class FirstMSTest
    {

        [ClassInitialize]
        public  static void ConnectToDatabase(TestContext testContext)
        {
            Console.WriteLine("Open connection to the database");
        }

        [TestInitialize]
        public void LaunchBrowser()
        {
            Console.WriteLine("Launch the browser");
        }

        [Ignore]
        [TestMethod]
        [TestCategory("SMOKE TEST")]
        public void ClickAButton()
        {
            Console.WriteLine("click on a button");
        }

        [TestMethod]
        [TestCategory("PENETRATION TEST")]
        public void EnterAText()
        {
            Console.WriteLine("Enter text into text field");
        }

        [TestMethod]
        public void NavigateToPage()
        {
            Console.WriteLine("Navigate to a certain page");
        }

        [TestCleanup]
        public void TearDownBrowser()
        {
            Console.WriteLine("Close all open Browser");
        }

        [ClassCleanup]
        public static void DisconnectFromDatabase()
        {
            Console.WriteLine("Close connection to the database");
        }

      



    }
}
