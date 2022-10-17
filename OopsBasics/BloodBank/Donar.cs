using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public  class Donar
    {
        
        private static int s_donarId=100;
        public string DonarId { get;  }
        public string Name { get; set; }
        public int Age { get; set; }
        public long MobileNumber { get; set; }
        public string BloodGroup { get; set; }
        public DateTime LastDonation { get; set; }

        public Donar(string name,int age,long mobile,string bloodGroup,DateTime lastDonation)
        {
            s_donarId++;
            DonarId="DID"+s_donarId;
            Name=name;
            Age=age;
            MobileNumber=mobile;
            BloodGroup=bloodGroup;
            LastDonation=lastDonation;
            
        }

    }

}