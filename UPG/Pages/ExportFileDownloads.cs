using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class ExportedFilesDownloads
    {
        Operations workFlowOperations = Operations.Instance;
        public By actionDownLoadLocator = By.CssSelector(".grid-row:nth-child(1) .btn");
        public By statusDropDownLocator = By.CssSelector("#Status");
        string selectedStatusDropDownLocator;
        public By searchExcelLocator = By.CssSelector(".btn-block");
        public void ClickToDownloadFromExportedFileIcon() 
        {
            workFlowOperations.ClickOnBtn(actionDownLoadLocator);
            workFlowOperations.waitForPageLoaded();
        }

    public void ChecIfSystemAllowUserToSelectExportedFilesStatusFromDropDownList ()
        {
            workFlowOperations.ChooseFromDropDown(statusDropDownLocator, selectedStatusDropDownLocator);
            workFlowOperations.ClickOnBtn(searchExcelLocator);
        }





    }
}
