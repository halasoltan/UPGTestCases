using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

    public class BankFinancialOperationsAdministrator : Actor
    {
        
        public BankFinancialOperationsAdministrator()
        {
            //General Test Data preparation
            userRole = "Bank Financial Operations Administrator";
            username = "QNB_Bank_FO";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void BankFinancialOperationsAdministrator_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankFinancialOperationsAdministrator_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "_QNB_Bank_FO";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankFinancialOperationsAdministrator_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }



        [TestMethod]  
        public void BankFinancialOperationsAdministrator_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_Bank_FO";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod] 
        public void BankFinancialOperationsAdministrator_53_Login_EmptyFields()
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
        public void BankFinancialOperationsAdministrator_10_TransactionReport_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_FO";
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
        public void BankFinancialOperationsAdministrator_11_TransactionReport_checkingWhenUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_FO";
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
        public void BankFinancialOperationsAdministrator_12_TransactionReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_FO";
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

        [TestMethod]  //pending
        public void BankFinancialOperationsAdministrator_25_SettlementReport_SearchForGroupOfSettlementReportsInADatePeriod()

        {
            username = "QNB_Bank_FO";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //9/8/2020
            searchDateTo = new DateTime(2020, 8, 10);   //10/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);

        }

        [TestMethod]//pending
        public void BankFinancialOperationsAdministrator_26_SettlementReport_SearchbyfromTodatesWithReversedvalues()
        {
            username = "QNB_Bank_FO";
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
        public void BankFinancialOperationsAdministrator_27_SettlementReport_checkingWhenUserEnterValidDateFromOnly()
        {
            username = "QNB_Bank_FO";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] //pending
        public void BankFinancialOperationsAdministrator_28_SettlementReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "QNB_Bank_FO";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //
            searchDateTo = new DateTime(2020, 8, 10);

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

    }
}

