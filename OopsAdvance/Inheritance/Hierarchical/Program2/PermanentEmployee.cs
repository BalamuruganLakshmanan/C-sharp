using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program2
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeId=3000;
        public string EmployeeId { get; set; }
        public string EmployeeType { get; set; }


        public PermanentEmployee(double basicSalary,int month,string employeeType):base( basicSalary, month)
        {
            s_employeeId++;
            EmployeeType=employeeType;
        }


        public void CalculateTotalSalary( )
        {
            int basic =500;
            double DA=(0.2/100)*basic;
            double HRA= (0.18/100)*basic;
            double PF =(0.1/100)*basic ;
            double Total=basic +DA+HRA-PF;
            double final=Total*Month;
        }
    }
}