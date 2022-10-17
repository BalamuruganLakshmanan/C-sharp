using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program2
{
     public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender1 { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public string Mail { get; set; }


        public PersonalInfo(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail)
        {
           
            Name=name;
            FatherName=fatherName;
            Gender1=gender;
            DOB=dob;
            PhoneNumber=phoneNumber;
            Mail=mail;

        }

       

        public  void ShowDetails( )
        {
            System.Console.WriteLine("your name is "+Name);
            System.Console.WriteLine("Your father name is "+FatherName);
            System.Console.WriteLine("Your gender is "+Gender1);
            System.Console.WriteLine("Your phone Number is  "+PhoneNumber);
            System.Console.WriteLine("DOB IS "+DOB);
           
            
        }
    }
   
}