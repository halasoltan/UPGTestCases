using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases.System_Admin
{
    class TC_SystemAdministrator
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        int timeBeforeSubmit ;
        LoginType loginType;


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\SystemAdministrator\\SystemAdministrator.xml",
            "testcase27", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC27()
        {
            // Test Data Preparation
            string userName = (TestContext.DataRow["UserName"].ToString());
            string password =(TestContext.DataRow["Password"].ToString());
            string Otp = (TestContext.DataRow["OTP"].ToString());
            string bankName = (TestContext.DataRow["BankName"].ToString());
            int num = random.Next();

            LoginPage loginPage = new LoginPage();
            loginPage.Login(userName, password, Otp, timeBeforeSubmit, loginType);

            HomePage homePage = new HomePage();
            homePage.selectFromSideMenu("Banks Management", "Banks");

            BanksManagement banksManagementPage = new BanksManagement();
            banksManagementPage.CreateBank();
            // TODO:  generate Random number For bank name   
            CreateBankPage createBankPage = new CreateBankPage();
            createBankPage.CreateBank(bankName + num.ToString());

            // Additional verification by Automation
            banksManagementPage.SearchByBankNameandViewDetails(bankName);

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestCases\\SystemAdministrator\\SystemAdministrator.xml",
          "testcase442", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC442()
        {
            // Test Data Preparation
            string userName = (TestContext.DataRow["UserName"].ToString());
            string password = (TestContext.DataRow["Password"].ToString());
            string Otp = (TestContext.DataRow["OTP"].ToString());
            string bankStr = (TestContext.DataRow["BankName"].ToString());
            string merchantNameStr = (TestContext.DataRow["MerchantName"].ToString());
            string addressStr = (TestContext.DataRow["Address"].ToString());
            string accountTypeStr = (TestContext.DataRow["AccountType"].ToString());
            string accountNumberStr = (TestContext.DataRow["AccountNumber"].ToString());
            string minTransactStr = (TestContext.DataRow["MinTransactionAmount"].ToString());
            string maxTransCountStr = (TestContext.DataRow["MaxTransCount"].ToString());
            string dailyLimitStr = (TestContext.DataRow[""].ToString());
            string maxTransactAmountStr = (TestContext.DataRow["MaxTransactAmount"].ToString());
            string monthlyLimitStr = (TestContext.DataRow["MonthlyLimit"].ToString());
            string fullNameStr = (TestContext.DataRow["FullName"].ToString());
            string emailStr = (TestContext.DataRow["Email"].ToString());
            string notificationMethodStr = (TestContext.DataRow["portalLoginUsername"].ToString());
            string portalLoginUsernameStr = (TestContext.DataRow["NotificationMethod"].ToString());





            LoginPage loginPage = new LoginPage();
            loginPage.Login(userName, password, Otp, timeBeforeSubmit, loginType);

            HomePage homePage = new HomePage();
            homePage.selectFromSideMenu("Merchants Management", "Merchants");

            MerchantManagementMerchant merchantPage = new MerchantManagementMerchant();
            merchantPage.AddMerchant();

            AddMerchantEditRecord addMerchantPage = new AddMerchantEditRecord();
            addMerchantPage.AddMerchantThroughMerchantManagement(  bankStr,   merchantNameStr,   addressStr,
               accountTypeStr,   accountNumberStr,   minTransactStr,
              dailyLimitStr,   maxTransCountStr,   maxTransactAmountStr,   monthlyLimitStr,
              fullNameStr,   emailStr,   notificationMethodStr,   portalLoginUsernameStr);

            // Additional verification by Automation
            merchantPage.SearchByMerchantName(merchantNameStr);
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
