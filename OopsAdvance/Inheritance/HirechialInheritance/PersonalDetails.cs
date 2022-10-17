using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirechialInheritance
{
    public enum Gender{Default,Male,Female,transgenger}
    
    public class PersonalDetails
    {
        private static int s_aId=1000;
        public string AId { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender1 { get; set; }
        public long PhoneNumber { get; set; }


        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_aId++;
            AId="AID"+s_aId;
            Name=name;
            FatherName=fatherName;
            Gender1=gender;
            PhoneNumber=phoneNumber;

        }

        public PersonalDetails(string aID,string name,string fatherName,Gender gender,long phoneNumber)
        {
           
            AId=aID;
            Name=name;
            FatherName=fatherName;
            Gender1=gender;
            PhoneNumber=phoneNumber;

        }

        public  void ShowDetails( )
        {
            System.Console.WriteLine("your name is "+Name);
            System.Console.WriteLine("Your father name is "+FatherName);
            System.Console.WriteLine("Your gender is "+Gender1);
            System.Console.WriteLine("Your phone Number is  "+PhoneNumber);
            System.Console.WriteLine("Your Aadhar Id number is "+AId);
            
        }
        
    }
}