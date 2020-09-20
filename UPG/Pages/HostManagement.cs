using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class HostManagement
    {
        Operations workFlowOperations = Operations.Instance;
        public By selectParametersBtnLocator = By.CssSelector("#searchHeader");
        public By searchBtnLocator = By.CssSelector(".btn-block");
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By plusIconLocator = By.CssSelector(".fa-plus");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By hostTypeDropDownLocator = By.CssSelector("#HostType");
        public By bankDropDownLocator = By.CssSelector("#BankId");
        public By hostIdTxtboxLocator = By.CssSelector("#Host_HostId");
        public By hostNameTxtboxLocator = By.CssSelector("#HostName");
        public By addBankDropDownLocator = By.CssSelector("#bankContent #BankId");
        public By MessageFormatDropDownLocator = By.CssSelector("#Host_CommunicationMessageFormatId");
        public By hostIp1TxtboxLocator = By.CssSelector("#Host_ServerIp1");
        public By hostPort1TxtboxLocator = By.CssSelector("#Host_ServerPort1");
        public By saveAddHostBtnLocator = By.CssSelector("#btnSave");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
        public By exportedDwFilesIconLocator = By.LinkText("Exported Files Downloads");
        string selectedBankLocatorStr;
        string selectedHostTypeStr;
        string editHostNameStr;
        string hostIdStr;
        string hostNameStr;
        string addBankStr;
        string msgFormatStr;
        string hostIpStr;
        string hostPortStr;
        // TODO:  Mina Review   
        public void SearchByBankAndViewDetailsThenEdit()
        {  //test data preparation QNB
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(bankDropDownLocator, selectedBankLocatorStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
            
        }

        // TODO:  Mina Review   
        public void SearchByHostType()
        {
            workFlowOperations.ClickOnBtn(selectParametersBtnLocator);
            workFlowOperations.ChooseFromDropDown(hostTypeDropDownLocator, selectedHostTypeStr);
            workFlowOperations.ClickOnBtn(searchBtnLocator);
            workFlowOperations.waitForPageLoaded();
        }
        // TODO:  Mina Review   
        public void AddHostManagement()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusIconLocator);
            workFlowOperations.SendKeysToTxtBox(hostIdTxtboxLocator , hostIdStr);
            workFlowOperations.SendKeysToTxtBox(hostNameTxtboxLocator, hostNameStr);
            workFlowOperations.ChooseFromDropDown(addBankDropDownLocator, addBankStr);
            workFlowOperations.ChooseFromDropDown(MessageFormatDropDownLocator, msgFormatStr);
            workFlowOperations.SendKeysToTxtBox(hostIp1TxtboxLocator , hostIpStr);
            workFlowOperations.SendKeysToTxtBox(hostPort1TxtboxLocator, hostPortStr);
            workFlowOperations.ClickOnBtn(saveAddHostBtnLocator);
        }
        // details and edit discussed with mina As we can't search with specific Host





        // TODO:  Mina Review   
        public void CheckThatUserCanExportUserData() 
        {
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.ClickOnBtn(optionBtnLocator);
            workFlowOperations.waitForPageLoaded();

            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
            workFlowOperations.waitForPageLoaded();
            //complete in another page

        }














    }
}
