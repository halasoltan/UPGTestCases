using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class BalanceManagement                                                // Balance Audit in system
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
       
        public By DateToTxtboxLocator = By.CssSelector("#EndDate");
        public By bankLocator = By.CssSelector("#BankId");
        public By merchantDropDownLocator = By.CssSelector(".k-i-arrow-60-down");
        public By selectedMerchantLocator = By.CssSelector(".k-input"); //All choice only
        public By reportTypeLocator = By.CssSelector("#AuditType");
        public By searchBtnBalanceLocator = By.CssSelector(".btn-block");
        string selectedBankLocatorStr; // from DB Query
        string reportTypeStr;

        // TODO:  Mina Review   
        public void SearchByBank()
        {  //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator, selectedBankLocatorStr);
            workFlowOperations.ClickOnBtn(searchBtnBalanceLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void SearchByMerchant()
        {   //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(merchantDropDownLocator, selectedMerchantLocator);
            workFlowOperations.ClickOnBtn(searchBtnBalanceLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   revise function date by Mina
        public void SearchByDate()
        { //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
           //  workFlowOperations.searchByDates(); //??
            workFlowOperations.ClickOnBtn(searchBtnBalanceLocator);
            workFlowOperations.waitForPageLoaded();
        }

        public void SearchByReportType()
        { // test data preparation = "AMS"
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(reportTypeLocator, reportTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnBalanceLocator);
            workFlowOperations.waitForPageLoaded();

        }
    }
}
