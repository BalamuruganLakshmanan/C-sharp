using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public string  Degree { get; set; }
        public  string Department { get; set; }
        public int Semester  { get; set; }

        public StudentInfo(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string degree,string department,int semester):base( name, fatherName, gender, phoneNumber,dob, mail)

        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowInfo( )
        {
            ShowDetails( );
            System.Console.WriteLine("StudentID : "+StudentID);
            System.Console.WriteLine("Degree : "+Degree);
            System.Console.WriteLine("Department : "+Department);
            System.Console.WriteLine("Semester : "+Semester);
        }


    }
}