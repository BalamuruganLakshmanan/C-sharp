using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class ClassTeacher:PersonalInfo
    {
        private static int s_teacherId=1000;
        public string TeacherId { get; set; }
        public string Department { get; set; }
        public string  SubjectTeaching { get; set; }
        public string   Qualification{ get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DOJ { get; set; }

        public ClassTeacher(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime doj):base(name, fatherName, gender,phoneNumber, dob,mail)
        {
            s_teacherId++;
            TeacherId="TID"+s_teacherId;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DOJ=doj;
        }

        public void ShowInfo( )
        {
            ShowDetails( );
            System.Console.WriteLine("TeacherId : "+TeacherId);
            System.Console.WriteLine("Department : "+Department);
            System.Console.WriteLine("SubjectTeaching : "+SubjectTeaching);
            System.Console.WriteLine(" Qualification : "+ Qualification);
            System.Console.WriteLine(" YearOfExperience : "+ YearOfExperience);
            System.Console.WriteLine("DOJ : "+DOJ);
        }
    }
}