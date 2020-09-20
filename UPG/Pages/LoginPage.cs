using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
namespace UPG.Pages
{
    public enum LoginType
    {
        ValidLogin,
        InValidCredentials,
        otpTimeExpired,
        EmptyCredentials,
        InValidOTP
    }
    class LoginPage
    {
        Operations workFlowOperations = Operations.Instance;

        By userNameTxtBoxLocator = By.Id("UserName");
        By passwordTxtBoxLocator = By.Id("userpassword");
        By sendOtpBtnLocator = By.Id("sendotp");
        By userOtpTxtBoxLocator = By.Id("otp");
        By otpSentMessageLocator = By.XPath("//*[@id=\"timer\"]");
        By signInBtnLocator = By.Id("signinbtn");

        By pleaseEnterUserNamePasswordLocator = By.XPath("//*[@id=\"LogFrm\"]/p");
        By invalidUserNamePasswordLocator = By.XPath("//*[@id=\"validateSummaryDiv\"]/p");
        By fieldIsRequiredLocator = By.Id("UserName - error");
        By setUserNameandPasswordLocator = By.XPath("//*[@id=\"validateSummaryDiv\"]/p");
        By wrongOtpLocator = By.Id("validateSummaryDiv");


        string homePageTitleStr = "Unified payment gateway";                
        string userNamePassworMsgdStr = "Please enter your Username & Password to login:";
        string failedLoginMsgStr = "Invalid user name or password.";
        string fieldRequiredMsgStr = "This field is required.";
        string setUserNameandPasswordMsgStr = "User name and password must be set";
        string otpSentMessageStr = "System sent OTP to your mobile *******471 and will expire within  0:28 secs";
        string wrongOtpStr = "Code is not verified";
        //Code is not verified.
        // id = validateSummaryDiv
        string validLoginStr = " Redirecting...";


        


        public void Login(string username, string password, string otp, int timeBeforeSubmit, LoginType loginType)
        {
            workFlowOperations.GoToPage(UPG.Properties.Settings.Default.PortalUrl, homePageTitleStr);
            workFlowOperations.waitForPageLoaded();
            workFlowOperations.WaitToSendKeysToTxtBox(userNameTxtBoxLocator, username);
            workFlowOperations.SendKeysToTxtBox(passwordTxtBoxLocator, password); //Same for Password Field
            workFlowOperations.ClickOnBtn(sendOtpBtnLocator);
            workFlowOperations.WaitConfirmationMessage(otpSentMessageLocator, otpSentMessageStr);
            workFlowOperations.SendKeysToTxtBox(userOtpTxtBoxLocator, otp);      //Same for OTP Field                             
            Thread.Sleep(timeBeforeSubmit);
            workFlowOperations.ClickOnBtn(signInBtnLocator);
            workFlowOperations.waitForPageLoaded();

            if (loginType == LoginType.ValidLogin)
            {
                workFlowOperations.WaitConfirmationMessage(signInBtnLocator, validLoginStr);
            }
            else if (loginType == LoginType.InValidCredentials)
            {
                workFlowOperations.WaitConfirmationMessage(invalidUserNamePasswordLocator, failedLoginMsgStr);
            }

            else if (loginType == LoginType.EmptyCredentials)
            {
                //TBD
                workFlowOperations.WaitConfirmationMessage(invalidUserNamePasswordLocator, failedLoginMsgStr);
            }

            else if (loginType == LoginType.otpTimeExpired)
            {
                //TBD
                workFlowOperations.WaitConfirmationMessage(invalidUserNamePasswordLocator, failedLoginMsgStr);
            }

            else if (loginType == LoginType.InValidOTP)
            {
                workFlowOperations.WaitConfirmationMessage(wrongOtpLocator, wrongOtpStr);
            }

            else
            {
                
            }           
        }
    }
}
