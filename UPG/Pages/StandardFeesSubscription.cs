using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class StandardFeesSubscription
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankLocator = By.CssSelector("#BankId");
        public By searchFeesBtnLocator = By.CssSelector("#btnSearch");
        public By editBtnLocator = By.CssSelector(".grid-row-selected .btn");
        public By updateFeezPopUpLocator = By.CssSelector("#Heading");
        public By flatFeeTxtBoxLocator = By.CssSelector("#FeesData_FlatFee");
        public By updateFeesBtnLocator = By.CssSelector("#btnSave");
        string selectedBankLocatorStr;
        string flatFeesStr;
        // TODO:  Mina Review   
        public void SearchByBank()
        {  
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator, selectedBankLocatorStr);
            workFlowOperations.ClickOnBtn(searchFeesBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void EditTransactionType()
        {
            workFlowOperations.WaitToClickOnBtn(editBtnLocator);
            workFlowOperations.ExtractDataFromText(updateFeezPopUpLocator);
            workFlowOperations.SendKeysToTxtBox(flatFeeTxtBoxLocator , flatFeesStr);
            workFlowOperations.ClickOnBtn(updateFeesBtnLocator);


        }








    }
}
