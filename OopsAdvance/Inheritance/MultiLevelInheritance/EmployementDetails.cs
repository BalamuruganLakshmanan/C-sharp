using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployementDetails:StudentDetail
    {
        private static int s_employeeId=100;
        public string EmployeeRegistrationId { get; }
        public DateTime RegistrationDate { get; set; }

        public EmployementDetails(string studentId,string aID,string name,string fatherName,Gender gender,long phoneNumber,Department department ):base(studentId,aID,name, fatherName,gender, phoneNumber, department)
        {
            s_employeeId++;
            EmployeeRegistrationId="EID"+s_employeeId;
            RegistrationDate=DateTime.Now;

        }
        public void ShowEmployementDetail( )
        {
            System.Console.WriteLine("EMployement ID is  "+EmployeeRegistrationId);
            ShowStudent( );
            System.Console.WriteLine("Registration Date is "+RegistrationDate.ToString("dd/MM/yyyy"));
        }

    }
}