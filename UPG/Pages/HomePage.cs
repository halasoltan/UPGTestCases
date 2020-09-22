using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class HomePage
    {
        Operations workFlowOperations = Operations.Instance;

        By userRuleLocator = By.XPath("/html/body/div[1]/div/div/div[1]/div[3]/ul/div/div/center[1]");
        By userNameLocator = By.XPath("/html/body/div[1]/div/div/div[1]/div[3]/ul/li/a");

        By dropDownLocator = By.XPath("/html/body/div[1]/div/div/div[1]/div[3]/ul/li");
        By changePasswordLocator = By.XPath("/html/body/div[1]/div/div/div[1]/div[3]/ul/li/ul/li[1]/a");
        By logoutLocator = By.XPath("/html/body/div[1]/div/div/div[1]/div[3]/ul/li/ul/li[2]/a");
        //Side Menu Table
        public Dictionary<string, By> sideMenuTable = new Dictionary<string, By>()
        {
            { "Dashboard", By.Id("IndexAdmin")},
            { "Banks Management", By.LinkText(" Banks Management ")},
                { "Banks", By.Id("IndexBanks")},
                { "Transaction Routes", By.Id("IndexRoutes")},
            { "Merchants Management", By.LinkText(" Merchants Management ")},
                { "Merchants", By.Id("IndexMerchants")},
                { "Bulk Merchant Upload", By.Id("BulkMerchantMasterSearchMerchants")},
                { "Branches", By.Id("IndexMerchantBranch")},

            { "UPG Fees Management", By.LinkText(" UPG Fees Management ")},
                { "Standard Fees - Transactions", By.Id("TransactionsFees")},
                { "Standard Fees - Subscription", By.Id("SubscriptionFees")},


            { "Terminal Management", By.LinkText(" Terminal Management ")},
                { "Terminal List", By.Id("IndexTerminals")},
                { "Bulk Terminal Upload", By.Id("BulkTerminalMasterSearchTerminals")},

            { "Settlement Reports", By.Id("MerchantSettlementTransactions")},
            { "Balance Audit", By.Id("IndexBalance")},
            { "UPG Billing Report", By.Id("BillingReportReport")},
            { "Hosts Management", By.Id("IndexHosts")},
            { "Manage Users", By.Id("ViewUsersUser")},
            { "User Status Report", By.Id("ViewUsersStatusUser")},
            { "Exchange Rates", By.Id("IndexExchangeRates")},
            { "System Configurations", By.Id("IndexConfParam")},
            { "SMS Log Report", By.Id("IndexSmsLog")},

            { "Audit Log Reports", By.LinkText(" Audit Log Reports ") },
                { "Detailed Audit Log", By.Id("AuditDetailsLogAudit") },
                { "Session Audit Log", By.Id("AuditLogAudit")},

            { "System Log Report", By.Id("IndexSystemLog")},
            { "Communication Log Report", By.Id("IndexCommunicationLog")},
            { "System Mode", By.Id("SystemModeAdmin")},
            { "Meeza Digital Admin Functions", By.Id("IndexTahweel")},
            { "Exported Files Downloads", By.Id("ExportedFilesDownloadSearchBase") },

            //To be done
            ///Not Present in Sys Admin Panel
            {"Transactions Report" , By.Id("IndexTransactions") },
            {"AMS Transaction Report" , By.Id("AMSTransactionTransactions") },
            {"Support Tickets",By.XPath("MerchantRequestsSupportTicket") },


           
        };

        public void validateLogin(string userRule,string userName)
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(userRuleLocator, userRule);
            workFlowOperations.WaitConfirmationMessage(userNameLocator, userName);
        }

        public void logout()
        {
            workFlowOperations.ClickOnBtn(dropDownLocator);
            workFlowOperations.WaitToClickOnBtn(logoutLocator);
        }

        public void changePasssword()
        {
            workFlowOperations.ClickOnBtn(dropDownLocator);
            workFlowOperations.WaitToClickOnBtn(changePasswordLocator);
        }

        public void selectFromSideMenu(string sideMenu1stChoice, string sideMenu2stChoice)
        {

            workFlowOperations.ClickOnBtn(sideMenuTable[sideMenu1stChoice]);
            if (sideMenu2stChoice != "")
            {
                workFlowOperations.WaitToClickOnBtn(sideMenuTable[sideMenu2stChoice]);
            }

        }



        // TODO: To be transmitted to their pages   
        // TODO:  Mina Review   
        // Locators for Search

        
        public string errorMessageSearchStr = "Date From should be Lees Then Date To";

        
        //--------------------------------------------------------------------------------------------------------------


    }
}
