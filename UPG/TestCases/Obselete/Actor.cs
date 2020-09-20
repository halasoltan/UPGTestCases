using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG.TestCases
{
    public class Actor
    {
        

        //
        protected WorkFlows workflow;
        protected string username;
        protected string password;
        protected string otp;
        protected int timeBeforeSubmit;

        protected const int OTPExpireTime = 66000;
        protected const int NOTime = 0;
        protected  DateTime searchDateFrom;
        protected   DateTime searchDateTo;
        protected string userRole = "Default Actor";
        protected LoginType loginType;
       
        public Actor()
        {
            workflow = new WorkFlows();
            timeBeforeSubmit = NOTime;
            otp = "1111";
        }
    }
}
