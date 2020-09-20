using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class BanksManagement
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankShortNameLocator = By.CssSelector("#BankCode");
        public By banktNameLocator = By.CssSelector("#BankName");
        public By searchBankBtnLocator = By.CssSelector(".btn-block");
        string bankShortNameStr;
        string bankNameStr;
        // TODO:  Mina Review   
        public void SearchByBankShortName()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(bankShortNameLocator , bankShortNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void SearchByBankName()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(banktNameLocator, bankNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

    }
}
