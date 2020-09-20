using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class TerminalManagementTerminalList
    {

        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By searchBtnLocator = By.CssSelector(".btn-block");
        public By terminalTypeDropDownLocator = By.CssSelector("#TerminalTypeId");
        string terminalTypeStr;
        public By terminalIdTxtBoxLocator = By.CssSelector("#TerminalId");
        string terminalIdStr;
        public By terminalSerialTxtBoxLocator = By.CssSelector("#TerminalSerial");
        string terminalSerialStr;
        public By noteIdTxtBoxLocator = By.CssSelector("#TerminalRefId");
        string noteIDStr;
        public By updateStatusDropDownLocator = By.CssSelector("#IsUpdated");
        string updateStatusStr;
        public By lastUpdatesTxtBoxLocator = By.CssSelector("#LastUpdate");
        string lastUpdatesStr;
        public By acquirerMerchantIdDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        string acquirerMerchantIdStr;
        public By bankDropDownLocator = By.CssSelector("#BankId");
        string bankStr;
        public By merchantDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        string merchantStr;
        public By terminalNameTxtBoxLocator = By.CssSelector("#TerminalName");
        string terminalNameStr;
        public By batchIdTxtBoxLocator = By.CssSelector("#BulkTerminalMasterId");
        string batchId;
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By reloadBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By detailsTerminalBtnLocator = By.CssSelector(".grid-row:nth-child(1) .btn-info");
        public By bankDetailsFieldLocator = By.CssSelector(".panel:nth-child(1) > .row:nth-child(2) > .form-group:nth-child(1) > .col-sm-3:nth-child(2)");
        public By viewMerchantTerminalBtnLocator = By.CssSelector(".grid-row:nth-child(1) .btn-success");
        public By editTerminalBtnLocator = By.CssSelector(".grid-row:nth-child(1) div > .btn");
        public By deleteTerminalBtnLocator = By.CssSelector(".grid-row:nth-child(1) #btnDelete");
        public By confirmDeleteRouteBtnLocator = By.CssSelector(".btn-xs:nth-child(1)");
        public By terminalIdCellLocator = By.CssSelector(".grid-row:nth-child(1) > .grid-cell:nth-child(2)");
        // TODO:  Mina Review  
        public void DownloadExchangeRates()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }
        // TODO:  Mina Review  
        public void CreateTerminal()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(plusAddBtnLocator);
            workFlowOperations.waitForPageLoaded();
            //********************************* completed in Deploy Terminal
        }

        // TODO:  Mina Review  
        public void SerchForTerminalListToViewDetails()
        {
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(detailsTerminalBtnLocator);
            workFlowOperations.ExtractDataFromText(bankDetailsFieldLocator);
        }
        // TODO:  Mina Review  
        public void SerchForTerminalListToViewMerchant()
        {
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(viewMerchantTerminalBtnLocator);
            /*https://172.16.25.26/Portal/MerchantManagement/Merchants?TerminalNodeId=46*/
            //https://172.16.25.26/Portal/TerminalManagement/Terminals
            //Discuss with Mina
        }

        // TODO:  Mina Review  
        public void EditTerminalListToViewMerchant()
        {
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(editTerminalBtnLocator);
            // think edit with Mina
        }

        // TODO:  Mina Review  
        public void deleteTerminalListToViewMerchantAndVerifyReload()
        {
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            string beforeDelete = workFlowOperations.ExtractDataFromText(terminalIdCellLocator);
            workFlowOperations.ClickOnBtn(deleteTerminalBtnLocator);
            workFlowOperations.WaitToClickOnBtn(confirmDeleteRouteBtnLocator);
            string afterDelete = workFlowOperations.ExtractDataFromText(terminalIdCellLocator);
           
            if(beforeDelete != afterDelete)
            {
                Console.WriteLine("Reload is done ");
            }
            else
            {
                Console.WriteLine("Error in Reload");
            }
        }







    }
}
