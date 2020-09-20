using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class AddUserRegisteration
    {
        Operations workFlowOperations = Operations.Instance;
        public By userRuleDropDownLocator = By.CssSelector("#UserRole");
        public By usernameLocator = By.CssSelector("#UserName");
        public By fullNameLocator = By.CssSelector("#FullName");
        public By emailLocator = By.CssSelector("#Email");
        public By phoneLocator = By.CssSelector("#TempPhone");
        public By phoneCodeLocator = By.CssSelector("#frmRegister > div:nth-child(14) > div > div:nth-child(2) > div > div > div > div.iti-arrow");
        public By selectedNotificationMethod = By.CssSelector("#NotificationId > option:nth-child(4)");
        public By notificationMethodLocator = By.CssSelector("#NotificationId");
        public By userExpiryDurationLocator = By.CssSelector("#ExpirationDate");
        public By PrivilegesLocator = By.CssSelector(".k-multiselect-wrap");
        public By registerationButtonLocator = By.CssSelector("#btnSave");
        public By requiredFieldLocator = By.CssSelector("#UserName-error");
        public By userRuleRequiredFieldLocator = By.CssSelector(".k-widget > .alert");
        string userRuleStr;
        string userNameStr;
        string fullNameStr;
        string phoneCodeStr;
        string emailStr;
        string notificationMethodStr;
        string selectedCodePhoneStr;
        string phoneNumberStr;
        string userExpiryStr;
        string PrivilegesStr;
        string requiredFieldsdStr;
        string userRuleRequiredStr;

        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCanAddUserfromManageUsersPageWhenFillMandatoryFieldsOnly()
        {  // Test Data user rule should be " bank administration supervisor"
            workFlowOperations.ChooseFromDropDown(userRuleDropDownLocator, userRuleStr);
            workFlowOperations.SendKeysToTxtBox(usernameLocator , userNameStr);
            workFlowOperations.SendKeysToTxtBox(fullNameLocator, fullNameStr);
            workFlowOperations.SendKeysToTxtBox(emailLocator, emailStr);
            workFlowOperations.ChooseFromDropDown(phoneCodeLocator, selectedCodePhoneStr);
            workFlowOperations.SendKeysToTxtBox(phoneLocator, phoneNumberStr);
            workFlowOperations.ChooseFromDropDown(PrivilegesLocator, PrivilegesStr);
            workFlowOperations.selectFromDropDownList(notificationMethodLocator, selectedNotificationMethod);
            workFlowOperations.SendKeysToTxtBox(userExpiryDurationLocator, userExpiryStr);
            workFlowOperations.ClickOnBtn(registerationButtonLocator);
            // complete in manage users "VerifyDataOnPage"

        }

        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCannotAddUserFromManageUsersPageWhenFillOptionalFieldsOnly()
        {
           // No user rule selected
           
            workFlowOperations.ClickOnBtn(registerationButtonLocator);
            workFlowOperations.WaitConfirmationMessage(userRuleRequiredFieldLocator, userRuleRequiredStr);
            workFlowOperations.WaitConfirmationMessage(requiredFieldLocator , requiredFieldsdStr);

        }


        // TODO: Mina Reviewed

        public void CheckThatBankUsersAdministratorCanAddBankBusinessUser()
        {
            // Test Data user rule should be " bank business  user "
            workFlowOperations.ChooseFromDropDown(userRuleDropDownLocator, userRuleStr);
            workFlowOperations.SendKeysToTxtBox(usernameLocator, userNameStr);
            workFlowOperations.SendKeysToTxtBox(fullNameLocator, fullNameStr);
            workFlowOperations.SendKeysToTxtBox(emailLocator, emailStr);
            workFlowOperations.ChooseFromDropDown(phoneCodeLocator, selectedCodePhoneStr);
            workFlowOperations.SendKeysToTxtBox(phoneLocator, phoneNumberStr);
            workFlowOperations.selectFromDropDownList(notificationMethodLocator, selectedNotificationMethod);
            workFlowOperations.SendKeysToTxtBox(userExpiryDurationLocator, userExpiryStr);
            workFlowOperations.ClickOnBtn(registerationButtonLocator);
            // complete in manage users "VerifyDataOnPage"


        }
        // TODO: Mina Reviewed
        public void CheckThatBankUsersAdministratorCanAddBankMerchantsAdministrator()
        {
            // Test Data user rule should be " bank merchantys adminstrator "
            workFlowOperations.ChooseFromDropDown(userRuleDropDownLocator, userRuleStr);
            workFlowOperations.SendKeysToTxtBox(usernameLocator, userNameStr);
            workFlowOperations.SendKeysToTxtBox(fullNameLocator, fullNameStr);
            workFlowOperations.SendKeysToTxtBox(emailLocator, emailStr);
            workFlowOperations.ChooseFromDropDown(phoneCodeLocator, selectedCodePhoneStr);
            workFlowOperations.SendKeysToTxtBox(phoneLocator, phoneNumberStr);
            workFlowOperations.selectFromDropDownList(notificationMethodLocator, selectedNotificationMethod);
            workFlowOperations.SendKeysToTxtBox(userExpiryDurationLocator, userExpiryStr);
            workFlowOperations.ClickOnBtn(registerationButtonLocator);
            // complete in manage users "VerifyDataOnPage"


        }

      


       










    }
}
