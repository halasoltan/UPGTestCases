using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class ManageUsers
    {
        public IWebDriver driver;
        Operations workFlowOperations = Operations.Instance;
        public By manageUsersIconLocator = By.LinkText("Manage Users");
        public By resetIconLocator = By.XPath("//*[@id=\"divListPanel\"]/div[2]/div/table/tbody/tr/td[10]/b/a");
        public By userNameManageUsersIconLocator = By.CssSelector("#UserName");
        string userNameResetStr;
        string invalidUserStr;
        string errorDWExcelStr = "can't export empty list.";
        public By searchManageUsersBtnLocator = By.Id("#searchBody > div:nth-child(5) > div > div > button");
        public By resetPasswordPopUpLocator = By.Id("Heading");
        public By confirmResetBtnLocator = By.Id("btnSave");
        public By changeStausIconLocator = By.CssSelector(".btn-success");
        public By statusDropDownLocator = By.CssSelector("#status");
        public By selectedstatusLocator = By.CssSelector("#status > option:nth-child(2)");
        public By saveStatusLocator = By.CssSelector("#btnSave");
        public By statementStatusLocator = By.XPath("//*[@id=\"divListPanel\"]/div[2]/div/table/tbody/tr/td[8]");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By eportDowwnLoadBtnLocator = By.CssSelector(".fa-download");
        public By refreshBtnLocator = By.CssSelector("fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText("Exported Files Downloads");
        public By downLaodFileBtnLocator = By.XPath("#divListPanel > div > div.grid-mvc > div > table > tbody > tr:nth-child(1) > td.grid-cell.cell-center > b > div > a");
        public By exportedDwFilesMessageLocator = By.CssSelector(".k-widget > .alert");
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By plusIconLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a:nth-child(3) > span");
        string addUserstr = "Your request have been submitted for approval, Pipeline ID 193";
        public By addUserLocator = By.CssSelector(".alert:nth-child(1) > p"); 
        public By searchManageUserBtnLocator = By.CssSelector(".btn-block");// Bank user Adminstrator user
        public By editIconUserBtnLocator = By.CssSelector(".btn-md");// Bank user Adminstrator user
        public By editUserMessageLocator = By.CssSelector(".alert:nth-child(1) > p");
        public void CheckAggregatorCallCenterCanResetAnyUserpassword() // pass //AggregatorCallCenter
        {
            // select user using search then change password

            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.ClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.ClickOnBtn(resetIconLocator);
            // verify on pop up message apppear
            workFlowOperations.ExtractDataFromText(resetPasswordPopUpLocator);
            workFlowOperations.ClickOnBtn(confirmResetBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // Then check mail of UPG manually with new password 
            // Do you want to cover it in Automation access of out look? 
            //TODO: Verification to be done with Database
        }
        public void CheckThatAggregatorCallCenterCanIndicateWhetherUserIsOnline() //AggregatorCallCenter
        {

            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.ClickOnBtn(searchManageUsersBtnLocator);
            // to verify on icon status
            // think with you mina
            // not completed as user should viewed by another PC
            //TODO: opening user in other session i.e. incognito mode
            //TODO : Don't Know
        }


        public void CheckThatAggregatorCallCenterCanDeactivateActiveUsers() //AggregatorCallCenter
        {

            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(changeStausIconLocator);
            workFlowOperations.ClickOnBtn(selectedstatusLocator);
            workFlowOperations.ClickOnBtn(saveStatusLocator);
            workFlowOperations.waitForPageLoaded();
            // return string "InActive" in TC call
            //  workFlowOperations.ExtractDataFromText(statementStatusLocator); will be called in TC
            //TODO: Verification to be done with Database

        }

        public void CheckThatAggregatorCallCenterCanActivateInactiveUsers() //AggregatorCallCenter
        {

            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToSendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(changeStausIconLocator);
            workFlowOperations.ClickOnBtn(selectedstatusLocator);
            workFlowOperations.ClickOnBtn(saveStatusLocator);
            workFlowOperations.waitForPageLoaded();
            // return string "Active" in TC call
            workFlowOperations.ExtractDataFromText(statementStatusLocator);

            //TODO: Verification to be done with Database
        }

        public void CheckThatAggregatorCallCenterCanExportUserData() //AggregatorCallCenter
        {


            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
            workFlowOperations.waitForPageLoaded();
            //complete in another page

        }

        public void CheckThatAggregatorCallCenteCannotExportUserDataWhenListHasNoData() //AggregatorCallCenter
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToSendKeysToTxtBox(userNameManageUsersIconLocator, invalidUserStr);
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.WaitConfirmationMessage(exportedDwFilesMessageLocator, errorDWExcelStr);

        }

        public void CheckThedownloadUserStatusReportDataAfterRefreshingSettlementList() //AggregatorCallCenter
        {

            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(refreshBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // steps is completed but how to verify data updated

        }
        public void CheckTheSystemNoDisplayAnyDataWhenAggregatorCallCenterPressSearchWithoutFillingAnySearchParameter()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // action should be verified by the system

        }





        // TODO: Function => System admin can delete 



        // TODO: Function => Bank users administrator can edit
        // TODO: Mina Review
        public void CheckThatSystemDisplayEditUserDataPageForBankUsersAdministrator ()
        { // Test Data Prep "choose user doesn't have request in approval pipeline in "bank admin super approver"
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.ClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.ClickOnBtn(editIconUserBtnLocator);
            // completed in edit user page "EditUser"


        }



        // TODO: Function =>Bank users administrator can Add user
        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCanResetAnyUsersPassword()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(plusIconLocator); // completed in another page "add user reg."


        }
        // TODO: Mina Reviewed
        public Boolean VerifyAddUserDataOnPage(string addUserstr)
        {
            Boolean x = false;
            IWebElement title = driver.FindElement(addUserLocator);
            string z = title.Text.Trim();
            if (z.Contains("Your request have been submitted for approval, Pipeline ID"))
            {
                x = true;
            }
            return x;

        }
        // TODO: Mina Reviewed
        public Boolean VerifyEditUserDataOnPage(string addUserstr)
        {
            Boolean x = false;
            IWebElement title = driver.FindElement(editUserMessageLocator);
            string z = title.Text.Trim();
            if (z.Contains("Your request have been submitted for approval, Pipeline ID"))
            {
                x = true;
            }
            return x;

        }
        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCannotEditUserDataWhenEnterInvalidData()
        {
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.ClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.ClickOnBtn(editIconUserBtnLocator);

        }
        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCanDeactivateActiveUsers ()
        {
            workFlowOperations.WaitToClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(userNameManageUsersIconLocator, userNameResetStr);
            workFlowOperations.ClickOnBtn(searchManageUsersBtnLocator);
            workFlowOperations.ClickOnBtn(changeStausIconLocator);
            workFlowOperations.selectFromDropDownList(statusDropDownLocator, selectedstatusLocator);
            workFlowOperations.ClickOnBtn(saveStatusLocator);


        }



    }


}



    



    

