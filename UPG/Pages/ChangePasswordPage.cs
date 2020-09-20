using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class ChangePasswordPage
    {
        
        Operations workFlowOperations = Operations.Instance;
        // Locators for Change_Reset_logout_page
        public By currentPasswordTxtBoxLocator = By.CssSelector("#OldPassword");
        public By newPasswordTxtBoxLocator = By.CssSelector("#NewPassword");
        public By confirmNewPasswordTxtBoxLocator = By.CssSelector("#ConfirmPassword");
        public By saveBtnLocator = By.CssSelector("#btnSave");
        public By resetBtnLocator = By.CssSelector("#btnRest");
        public By cancelBtnLocator = By.CssSelector("#btnCancel");

        public By eyeCloseBtnLocator = By.CssSelector("#oldPass_pass-status");
        public By eyeOpenBtnLocator = By.CssSelector("#newPass_pass-status");


        //assertion locators for reset password
        public By charLongLocator = By.Id("8char");
        public By upperCaseLocator = By.CssSelector("#ucase");
        public By specialCharLocator = By.Id("special");
        public By lowercaseLetterLocator = By.Id("lcase");
        public By oneNumberLocator = By.Id("num");
        public By newPasswordsMatchedLocator = By.Id("pwmatch");
        public By oldPasswordNotMatchedLocator = By.Id("pwOldNotmatch");
        public By passwordHistoricalLocator = By.Id("passwordHistoricalRole");
        public By changedPasswordMsgLocator = By.CssSelector(""); //disappeared
        public By invalidPAsswordMsgLocator = By.CssSelector("");//disappeared

        // Assertion _For change password page

        string charLongStr = "8 Characters Long";
        string upperCaseStr = "One Uppercase Letter";
        string specialCharStr = "One special Char";
        string lowerCaseLetterStr = "One Lowercase Letter";
        string oneNumberStr = "One Number";
        string newPasswordsMatchedStr = "New / Confirm Passwords Match";
        string newoldPasswordNotMatchedStr = "New / Current Passwords Not the same";
        string passwordHistoricalStr = "The new password shouldn't be one of last used 3 passwords";
        string changedPasswordMsgStr = "Password changed successfully!";
        string invalidPasswordStr = "The password is already used before for this account, please try again with another password!";
        // TODO: Functions for change password page
        // TODO: Mina Review
        public void CheckThatUserCanChangePassword(string currentPasssword , string newPassword , string confirmPassword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator,currentPasssword);
            workFlowOperations.SendKeysToTxtBox(newPasswordTxtBoxLocator, newPassword);
            workFlowOperations.SendKeysToTxtBox(confirmNewPasswordTxtBoxLocator, confirmPassword);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(changedPasswordMsgLocator, changedPasswordMsgStr);
        }


        public void CheckTheUserCannotChangePasswordwithInvalidOldpassword (string currentPasssword, string newPassword, string confirmPassword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator, currentPasssword);
            workFlowOperations.SendKeysToTxtBox(newPasswordTxtBoxLocator, newPassword);
            workFlowOperations.SendKeysToTxtBox(confirmNewPasswordTxtBoxLocator, confirmPassword);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(invalidPAsswordMsgLocator, invalidPasswordStr);
        }

        public void CheckTheUserCannotChangePasswordwithInvalidNewpassword(string currentPasssword, string newPassword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator, currentPasssword);
            workFlowOperations.SendKeysToTxtBox(newPasswordTxtBoxLocator, newPassword); //@12345m#
           
            workFlowOperations.WaitConfirmationMessage(upperCaseLocator, upperCaseStr);
        }
        public void CheckThattheNewPasswordMatchTheConfirmNewpassword(string currentPasssword, string newPassword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator, currentPasssword);
            workFlowOperations.SendKeysToTxtBox(newPasswordTxtBoxLocator, newPassword);// new != match
            workFlowOperations.WaitConfirmationMessage(newPasswordsMatchedLocator, newPasswordsMatchedStr);
        }

        public void CheckThatTheNewPasswordIsSameOfOldPassword ( string currentPasssword, string newPassword, string confirmPassword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator,currentPasssword);
            workFlowOperations.SendKeysToTxtBox(newPasswordTxtBoxLocator, newPassword); //new == old
            workFlowOperations.SendKeysToTxtBox(confirmNewPasswordTxtBoxLocator, confirmPassword);
           
            workFlowOperations.WaitConfirmationMessage(oldPasswordNotMatchedLocator, newoldPasswordNotMatchedStr);
        }

      public void  CheckTheUserCanCancelTheChangePasswordPageUsingCancelButton ()
    {
            workFlowOperations.WaitToClickOnBtn(cancelBtnLocator);
    }




        string classreturned = " form-control";
        public void CheckTheUserCanResetThePasswordPageUsingResetButton (string currentPasssword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator, currentPasssword);
           
            workFlowOperations.ClickOnBtn(resetBtnLocator);
            // workFlowOperations.VerifyElementworked(currentPasswordTxtBoxLocator, classreturned);will be called in TC  to write in console
        }

        public void verifyEyeButtonWorked(string currentPasssword)
        {
            workFlowOperations.WaitToSendKeysToTxtBox(currentPasswordTxtBoxLocator, currentPasssword);
            workFlowOperations.WaitToClickOnBtn(eyeCloseBtnLocator);
          //  workFlowOperations.ExtractDataFromText(currentPasswordTxtBoxLocator ); will be called in TC  to write in console
        }
       

    }
}
