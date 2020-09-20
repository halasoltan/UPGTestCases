using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{ // TODO: Mina Reviewed
    class EditRecordUser
    {
        Operations workFlowOperations = Operations.Instance;
        public By fullnameTxtBoxLocator = By.CssSelector ("#FullName");
        public By updateButtonLocator = By.CssSelector("#btnSave");
        public By pohoneTxtBoxLocator = By.CssSelector("#Phone");
        public By phoneErrorMessageLocator = By.CssSelector("#Phone-error");
        string fullNameStr;
        string phoneStr;
        string phoneErrorMsgStr = "The Phone must be at least 11 characters long.";

        public void EditUserName ()
        {
            workFlowOperations.SendKeysToTxtBox(fullnameTxtBoxLocator, fullNameStr);
            workFlowOperations.ClickOnBtn(updateButtonLocator);

        }
        public void EditUserPhone() //TODO: Mina Reviewed
        { //Test data Prep, Enter invalid Phone 12 chars
            workFlowOperations.SendKeysToTxtBox(pohoneTxtBoxLocator, phoneStr);
            workFlowOperations.ClickOnBtn(updateButtonLocator);
            workFlowOperations.WaitConfirmationMessage(phoneErrorMessageLocator, phoneErrorMsgStr);

        }

    }
}
