using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]
    class MerchantAdministrator
    {
        WorkFlows workflow;
        string username;
        string password;
        string otp;
        int timeBeforeSubmit;

        const int otpExpireTime = 66000;
        const int noTime = 0;

        const string userRole = "Merchant Administrator";
        LoginType loginType;
        public MerchantAdministrator()
        {
            workflow = new WorkFlows();
        }


        [TestMethod]
        public void Login_50_ValidCredentials()
        {
            //Test Data preparation
            username = "10480427111";
            password = "147369";
            otp = "1111";
            timeBeforeSubmit = noTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType,userRole);
        }

        [TestMethod]
        public void Login_51_InValidCredentials_InValidUsername()
        {
            //Test Data preparation
            username = "1048042711";
            password = "147369";
            otp = "1111";
            timeBeforeSubmit = noTime;
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void Login_51_InValidCredentials_InValidPassword()
        {
            //Test Data preparation
            username = "10480427111";
            password = "1473690";
            otp = "1111";
            timeBeforeSubmit = noTime;
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void Login_52_OTPSessionExpired()
        {
            //Test Data preparation
            username = "10480427111";
            password = "147369";
            otp = "1111";
            timeBeforeSubmit = otpExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void Login_53_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = noTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType,userRole);
        }
    }
}
