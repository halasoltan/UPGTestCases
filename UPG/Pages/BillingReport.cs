using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class BillingReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankLocator = By.CssSelector("#BankId");
        public By DateFromTxtboxLocator = By.CssSelector("#ByDate");
        public By feesTypeDropDownLocator = By.CssSelector("#FeeType");
        public By searchBillingBtnLocator = By.CssSelector(".btn-block");
        string selectedbankLocatorStr;
        string dateStr;
        string feesTypeStr;
        // TODO:  Mina Review   

        public void SearchBillingReport()
        {  //test data preparation // 3 fields mandatory search and "transaction" pending 
            //so in this phase we choose "subscription" fees type
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator, selectedbankLocatorStr);
            workFlowOperations.SendKeysToTxtBox(DateFromTxtboxLocator, dateStr);
            workFlowOperations.ChooseFromDropDown(feesTypeDropDownLocator, feesTypeStr);
            workFlowOperations.ClickOnBtn(searchBillingBtnLocator);
            workFlowOperations.waitForPageLoaded();



        }
    }
}
