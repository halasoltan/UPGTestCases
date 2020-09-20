using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases.System_Admin
{
    class TC_System_Admin
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\System Admin\\System_Admin.xml",
            "testcase1", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC1()
        {

            Console.WriteLine(TestContext.DataRow["name"].ToString());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\System Admin\\System_Admin.xml",
           "testcase2", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC2()
        {
            Console.WriteLine(TestContext.DataRow["BIN"].ToString());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\System Admin\\System_Admin.xml",
          "testcase3", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC3()
        {
            Console.WriteLine(TestContext.DataRow["BIN"].ToString());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\System Admin\\System_Admin.xml",
         "testcase4", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC4()
        {
            Console.WriteLine(TestContext.DataRow["BIN"].ToString());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\System Admin\\System_Admin.xml",
         "testcase5", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC5()
        {
            Console.WriteLine(TestContext.DataRow["BIN"].ToString());
        }
    }
}
