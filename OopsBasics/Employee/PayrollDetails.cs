using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Location{Default,Mathura,Eymard}
    public class PayrollDetails
    {
        private static int s_employeeId=1000;
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public Location WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DOJ { get; set; }
        public int Month { get; set; }
        public int Leave { get; set; }
        public Gender Gender1 { get; set; }

        public PayrollDetails(string name,string role,Location place1,string team,DateTime doj,int month,int leave,Gender gender)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            EmployeeName=name;
            Role=role;
            WorkLocation=place1;
            TeamName=team;
            DOJ=doj;
            Month=month;
            Leave=leave;
            Gender1=gender;
        }
        public void ShowDetail( )
        {
            System.Console.WriteLine("Employee name is : "+EmployeeName);
            System.Console.WriteLine("Role : "+Role);
            System.Console.WriteLine("WorkLocation "+TeamName);
            System.Console.WriteLine("Date of joining "+DOJ);
            System.Console.WriteLine("No of leave taken "+Leave);
            System.Console.WriteLine("No of working days in month "+Month);
            System.Console.WriteLine("gender: "+Gender1);
            SalaryCalculation( );
        }
            public void SalaryCalculation( )
            {
                int basic=500;
                int total=Month-Leave;
                int final=total*basic;
                System.Console.WriteLine("Your salary is "+final);
            }

        
    }
}