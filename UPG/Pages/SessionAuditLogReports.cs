using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class SessionAuditLogReports
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.Id("searchHeader");
        public By DateFromTxtboxLocator = By.Id("StartDate ");
        public By DateToTxtboxLocator = By.Id("EndDate");// edited
        public By searchBtnSessionLocator = By.CssSelector("#searchBody > div:nth-child(3) > div > button");
        public By messageSearchLocator = By.XPath("//*[@id=\"divListPanel\"]/div/div[2]/div/table/tbody/tr/td");
        public string invalidDateMessageSearchStr = "There are no items to display";

        public By optionBtnLocator = By.CssSelector(".rotate");
        public By dwwnloadBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.exportUrl > span");
        public By refreshBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By sessionAuditLogLocator = By.LinkText(" Session Audit Log ");
        public By SmsLogReportIconLocator = By.LinkText("SMS Log Report");
        public By userStatusReportIconLocator = By.LinkText("User Status Report");
        public By auditLogReportsIconLocator = By.CssSelector("#bs-sidebar-navbar-collapse-1 > ul > li.dropdown > a");
        public By userNameIconLocator = By.LinkText("User Name");
        public By sessionStartTimeIconLocator = By.LinkText("Session Start Time");
        public By sessionDurationIconLocator = By.LinkText("Session Duration");
        public By actionsCountIconLocator = By.LinkText("Actions Count");
        public By detailsIconLocator = By.LinkText("Details");









        public void searchByDates(DateTime dateFrom, DateTime dateTo)
        {
            bool dateEntered = false;
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);

            if ((dateFrom == null) && (dateTo == null))
            {
                //invalidDateMessageSearchStr => no items to Display
                workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidDateMessageSearchStr);
            }
            else
            {
                if (dateFrom != null)
                {
                    workFlowOperations.selectDatesFromcalender(DateFromTxtboxLocator, dateFrom);
                    dateEntered = true;
                }
                if (dateTo != null)
                {
                    workFlowOperations.selectDatesFromcalender(DateToTxtboxLocator, dateTo);
                    dateEntered = true;
                }

                if (dateEntered)
                    workFlowOperations.ClickOnBtn(searchBtnSessionLocator);
                if (dateFrom <= dateTo)
                {

                }

                else //(dateFrom > dateTo)
                {
                    workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidDateMessageSearchStr);
                }
            }

            
        }

       /* public void AttemptDownloadingAllLogReportsInExcelSheetFormat()//BankAuditorUser
        {

        }*/

    public void CheckingTheBankAuditorUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(sessionAuditLogLocator);
        }
        public void CheckingTheBankAuditorUiSmsLeftSide()//BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(SmsLogReportIconLocator);
        }
        public void CheckingUserStausUiLeftSide()//BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(userStatusReportIconLocator);
        }
        public void CheckingexportDownloadLeftSide()//BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(exportedDwFilesIconLocator);
        }
        public void CheckTheSessionAuditLogPageUi() //BankAuditorUser
        {
            workFlowOperations.selectFromDropDownList(auditLogReportsIconLocator, sessionAuditLogLocator);
        }

        public void CheckingsessionAuditLogTableUserNameUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(userNameIconLocator);
        }
        public void CheckingsessionAuditLogTableSessionStartTimeUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(sessionStartTimeIconLocator);
        }
      
        public void CheckingsessionAuditLogTableSessionDurationUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(sessionDurationIconLocator);
        }
        public void CheckingsessionAuditLogTableActionsCountUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(actionsCountIconLocator);
        }
        public void CheckingsessionAuditLogTableDetailsUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(detailsIconLocator);
        }




    }
}
