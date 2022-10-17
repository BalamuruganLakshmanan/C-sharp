using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employement
{
    public enum Gender{Default,Male,Female,transgenger}
    
    public class PersonalDetails
    {
        private static int s_registerId=1000;
        public string RegisterId { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender1 { get; set; }
        public long PhoneNumber { get; set; }


        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_registerId++;
            RegisterId="AID"+s_registerId;
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
            System.Console.WriteLine("Your Aadhar Id number is "+RegisterId);
            
        }
        
    }
}