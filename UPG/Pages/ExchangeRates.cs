using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace UPG.Pages
{
    class ExchangeRates
    {
        Operations workFlowOperations = Operations.Instance;
        private IWebDriver driver;
        public By optionBtnLocator = By.CssSelector(".rotate");
        public By exportBtnLocator = By.CssSelector(".fa-download");
        public By plusAddBtnLocator = By.CssSelector(".fa-plus");
        // elements of add exchange rates
        public By currencyNameTxtBoxLocator = By.CssSelector("#ExRate_CurrencyName");
        string currencyNameStr;
        public By currencyCodeTxtBoxLocator = By.CssSelector("#ExRate_CurrencyCode");
        string currencyCodeStr;
        public By buyRateTxtBoxLocator = By.CssSelector("#ExRate_Buy");
        string buyRateStr;
        public By sellRateTxtBoxLocator = By.CssSelector("#ExRate_Sell");
        string sellRateStr;
        public By saveExchangeBtnLocator = By.CssSelector("#btnSave");
        public By editExchangeBtnLoctr = By.CssSelector(".grid-row:nth-child(1) b > .btn");// xpath
        public By deleteRouteBtnLocator = By.CssSelector(".grid-row:nth-child(1) div .btn");// xpath
        public By confirmDeleteRouteBtnLocator = By.CssSelector(".btn-xs:nth-child(1)");
        public By exportedDwFilesIconLocator = By.LinkText(" Exported Files Downloads ");
        public By generateExportFileLocator = By.CssSelector("#InfoMessage");
        string generateExportFileMessageStr = "The requested export file is going to be generated, you can download it from downloads page";
      
        // TODO:  Mina Review  
        public void AddExchangeRate()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.WaitToSendKeysToTxtBox(currencyNameTxtBoxLocator, currencyNameStr);
            workFlowOperations.SendKeysToTxtBox(currencyCodeTxtBoxLocator, currencyCodeStr);
            workFlowOperations.SendKeysToTxtBox(buyRateTxtBoxLocator, buyRateStr);
            workFlowOperations.SendKeysToTxtBox(sellRateTxtBoxLocator, sellRateStr);
            workFlowOperations.ClickOnBtn(saveExchangeBtnLocator);

        }

        // TODO:  Mina Review  
  //body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.table_container > div.grid-mvc > div > table > tbody
  //body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.table_container > div.grid-mvc > div > table > tbody > tr:nth-child
        public Boolean EditExchangeRates(string CodeStr)
        {
            Boolean con = false;
            IList<IWebElement> All_Exchange_rates = driver.FindElements(By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.table_container > div.grid-mvc > div > table > tbodytr:nth-child"));
            for (int i = 0; i < All_Exchange_rates.Count; i++)
            {

                IWebElement CurrencyCode = All_Exchange_rates[i].FindElement(By.CssSelector("./td:nth-child(2)"));
                string codeCurrency = CurrencyCode.Text.Trim();
                if (codeCurrency .Equals( currencyCodeStr))
                {
                    con = true;
                    workFlowOperations.ClickOnBtn(editExchangeBtnLoctr);                  
                    workFlowOperations.SendKeysToTxtBox(buyRateTxtBoxLocator, buyRateStr);
                    workFlowOperations.ClickOnBtn(saveExchangeBtnLocator);

                }
            }
            return con;
        }
        // TODO:  Mina Review  
        public Boolean DeleteExchangeRates(string CodeStr)
        {
            Boolean con = false;
            IList<IWebElement> All_Exchange_rates = driver.FindElements(By.CssSelector("body > div:nth-child(7) > div.col-md-9.col-sm-7 > div > div.table_container > div.grid-mvc > div > table > tbodytr:nth-child"));
            for (int i = 0; i < All_Exchange_rates.Count; i++)
            {

                IWebElement CurrencyCode = All_Exchange_rates[i].FindElement(By.CssSelector("./td:nth-child(2)"));
                string codeCurrency = CurrencyCode.Text.Trim();
                if (codeCurrency.Equals(currencyCodeStr))
                {
                    con = true;
                    workFlowOperations.ClickOnBtn(deleteRouteBtnLocator);
                    workFlowOperations.WaitToClickOnBtn(confirmDeleteRouteBtnLocator);                 

                }
            }
            return con;
        }

        // TODO:  Mina Review  

        public void  DownloadExchangeRates()
        {
            workFlowOperations.WaitToClickOnBtn(optionBtnLocator);
            workFlowOperations.ClickOnBtn(plusAddBtnLocator);
            workFlowOperations.WaitToClickOnBtn(exportBtnLocator);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitConfirmationMessage(generateExportFileLocator, generateExportFileMessageStr);
            workFlowOperations.ClickOnBtn(exportedDwFilesIconLocator);
        }
      




    }
}
