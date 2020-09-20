using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]
  public  class AggregatorMerchantAdmin :   Actor
    {
        
        public AggregatorMerchantAdmin()
        {
            //General Test Data preparation
            userRole = "Aggregator Merchant Admin";
            username = "10458514251";
            password = "147369";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void AggregatorMerchantAdmin_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void AggregatorMerchantAdmin_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "__10458514251";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void AggregatorMerchantAdmin_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__147369";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }


        [TestMethod]
        public void AggregatorMerchantAdmin_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "10458514251";
            password = "147369";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]
        public void AggregatorMerchantAdmin_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void AggregatorMerchantAdmin_7_CheckIfUserLoginWithInvalidOtp()
        {
            //Test Data preparation

            otp = "11_1";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

       



    }
}