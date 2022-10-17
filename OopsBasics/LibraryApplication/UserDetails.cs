using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public  enum Department{Default,ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registerId=3000;
        
        public string RegisterId { get;  }

        public string UserName { get; set; }
   
        public string Gender { get; set; }
        public Department Department1 { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }

        public UserDetails(string name,string gender,Department department1,long mobileNumber,string mailId)
        {
            s_registerId++;
            RegisterId="SF"+s_registerId;
            UserName=name;
            Gender=gender;
            Department1=department1;
            MobileNumber=mobileNumber;
            MailId=mailId;
        }


         
    }
}