using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program4
{
    public class Departmentdetails
    {
        public string DepartmentName { get; set; }
        public string Degree { get; set; }


        public Departmentdetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
        public void ShowInfo( )
        {
            System.Console.WriteLine("Department Name : "+DepartmentName);
            System.Console.WriteLine("Degree : "+Degree);
        }
    }
}