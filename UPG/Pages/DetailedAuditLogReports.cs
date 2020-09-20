using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class DetailedAuditLogReports
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By DateFromTxtboxLocator = By.CssSelector("#StartDate");
        public By DateToTxtboxLocator = By.CssSelector("#EndDate");// edited
        public By searchBtnDetailedLocator = By.CssSelector("#searchBody > div:nth-child(8) > div > button");
        public By messageSearchLocator = By.XPath("//*[@id=\"divListPanel\"]/div/div[2]/div/table/tbody/tr/td");
        public string invalidDateMessageSearchStr = "There are no items to display";
        public By sessionAuditIdTxtboxLocator = By.Id("AuditId");
        public By auditLogIdTxtboxLocator = By.Id("AuditLogId");
        public By merchantDropDownLocator = By.CssSelector("#searchBody > div:nth-child(6) > div:nth-child(1) > div > div > span > span > span.k-select > span");
        public By selectedMerchantLocator = By.CssSelector("#merchantRefID_listbox > li:nth-child(9)");
        
        public By operationTypeDropDownLocator = By.CssSelector("#searchBody > div:nth-child(5) > div:nth-child(1) > div > div > div > div.k-widget.k-multiselect.k-header > div");
        public By selectedOperationType = By.Id("656d0972-4cb5-48ad-b681-db7bb2215e17");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By exportDownLoadBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.exportUrl > span");
        public By refreshBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By auditLogIdTableLocator = By.LinkText("Audit Log Id");
        public By actionDateTableLocator = By.LinkText("Action Date");
        public By makerTableLocator = By.LinkText("Maker");
        public By checkerTableLocator = By.LinkText("Checker");
        public By ipAddressTableLocator = By.LinkText("IP Address");
        public By operationTypeTableLocator = By.LinkText("Operation Type");
        public By actionDetailsTableLocator = By.LinkText("Action Type");
        public By destinationNameTableLocator = By.LinkText("Action Details");
        public By auditSamplesTableLocator = By.LinkText("Destination Name");
        public By detailsFieldTableLocator = By.LinkText("Audit Sample");
        public By detailsTableLocator = By.LinkText("Details");
        public By auditLogReportsIconLocator = By.CssSelector("#bs-sidebar-navbar-collapse-1 > ul > li.dropdown > a");
        public By detailedAuditLogIconLocator = By.LinkText(" Detailed Audit Log ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By makerUserLocator = By.CssSelector("#searchBody > div:nth-child(4) > div:nth-child(1) > div > div > span > span > span.k-select > span");
        public By selectedMakerUserLocator = By.CssSelector("#makerUserId_listbox > li:nth-child(4)");
        public By checkUserLocator = By.CssSelector("#searchBody > div:nth-child(4) > div:nth-child(2) > div > div > span > span > span.k-select > span");
        public By selectedCheckUserLocator = By.CssSelector("#approvalUserId_listbox > li:nth-child(8)");
        public By actionTypeLocator = By.CssSelector("#searchBody > div:nth-child(5) > div:nth-child(2) > div > div > div > div.k-widget.k-multiselect.k-header > div");
        public By selectedactionTypeLocator = By.CssSelector("#ActionTypes_listbox > li:nth-child(2)");
        public By userLocator = By.CssSelector("#searchBody > div:nth-child(6) > div:nth-child(2) > div > div > span > span > span.k-select > span");
        public By selectedUserLocator = By.CssSelector("#userId_listbox > li:nth-child(27)");
        public By bankLocator = By.CssSelector("#BankId");
        string selectedbankLocator; // from DB Query
        public By ipAddressLocator = By.CssSelector("#IPAddress");





        // TODO: check with Hala collective function for all methods verifying titles
        // TODO: Mina Review
        public void CheckingTheDetailedAuditLogIdTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(auditLogIdTableLocator);
        }
        public void CheckingTheDetailedAuditLogActionDateTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(actionDateTableLocator);
        }
        public void CheckingTheDetailedAuditLogMakerTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(makerTableLocator);
        }
        public void CheckingTheDetailedAuditLogCheckerTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(checkerTableLocator);
        }
        public void CheckingTheDetailedAuditLogIpAddressTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(ipAddressTableLocator);
        }
        public void CheckingTheDetailedAuditLogOperationTypeTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(operationTypeTableLocator);
        }
        public void CheckingTheDetailedAuditLogActionDetailsTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(actionDetailsTableLocator);
        }
        public void CheckingTheDetailedAuditLogDestinationNameTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(destinationNameTableLocator);
        }
        public void CheckingTheDetailedAuditLogAuditSamplesTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(auditSamplesTableLocator);
        }
        public void CheckingTheDetailedAuditLogDetailsFieldTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(detailsFieldTableLocator);
        }
        public void CheckingTheDetailedAuditLogDetailsTablePageUI() //BankAuditorUser
        {
            workFlowOperations.ExtractDataFromText(detailsTableLocator);
        }

        public void AttemptDownloadingExcelSheetReportContainingSpecificListOfTransactions ()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            //search by dates function 9/8 to 11/8
            // TODO: check with Hala Date searching purpose 
            // TODO: check with Mina in operation 
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(exportDownLoadBtnLocator);
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);


        }

        public void DownloadAllDetailedLogReportsInExcelSheetFormatAfterRefreshingTheSessionLogData() //Bank Auditor user
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            // TODO: check with Hala Date searching purpose 
            //search by dates function 9/8 to 11/8
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(refreshBtnLocator);

        }





        public void searchByDates(DateTime dateFrom, DateTime dateTo)//Bank Auditor
        {
            bool dateEntered = false;
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);

            if ((dateFrom == null) && (dateTo == null))
            {
                // TODO: invalidDateMessageSearchStr => no items to Display
                // TODO: Mina Review
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
                    workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
                if (dateFrom <= dateTo)
                {
                    // TODO: Valid search operation verification 
                    // TODO: will be from DB?// TODO: Mina Review
                }

                else //(dateFrom > dateTo)
                {
                    workFlowOperations.WaitConfirmationMessage(messageSearchLocator, invalidDateMessageSearchStr);
                }
            }

        


    }

        public void SearchBySessionAuditID(string Id) //BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(sessionAuditIdTxtboxLocator, Id);
            // TODO: check with Hala Id conversion
            // TODO: AS id is number
            // TODO: Mina Review
            int id = Int32.Parse(Id);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }

        public void SearchByAuditLogID(string Id)//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(auditLogIdTxtboxLocator, Id);
            // TODO: check with Hala Id conversion
            int id = Int32.Parse(Id);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO: Function => search by Maker user
        // TODO: Mina Review
        public void SearchByMakeruser()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(makerUserLocator, selectedMakerUserLocator); 
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();

        }
        // TODO: Function => search by check user
        // TODO: Mina Review
        public void SearchByCheckUser()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(checkUserLocator, selectedCheckUserLocator);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();

        }

        // TODO: Function => search by action type
        // TODO: Mina Review
        public void SearchByActionType()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(actionTypeLocator, selectedactionTypeLocator);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();

        }

        // TODO: Function => search by users
        // TODO: Mina Review

        public void SearchByUser()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(userLocator, selectedUserLocator);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }


        // TODO: Function => search by bank
        // TODO: Mina Review
        public void SearchByBank()//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankLocator,selectedbankLocator );
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO: Function => search by IP address
        // TODO: Mina Review
        string IpAddress;  // From DB
        public void SearchByIpAddress()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(ipAddressLocator , IpAddress);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }


        public void SearchByMerchant()//BankAuditorUser
        {
            // TODO: check with Hala Id conversion
            // TODO: 7ateb2a keda   
            // TODO:  Mina Review    string selectedMerchantLocatorworkFlowOperations.ChooseFromDropDown(merchantDropDownLocator, selectedMerchantLocator); w7anremove  276
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(merchantDropDownLocator, selectedMerchantLocator);
           
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }

        public void SearchByOperationType(string operation_Type)//BankAuditorUser
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.selectFromDropDownList(operationTypeDropDownLocator, selectedOperationType);
            workFlowOperations.ClickOnBtn(searchBtnDetailedLocator);
            workFlowOperations.waitForPageLoaded();
        }

       

    }
}
