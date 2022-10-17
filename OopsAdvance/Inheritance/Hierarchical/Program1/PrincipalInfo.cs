using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalId=2000;
        public string PrincipalId { get; set; }
        public string  Qualification { get; set; }
        public int  YearOfExperience { get; set; }
        public DateTime DOJ { get; set; }


        public PrincipalInfo(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string qualification,int yearOfExperience,DateTime doj):base(name, fatherName,gender, phoneNumber,dob,mail)
        {
            s_principalId++;
            PrincipalId="PID"+s_principalId;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DOJ=doj;
        }
        public void ShowInfo1( )
        {
            
            System.Console.WriteLine("PrincipalId : "+PrincipalId);
            System.Console.WriteLine("Qualification : "+Qualification);
            System.Console.WriteLine("YearOfExperience: "+YearOfExperience);
            System.Console.WriteLine("DOJ : "+DOJ);
        }
    }
}