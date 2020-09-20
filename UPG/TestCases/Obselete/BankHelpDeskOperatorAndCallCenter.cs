using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

 public   class BankHelpDeskOperatorAndCallCenter : Actor
    {
       
        public BankHelpDeskOperatorAndCallCenter()
        {
            //General Test Data preparation
            userRole = "Bank Help Desk Operator / Call Center";
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void BankHelpDeskOperatorAndCallCenter_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankHelpDeskOperatorAndCallCenter_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "__QNB_Bank_HD_CallCenter";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankHelpDeskOperatorAndCallCenter_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankHelpDeskOperatorAndCallCenter_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankHelpDeskOperatorAndCallCenter_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]//pending
        public void BankHelpDeskOperatorAndCallCenter_10_TransactionReport_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);

        }
        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_11_TransactionReport_checkingUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_12_TransactionReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //
            searchDateTo = new DateTime(2020, 8, 10);

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod]//pending
        public void BankHelpDeskOperatorAndCallCenter_27_SettlementReport_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);

        }

        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_28_SettlementReport_checkingUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SettlementReport", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_29_SettlementReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //
            searchDateTo = new DateTime(2020, 8, 10);

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SettlementReport", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod]//pending
        public void BankHelpDeskOperatorAndCallCenter_26_SupportTickets_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Support Tickets", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);

        }
        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_27_SupportTickets_checkingUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SupportTickets", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_28_SupportTickets_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //
            searchDateTo = new DateTime(2020, 8, 10);

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SupportTickets", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod]//pending
        public void BankHelpDeskOperatorAndCallCenter_40_SMSLogReport_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMSLogReport", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);

        }

        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_41_SMSLogReport_checkingUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMSLogReport", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] //pending
        public void BankHelpDeskOperatorAndCallCenter_42_SMSLogReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_HD_CallCenter";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //
            searchDateTo = new DateTime(2020, 8, 10);

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMSLogReport", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


    }
}
