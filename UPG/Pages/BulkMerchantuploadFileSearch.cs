using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class BulkMerchantuploadFileSearch
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By batchIdTxtBoxLocator = By.CssSelector("#Id");
        public By statusDropDownLocator = By.CssSelector("#Status");
        public By bankDropDownLocator = By.CssSelector("#BankId");
        public By searchBtnLocator = By.CssSelector(".btn-block");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddbulk = By.CssSelector(".fa-plus");
        public By reloadBtnLocator = By.CssSelector(".fa-refresh");
        string batchIdStr;
        string selectedBankLocatorStr;
        string selectedStatusStr;
        // TODO:  Mina Review   
        public void SearchByBatchId()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(batchIdTxtBoxLocator , batchIdStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void SearchByBank()
        {  //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, selectedBankLocatorStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void SearchByStatus()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(statusDropDownLocator, selectedStatusStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

       
        // TODO:  Mina Review   

        public void ReloadBulkMerchant()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(reloadBtnLocator);
           
        }












        //public void AddBulk() // Fail Tc
        //{
        //    workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
        //    workFlowOperations.ClickOnBtn(plusAddbulk);

        //}
    }
}

