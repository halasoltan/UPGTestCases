using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class SystemMode
    {
        Operations workFlowOperations = Operations.Instance;
        public By updateMaintenanceModeBtnLocator = By.CssSelector(".slider");
        public By maintenanceModeMsgLocator = By.CssSelector(".alert-success");
        string maintenanceModeMsgStr = "System currently in maintenance mode, you can apply your maintenance process.";
        public void ActiveDeactiveMaintenanceMode()
        {
            workFlowOperations.ClickOnBtn(updateMaintenanceModeBtnLocator);
            workFlowOperations.WaitConfirmationMessage(maintenanceModeMsgLocator , maintenanceModeMsgStr);
            workFlowOperations.ClickOnBtn(updateMaintenanceModeBtnLocator);
        }
        // TC for example Adding Route should be called after this TC
        //and can't do action but we could take action so  it is abug 
    }
}
