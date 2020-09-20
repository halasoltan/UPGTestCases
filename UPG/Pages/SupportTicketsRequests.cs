using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class SupportTicketsRequests
    {
        //TODO: check page users with Hala : Merchant Branch Admin 
        // TODO:  Mina Review   
        public IWebDriver driver;
        Operations workFlowOperations = Operations.Instance;
        public By terminalTypeDropDownLocator = By.CssSelector("#terminalNodeId");
        
        public By ticketPriorityDropDownLocator = By.CssSelector("#servirityId");
       
        public By ticketTypeDropDownLocator = By.CssSelector("#SelectedRequest");
      
        public By detailsAddTicketTxtBoxLocator = By.CssSelector("#details");

        public By sendBtnLocator = By.CssSelector("#btnSend");
        public By BackBtnLocator = By.CssSelector("#saveRequestFrm > div:nth-child(4) > div:nth-child(1) > a");
        string DetailsStr = "test";
        public By errorAddTicketLocator = By.CssSelector("#customError");
        string errorAddTicketStr = "Please fill Details!";
        public void CreateTicketAfterAdd(string terminalType , string TicketPriority , string TicketType)// Merchant Branch Admin 
        {
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalType);
            workFlowOperations.ChooseFromDropDown(ticketPriorityDropDownLocator, TicketPriority);
            workFlowOperations.ChooseFromDropDown(ticketTypeDropDownLocator , TicketType);
            //TODO: test data should be passed as parameter to function :Done
            // TODO:  Mina Review   
            workFlowOperations.SendKeysToTxtBox(detailsAddTicketTxtBoxLocator, DetailsStr);
            workFlowOperations.ClickOnBtn(sendBtnLocator);
        }

        public void CheckIfSystemhandlesErroneousIfUserkeepAllFieldsEmptyAtAddSupportTicketForm () // Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(sendBtnLocator);
            workFlowOperations.WaitConfirmationMessage(errorAddTicketLocator, errorAddTicketStr);
        }
         public void CheckIfSystemAllowForUsertoCancelRequest()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.SendKeysToTxtBox(detailsAddTicketTxtBoxLocator, DetailsStr);
            workFlowOperations.ClickOnBtn(BackBtnLocator);
            driver.SwitchTo().Alert().Accept(); // can't catch leave button using inspect
            //Navigation to support tickets page
            //TODO: check Missing action with Hala  "can't catch leave button using inspect"
        }













        //public By selectedTicketTypeLocator = By.CssSelector("#SelectedRequest > option:nth-child(8)");//offline POS termonal
        //public By selectedTicketPriorityLocator = By.CssSelector("#TerminalNodeId > option:nth-child(2)");
        //public By selectedterminalTypeLocator = By.CssSelector("#terminalNodeId > option:nth-child(2)");

    }
}
