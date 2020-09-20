using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]

    public class AccountingAdministrator : Actor
    {



        public AccountingAdministrator()
        {
            //General Test Data preparation
            userRole = "Accounting Administrator";
            username = "QNB_ACC_Admin";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }


        [TestMethod]
        public void AccountingAdministrator_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void AccountingAdministrator_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "__QNB_ACC_Admin";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void AccountingAdministrator_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }


        [TestMethod]
        public void AccountingAdministrator_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "QNB_ACC_Admin";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod]
        public void AccountingAdministrator_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod] // fail
        public void AccountingAdministrator_23_TransactionsReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()
        {
            
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


        [TestMethod] // fail
        public void AccountingAdministrator_24_TransactionsReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
            
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Transactions Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


        [TestMethod] // fail
        public void AccountingAdministrator_59_AmsTransactionReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()

        {
          
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("AMS Transaction Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod] // fail
        public void AccountingAdministrator_60_AmsTransactionReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
          
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("AMS Transaction Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }

        [TestMethod] // fail
        public void AccountingAdministrator_89_SettlementReport_CheckSystemHandlesErroIfUserEnterTimeFromBiggerThanTimeTo()
        {

            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod] // fail
        public void AccountingAdministrator_90_SettlementReport_CheckSystemHandlesErroneousIfUserEnterFutureDateAtDatefields()

        {
           
            searchDateFrom = new DateTime(2020, 11, 20); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Settlement Report", "");

            workflow.searchByDates(searchDateFrom, searchDateTo);
        }


    }
}
