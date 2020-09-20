using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class SupportTickets
    {
        //TODO: check page users with Hala
        //TODO: Many Link Text Locators : Verify coloms name in table by ME
        // TODO:  Mina Review   
        Operations workFlowOperations = Operations.Instance;
        public By supportTicketIconLocator = By.LinkText(" Support Tickets ");
        public By requestDateLocator = By.LinkText("TRequest Date");
        public By ticketIdLocator = By.LinkText("Ticket ID");
        public By severityLocator = By.LinkText("Severity");
        public By terminalLocator = By.LinkText("Terminal");
        public By merchantLocator = By.LinkText("Merchant");
        public By requestLocator = By.LinkText("Request");
        public By closedLocator = By.LinkText("Closed");
        public By closeDateLocator = By.LinkText("Close Date");
        public By creatorLocator = By.LinkText("Creator");
        public By detailsLocator = By.LinkText("Details");
        public By messagesLocator = By.LinkText("Messages");
        public By selectParametersBtnLocator = By.Id("searchHeader");
        public By dateFromTxtLocator = By.CssSelector("#StartDate");
        public By dateToTxtLocator = By.CssSelector("#EndDate");
        public By searchSupportBtnLocator= By.CssSelector("#searchBody > div:nth-child(5) > div > div > button");
        public By problemTypeDropDownLocator = By.CssSelector("#ProblemTypeId");
        public By selectedproblemTypeLocator = By.CssSelector("#ProblemTypeId > option:nth-child(4)"); //"Training request"
        public By requestCellLocator = By.LinkText("Training request");
        public By severtyTypeDropDownLocator = By.CssSelector("#ServerityId");//
        public By selectedsevertyTypeLocator = By.CssSelector("#ServerityId > option:nth-child(2)");
        public By terminalTypeDropDownLocator = By.CssSelector("#TerminalNodeId");//
        public By selectedterminalTypeLocator = By.CssSelector("#TerminalNodeId > option:nth-child(2)");
        public By optionBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a:nth-child(3) > span > span");
        public By eportDowwnLoadBtnLocator = By.CssSelector("/body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.export > span");
        public By refreshBtnLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a.fab-buttons.center-v-h.reloadList > span");
        public By addButtonLocator = By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.fab-container > a:nth-child(3) > span");

        ////#servirityId > option:nth-child(2)


        //TODO: Verification is not done
        // TODO:  Mina Review   
        public void CheckIfSystemDisplaySupportTicketsIconInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.ExtractDataFromText(supportTicketIconLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsRequestDateInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(requestDateLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsTicketIdInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(ticketIdLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsSeverityInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(severityLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsTerminalInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(terminalLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsMerchantInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(merchantLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsRequestInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(requestLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsClosedInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(closedLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsCloseDateInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(closeDateLocator);
        }
        public void CheckIfSystemDisplaySupportTicketscreatorInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(creatorLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsDetailsInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(detailsLocator);
        }
        public void CheckIfSystemDisplaySupportTicketsMessagesInTableforUser() //Merchant Branch Admin 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(messagesLocator);
          
        }

        //TODO: Use search by date common Function
        public void CheckIfSystemAllowForUserToSelectDateByClickingOnDateCalendarIcon () ////Merchant Branch Admin
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.SendKeysToTxtBox(dateFromTxtLocator ,""); // read date t send string
           // read date t send string
            workFlowOperations.ClickOnBtn(searchSupportBtnLocator);

        }
        public void CheckIfSystemHandlesErroneousIfUserEnterTimeFromBiggerThanTimeTo()//Merchant Branch Admin
        {
            // user should select After date selection // fail
        }
        public void CheckIfSystemAllowUserToSelectProblemTypeFromDropDownList()////Merchant Branch Admin
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.selectFromDropDownList(problemTypeDropDownLocator, selectedproblemTypeLocator);
            workFlowOperations.ClickOnBtn(searchSupportBtnLocator);
            //verify action returned succcessfully
            workFlowOperations.ExtractDataFromText(requestCellLocator); // calling in string using TC

        }

        public void CheckIfSystemAllowUserToSelectSeverityTypeFromDropDownList() //Merchant Branch Admin
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.waitForPageLoaded();
            
            workFlowOperations.selectFromDropDownList(severtyTypeDropDownLocator, selectedsevertyTypeLocator);
            
            workFlowOperations.ClickOnBtn(searchSupportBtnLocator);
        }

        public void CheckIfSystemAllowUserToSelectTerminalfromDropDownList()//Merchant Branch Admin
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            
            workFlowOperations.selectFromDropDownList(terminalTypeDropDownLocator, selectedterminalTypeLocator);
            workFlowOperations.ClickOnBtn(searchSupportBtnLocator);


        }
     
        public void CheckIfSystemAllowForUserToAddSupportTickets()//Merchant Branch Admin
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(addButtonLocator);
            workFlowOperations.waitForPageLoaded();
           

        }

        public void CheckIfExcelDownloadedFileContainsSameDataEnteredByUser ()
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(eportDowwnLoadBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // verify DW excel and open

        }

        public void CheckIfSystemAllowUserToRefreshSupportTicketList()
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(refreshBtnLocator);
            workFlowOperations.waitForPageLoaded();
            // confirm refresh continue

        }

        public void CheckIfExportedFilesareAddedToExportedFilesDownloadsList()
        {
            workFlowOperations.WaitToClickOnBtn(supportTicketIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(eportDowwnLoadBtnLocator);

        }














    }
}
