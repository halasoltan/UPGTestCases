using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class AddMerchantEditRecord
    {
        Operations workFlowOperations = Operations.Instance;
        public By bankDropDownLocator = By.CssSelector("#BankId");
       // public By merchantIdTxtBoxLocator = By.CssSelector("#MerchantID");
        public By merchantNameTxtBoxLocator = By.CssSelector("#MerchantName");
        
        public By isAggregatorBtnLocator = By.CssSelector("#dvIsAggregator .slider");
        public By categoryDropDownLocator = By.CssSelector(".k-state-hover > .k-input");
        public By categoryLocator = By.CssSelector("#CategoryCodeId_listbox > li:nth-child(5)");
        public By cityDropDownLocator = By.CssSelector(".k-state-focused > .k-select > .k-icon");
        public By cityLocator = By.CssSelector("#StateId_listbox > li.k-item.k-state-hover");
        public By addressTxtBoxLocator = By.CssSelector("#Merchant_Address1"); 
        public By countryCodeNumberDropDownLocator = By.CssSelector(".iti-arrow");




       
        public By phoneTxtBoxLocator = By.CssSelector("#TempMerchant_ContactPersonPhone");
        public By countryDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        public By countryLocator = By.CssSelector("#be588725-d9c7-4df0-a045-21df3eb605f3");
        public By accountTypeDropDownLocator = By.CssSelector("#SettlementAccountType");
        
        public By accountNumberTxtBoxLocator = By.CssSelector("#SettBankAccNumber");
        public By CodeNumberLocator = By.CssSelector("#MerchantCanRefundDiv > div:nth-child(1) > div:nth-child(2) > div > div > ul > li.country.preferred.active");
        public By minTransactionAmountTxtBoxLocator = By.CssSelector("#MinTxnAmount");
        public By dailyLimitAmountTxtBoxLocator = By.CssSelector("#DailyLimitAmount"); 
        public By maxTransactionCountDayTxtBoxLocator = By.CssSelector("#MaxTxnCountDay"); 
        public By maxTransactionAmountTxtBoxLocator = By.CssSelector("#MaxTxnLimit");  
        public By monthlyLimitAmountTxtBoxLocator = By.CssSelector("#MonthlyLimitAmount");
        public By fullNameTxtBoxLocator = By.CssSelector("#MerchantFullName"); 
        public By EmailTxtBoxLocator = By.CssSelector("#MerchantUserEmail"); 
        public By notificationMethodDropDownLocator = By.CssSelector("#NotificationId"); 
       
        public By portalLoginUsernameDropDownLocator = By.CssSelector("#MerchantUserNameSelectedType");
       
        public By saveMerchantBtnLocator = By.CssSelector("#btnSave");
        public By cancelAddMerchantBtnLocator = By.CssSelector(".btn-danger");



        // TODO:  Mina Review   
        public void AddMerchantThroughMerchantManagement(string bankStr, string merchantNameStr, string addressStr,
             string accountTypeStr , string accountNumberStr, string minTransactStr,
            string dailyLimitStr, string maxTransCountStr, string maxTransactAmountStr, string monthlyLimitStr, 
            string fullNameStr, string emailStr, string notificationMethodStr, string portalLoginUsernameStr)
        {
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, bankStr);
            workFlowOperations.SendKeysToTxtBox(merchantNameTxtBoxLocator, merchantNameStr);
            /*Optional
            workFlowOperations.ClickOnBtn(isAggregatorBtnLocator);*/
            workFlowOperations.selectFromDropDownList(categoryDropDownLocator, categoryLocator);
            workFlowOperations.selectFromDropDownList(cityDropDownLocator, cityLocator);
            workFlowOperations.SendKeysToTxtBox(addressTxtBoxLocator, addressStr);

            workFlowOperations.SendKeysToTxtBox(countryDropDownLocator, countryLocator);

            workFlowOperations.selectFromDropDownList(countryCodeNumberDropDownLocator, CodeNumberLocator);
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
