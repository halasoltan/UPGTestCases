using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

   public class BankBusinessUser :Actor
    {
        
        public BankBusinessUser()
        {
            //General Test Data preparation
            userRole = "Bank Business User";
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
       
        public void BankBusinessUser_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankBusinessUser_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "__QNB_Bank_Bussiness";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankBusinessUser_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }


        [TestMethod]
        public void BankBusinessUser_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]
        public void BankBusinessUser_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]// pass
        public void BankBusinessUser_29_MerchantsManagement_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Merchants Management", "Merchants");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


        [TestMethod]// pending
        public void BankBusinessUser_79_TransactionsReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


        [TestMethod] // pending
        public void AccountingAdministrator_80_TransactionsReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
            username = "QNB_ACC_Admin";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        // TC 111 tomorrow
        [TestMethod]// pending
        public void BankBusinessUser_112_AMSTransactionReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("AMS Transaction Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod] // pending
        public void AccountingAdministrator_113_AMSTransactionReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
            username = "QNB_ACC_Admin";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("AMSTransactionReport", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod]// pending
        public void BankBusinessUser_132_SettlementReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod]// pending
        public void BankBusinessUser_133_SettlementReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod]// Fail
        public void BankBusinessUser_185_SupportTickets_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Support Tickets", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod]// fail
        public void BankBusinessUser_186_SupportTickets_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SupportTickets", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


        [TestMethod]// pending
        public void BankBusinessUser_224_SMSLogReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
            username = "QNB_Bank_Bussiness";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMS Log Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] // pending
        public void AccountingAdministrator_225_SMSLogReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
            username = "QNB_ACC_Admin";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMS Log Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }



    }
}
