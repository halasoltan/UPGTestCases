using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class MerchantBranchAdmin
    {
        //TODO: Check page purpose with Hala    :  Most methods in that page pending
        // TODO:  Mina Review   
        Operations workFlowOperations = Operations.Instance;
        public By dashboardIconLocator = By.LinkText("Dashboard ");
        public By transactioreportLocator = By.LinkText(" Transactions Report ");
        public By merchantAmsTransactionLocator = By.LinkText(" Merchant AMS Transaction ");
        public By settelmentReportLocator = By.LinkText(" Settlement Report ");
        public By digitalTokenLocator = By.LinkText(" Digital Token management ");
        public By supportTicketLocator = By.LinkText(" Support Tickets ");
        public By exportDownloadFileLocator = By.LinkText(" Exported Files Downloads ");



        //MerchantBranchAdmin
        public void CheckIfSystemDisplayDashboardIconLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(dashboardIconLocator);
        }
        public void CheckIfSystemDisplayTransactioReportLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(transactioreportLocator);
        }
        public void CheckIfSystemDisplayMerchantAmsTransactionLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(merchantAmsTransactionLocator);
        }
        public void CheckIfSystemDisplaysettelmentReportLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(settelmentReportLocator);
        }
        public void CheckIfSystemDisplayDigitalTokenLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(digitalTokenLocator);
        }
            public void CheckIfSystemDisplayExportDownloadFileLeftSideMenuAtTheLeft()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(exportDownloadFileLocator);
        }

    }
}
