using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentInfo
    {
        public StudentInfo(string name,string fatherName,DateTime dob,Gender gender , int physics,int chemistry,int maths)
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
        
    }
}