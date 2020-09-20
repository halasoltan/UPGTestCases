using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OpenQA.Selenium;


namespace UPG.Pages
{
    class DigitalTokenManagement
    {
        // TODO: Check page users with Hala

        Operations workFlowOperations = Operations.Instance;
        public By DigitalTokenManagementIconLocator = By.LinkText(" Digital Token management ");
       // public By selectParametersBtnLocator = By.Id("searchHeader");
        public By termainalIdLocator = By.LinkText("Terminal Id");
        public By terminalNameLocator = By.LinkText("Terminal Name");
        public By schemeMIDLocator = By.LinkText("Scheme MID");
        public By mVisaAccountIdLocator = By.LinkText("mVisa Account Id");
        public By TypeLocator = By.LinkText("Type");
        public By TerminalCreationDtLocator = By.LinkText("Terminal Creation DT");
        public By ActionLocator = By.LinkText("Action");




        // string  = "10456405964";
        public void CheckIfTheUserCanViewdataThatStoredInTable()
        {
            //workFlowOperations.ClickOnBtn(DigitalTokenManagementIconLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ExtractDataFromText(termainalIdLocator); 
            workFlowOperations.ExtractDataFromText(terminalNameLocator);
            workFlowOperations.ExtractDataFromText(schemeMIDLocator);
            workFlowOperations.ExtractDataFromText(mVisaAccountIdLocator);
            workFlowOperations.ExtractDataFromText(TypeLocator);
            workFlowOperations.ExtractDataFromText(TerminalCreationDtLocator);
            workFlowOperations.ExtractDataFromText(ActionLocator);
            // will retutn in all string of TCs
        }

        public void CheckIfSystemAllowForUserToViewRelatedStaticQR()
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToClickOnBtn(DigitalTokenManagementIconLocator);
            // TODO:  Mina Review   prerequistes Didital QR termainal should be added first using another user 

        }
        // till finish the 





    }
}
