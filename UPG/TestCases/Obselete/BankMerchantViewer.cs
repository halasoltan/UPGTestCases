using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

  public  class BankMerchantViewer : Actor
    {
        
        public BankMerchantViewer()
        {
            userRole = "Bank Merchant Viewer";
            username = "QNB_Merchant_Viewer";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void BankMerchantViewer_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankMerchantViewer_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "_QNB_Merchant_Viewer";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankMerchantViewer_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankMerchantViewer_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_Merchant_Viewer";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankMerchantViewer_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod] // pass

        public void BankMerchantViewer_77_MerchantsManagement_CheckValidationWhenDateFromIsGreaterThanDateOfDateTo()
        {
            username = "QNB_Merchant_Viewer";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Merchants Management", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);


        }
        [TestMethod] // FAil
        public void BankMerchantViewer_78_MerchantsManagement_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
            username = "QNB_Merchant_Viewer";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("MerchantsManagement", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

    }
}

