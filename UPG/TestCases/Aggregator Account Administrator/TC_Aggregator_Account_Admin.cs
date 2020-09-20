using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UPG.TestCases.Aggregator_Account_Administrator
{

    [TestClass]
    public class TC_Aggregator_Account_Admin
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\Aggregator Account Administrator\\Aggregator_Account_Admin.xml",
            "testcase1", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC1()
        {
            Operations op = Operations.Instance;
            op.GoToPage("https://www.google.com/", "Google");
            Console.WriteLine(TestContext.DataRow["name"].ToString());
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\Aggregator Account Administrator\\Aggregator_Account_Admin.xml",
            "testcase2", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC2()
        {

            Console.WriteLine(TestContext.DataRow["MerchantName"].ToString());
            Console.WriteLine(TestContext.DataRow["Address1"].ToString());         
            Console.WriteLine(TestContext.DataRow["AccountNumber"].ToString());
            Console.WriteLine(TestContext.DataRow["MinTransactionAmount"].ToString());
            Console.WriteLine(TestContext.DataRow["DailyLimitAmount"].ToString());
            Console.WriteLine(TestContext.DataRow["MaxTransactionCountDay"].ToString());
            Console.WriteLine(TestContext.DataRow["MaxTransactionAmount"].ToString());
            Console.WriteLine(TestContext.DataRow["MonthlyLimitAmount"].ToString());
            Console.WriteLine(TestContext.DataRow["FullName"].ToString());
            Console.WriteLine(TestContext.DataRow["UserEmail"].ToString());

        }
    }
}
