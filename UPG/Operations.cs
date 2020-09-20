using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UPG
{
    class Operations
    {
        private static readonly Operations instance = new Operations();
        public IWebDriver driver;
        WebDriverWait wait;

        TimeSpan loadingTimeout;


        static Operations()
        {

        }
        private Operations()
        {
            loadingTimeout = new TimeSpan(0, 1, 0);
            if (UPG.Properties.Settings.Default.Browser == "Chrome")
                ChromeDriverInitialize();
            else if (UPG.Properties.Settings.Default.Browser == "Edge")
                EdgeDriverInitialize();
            else if (UPG.Properties.Settings.Default.Browser == "Firefox")
                FirefoxDriverInitialize();
            else if (UPG.Properties.Settings.Default.Browser == "Opera")
                OperaDriverInitialize();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, loadingTimeout);
        }

        

        public static Operations Instance
        {
            get
            {
                return instance;
            }
        }
        private void FirefoxDriverInitialize()
        {
            string browserInstallationDir = UPG.Properties.Settings.Default.BrowserInstallionDir;
            if (UPG.Properties.Settings.Default.BrowserInstallionDir != "Default")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.BrowserExecutableLocation = browserInstallationDir;
                driver = new FirefoxDriver(options);

            }            
            else
            {                
                driver = new FirefoxDriver();
            }
        }

        private void EdgeDriverInitialize()
        {
            String driverPath = Directory.GetCurrentDirectory();
            var options = new EdgeOptions();
            options.UseChromium = true;

            driver = new EdgeDriver(options);
        }
        private void OperaDriverInitialize()
        {
            string browserInstallationDir = UPG.Properties.Settings.Default.BrowserInstallionDir;
            if (browserInstallationDir != "Default")
            {
                OperaOptions options = new OperaOptions();
                options.BinaryLocation = browserInstallationDir;
                driver = new OperaDriver(options);
            }
            
            else
            {                
                driver = new OperaDriver();
            }
        }
        private void ChromeDriverInitialize()
        {
            string browserInstallationDir = UPG.Properties.Settings.Default.BrowserInstallionDir;                      
            if (browserInstallationDir != "Default")
            {
                ChromeOptions options = new ChromeOptions();
                options.BinaryLocation = browserInstallationDir;               
                driver = new ChromeDriver(options);
                
            }
            //options.setExperimentalOption("useAutomationExtension", false);
            //System.setProperty("webdriver.chrome.driver", driverPath);
            else
            {
                driver = new ChromeDriver();
            }
        }
        public void waitForPageLoaded()
        {
            wait.Until(webdriver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public void GoToPage(String pageUrl, String assertionStr)
        {
            driver.Navigate().GoToUrl(pageUrl);
            waitForPageLoaded();
            Assert.AreEqual(driver.Title, assertionStr);
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,0)");
        }

        public void WaitToClickOnBtn(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            IWebElement Btn = driver.FindElement(locator);
            Btn.Click();
        }

        public void ClickOnBtn(By locator)
        {
            IWebElement Btn = driver.FindElement(locator);
            Btn.Click();
        }

        public void ChooseFromDropDown(By locator, String selectedValue)
        {
            SelectElement dropDown = new SelectElement(driver.FindElement(locator));
            dropDown.SelectByText(selectedValue);
        }
        // Hala
        public void selectFromDropDownList(By locator, By locator2)
        {
            ClickOnBtn(locator);
            WaitToClickOnBtn(locator2);

        }

        public void WaitToSendKeysToTxtBox(By locator, String text)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            IWebElement txtBox = driver.FindElement(locator);
            txtBox.SendKeys(text);

        }
        public void SendKeysToTxtBox(By locator, String text)
        {
            IWebElement txtBox = driver.FindElement(locator);
            txtBox.SendKeys(text);
        }

        public void WaitConfirmationMessage(By locator, String txtMsg)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(locator, txtMsg));
        }

        public void SwitchToPopUp(By locator)
        {
            IWebElement iframeElement = driver.FindElement(locator);
            driver.SwitchTo().Frame(iframeElement);
        }

        public void ReturnToPage()
        {
            driver.SwitchTo().DefaultContent();
        }



        public void selectDatesFromcalender(By locator, DateTime date)
        {
            IWebElement txtBxDatePicker = driver.FindElement(locator); //edit id
            txtBxDatePicker.SendKeys(date.ToShortDateString()); //Send in Required Format.
        }

        // to get  Text in title
        public string ExtractDataFromText(By locator)
        {
            string x = "";

            IWebElement title = driver.FindElement(locator);
            x = title.Text.Trim();

            return x;

        }


        // for check elemt is  returned with correct class (empty, color of it) 
        //TODO: Reviewed byy mina
        public Boolean VerifyElementworked(By locator, string returnedclass)
        {
            Boolean a = false;
            IWebElement title = driver.FindElement(locator);
            if (title.GetAttribute("calss").Contains(returnedclass))
            {
                a = true;

            }
            return a;
        }
        //Date Method
        //TODO: Reviewed byy mina
        public void searchByDates(DateTime dateFrom, DateTime dateTo, By locator, string txt)
        {
            bool dateEntered = false;
            ClickOnBtn(locator);

            if ((dateFrom == null) && (dateTo == null))
            {
                //invalidDateMessageSearchStr => no items to Display
                WaitConfirmationMessage(locator, txt);
            }
            else
            {
                if (dateFrom != null)
                {
                    WaitToSendKeysToTxtBox(locator, txt);
                    dateEntered = true;
                }
                if (dateTo != null)
                {
                    WaitToSendKeysToTxtBox(locator, txt);
                    dateEntered = true;
                }

                if (dateEntered)
                    ClickOnBtn(locator);
                if (dateFrom <= dateTo)
                {

                }

                else //(dateFrom > dateTo)
                {
                    WaitConfirmationMessage(locator, txt);
                }
            }
        }
       


    }
}
