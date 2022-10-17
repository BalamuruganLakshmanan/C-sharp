using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentInfo
    {
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