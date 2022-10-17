using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program3
{
    public class EmployeeInfo:SalaryInfo
    {
        private static int s_employeeId=1000;
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }
        public EmployeeInfo(int month,int leave,string name,string fatherName,string gender,long mobile,DateTime dob,string branch):base(month,leave)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
        }


        public void Showdetail( )
        {
            System.Console.WriteLine("EmployeeId "+EmployeeId);
            System.Console.WriteLine(" Name : "+ Name);
            System.Console.WriteLine("FatherName : "+FatherName);
            System.Console.WriteLine(" Gender : "+ Gender);
            System.Console.WriteLine("Mobile : "+Mobile);
            System.Console.WriteLine("DOB : "+DOB);
            System.Console.WriteLine("Branch : "+Branch);
            SalaryCalculation( );
            
        }
    }
}