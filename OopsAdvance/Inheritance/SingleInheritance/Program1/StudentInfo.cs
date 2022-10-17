using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }

        public StudentInfo(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string standard,string branch,string academicYear):base( name, fatherName, gender, phoneNumber, dob, mail)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        
        public void ShowInfo( )
        {
             System.Console.WriteLine("Student Id is "+RegisterNumber);
            ShowDetails( );
            System.Console.WriteLine("Branch : "+Branch);
            System.Console.WriteLine("Academic Year : "+AcademicYear);
        }
    }
}