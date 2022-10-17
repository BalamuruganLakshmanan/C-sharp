using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirechialInheritance
{
    public enum Department{Default,ECE,EEE,CSE}
    public class StudentDetail:PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department1 { get; set; }
        public string Year { get; set; }
    
        public StudentDetail(string aID,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base( aID, name, fatherName, gender, phoneNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department1=department;
            Year=year;
        }

        public void ShowStudent( )
        {
            System.Console.WriteLine("Student Id is "+StudentID);
            ShowDetails( );
            System.Console.WriteLine("Department : "+Department1);
            System.Console.WriteLine("Year : "+Year);
        }


    }

}