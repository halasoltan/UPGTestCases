using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class SystemAdminDashboard
    {
        Operations pageOperations = Operations.Instance;

        By manageUsersLocator = By.CssSelector("body > div:nth-child(6) > div.col-md-9.col-sm-7 > div > div:nth-child(2) > div > div > div.pricing-footer > a");
        By manageTerminalsCountLocator = By.CssSelector("body > div:nth-child(6) > div.col-md-9.col-sm-7 > div > div:nth-child(3) > div > div > div.pricing-footer > a");
        By manageTerminalTemplatesLocator = By.CssSelector("body > div:nth-child(6) > div.col-md-9.col-sm-7 > div > div:nth-child(4) > div > div > div.pricing-footer > a");
        By manageApplicationVersionsLocator = By.CssSelector("body > div:nth-child(6) > div.col-md-9.col-sm-7 > div > div:nth-child(5) > div > div > div.pricing-footer > a");

        public void MangeUsers()
        {
            pageOperations.WaitToClickOnBtn(manageUsersLocator);
        }

        public void MangeTerminalsCount()
        {
            pageOperations.WaitToClickOnBtn(manageTerminalsCountLocator);
        }

        public void MangeTerminalTemplates()
        {
            pageOperations.WaitToClickOnBtn(manageTerminalTemplatesLocator);
        }

        public void MangeApplicationVersions()
        {
            pageOperations.WaitToClickOnBtn(manageApplicationVersionsLocator);
        }
    }
}
