using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPG;
using UPG.Locators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UPG.TestCases
{
    [TestClass]
    public class BankAuditorUser : Actor
    {
        

        public BankAuditorUser()
        {
            userRole = "Bank Auditor User";
            username = "Bank_Auditor";
            password = "A@12345m";
            loginType = LoginType.ValidLogin;
        }
        

        [TestMethod]
        public void BankAuditor_50_Login_ValidCredentials()
        {
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankAuditor_51_Login_InValidCredentials_InValidUsername()
        {
            //Test Data preparation

            loginType = LoginType.InValidCredentials;
            username = "_Bank_auditor";
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankAuditor_51_Login_InValidCredentials_InValidPassword()
        {
            //Test Data preparation

            password = "__A@12345m";
            loginType = LoginType.InValidCredentials;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankAuditor_52_Login_OTPSessionExpired()
        {
            //Test Data preparation
            username = "Bank_Auditor";
            password = "A@12345m";

            timeBeforeSubmit = OTPExpireTime;
            loginType = LoginType.ValidLogin;

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }

        [TestMethod]
        public void BankAuditor_53_Login_EmptyFields()
        {
            //Test Data preparation
            username = "";
            password = "";
            otp = "";
            timeBeforeSubmit = NOTime;
            loginType = LoginType.InValidCredentials;
            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
        }
        [TestMethod] // pending
        public void BankAuditor_3_AuditLogReport_CheckCurrentDaySessionWhenSearchingByDates()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 19); //19/8/2020
            searchDateTo = new DateTime(2020, 8, 19);    //19/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;
            

            workflow.Login(username, password, otp, timeBeforeSubmit, loginType,userRole);
            
            workflow.selectFromSideMenu( "Audit Log Reports", "Session Audit log");
            workflow.searchByDates(searchDateFrom, searchDateTo);

        }
        [TestMethod] // pending

        public void BankAuditor_4_AuditLogReport_CheckValidationWhenDateFromIsGreaterThanDateOfDateTo()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Audit Log Reports", "Session Audit log");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);


        }

        [TestMethod]// pass

        public void BankAuditor_15_DetailedAuditLogReport_SearchForGroupOfAuditLogReportsInadatePeriod()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //9/8/2020
            searchDateTo = new DateTime(2020, 8, 10);   //10/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu( "Audit Log Reports" , "Detailed Audit log");

            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);

        }

        [TestMethod] // pass
        public void BankAuditor_16_DetailedAuditLogReport_CheckValidationWhenDateFromIsGreaterThanDateOfDateTo()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020 , 8 , 10); //10/8/2020
            searchDateTo = new DateTime (2020, 8 , 7) ;   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("Audit Log Reports", "Detailed Audit log");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);


        }
         
        [TestMethod]// pass
        public void BankAuditor_32_SMSLogReport_SearchTodaysSmslogReports()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //19/8/2020
            searchDateTo = new DateTime(2020, 8, 9);    //19/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);

            workflow.selectFromSideMenu("SMS Log Report", ""); //***No sub menu ?????
            workflow.searchByDates(searchDateFrom, searchDateTo);

        }

        [TestMethod]// pass
        public void BankAuditor_33_SMSLogReport_CheckValidationWhenDateFromIsGreaterThanDateOfDateTo()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 10); //10/8/2020
            searchDateTo = new DateTime(2020, 8, 7);   //7/8/2020

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMS Log Report", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);

        }
        [TestMethod]// pass
        public void BankAuditor_34_SMSLogReport_CheckingWhenUserEnterValidDateFromOnly()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(2020, 8, 9); //10/8/2020
            searchDateTo = new DateTime();   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMS Log Report", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }
        [TestMethod]// pass
        public void BankAuditor_35_SMSLogReport_CheckingWhenUserEnterValidDateToOnly()
        {
            username = "Bank_Auditor";
            password = "A@12345m";
            otp = "1111";
            searchDateFrom = new DateTime(); //10/8/2020
            searchDateTo = new DateTime(2020 , 8 , 10);   // No date to ????

            timeBeforeSubmit = NOTime;
            loginType = LoginType.ValidLogin;


            workflow.Login(username, password, otp, timeBeforeSubmit, loginType, userRole);
            workflow.selectFromSideMenu("SMS Log Report", "");


            //workflow.selectSubModule(subModule);
            workflow.searchByDates(searchDateFrom, searchDateTo);
        }




    }
}
