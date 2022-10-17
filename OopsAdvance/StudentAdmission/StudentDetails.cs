using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public enum Gender{Default, Male ,Female ,Transgender}
    public class StudentDetails
    {
        private static int s_studentId=3000;
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender1 { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }


        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender , int physics,int chemistry,int maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;
            Name=name;
            FatherName=fatherName;
            dob=DOB;
            Gender1=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            
        }
        public StudentDetails(string data)
        {
             string[] values=data.Split(',');
           s_studentId=int.Parse(values[0].Remove(0,2));
           StudentId=values[0];
            Name=values[1];
            FatherName=values[2];
            DOB=DateTime.Parse(values[3]);
            Gender1=Enum.Parse<Gender>(values[4]);
            Physics=int.Parse(values[5]);
            Chemistry=int.Parse(values[6]);
            Maths=int.Parse(values[7]);

        }

        public  bool CheckEligibility( )
        {
            int temp=Physics+Chemistry+Maths;
            int total=temp/3;
            if(total>=75)
            {
                return true;
            }
            else
            {
               return false;
            }
        }

        public void ShowDetails( )
        {
            System.Console.WriteLine("Student's Name is : "+Name);
            System.Console.WriteLine("Father's Name is : "+FatherName);
            System.Console.WriteLine("DOB is : "+DOB);
            System.Console.WriteLine("Gender is: "+Gender1);
            System.Console.WriteLine("Physics Mark is: "+Physics);
            System.Console.WriteLine("Chemistry Mark is : "+Chemistry);
            System.Console.WriteLine("Maths Mark is : "+Maths);
        }
        
    }
}