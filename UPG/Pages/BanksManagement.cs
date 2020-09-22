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
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By reloadBtnLocator = By.CssSelector(".fa-refresh");
      
       
        public By detailsIconBtnLocator = By.CssSelector(".grid-row-selected .glyphicon-info-sign");
        public By detailsFieldLocator = By.CssSelector(".row:nth-child(2) .col-xs-6:nth-child(2)");
        public By saleTransactionSmsTemplateBtnLocator = By.CssSelector(".grid-row-selected > .grid-cell:nth-child(7) .btn-info");
        public By minIconTemplateLocator = By.CssSelector("#MN");
        public By saveTemplateLocator = By.CssSelector("#btnSave");
        public By saleTrnSaveMsgLocator = By.CssSelector("p:nth-child(3)");
        string saleTrnSaveMsgStr = "Transaction SMS template has been updated.";
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By editIconBtnLocator = By.CssSelector(".grid-row:nth-child(1) .btn-warning");
        // TODO:  Mina Review   
        public void SearchByBankShortName(string bankShortNameStr)
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(bankShortNameLocator, bankShortNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(detailsIconBtnLocator);
            workFlowOperations.ExtractDataFromText(detailsFieldLocator);
        }
        // TODO:  Mina Review   
        public void SearchByBankNameandViewDetails(string bankNameStr)
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(banktNameLocator , bankNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(detailsIconBtnLocator);
            workFlowOperations.ExtractDataFromText(detailsFieldLocator);


        }
        // TODO:  Mina Review   
        public void CreateBank()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
        }
        // TODO:  Mina Review   
        public void ViewTxnSmsTemplate()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(banktNameLocator, bankNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(saleTransactionSmsTemplateBtnLocator);
            workFlowOperations.WaitToClickOnBtn(minIconTemplateLocator);
            workFlowOperations.ClickOnBtn(saveTemplateLocator);
            workFlowOperations.WaitConfirmationMessage(saleTrnSaveMsgLocator, saleTrnSaveMsgStr);
        }
        // TODO:  Mina Review   
        public void DownloadBanksList()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }
        // TODO:  Mina Review   
        public void EditBankPages()
        {
            workFlowOperations.ClickOnBtn(editIconBtnLocator);
        }
        // Reload method
    }
}
