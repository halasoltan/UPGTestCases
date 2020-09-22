using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class MerchantBranchManagement
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By codeTxtBoxLocator = By.CssSelector("#Code");
        public By nameTxtBoxLocator = By.CssSelector("#Name");
        public By merchantSearchDropDownLocator = By.CssSelector(".k-i-arrow-60-down");
        public By searchBankBtnLocator = By.CssSelector(".btn-block");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By reloadBtnLocator = By.CssSelector(".fa-refresh");

        // Pop up details
        public By detailsCellFieldLocator = By.CssSelector(".row:nth-child(1) .col-xs-6:nth-child(2)");
        public By editBranchBtnLocator = By.CssSelector(".grid-row-selected .btn-warning");
        //pop up Header for edit branch

        public By headerPopUpLocator = By.CssSelector("#Heading");
        string headerEditBranchPopUp = "Merchant Branch Info";






        //Add pop up elements
        public By bankDropDownLocator = By.CssSelector("#BankId");
        public By merchantDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");

        public By merchantBranchCodeTxtBoxLocator = By.CssSelector("#MerchantBranch_Code");
        public By merchantBranchNameTxtBoxLocator = By.CssSelector("#MerchantBranch_Name");
        public By merchantBranchAddressTxtBoxLocator = By.CssSelector("#MerchantBranch_Address");

        public By canRefundCheckBoxLocator = By.CssSelector("#CanRefund");
        public By countryDropDownLocator = By.XPath("//form[@id='uploadForm']/div[2]/div[7]/div/div[2]/span/span/span[2]/span");
        //CssSelector(".k-state-hover > .k-select > .k-icon");// same css
        public By cityDropDownLocator = By.XPath("//form[@id='uploadForm']/div[2]/div[8]/div/div[2]/span/span/span[2]/span");
        //CssSelector(".k-state-hover > .k-select > .k-icon");// same css
        public By merchantBranchFullNameTxtBoxLocator = By.CssSelector("#MerchantBranchFullName");
        public By merchantBranchUserEmailTxtBoxLocator = By.CssSelector("#MerchantBranchUserEmail");

        public By portalLoginUserNameDropDownLocator = By.CssSelector("#PortalLoginTypeId");
        public By merchantBranchUserMobileTxtBoxLocator = By.CssSelector("# TempMerchant_MerchantBranchUserPhone");
        public By saveBtnLocator = By.CssSelector("#btnSave");
        public By notificationMethodDropDownLocator = By.CssSelector("#NotificationId");
        public By addBranchSuccessMsgLocator = By.CssSelector(".alert-success > p");
        string addBranchSuccessMsgStr = " Successfully Register User.";
        string selectedBankStr;
        string selectedMerchantStr;
        string merchantBranchCodeStr;
        string merchantBranchNameStr;
        string merchantBranchAddressStr;
        string selectedCountryStr;
        string selectedCityStr;
        string FullNameStr;
        string emailStr;
        string userNameStr;
        string portalNameStr;
        string mobileStr;
        string notificaionStr;


        public By invalidPhoneTerminalMsgLoctor = By.CssSelector("#TempPhone-error");
        string invalidPhoneTerminalStr = "Invalid Mobile Number";


        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By detailsFieldLocator = By.CssSelector(".grid-row:nth-child(1) .btn-info");
        public By deleteBranchIconLocator = By.CssSelector(".deleteRecord");
        public By confirmDeleteBtnLocator = By.CssSelector(".btn-xs:nth-child(1)");
        public By statusCellTicket = By.CssSelector(".grid-cell:nth-child(6)");


        // TODO:  Mina Review  
        public void AddMerchantBranchManagemnt()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, selectedBankStr);
            workFlowOperations.ChooseFromDropDown(merchantDropDownLocator, selectedMerchantStr);
            workFlowOperations.SendKeysToTxtBox(merchantBranchCodeTxtBoxLocator, merchantBranchCodeStr);
            workFlowOperations.SendKeysToTxtBox(merchantBranchNameTxtBoxLocator, merchantBranchNameStr);
            workFlowOperations.SendKeysToTxtBox(merchantBranchAddressTxtBoxLocator, merchantBranchAddressStr);
            workFlowOperations.ClickOnBtn(canRefundCheckBoxLocator);
            workFlowOperations.ChooseFromDropDown(countryDropDownLocator, selectedCountryStr);
            workFlowOperations.ChooseFromDropDown(cityDropDownLocator, selectedCityStr);

            workFlowOperations.SendKeysToTxtBox(merchantBranchFullNameTxtBoxLocator, FullNameStr);
            workFlowOperations.SendKeysToTxtBox(merchantBranchUserEmailTxtBoxLocator, emailStr);

            workFlowOperations.ChooseFromDropDown(portalLoginUserNameDropDownLocator, portalNameStr);
            if (phoneStr.Length == 10)// phone should be 10 digits
            {
                workFlowOperations.SendKeysToTxtBox(merchantBranchUserMobileTxtBoxLocator, mobileStr);
            }
            else
            {
                workFlowOperations.WaitConfirmationMessage(invalidPhoneTerminalMsgLoctor, invalidPhoneTerminalStr);
            }
          
            workFlowOperations.ChooseFromDropDown(notificationMethodDropDownLocator, notificaionStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);

            workFlowOperations.WaitConfirmationMessage(addBranchSuccessMsgLocator, addBranchSuccessMsgStr);
        }

        // TODO:  Mina Review

        public void DownloadBranchesList()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }
        // TODO:  Mina Review
        public void SearchForBaranchUsingCodeAndViewDetailsThenEdit()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(codeTxtBoxLocator, merchantBranchCodeStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.ClickOnBtn(detailsFieldLocator);
          string details =   workFlowOperations.ExtractDataFromText(detailsCellFieldLocator);
            Console.WriteLine("Details is" + details);
            workFlowOperations.ClickOnBtn(editBranchBtnLocator);
            workFlowOperations.WaitConfirmationMessage(headerPopUpLocator, headerEditBranchPopUp);
            workFlowOperations.SendKeysToTxtBox(merchantBranchCodeTxtBoxLocator, merchantBranchCodeStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);


        }
        public void SearchForBaranchUsingMerchant()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(merchantSearchDropDownLocator, selectedMerchantStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
        }
        
         public void SearchForBaranchUsingName()
         {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(nameTxtBoxLocator, merchantBranchNameStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
        }




       
        public void DeleteMerchantBranchThenCheckReloadPage()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(merchantBranchCodeTxtBoxLocator, merchantBranchCodeStr);
            workFlowOperations.ClickOnBtn(searchBankBtnLocator);
            workFlowOperations.waitForPageLoaded();
          string beforeDelete =   workFlowOperations.ExtractDataFromText(statusCellTicket);
            workFlowOperations.ClickOnBtn(deleteBranchIconLocator);
            workFlowOperations.WaitToClickOnBtn(confirmDeleteBtnLocator);
            workFlowOperations.waitForPageLoaded();
            string afterDelete = workFlowOperations.ExtractDataFromText(statusCellTicket);
            if(beforeDelete != afterDelete)
            {
                Console.WriteLine("Status is changed to delete " + afterDelete);
            }
        }



        // Reload



    }
}
