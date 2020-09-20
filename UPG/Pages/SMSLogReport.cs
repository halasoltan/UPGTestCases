using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Globalization;

namespace UPG.Pages
{
    class SMSLogReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By SmsLogReportIconLocator = By.LinkText("SMS Log Report");
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By statusDropDownLocator = By.CssSelector("#Status");
        public By selectedStatusTypeLocator = By.CssSelector("#Status > option:nth-child(2)");
        public By searchBtnSmsLocator = By.CssSelector("#searchBody > div:nth-child(5) > div > div > button");

        public By gateWayDropDownLocator = By.Id("Gateway");
        public By selectedGateWayTypeLocator = By.CssSelector("#Gateway > option:nth-child(3)");
        public By mobileTxtBoxLocator = By.CssSelector("#MobileNumber");
        public By DateFromTxtboxLocator = By.CssSelector("#StartDate ");
        public By DateToTxtboxLocator = By.CssSelector("#EndDate");// edited
        public By messageSearchLocator = By.XPath("//*[@id=\"divListPanel\"]/div/div[2]/div/table/tbody/tr/td");
        public string invalidDateMessageSearchStr = "There are no items to display";
        public By mobileErrorLocator = By.CssSelector("#MobileNumber-error");
        public string invalidMobileDataStr = "only numeric";
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By eportDowwnLoadBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.exportUrl > span");
        public By refreshBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By bankLocator = By.CssSelector("#BankId");
        string selectedBankLocator; // parameter sent by DB
        //


        //TODO: Function => Search by Bank :Done
        public void SearchForAllSmsLogsByBank() // bankAuditor user
        { // Date from must be 9/8/2020 "Missing call function date" :check That
           // workFlowOperations.searchByDates();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator, selectedBankLocator);
            workFlowOperations.ClickOnBtn(searchBtnSmsLocator);
        }

        public void SearchForAllSmsLogsByStatus () // bankAuditor user
        { // Date from must be 9/8/2020 "Missing call function date"
            
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(statusDropDownLocator, selectedStatusTypeLocator);
            workFlowOperations.ClickOnBtn(searchBtnSmsLocator);
        }

        public void SearchForAllSmsLogsBySelectedGateWay()// bankAuditor user
        { // Date from must be 9/8/2020 "Missing call function date"
          
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(statusDropDownLocator, selectedStatusTypeLocator);
            workFlowOperations.ClickOnBtn(searchBtnSmsLocator);
        }
        public void SearchWithExactMobileNumber(string mobile) // bankAuditor user
        {
            
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            // how to cover exact format of mobile number using send key "201147917471"
            workFlowOperations.SendKeysToTxtBox(mobileTxtBoxLocator, mobile);

            //TODO: check conversion purpose with Hala
            //ToDO : validation n field "201147917471"
            // TODO:  Mina Review   
            string firstCharOfString = StringInfo.GetNextTextElement(mobile, 0);
            
            if (firstCharOfString.Length <= 12 && firstCharOfString[0] ==2) 
            {
                workFlowOperations.ClickOnBtn(searchBtnSmsLocator);
            }

            else
            {
                workFlowOperations.WaitConfirmationMessage(mobileErrorLocator, invalidMobileDataStr);

            }
        }
        //TODO: Function should be common (adding data controls as parameters) : Done in operations check that
        // TODO:  Mina Review   
        public void searchByDates(DateTime dateFrom, DateTime dateTo) // bankAuditor user
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
                    workFlowOperations.ClickOnBtn(searchBtnSmsLocator);
                if (dateFrom <= dateTo)
                {

                }

                else //(dateFrom > dateTo)
                {
                    workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidDateMessageSearchStr);
                }
            }

            // downloading Excel wil be completeed but elements defined
            //*************search by dates need to revised enter invalis format or exact format using mobile number need to be covered and the part of exported file how to locate the file excel which we dW according date and time
        }

        public void DownloadAllSMSLogReportsInExcelSheetFormat() // Bank Auditor user
        {   // search by dates "9/8" to 29/8
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
            //will be completed in export file page

        }

        public void DownloadAllSmsReportsInExcelSheetFormatAfterRefreshingTheSmsData()
        {   // search by dates "9/8" to 29/8
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(refreshBtnLocator);
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }

    }
}
