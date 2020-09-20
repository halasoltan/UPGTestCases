using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class AddMerchant
    {
        Operations workFlowOperations = Operations.Instance;
        public By bankDropDownLocator = By.CssSelector("#BankId");
        string bankStr;
       // public By merchantIdTxtBoxLocator = By.CssSelector("#MerchantID");
        public By merchantNameTxtBoxLocator = By.CssSelector("#MerchantName");
        string merchantNameStr;
        public By isAggregatorBtnLocator = By.CssSelector("#dvIsAggregator .slider");
        public By categoryDropDownLocator = By.CssSelector(".k-state-hover > .k-input");
        string categoryStr;
        public By cityDropDownLocator = By.CssSelector(".k-state-focused > .k-select > .k-icon");
        string cityStr;
        public By addressTxtBoxLocator = By.CssSelector("#Merchant_Address1"); string addressStr;
        public By countryCodeNumberDropDownLocator = By.CssSelector(".iti-arrow");
        string CodeNumberStr;
        public By phoneTxtBoxLocator = By.CssSelector("#TempMerchant_ContactPersonPhone");
        public By countryDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        string countryStr;
        public By accountTypeDropDownLocator = By.CssSelector("#SettlementAccountType");
        string accountTypeStr;
        public By accountNumberTxtBoxLocator = By.CssSelector("#SettBankAccNumber");
        string accountNumberStr;
        public By minTransactionAmountTxtBoxLocator = By.CssSelector("#MinTxnAmount"); string minTransactStr;
        public By dailyLimitAmountTxtBoxLocator = By.CssSelector("#DailyLimitAmount"); string dailyLimitStr;
        public By maxTransactionCountDayTxtBoxLocator = By.CssSelector("#MaxTxnCountDay"); string maxTransCountStr;
        public By maxTransactionAmountTxtBoxLocator = By.CssSelector("#MaxTxnLimit");  string maxTransactAmountStr;
        public By monthlyLimitAmountTxtBoxLocator = By.CssSelector("#MonthlyLimitAmount"); string monthlyLimitStr;
        public By fullNameTxtBoxLocator = By.CssSelector("#MerchantFullName"); string fullNameStr;
        public By EmailTxtBoxLocator = By.CssSelector("#MerchantUserEmail");  string emailStr;
        public By notificationMethodDropDownLocator = By.CssSelector("#NotificationId"); 
        string notificationMethodStr;
        public By portalLoginUsernameDropDownLocator = By.CssSelector("#MerchantUserNameSelectedType");
        string portalLoginUsernameStr;
        public By saveMerchantBtnLocator = By.CssSelector("#btnSave");
        public By cancelAddMerchantBtnLocator = By.CssSelector(".btn-danger");



        // TODO:  Mina Review   
        public void AddMerchantThroughMerchantManagement()
        {
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, bankStr);
            workFlowOperations.SendKeysToTxtBox(merchantNameTxtBoxLocator, merchantNameStr);
            /*Optional
            workFlowOperations.ClickOnBtn(isAggregatorBtnLocator);*/
            workFlowOperations.ChooseFromDropDown(categoryDropDownLocator, categoryStr);
            workFlowOperations.ChooseFromDropDown(cityDropDownLocator, cityStr);
            workFlowOperations.SendKeysToTxtBox(addressTxtBoxLocator, addressStr);
            workFlowOperations.ChooseFromDropDown(countryCodeNumberDropDownLocator, CodeNumberStr);
            workFlowOperations.ChooseFromDropDown(accountTypeDropDownLocator, accountTypeStr);
            workFlowOperations.SendKeysToTxtBox(accountNumberTxtBoxLocator, accountNumberStr);
            workFlowOperations.SendKeysToTxtBox(minTransactionAmountTxtBoxLocator, minTransactStr);
            workFlowOperations.SendKeysToTxtBox(dailyLimitAmountTxtBoxLocator, dailyLimitStr);
            workFlowOperations.ChooseFromDropDown(maxTransactionCountDayTxtBoxLocator, maxTransCountStr);
            workFlowOperations.ChooseFromDropDown(maxTransactionAmountTxtBoxLocator, maxTransactAmountStr);
            workFlowOperations.ChooseFromDropDown(monthlyLimitAmountTxtBoxLocator, monthlyLimitStr);
            workFlowOperations.SendKeysToTxtBox(fullNameTxtBoxLocator, fullNameStr);
            workFlowOperations.SendKeysToTxtBox(EmailTxtBoxLocator, emailStr);
            workFlowOperations.ChooseFromDropDown(notificationMethodDropDownLocator, notificationMethodStr);
            workFlowOperations.ChooseFromDropDown(portalLoginUsernameDropDownLocator, portalLoginUsernameStr);
            workFlowOperations.ClickOnBtn(saveMerchantBtnLocator);
            workFlowOperations.waitForPageLoaded();

        }


















    }
}
