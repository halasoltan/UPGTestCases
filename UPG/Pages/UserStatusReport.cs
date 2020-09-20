
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Globalization;


namespace UPG.Pages
{
    class UserStatusReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By userStatusReportIconLocator = By.LinkText("User Status Report");
        public By selectParametersBtnLocator = By.Id("searchHeader");
        public By userNameStatusLocator = By.CssSelector("#UserName");
        public By fullNameStausLocator = By.CssSelector("#FullName");
        public By emailStatusLocator = By.CssSelector("#Email");
        public By phoneStatusLocator = By.CssSelector("#Phone");
        public By userRuleStatusDropDownLocator = By.CssSelector("#UserRole");
        public By selectedUsereRuleStatusDropDownLocator = By.CssSelector("#UserRole > option:nth-child(5)");
        public By userStausDropDownLocator = By.CssSelector("#Status");
        public By selecteduserStausLocator = By.CssSelector("#Status > option:nth-child(2)");
        public By searchUserStatusLcator = By.CssSelector("#searchBody > div:nth-child(5) > div > div > button");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By dwwnloadBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.exportUrl > span");
        public By refreshBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        //public By invalidMobileDataLocator = By.CssSelector("#MobileNumber-error");
        //string invalidMobileDataStr = "only numeric";
        public By messageSearchLocator = By.CssSelector("#divListPanel > div.grid-mvc > div > table > tbody > tr > td");
        public string invalidMessageSearchStr = "There are no items to display";
        public By merchantDropDownLocator = By.CssSelector("#searchBody > div:nth-child(4) > div > div > span > span > span.k-select > span");
        public By selectedMerchantDropDownLocator = By.CssSelector("#merchantRefID_listbox > li.k-item.k-state-hover");
     
        public By eportDowwnLoadBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.exportUrl > span");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By exportedDwFilesMessageLocator = By.CssSelector("");
        string errorDWExcelStr = "can't export empty list.";


        //aggregator call ceter
        public void SearchForSpecificUserStatusReport (string UserName , string FullName , string Email , string Phone )
        {
           
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameStatusLocator, UserName);
            workFlowOperations.SendKeysToTxtBox(fullNameStausLocator, FullName);
            workFlowOperations.SendKeysToTxtBox(emailStatusLocator, Email);
            workFlowOperations.SendKeysToTxtBox(phoneStatusLocator, Phone);
            workFlowOperations.selectFromDropDownList(userRuleStatusDropDownLocator , selectedUsereRuleStatusDropDownLocator);
            workFlowOperations.selectFromDropDownList(userStausDropDownLocator, selecteduserStausLocator);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);

        }

        //TODO: Function name should be fixed
        //TODO: Mina reviewed
        public void SearchForUserStatusWithInvalidEmail(string Email)
        {   // test data for mail should be invalid
           
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(emailStatusLocator, Email);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);
        }



        // Invalid phone number
        public void SearchWithExactMobileNumber(string phone)
        {
            
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(phoneStatusLocator, phone);
            //TODO: check conversion with Hala
                workFlowOperations.ClickOnBtn(searchUserStatusLcator);
        }

        //TODO: check function parameter with Hala : Not exist in page
        //1.Open the website   2.log in as call center  3.Click user status report page at the side menu
       public void CheckIfThereIsNoDataShownAtUserListTable ()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidMessageSearchStr);
        }

       public void CheckIfUserEntersTheSearchParametersWithUnMatchedSearchResults (string UserName)
        { // Test data invalid user name
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameStatusLocator, UserName);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);
            workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidMessageSearchStr);

        }
        public void CheckSearchingWithDropDownMenuValues ()
        {
            // Test Data Preparation , select correct merchant from drop down menu "Merchant Test001 Name"
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(merchantDropDownLocator, selectedMerchantDropDownLocator);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);

        }

        public void CheckThatTheUserCanDownloadTheUserStatusDataInExcelFormat() //AggregatorCallCenter
        {


            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);      
            //complete in another page
        }
        public void CheckIfUserSearchedForSpecificReportItIsDisplayedWhenExportingTheUserStatusData (string UserName)
        { // Test Data Prep valid user name
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameStatusLocator, UserName);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);

        }
        public void CheckResultsInExcelSheetWhenDownloadingEmptyListOfUserStatusReport(string UserName)
        { // Test Data Prep invalid user name
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameStatusLocator, UserName);
            workFlowOperations.ClickOnBtn(searchUserStatusLcator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.WaitConfirmationMessage(exportedDwFilesMessageLocator, errorDWExcelStr);
        }
       public void CheckThatUserCanRefreshTheUserStatusList()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(refreshBtnLocator);
            // Make sure of refresh in DB
        }

        public void CheckDownloadOfTheUserStatusReportDataAfterRefreshingTheSettlementList ()
        {
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(refreshBtnLocator);
            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // Make sure of refresh in DB
        }
       




    }
}
