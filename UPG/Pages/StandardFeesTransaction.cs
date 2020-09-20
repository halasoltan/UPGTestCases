using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class StandardFeesTransaction
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankLocator = By.CssSelector("#BankId");
        public By searchFeesBtnLocator = By.CssSelector("#btnSearch");
        string selectedBankLocatorStr;
        // TODO:  Mina Review   
        public void SearchByBank()
        {  //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator, selectedBankLocatorStr);
            workFlowOperations.ClickOnBtn(searchFeesBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

         //Note : Edit in the page is a fail TC
    }
}
