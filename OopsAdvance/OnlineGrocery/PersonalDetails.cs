using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender1 { get; set; }
        public  long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string MailId { get; set; }


        public PersonalDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId )
        {
            Name=name;
            FatherName=fatherName;
            Gender1=gender;
            MobileNumber=mobileNumber;
            DOB=dob;
            MailId=mailId;
        }
        public PersonalDetails()
        {
            
        }


        
    }
}