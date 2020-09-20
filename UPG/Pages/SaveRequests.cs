using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class SaveRequests
    {
        Operations workFlowOperations = Operations.Instance;
        public By saveRequestLocator = By.CssSelector("#saveRequestFrm > h3");
        string saveRequestStr = "Your Request has been sent with reference No.44";
        public void VerifyAddTicket() //Merchant Branch Admin
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(saveRequestLocator, saveRequestStr);
        }

      


    }
}

