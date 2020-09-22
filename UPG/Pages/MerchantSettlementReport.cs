using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class MerchantSettlementReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By bankDropDownLocator = By.CssSelector("#BankId");
        public By settlementTypeDropDownLocator = By.CssSelector("#SettlementType");
        public By dateFromTxtBoxLocator = By.CssSelector("#DateFrom");
        public By dateToTxtBoxLocator = By.CssSelector("#DateTo");
        public By merchantDropDownLocator = By.CssSelector(".k-i-arrow-60-down");
        string selectedBankStr;
        string selectedSettlementTypeStr;
        string dateFromStr;
        string dateToStr;
        string selectedMerchantTypeStr;
        public By downloadSettlementBtnLocator = By.CssSelector("#btnDownload");
        public By generateExportFileLocator = By.CssSelector("p:nth-child(3)");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        DateTime datefrom;
        DateTime dateTo;
        public By PeriodMsgLocator = By.CssSelector(".k-widget p");
        string PeriodMessageStr = "Search Criteria Period must be less than or equal 1 month";
        public By errorDwMsgLocator = By.CssSelector("p:nth-child(3)");
        string errorDwMessageStr = "Request by date must be first of month.";


        public void DownloadSettlementReport()
        {

            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, selectedBankStr);
            workFlowOperations.ChooseFromDropDown(settlementTypeDropDownLocator, selectedSettlementTypeStr);
            if (selectedSettlementTypeStr == "DTF"  || selectedSettlementTypeStr == "SVAReport")
            {
               string DF = workFlowOperations.SendKeysToTxtBox(dateFromTxtBoxLocator, dateFromStr);
                datefrom = Convert.ToDateTime(DF);
                string DTo = workFlowOperations.SendKeysToTxtBox(dateToTxtBoxLocator, dateToStr);
                dateTo = Convert.ToDateTime(DTo);
               
                int period = (dateTo - datefrom).TotalDays;
                if (period <= 30) // period =  one months
                {
                    workFlowOperations.ChooseFromDropDown(merchantDropDownLocator, selectedMerchantTypeStr);
                    workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                    workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
                }
                else
                {
                    workFlowOperations.ChooseFromDropDown(merchantDropDownLocator, selectedMerchantTypeStr);
                    workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                    workFlowOperations.WaitConfirmationMessage(PeriodMsgLocator, PeriodMessageStr);
                    
                }
                if (selectedSettlementTypeStr == "Subscription DTF")
                {
                    workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                    workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
                }
                //if (selectedSettlementTypeStr == "Billing Transaction")
                //{

                //    workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                //    workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
                //pending}
                if (selectedSettlementTypeStr == "Billing Subscription")
                {
                    string DF = workFlowOperations.SendKeysToTxtBox(dateFromTxtBoxLocator, dateFromStr);
                    datefrom = Convert.ToDateTime(DF);
                    if(datefrom.Day==1)
                    {
                        workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                        workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
                    }
                    else
                    {
                        workFlowOperations.ClickOnBtn(downloadSettlementBtnLocator);
                        workFlowOperations.WaitConfirmationMessage(errorDwMsgLocator, errorDwMessageStr);
                    }
                }


                }
        }










    }
}
