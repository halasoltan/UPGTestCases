using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UPG.Pages
{
    class DeployTerminalList
    {
        Operations workFlowOperations = Operations.Instance;
        
        public By terminalBankDropDownLocator = By.CssSelector("#Terminal_BankId");
        string terminalBankStr;
        public By terminalTypeDropDownLocator = By.CssSelector("#Terminal_TerminalTypeId");
        string terminalTypeStr;
        public By terminalIdTxtBoxLocator = By.CssSelector("#Terminal_TerminalId"); // generated Automatically
        string terminalIdStr;
        public By terminalNameTxtBoxLocator = By.CssSelector("#Terminal_Name");
        string terminalNameStr;
        public By terminalNameReqMsgLocator = By.CssSelector("#Terminal_Name-error");
        string terminalNameReqMsgStr = "This field is required.";
        public By channelCardBtnLocator = By.CssSelector(".ch-card .slider");
        public By mVisalCardBtnLocator = By.CssSelector("#dvIsMVisa .slider");
        public By suspendedMvisalCardBtnLocator = By.CssSelector(".form-group:nth-child(2) .slider");
        public By primaryMerchantDropDownLocator = By.CssSelector(".k-state-hover > .k-select > .k-icon");
        string primaryMerchantStr;
        public By digitalQrTerminalDropDownLocator = By.XPath("//form[@id='uploadForm']/div[2]/div/div/div[3]/div/div/div[2]/span/span/span[2]/span");
        string digitalQrTerminalStr;
        public By domainTxtBoxLocator = By.CssSelector("# Terminal_WT_Domain");
        string domainStr;
        public By fullNameTxtBoxLocator = By.CssSelector("#FullName");
        string fullNameStr;
        public By userNameDropDownBoxLocator = By.CssSelector("#TerminalUserNameSelectedType");
        string userNameStr;
        public By emailTxtBoxLocator = By.CssSelector("#Email");
        string emailStr;
        public By phoneTxtBoxLocator = By.CssSelector("#TempPhone");
        string phoneStr;
        public By saveBtnLocator = By.CssSelector("#btnSave");
        public By successCreateTerminalMsgLoctor = By.CssSelector("p:nth-child(3)");
        string successCreateTerminalStr = "Terminal has been deployed";
        public By invalidPhoneTerminalMsgLoctor = By.CssSelector("#TempPhone-error");
        string invalidPhoneTerminalStr = "Invalid Mobile Number";

        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By reloadBtnLocator = By.CssSelector(".fa-refresh");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        

        // TODO:  Mina Review  
        public void CreateTerminalUsingWebTerminalTypeCardOnly() // card only
        {
            workFlowOperations.ChooseFromDropDown(terminalBankDropDownLocator, terminalBankStr);
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.SendKeysToTxtBox(terminalNameTxtBoxLocator, terminalNameStr);
            workFlowOperations.ClickOnBtn(channelCardBtnLocator);
            workFlowOperations.ChooseFromDropDown(primaryMerchantDropDownLocator, primaryMerchantStr);
            workFlowOperations.SendKeysToTxtBox(domainTxtBoxLocator, domainStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(successCreateTerminalMsgLoctor, successCreateTerminalStr);

        }
      






        // TODO:  Mina Review  
        public void CreateTerminalUsingWebTerminalTypeVisaAndCard() // Visa and Card
        {
            workFlowOperations.ChooseFromDropDown(terminalBankDropDownLocator, terminalBankStr);
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.SendKeysToTxtBox(terminalNameTxtBoxLocator, terminalNameStr);
            workFlowOperations.ClickOnBtn(channelCardBtnLocator);
            workFlowOperations.ClickOnBtn(mVisalCardBtnLocator);
            workFlowOperations.ChooseFromDropDown(primaryMerchantDropDownLocator, primaryMerchantStr);
            //workFlowOperations.ChooseFromDropDown(digitalQrTerminalDropDownLocator, digitalQrTerminalStr);
            workFlowOperations.SendKeysToTxtBox(domainTxtBoxLocator, domainStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(successCreateTerminalMsgLoctor, successCreateTerminalStr);

        }
        // TODO:  Mina Review   
        public void CreateTerminalUsingDigitalQrTerminal() 
        {
            workFlowOperations.ChooseFromDropDown(terminalBankDropDownLocator, terminalBankStr);
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.SendKeysToTxtBox(terminalNameTxtBoxLocator, terminalNameStr);
            workFlowOperations.ClickOnBtn(mVisalCardBtnLocator);
            workFlowOperations.ChooseFromDropDown(primaryMerchantDropDownLocator, primaryMerchantStr);
            workFlowOperations.ClickOnBtn(suspendedMvisalCardBtnLocator);
            workFlowOperations.SendKeysToTxtBox(fullNameTxtBoxLocator, fullNameStr);
            workFlowOperations.SendKeysToTxtBox(emailTxtBoxLocator, emailStr);
            workFlowOperations.SendKeysToTxtBox(userNameDropDownBoxLocator, userNameStr);
            if (phoneStr.Length == 11)// phone should be 11 digits
            {
                workFlowOperations.SendKeysToTxtBox(phoneTxtBoxLocator, phoneStr);
            }
            else
            {
                workFlowOperations.WaitConfirmationMessage(invalidPhoneTerminalMsgLoctor, invalidPhoneTerminalStr);
            }
            workFlowOperations.SendKeysToTxtBox(domainTxtBoxLocator, domainStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(successCreateTerminalMsgLoctor, successCreateTerminalStr);

        }

        // TODO:  Mina Review 
        public void CheckThatTerminalNameFieldIsMandatory() 
        {
            workFlowOperations.ChooseFromDropDown(terminalBankDropDownLocator, terminalBankStr);
            workFlowOperations.ChooseFromDropDown(terminalTypeDropDownLocator, terminalTypeStr);
            workFlowOperations.ClickOnBtn(channelCardBtnLocator);
            workFlowOperations.ChooseFromDropDown(primaryMerchantDropDownLocator, primaryMerchantStr);
            workFlowOperations.SendKeysToTxtBox(domainTxtBoxLocator, domainStr);
            workFlowOperations.ClickOnBtn(saveBtnLocator);
            workFlowOperations.WaitConfirmationMessage(terminalNameReqMsgLocator, terminalNameReqMsgStr);
        }
        // TODO:  Mina Review 
        public void DownloadTerminalsList()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }

        // TODO:  Mina Review 

        public void ReloadRoutesManagement()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(reloadBtnLocator);
          
            // need verify

        }









    }
}
