using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]
   public class MerchantTerminalUser : Actor
    {
        
        public MerchantTerminalUser()
        {
            userRole = "Merchant Terminal User";
            username = "46646732";
            password = "147369";
            loginType = LoginType.ValidLogin;
        }


        public void MerchantTerminalUser_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantTerminalUser_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "_46646732";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantTerminalUser_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantTerminalUser_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "46646732";
            password = "147369";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantTerminalUser_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
    }
}


