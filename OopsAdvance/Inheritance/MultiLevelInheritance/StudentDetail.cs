using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public enum Department{Default,ECE,EEE,CSE}
    public class StudentDetail:PersonalDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department1 { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }
         public int Chemistry { get; set; }
        public  int Maths { get; set; }
        public  int Total{get; set; }
         public  double Average{ get; set; }
       
    
        public StudentDetail(string aID,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base( aID, name, fatherName, gender, phoneNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department1=department;
            Year=year;
        }
        public StudentDetail(string studentId,string aID,string name,string fatherName,Gender gender,long phoneNumber,Department department):base( aID, name, fatherName, gender, phoneNumber)
        {
            StudentID=studentId;
            Department1=department;
            
        }

        

        public void GetMark(int physics,int chemistry,int maths )
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }
        public void Calculate( )
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3;
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Average : "+Average);
        }
        public void ShowMarks( )
        {
            System.Console.WriteLine("Physics : "+Physics);
            System.Console.WriteLine("Chemistry : "+Chemistry);
            System.Console.WriteLine("Maths : "+Maths);
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