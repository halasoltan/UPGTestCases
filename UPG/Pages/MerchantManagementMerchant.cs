using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class MerchantManagementMerchant
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By upgMerchantIdLocator = By.CssSelector(".k-state-focused > .k-select > .k-icon");
        public By acqMerchantIdLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        public By merchantStatusLocator = By.CssSelector("#MerchantStatus");
        public By creationDateFromLocator = By.CssSelector("#CreationDateFrom");
        public By parentMerchantLocator = By.XPath("//div[@id='searchBody']/div[5]/div/div/span/span/span[2]/span");
        public By documentsReceivedLocator = By.CssSelector("#IsDocumentsReceived");
        public By merchantNameLocator = By.XPath("//div[@id='searchBody']/div/div/div[2]/span/span/span[2]/span");
        public By categoryCodeLocator = By.XPath("//div[@id='searchBody']/div[2]/div/div[2]/span/span/span[2]/span");
        public By bankDropDownLocator = By.CssSelector("#BankId");
        public By creationDateToLocator = By.CssSelector("#CreationDateTo");
        public By batchIdLocator = By.CssSelector("#BulkMerchantMasterId");
        public By aggregatorLocator = By.CssSelector("#AggregatorId");
        public By searchBtnLocator = By.CssSelector(".btn-block");
        string MerchantIdStr;
        string acqMerchantStr;
        string merchantStatusStr;
        string creationDateStr;
        string parentMerchantStr;
        string documentStr;
       
        string categoryCodeStr;
        string selectedBankStr;
        string creationDateToStr;
        string batchStr;
        string aggregator;
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddbulkLocator = By.CssSelector(".fa-plus");
        public By reloadtBtnLocator = By.CssSelector(".fa-refresh");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By exportedDwFilesIconLocator = By.LinkText("Exported Files Downloads");
        public By exportMdrBtnLocator = By.CssSelector(".exportmdr > .fa");
        public By exportBtnLocator = By.CssSelector(".exportUrl > .fa");
        // TODO:  Mina Review   
        public void SearchByUpgMerchantID()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(upgMerchantIdLocator, MerchantIdStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByAcqMerchantID()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(acqMerchantIdLocator, acqMerchantStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByMerchantStatus()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(merchantStatusLocator, merchantStatusStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void SearchByCreationDateFrom()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(creationDateFromLocator, creationDateStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByParentMrechantId()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(parentMerchantLocator, parentMerchantStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByDocumentReceived()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(documentsReceivedLocator, documentStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByMerchantName(string merchantNameStr)
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(merchantNameLocator, merchantNameStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByCategoryCode()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(categoryCodeLocator, categoryCodeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        
        
        // TODO:  Mina Review   
        public void SearchByBank()
        {  
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, selectedBankStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }


        // TODO:  Mina Review   
        public void SearchByCreationDateTo()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(creationDateToLocator, creationDateToStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review   
        public void SearchByBatchId()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(batchIdLocator,batchStr );
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }



        // TODO:  Mina Review   
        public void SearchByAggregator()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(aggregatorLocator, aggregator);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
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
        public void CheckThatUserCanExportMdrUserData()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(exportMdrBtnLocator);
            workFlowOperations.waitForPageLoaded();
          
            //DW in the same page
        }
        // TODO:  Mina Review   

        public void ReloadBulkMerchant()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(reloadtBtnLocator);

        }



        // TODO:  Mina Review  
        public void AddMerchant()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddbulkLocator);

        }
        
    }
}
