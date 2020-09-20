using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

 public   class MerchantSupervisor : Actor
    {
        
        public MerchantSupervisor()
        {
            //General Test Data preparation
            userRole = "Merchant Supervisor";
            username = "QNB_Merchant_Super";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void MerchantSupervisor_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]
        public void MerchantSupervisor_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "__QNB_MerchantSuper";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantSupervisor_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantSupervisor_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_Merchant_Super";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void MerchantSupervisor_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        //[TestMethod]

    }
}
