using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class TransactionsRoutesManagement
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankDropDownLocator = By.CssSelector("#BankId");
        string selectedBankStr;
        public By hostTypeDropDownLocator = By.CssSelector("#HostRefId");
        string hostStr;
        public By BinTxtBoxLocator = By.CssSelector("#DateTo");
        string BinStr;
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By reloadtBtnLocator = By.CssSelector(".fa-refresh");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        public By searchBtnLocator = By.CssSelector(".btn-block");
        public By routesInfoHeaderLocator = By.CssSelector("#Heading");
        // For Pop up Add Routes 
        public By routeBankDropDownLocator = By.CssSelector("#Route_BankId");
        string RouteBankStr;
        public By hostRouteDropDownLocator = By.CssSelector("#HostRefId");
        string hostRouteStr;
        public By routeBinTxtLocator = By.CssSelector("#Route_Bin");
        string routeBinStr; // should be at least 6 chars
        public By saveRoutesBtnLocator = By.CssSelector("#btnSave");
        public By errorBinMsgLocator = By.CssSelector("#Route_Bin-error");
        string errorBinMsgStr = "Please enter at least 6 characters.";
        public By requiredBankMsgLocator = By.CssSelector("#Route_BankId-error");
        string requiredBankMsgStr = "The BankId field is required.";
        public By requiredHostMsgLocator = By.CssSelector("#Route_HostRefId-error");
        string requiredHostMsgStr = "The HostRefId field is required.";
        public By requiredBinMsgLocator = By.CssSelector("#Route_Bin-error");
        string requiredBintMsgStr = "This field is required.";
        public By editRoutesBtnLocator = By.CssSelector(".btn-warning");
        public By deleteRouteBtnLocator = By.CssSelector(".deleteRecord");
        public By confirmDeleteRouteBtnLocator = By.CssSelector(".btn-xs:nth-child(1)");
        public By binCreatedBeforeMsgLocator = By.CssSelector(".validation-summary-errors li");
        string binCreatedBeforeMsgStr = "This BIN already used before with this bank!";
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By exportedDwFilesIconLocator = By.LinkText("Exported Files Downloads");
        // TODO:  Mina Review  

        public void AddRoutesManagement()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.ExtractDataFromText(routesInfoHeaderLocator);
            workFlowOperations.ChooseFromDropDown(routeBankDropDownLocator, RouteBankStr);
            workFlowOperations.ChooseFromDropDown(hostRouteDropDownLocator, hostRouteStr);
            if (routeBinStr.Length == 6)
            {
                workFlowOperations.SendKeysToTxtBox(routeBinTxtLocator, routeBinStr);
            }
            else
            {
                workFlowOperations.WaitConfirmationMessage(errorBinMsgLocator, errorBinMsgStr);
            }
            workFlowOperations.ClickOnBtn(saveRoutesBtnLocator);
        }
        // TODO:  Mina Review  
        public void AddRoutesManagementWithoutEntertData()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.ExtractDataFromText(routesInfoHeaderLocator);
            workFlowOperations.ClickOnBtn(saveRoutesBtnLocator);
            workFlowOperations.WaitConfirmationMessage(requiredBankMsgLocator , requiredBankMsgStr);
            workFlowOperations.WaitConfirmationMessage(requiredHostMsgLocator, requiredHostMsgStr);
            workFlowOperations.WaitConfirmationMessage(requiredBinMsgLocator, requiredBintMsgStr);
        }


        // TODO:  Mina Review  
        public void SearchAndEditForTransactionRoute()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(BinTxtBoxLocator, routeBinStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(editRoutesBtnLocator);
            workFlowOperations.ChooseFromDropDown(routeBankDropDownLocator, RouteBankStr);
            workFlowOperations.ChooseFromDropDown(hostRouteDropDownLocator, hostRouteStr);
            workFlowOperations.ClickOnBtn(saveRoutesBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review  
        public void DeleteTransactionRoute()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(BinTxtBoxLocator, routeBinStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(deleteRouteBtnLocator);
            workFlowOperations.WaitToClickOnBtn(confirmDeleteRouteBtnLocator);
        }
        // TODO:  Mina Review  
        public void CreateRoutesTransactionExistedBefore()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.ExtractDataFromText(routesInfoHeaderLocator);
            workFlowOperations.ChooseFromDropDown(routeBankDropDownLocator, RouteBankStr);
            workFlowOperations.ChooseFromDropDown(hostRouteDropDownLocator, hostRouteStr);
            if (routeBinStr.Length == 6)
            {
                workFlowOperations.SendKeysToTxtBox(routeBinTxtLocator, routeBinStr);
            }
            else
            {
                workFlowOperations.WaitConfirmationMessage(errorBinMsgLocator, errorBinMsgStr);
            }
            workFlowOperations.ClickOnBtn(saveRoutesBtnLocator);
            workFlowOperations.WaitConfirmationMessage(binCreatedBeforeMsgLocator, binCreatedBeforeMsgStr);
        }
        // TODO:  Mina Review   
        public void CheckThatUserCanExportUserData()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
            workFlowOperations.waitForPageLoaded();
            //complete in another page

        }



        // TODO:  Mina Review 

        public void ReloadRoutesManagement()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(reloadtBtnLocator);
            // need verify

        }


    }
}
