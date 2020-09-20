using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class CommunicationLogReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By bankDropDownLocator = By.CssSelector("#BankId");
        string selectedBankStr;
        public By terminalDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        string terminalStr;
        public By batchIdTxtBoxLocator = By.CssSelector("#BatchId");
        string batchIdStr;
        public By messageTypeLocator = By.CssSelector("#MsgTypeId");
        string msgStr;
        public By dateFromTxtLocator = By.CssSelector("#DateFrom");
        string dateFromStr;
        public By dateToTxtLocator = By.CssSelector("#DateTo");
        string dateToStr;
        public By ticketNoTxtLocator = By.CssSelector("#TicketNo");
        string ticketNoStr;
        public By merchantDropDownLocator = By.CssSelector(".k-i-arrow-60-down");
        string merchantStr;
        public By MessageFormatDropDownLocator = By.CssSelector("#MsgFormatId");
        string msgFormatStr;
        public By responseTypeDropDownLocator = By.CssSelector("#ResponseCodeId");
        string responseTypeStr;
        public By serviceNameTxtBoxLocator = By.CssSelector("#ServiceName");
        string serviceNameStr;
        public By transactionTypeDropDownLocator = By.CssSelector("#TxnTypeId");
        string transactionTypeStr;
        public By searchBtnLocator = By.CssSelector(".btn-block");
         // TODO:  Mina Review   
        // Page is Pending according to the transaction
    }
}
