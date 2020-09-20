using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class SystemLogReport
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By dateFromTxtLocator = By.CssSelector("#DateTimeFrom");
        string dateFromStr;
        public By dateToTxtLocator = By.CssSelector("#DateTimeTo");
        string dateToStr;
        public By eventTypeDropDownLocator = By.CssSelector("#EventType");
        string eventTypeStr;
        public By eventSubTypeDropDownLocator = By.CssSelector("#EventType");
        string eventSubTypeStr;
        public By searchBtnLocator = By.CssSelector(".btn-block");


        // TODO:  Mina Review     
        public void SearchForSystemLogReport ()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            // workFlowOperations.searchByDates()
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }

        // TODO:  Mina Review     
        public void SearchForSystemLogReportUsingEvents()
        {
            workFlowOperations.WaitToClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(eventTypeDropDownLocator, eventTypeStr);
            workFlowOperations.ChooseFromDropDown(eventSubTypeDropDownLocator, eventTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }








    }
}
