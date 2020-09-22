using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class CreateBankPage
    {
        Operations workFlowOperations = Operations.Instance;
        public By bankShortNameLocator = By.CssSelector("#BankCode");
        public By banktNameTxtBoxLocator = By.CssSelector("#BankName");
       
       
        public By requiredFieldMsgLocator = By.CssSelector("#Bank_Name-error");
        string requiredFieldMsgStr = "This field is required.";
        public By saveBtnLocator = By.CssSelector("#btnSave");
        public By editIconBtnLocator = By.CssSelector(".grid-row:nth-child(1) .btn-warning");
        public By bankNameCellLocator = By.CssSelector(".grid-row:nth-child(1) > .grid-cell:nth-child(1)");

        public By enableMobileSdkBtnLocator = By.CssSelector(".row:nth-child(20) .slider");
        public By domesticRouteBtnLocator = By.CssSelector(".row:nth-child(21) .slider");
        public By enableDisputeBtnLocator = By.CssSelector(".row:nth-child(22) .slider");




        // TODO:  Mina Review  
        public void CreateBank(string bankName)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(banktNameLocator, bankName);
            workFlowOperations.ClickOnBtn(enableMobileSdkLocator);
            workFlowOperations.ClickOnBtn(domesticRouteBtnLocator);
            workFlowOperations.ClickOnBtn(enableDisputeBtnLocator);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
        }
        // TODO:  Mina Review  
        public void CreateBankWithoutEnterBankName(string shortBankNameStr)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(bankShortNameLocator, shortBankNameStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(requiredFieldMsgLocator, requiredFieldMsgStr);
        }
        // TODO:  Mina Review  
        public void EditBankPage(string bankNameStr)
        {         
            //workFlowOperations.ClickOnBtn(editIconBtnLocator);
           workFlowOperations.WaitToSendKeysToTxtBox(banktNameLocator, bankNameStr);
            workFlowOperations.WaitToSendKeysToTxtBox(bankShortNameLocator, shortBankNameStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);

        }
    }
}
